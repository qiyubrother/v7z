using System;
using System.Security.AccessControl;
using Microsoft.Win32;
using System.Diagnostics;

namespace v7zuncompress
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
            Trace("A");
            //Console.WriteLine(args[0]);
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
            var uncompressionPath = root.GetValue("uncompress2").ToString();
            var psd = root.GetValue("psd").ToString();
            //Console.WriteLine(uncompressionPath);
            Trace("D");

            var param = string.Format("x {0} -p{1} -y -o\"{2}\"",
                args[0],
                psd,
                uncompressionPath
            );
            Trace("E");
            Console.WriteLine(param);
            Process.Start(z, param);
        }

        private static void Trace(string str)
        {
            //Console.WriteLine(str);
            //Console.ReadKey();
        }
    }
}
