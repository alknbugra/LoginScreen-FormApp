using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginClass
{
    public class LoginControl
    {
        public Form1 frm1;

        public string control(string username,string password)
        {
            string turnInfo="";

            string trialname = "bugra";
            string trialpass = "lemon";

            if (trialname == username && trialpass == password)
            {
                turnInfo = "Login successful";
                frm1.textBox2.Clear();
                frm1.textBox1.Clear();
                frm1.textBox1.Focus();
            }
            else
            {
                 turnInfo = "login failed";
            }
            return turnInfo;
        }
    }
}
