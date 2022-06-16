using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItem fi = new frmItem();
            fi.MdiParent = this;
            fi.Show();
        }
    }
}
