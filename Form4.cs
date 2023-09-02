using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace başladıkbagalım
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5  a   =new Form5();
            a.Show();
            this.Hide();
            a.BackgroundImage = this.BackgroundImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 b =new Form1();
            b.Show();
            this.Hide();
            b.BackgroundImage = this.BackgroundImage;   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 c = new Form6();
            c.Show();
            this.Hide();
            c.BackgroundImage = this.BackgroundImage;

        }
    }
}
