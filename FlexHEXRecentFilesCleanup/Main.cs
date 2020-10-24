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

        private void btnCleanup_Click(object sender, EventArgs e)
        {
            DialogResult clearDialog = MessageBox.Show("Are you sure you want to clear all of the recent files?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (clearDialog == DialogResult.Yes)
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Inv Softworks\\FlexHEX", true))
                {
                    try
                    {
                        key.DeleteSubKeyTree("Recent File List", true);
                        MessageBox.Show("FlexHEX Recent Files was cleared sucessfully.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch
                    {
                        MessageBox.Show("The tool was not be able to clear all of the recent files. Maybe it's because you've already cleaned it up or you haven't got FlexHEX installed on your computer.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tool made by Joshua Maitland\r\n\r\nThis program was made under GNU General Public License v3.0. See LICENSE for details", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
