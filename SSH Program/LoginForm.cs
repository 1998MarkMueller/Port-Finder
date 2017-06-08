using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Port_Finder
{
    public partial class LoginForm : Form
    {
        string ip;
        string port;
        int portNum;

        public LoginForm(string _ip, string _port, int _portNum)
        {
            InitializeComponent();
            this.Text += _ip + "(" + _port + ")";

            ip = _ip;
            port = _port;
            portNum = _portNum;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            SSH_Form form = new SSH_Form(userName, password, ip);
            form.Show();

            this.Close();
        }
    }
}
