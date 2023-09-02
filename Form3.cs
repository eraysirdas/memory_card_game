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
    public partial class Form3 : Form
    {
        SoundPlayer ses = new SoundPlayer();
        
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "arkaplan1")
            {
                this.BackgroundImage = Properties.Resources.arkaplan1;
                durum.Text = "varsayılan arkaplanı sectiniz...";
            }
            else if (comboBox1.Text == "arkaplan2")
            {
                this.BackgroundImage = Properties.Resources.arkaplan2;
                durum.Text = "yeni arkaplan ayarlandı...";
            }
            else if (comboBox1.Text == "arkaplan3")
            {
                this.BackgroundImage = Properties.Resources.arkaplan3;
                durum.Text = "yeni arkaplan ayarlandı...";
            }
            else if (comboBox1.Text == "arkaplan4")
            {
                this.BackgroundImage = Properties.Resources.arkaplan4;
                durum.Text = "yeni arkaplan ayarlandı...";
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("arkaplan1");
            comboBox1.Items.Add("arkaplan2");
            comboBox1.Items.Add("arkaplan3");
            comboBox1.Items.Add("arkaplan4");
          
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Müzik1(Rock)");
            comboBox2.Items.Add("Müzik2(Rock)");
            comboBox2.Items.Add("Müzik3(Klasik)");
            comboBox2.Items.Add("Müzik4(Bonus)");
            comboBox2.Items.Add("Müziği kapat");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 b = new Form2();  
            b.BackgroundImage=this.BackgroundImage;
            b.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Müzik1(Rock)")
            {
                ses.SoundLocation = @"C:\Users\Eray\Desktop\Yeni klasör (2)\başladıkbagalım\Resources\Iron ManBack In BlackAMV.wav";
                ses.PlayLooping();

            }
            else if (comboBox2.Text == "Müzik2(Rock)")
            {
                ses.SoundLocation = @"C:\Users\Eray\Desktop\Yeni klasör (2)\başladıkbagalım\Resources\ACDC - Thunderstruck.wav";
                ses.PlayLooping();
            }
            else if (comboBox2.Text == "Müzik3(Klasik)")
            {
                ses.SoundLocation = @"C:\Users\Eray\Desktop\Yeni klasör (2)\başladıkbagalım\Resources\Eternity and a Day,Eleni Karaindrou.wav";
                ses.PlayLooping();
            }
            else if (comboBox2.Text == "Müzik4(Bonus)")
            {
                ses.SoundLocation = @"C:\Users\Eray\Desktop\Yeni klasör (2)\başladıkbagalım\Resources\Herkesin Bildiği Klasik Müzik Ama ''DRİLL REMİX''.wav";
                ses.PlayLooping();
            }
            else if (comboBox2.Text == "Müziği kapat")
            {
                ses.Stop();
            }
        }
    }
}
