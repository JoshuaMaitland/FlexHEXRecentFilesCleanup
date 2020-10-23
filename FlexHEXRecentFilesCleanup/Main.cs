using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Other Stuff
using Microsoft.Win32;

namespace FlexHEXRecentFilesCleanup
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
#if DEBUG
            this.Text += " [Debug]";
#endif
        }

        private void btnCleanup_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tool made by Joshua Maitland\r\n\r\nThis program was made under GNU General Public License v3.0. See LICENSE for details", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
