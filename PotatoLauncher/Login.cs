using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Collections.Generic;

namespace PotatoLauncher
{
    class Login
    {
        public static String login(String mail, String password)
        {
            string parameter = "";
            try
            {
                string url = "https://login.minecraft.net/?user=" + mail + "&password=" + password + "&version=13";
                WebClient Login = new WebClient();
                Stream data = Login.OpenRead(url);
                StreamReader r = new StreamReader(data);
                string s = r.ReadToEnd();
                data.Close();
                r.Close();

                string[] LoginParameter = s.Split(':');
                parameter = "\"" + LoginParameter[2] + "\" \"" + LoginParameter[3] + "\"";
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("验证失败，请确定用户名和密码输入正确！");
            }
            return parameter;
        }
    }
}
