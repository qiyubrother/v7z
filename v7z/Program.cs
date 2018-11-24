using System;
using System.Diagnostics;
using System.Security.AccessControl;
using Microsoft.Win32;

namespace v7z
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Invalid param.");
                return;
            }
            Trace(args[0]);
            var rs = new RegistrySecurity();
            var user = Environment.UserDomainName + "\\" + Environment.UserName;
            rs.AddAccessRule(new RegistryAccessRule(user,
                        RegistryRights.WriteKey | RegistryRights.ReadKey | RegistryRights.Delete,
                        InheritanceFlags.None,
                        PropagationFlags.None,
                        AccessControlType.Allow));
            Trace("B");
            RegistryKey root = null;
            root = Registry.Users.OpenSubKey(@".DEFAULT\Software\v7z", RegistryKeyPermissionCheck.ReadWriteSubTree);
            if (root == null)
            {
                Console.WriteLine("Invalid config.");
                return;
            }
            Trace("C");
            root.SetAccessControl(rs);
            var z = root.GetValue("7z").ToString();
            var save2 = root.GetValue("save2").ToString();
            var psd = root.GetValue("psd").ToString();
            var mhe = root.GetValue("mhe").ToString();
            var f = args[0].TrimEnd(new[] { '\\' });
            var fileName = save2 + "\\" + f.Substring(f.LastIndexOf("\\", System.StringComparison.Ordinal) + 1) + ".7z";
            Trace("D");
            var param = string.Format("-p{0} {1} a \"{2}\" \"{3}\"",
                psd,
                mhe == "y" ? "-mhe" : " ",
                fileName,
                args[0]
                );
            Trace(param);
            Process.Start(z, param);
        }

        private static void Trace(string str)
        {
            //Console.WriteLine(str);
            //Console.ReadKey();
        }
    }
}
