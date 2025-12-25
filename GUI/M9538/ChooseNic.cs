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

namespace M9538
{
    public partial class ChooseNic : Form
    {
        public ChooseNic()
        {
            InitializeComponent();
        }

        public NetworkInterface[] NICs { set; get; }
        public IPAddress ChosenIP { get; private set; }
        public NetworkInterface ChosenNIC { get; private set; }

        private List<IPAddress> _IPs = new List<IPAddress>();
        private List<NetworkInterface> _NICs = new List<NetworkInterface>();

        private void ChooseNic_Load(object sender, EventArgs e)
        {
            if (NICs == null)
            {
                DialogResult = DialogResult.Abort;
                return;
            }
            foreach (NetworkInterface adapter in NICs)
            {
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                    continue;
                if (adapter.OperationalStatus == OperationalStatus.Down)
                    continue;
                // Only display informatin for interfaces that support IPv4.
                if (adapter.Supports(NetworkInterfaceComponent.IPv4) == false)
                {
                    continue;
                }

                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                // Try to get the IPv4 interface properties.
                IPv4InterfaceProperties p = adapterProperties.GetIPv4Properties();

                if (p == null)
                    continue;
                if (p.IsDhcpEnabled == true)
                    continue;
                foreach (IPAddress ip in adapterProperties.UnicastAddresses.Select(x => x.Address))
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        _IPs.Add(ip);
                        _NICs.Add(adapter);
                    }
                }
            }
            if (_IPs.Count == 0)
            {
                DialogResult = DialogResult.Abort;
                return;
            }
            for (int i = 0; i < _IPs.Count; i++)
                comboBox1.Items.Add(_NICs[i].Name + " : " + _IPs[i].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            ChosenIP = _IPs[comboBox1.SelectedIndex];
            ChosenNIC = _NICs[comboBox1.SelectedIndex];
        }
    }
}
