using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace PotatoLauncher
{
    class Login
    {
        public static String Login(String mail, String password)
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
                MessageBox.Show("验证失败，请确定用户名和密码输入正确！");
            }
            return parameter;
        }
    }
}
