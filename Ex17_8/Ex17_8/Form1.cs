using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex17_8
{
    public partial class Form1 : Form
    {
        public int num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num++;
            ToolStripMenuItem mi = new ToolStripMenuItem(num.ToString());
            mi.Click += this.ToolStripMenuItem_Click;
            menuToolStripMenuItem.DropDownItems.Add(mi);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = ((ToolStripMenuItem)sender).Text;
            MessageBox.Show(s);
        }
    }
}
