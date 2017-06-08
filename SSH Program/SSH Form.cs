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
    public partial class SSH_Form : Form
    {
        string userName;
        string password;
        string ip;

        public SSH_Form(string _usr, string _pass, string _ip)
        {
            InitializeComponent();
            userName = _usr;
            password = _pass;
            ip = _ip;
            this.Text = "SSH - " + _ip;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new SshClient(ip, userName, password))
                {
                    client.Connect();
                    client.RunCommand(txtSendCommand.Text);
                    client.Disconnect();
                }
            }
            catch
            {
                MessageBox.Show("Couldn't connect to " + ip + " at port " + 22);
                LoginForm form = new LoginForm(ip, "SSH", 22);
                form.Show();
                this.Close();
            }
        }
    }
}
