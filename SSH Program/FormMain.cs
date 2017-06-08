using Port_Finder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSH_Program
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            getInternetIP();

            loadLabels();
            loadListViewColumns();
        }

        string localIP; //Declares varible for the local ip of your machine

        //Function that gets your local ip
        private void getInternetIP()
        {
            localIP = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
        }

        //Function that loads the labels for local ip
        private void loadLabels()
        {
            lblInternetIP.Text = "Your local IP is: " + localIP;
        }

        //Function that loads the ListView's Columns with spacing
        private void loadListViewColumns()
        {
            ltvIPsOnNetwork.View = View.Details; //IDK what this is but you need it to make new columns
            ltvIPsOnNetwork.Columns.Add("     Local IPs     ", -2, HorizontalAlignment.Left);
            ltvIPsOnNetwork.Columns.Add("Is Online", -2, HorizontalAlignment.Left);
            ltvIPsOnNetwork.Columns.Add("    FTP (20)    ", -2, HorizontalAlignment.Left);
            ltvIPsOnNetwork.Columns.Add("    FTP (21)    ", -2, HorizontalAlignment.Left);
            ltvIPsOnNetwork.Columns.Add("    SSH (22)    ", -2, HorizontalAlignment.Left);
            ltvIPsOnNetwork.Columns.Add("    Telnet (23)    ", -2, HorizontalAlignment.Left);
        }

        int intHowManyIPsOnline; //Declaring varible that will check how many ips are online

        //Function that checks an ip and see if it is online
        private bool checkIPOnline(string _number)
        {
            System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
            string ipSending = _number.ToString();
            
            System.Net.NetworkInformation.PingReply rep = p.Send(ipSending);
            if (rep.Status == System.Net.NetworkInformation.IPStatus.Success)
            {
                intHowManyIPsOnline += 1;
                return true;
            }else
            {
                return false;
            }
        }

        //Function that checks if checkbox is checked and returns if port is open
        private string checkPortAvailble(CheckBox _checkBox, int _portNum, string _ip)
        {
            if (_checkBox.Checked)
            {
                return PingHost(_ip, _portNum).ToString();
            }
            else
            {
                return "Not Checked";
            }
        }

        //Function that populates the list view will ips and ports if they are open
        private void fillListView(string _ip, bool _bool)
        {
            ltvIPsOnNetwork.Items.Add(new ListViewItem(new[] { _ip, _bool.ToString(), checkPortAvailble(ckbFTP20,20,_ip), checkPortAvailble(ckbFTP21,21,_ip), checkPortAvailble(ckbSSH,22,_ip), checkPortAvailble(ckbTelnet,23,_ip) }));
        }

        //Function that is ran when Check for IPs button pressed
        private void btnCheckNetworkForIPs_Click(object sender, EventArgs e)
        {
            ltvIPsOnNetwork.Items.Clear(); //Always clear when you reset button
            intHowManyIPsOnline = 0; //Always clear when you reset button

            string ipHeader = txtHeader.Text;

            //string ipHeader = "192.168.1."; //TODO auto get header

            int howManyTimesLoop = Convert.ToInt32(txtPortsTwo.Text) - Convert.ToInt32(txtPortsOne.Text); //Varible that does math that gets how many times you need to loop

            for(var i = 0; i <= howManyTimesLoop; i++) //Loops all of the ips in the given range
            {
                fillListView(ipHeader + (i + Convert.ToInt32(txtPortsOne.Text)),checkIPOnline(ipHeader + (i + Convert.ToInt32(txtPortsOne.Text))));
            }

            int one = intHowManyIPsOnline; //GIANT TODO RIGHT HERE
            int two = howManyTimesLoop;
            //float ipsOnlineRatio = (one / two) * 10;
            lblHowManyIPs.Text = "There is " + intHowManyIPsOnline + " IPs online out of " + howManyTimesLoop + " (" + /*ipsOnlineRatio +*/ "%)";
        }
        
        //Function that is ran when check one ip button is pressed
        private void btnCheckOneIP_Click(object sender, EventArgs e)
        {
            string IP = txtTestSingleIP.Text; //Grabs the input from textbox

            lblSingleIP.Text = "IP: " + txtTestSingleIP.Text; //Sets your ip in label

            if(checkIPOnline(IP))
            {
                lblStatus.Text = "Status: Online";
            }
            else
            {
                lblStatus.Text = "Status: Offline";
            }

            if(PingHost(IP, 22))
            {
                lblSingleSSH.Text = "SSH: Enabled";
            }
            else
            {
                lblSingleSSH.Text = "SSH: Disabled";
            }
        }

        //Function that checks an ip for port opening
        public static bool PingHost(string _HostURI, int _PortNumber)
        {
            try
            {
                TcpClient client = new TcpClient(_HostURI, _PortNumber);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        string selectedIP; //Declares a varible that would be the ip of the selected index of the listview

        //Function that runs when you click an ip on the listview
        private void ltvIPsOnNetwork_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIP = ltvIPsOnNetwork.FocusedItem.Text;

            if(PingHost(selectedIP, 22))
            {
                btnSSH.Enabled = true;
            }
            else
            {
                btnSSH.Enabled = false;
            }
        }

        //Function that will run when you click SSH button
        private void btnSSH_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(selectedIP, "SSH", 22);
            loginForm.Show();
        }
    }
}
