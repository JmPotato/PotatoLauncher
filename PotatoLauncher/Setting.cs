using System;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Collections.Generic;

namespace PotatoLauncher
{
    class Setting
    {
        static public String SetJava()
        { 
            string JavaPath = "";
            try
            {
                RegistryKey hklm = Registry.LocalMachine;
                RegistryKey java = hklm.OpenSubKey(@"SOFTWARE\JavaSoft\Java Runtime Environment\1.7");
                JavaPath = java.GetValue("JavaHome").ToString();
                JavaPath += @"\bin\javaw.exe";
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("没有找到Java路径！请确认是否安装了1.7及以上版本的Java！");
            }
            return JavaPath;
        }
    }
}
