using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace başladıkbagalım
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.arkaplan1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
            this.Hide();
            a.BackgroundImage = this.BackgroundImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            c.BackgroundImage = this.BackgroundImage;
            c.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
