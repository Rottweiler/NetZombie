using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetZombie
{
    public partial class frmBuild : Form
    {
        public frmBuild()
        {
            InitializeComponent();
        }

        private void frmBuild_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.netzombie;
            this.Text = "NetZombie (Pre-alpha/GUI only)";
            txtHost.Text = IPAddress.Loopback.ToString();
            txtPort.Text = 3307.ToString();
        }
    }
}
