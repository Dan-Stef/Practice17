using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex17_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color color;
        string firstName;

        private void button1_Click(object sender, EventArgs e)
        {
            color = Color.MediumPurple;
            firstName = "Ivan";
            Invalidate();

            // Запись настроек.
            Properties.Settings.Default.color12 = color;
            Properties.Settings.Default.name = firstName;
            Properties.Settings.Default.Save();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            color = Color.Firebrick;
            firstName = "Roman";
            Invalidate();

            // Запись настроек.
            Properties.Settings.Default.color12 = Color.Firebrick;
            Properties.Settings.Default.name = firstName;
            Properties.Settings.Default.Save();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Восстановление настроек.
                color = Properties.Settings.Default.color12;
                firstName = Properties.Settings.Default.name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 10);
            g.DrawString(firstName, font, new SolidBrush(color), 100, 100);

        }
    }
}
