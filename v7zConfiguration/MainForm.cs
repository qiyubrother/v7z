using System;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;
using Microsoft.Win32;

namespace v7zConfiguration
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            var root = Registry.Users.OpenSubKey(@".DEFAULT\Software\v7z");
            if (root != null)
            {
                rbHide.Checked = root.GetValue("mhe").ToString() == "y";
                txt7z.Text = root.GetValue("7z").ToString();
                txtCompressionFileDirectory.Text = root.GetValue("save2").ToString();
                txtPassword.Text = root.GetValue("psd").ToString();
                txtUncompressionFileDirectory.Text = root.GetValue("uncompress2").ToString();
            }
            root = Registry.ClassesRoot.OpenSubKey(@"*\shell\v7z\command");
            if (root != null)
            {
                txtv7z.Text = root.GetValue("").ToString();
            }
            root = Registry.ClassesRoot.OpenSubKey(@"*\shell\v7zUncompress\command");
            if (root != null)
            {
                txtv7zuncompress.Text = root.GetValue("").ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Rule
            var rs = new RegistrySecurity();
            var user = Environment.UserDomainName + "\\" + Environment.UserName;
            rs.AddAccessRule(new RegistryAccessRule(user,
                        RegistryRights.WriteKey | RegistryRights.ReadKey | RegistryRights.Delete,
                        InheritanceFlags.None,
                        PropagationFlags.None,
                        AccessControlType.Allow));
            #endregion
            #region File
            // 保存参数
            var root = Registry.Users.OpenSubKey(@".DEFAULT\Software\v7z", RegistryKeyPermissionCheck.ReadWriteSubTree);
            if (root == null)
            {
                root = Registry.Users.CreateSubKey(@".DEFAULT\Software\v7z", RegistryKeyPermissionCheck.ReadWriteSubTree, rs);
                if (root == null)
                {
                    MessageBox.Show("Error.");
                    return;
                }
            }
            root.SetAccessControl(rs);
            root.SetValue("7z", txt7z.Text, RegistryValueKind.String);
            root.SetValue("mhe", rbHide.Checked ? "y" : "n", RegistryValueKind.String);
            root.SetValue("save2", txtCompressionFileDirectory.Text, RegistryValueKind.String);
            root.SetValue("psd", txtPassword.Text, RegistryValueKind.String);
            root.SetValue("uncompress2", txtUncompressionFileDirectory.Text, RegistryValueKind.String);
            // 注册v7z文件位置
            root = Registry.ClassesRoot.OpenSubKey(@"*\shell\v7z\command", RegistryKeyPermissionCheck.ReadWriteSubTree);
            if (root == null)
            {
                root = Registry.ClassesRoot.CreateSubKey(@"*\shell\v7z\command",RegistryKeyPermissionCheck.ReadWriteSubTree, rs);
                if (root == null)
                {
                    MessageBox.Show("Error.");
                    return;
                }
            }
            root.SetAccessControl(rs);
            root.SetValue("", txtv7z.Text);
            // 注册v7zUncompress文件位置
            root = Registry.ClassesRoot.OpenSubKey(@"*\shell\v7zUncompress\command", RegistryKeyPermissionCheck.ReadWriteSubTree);
            if (root == null)
            {
                root = Registry.ClassesRoot.CreateSubKey(@"*\shell\v7zUncompress\command", RegistryKeyPermissionCheck.ReadWriteSubTree, rs);
                if (root == null)
                {
                    MessageBox.Show("Error.");
                    return;
                }
            }
            root.SetAccessControl(rs);
            root.SetValue("", txtv7zuncompress.Text);

            #endregion
            #region Folder
            root = Registry.ClassesRoot.OpenSubKey(@"Folder\shell\v7z\command", RegistryKeyPermissionCheck.ReadWriteSubTree);
            if (root == null)
            {
                root = Registry.ClassesRoot.CreateSubKey(@"Folder\shell\v7z\command", RegistryKeyPermissionCheck.ReadWriteSubTree, rs);
                if (root == null)
                {
                    MessageBox.Show("Error.");
                    return;
                }
            }
            root.SetAccessControl(rs);
            root.SetValue("", txtv7z.Text);
            #endregion
            #region Icon
            root = Registry.ClassesRoot.OpenSubKey(@"*\shell\v7z", RegistryKeyPermissionCheck.ReadWriteSubTree);
            root.SetAccessControl(rs);
            root.SetValue("icon", Path.Combine(Application.StartupPath, "compression.ico"));

            root = Registry.ClassesRoot.OpenSubKey(@"Folder\shell\v7z", RegistryKeyPermissionCheck.ReadWriteSubTree);
            root.SetAccessControl(rs);
            root.SetValue("icon", Path.Combine(Application.StartupPath, "compression.ico"));

            root = Registry.ClassesRoot.OpenSubKey(@"*\shell\v7zUmcompress", RegistryKeyPermissionCheck.ReadWriteSubTree);
            if (root == null)
            {
                root = Registry.ClassesRoot.CreateSubKey(@"*\shell\v7zUncompress", RegistryKeyPermissionCheck.ReadWriteSubTree, rs);
                if (root == null)
                {
                    MessageBox.Show("Error.");
                    return;
                }
            }
            root.SetAccessControl(rs);
            root.SetValue("icon", Path.Combine(Application.StartupPath, "uncompression.ico"));

            #endregion
            MessageBox.Show("OK!");
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            txtv7z.Text = Path.Combine(Application.StartupPath, "v7z.exe %1");
            txt7z.Text = Path.Combine(Application.StartupPath, "7z.exe");
            txtCompressionFileDirectory.Text = Path.Combine(Application.StartupPath, "CompressionFiles");
            txtPassword.Text = "1234567890$1234567890";
            rbHide.Checked = true;
            txtUncompressionFileDirectory.Text = Path.Combine(Application.StartupPath, "UncompressionFiles");
            txtv7zuncompress.Text = Path.Combine(Application.StartupPath, "v7zuncompress.exe %1");
        }
    }
}
