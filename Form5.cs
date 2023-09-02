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
    public partial class Form5 : Form
    {
        Random karıştır = new Random(); // karıstırma yapmak için random sınıfını olusturdum burda yazmamın nedenı her yerden erişebilmek için
        List<Point> points = new List<Point>(); // point düzlem yaratmaya yarıyor yani x y koordinatları oluşturuyor, list de bir veri türüne birden çok eleman eklemeye yarıyor anladığım kadarıyla...
        int sayac = 0;              // sayac bilgisi geri sayım bittiginde kartların kapanması için...
        PictureBox birinciresim;    // resimler aynı mı degıl mı dıye kontrol etmek için kullandıgım degerler
        PictureBox ikinciresim;
        // int b = 2;
        int saniye = 0;
        int dakika = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            gerisayım.Text = "5"; // kartlar kapanmadan önceki geri sayımın değerini burdan girdim çünkü yeniden oyna dediğimde de çalışabilmesi için
            timer2.Start();
            timer1.Start();


            foreach (PictureBox tıklama in resimler.Controls)
            /*resimlerin hepsini foreach ile döndürdüm burada geri sayım varken tıklamayı pasif yapıyorum görünmeyi
            de aktif yapıyorum çünkü kpdun ilerleyen kısmında bütün resimlerin görünmesini pasif yaptım ve yeniden oyna dediğimde eski haline gelmesi için aktif yapmam gerekli.*/
            {
                tıklama.Enabled = false;
                tıklama.Visible = true;
                points.Add(tıklama.Location); // listeye elemanları kartların konumlarını aldım foreach sayesinde hepsini tek tek ekledim... (tıklama.location dıyerek kartın düzlemdeki bilgilerini aldık..)
            }
            foreach (PictureBox resim in resimler.Controls)
            {
                int next = karıştır.Next(points.Count);  // random sınıfına listedeki elemanların uzunlugunu girdim (count sayesinde ) yani random sınıfına hangı deger aralıgında calısacagını soyledim ve karıstırma işlemini yaptım.(düzlemler karışıyor)
                Point p = points[next];                     // yeni bir point oluşturup karışmıs olan kart konumlarını attım.
                resim.Location = p;                            //her seferinde kartlarının konumları guncelledim...her foreach calıstıgında 42 satır calısır rastgale bir konum olusur 43 de bu bilgi p ye atılır ve burada resime yani hangi karttaysa ona atar.
                points.Remove(p);                           // p nın degerini siler ilerleyebilmesi için yazman lazım cunku rastgale üretme sırasında bazen çakışabilir aynı konumlar...
            }

            kart1.Image = Properties.Resources._1;          // kartlara yani pictureboxlara resources den resimleri atıyorum
            kart_1.Image = Properties.Resources._1;
            kart2.Image = Properties.Resources._2;
            kart_2.Image = Properties.Resources._2;
            kart3.Image = Properties.Resources._3;
            kart_3.Image = Properties.Resources._3;
            kart4.Image = Properties.Resources._4;
            kart_4.Image = Properties.Resources._4;
        }
        private void kart1_Click_1(object sender, EventArgs e)
        {
            kart1.Image = Properties.Resources._1;
            kart1.Enabled = false;
            if (birinciresim == null)
            {
                birinciresim = kart1;
            }
            else if (birinciresim != null && ikinciresim == null)
            {
                ikinciresim = kart1;
            }
            if (birinciresim != null && ikinciresim != null)
            {
                if (birinciresim.Tag == ikinciresim.Tag)
                {

                    birinciresim = null;
                    ikinciresim = null;
                    kart1.Enabled = false;
                    timer4.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) + 10);
                }
                else
                {
                    timer3.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) - 10);
                    kart1.Enabled = false;
                    kart_1.Enabled = false;
                    kart2.Enabled = false;
                    kart_2.Enabled = false;
                    kart3.Enabled = false;
                    kart_3.Enabled = false;
                    kart4.Enabled = false;
                    kart_4.Enabled = false;
                }
            }
        }

        private void kart2_Click(object sender, EventArgs e)
        {
            kart2.Image = Properties.Resources._2;
            kart2.Enabled = false;
            if (birinciresim == null)
            {
                birinciresim = kart2;
            }
            else if (birinciresim != null && ikinciresim == null)
            {
                ikinciresim = kart2;
            }
            if (birinciresim != null && ikinciresim != null)
            {
                if (birinciresim.Tag == ikinciresim.Tag)
                {
                    birinciresim = null;
                    ikinciresim = null;
                    kart2.Enabled = false;
                    timer5.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) + 10);

                }
                else
                {
                    timer3.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) - 10);
                    kart1.Enabled = false;
                    kart_1.Enabled = false;
                    kart2.Enabled = false;
                    kart_2.Enabled = false;
                    kart3.Enabled = false;
                    kart_3.Enabled = false;
                    kart4.Enabled = false;
                    kart_4.Enabled = false;
                }
            }
        }

        private void kart3_Click(object sender, EventArgs e)
        {
            kart3.Image = Properties.Resources._3;
            kart3.Enabled = false;
            if (birinciresim == null)
            {
                birinciresim = kart3;
            }
            else if (birinciresim != null && ikinciresim == null)
            {
                ikinciresim = kart3;
            }
            if (birinciresim != null && ikinciresim != null)
            {
                if (birinciresim.Tag == ikinciresim.Tag)
                {
                    birinciresim = null;
                    ikinciresim = null;
                    kart3.Enabled = false;
                    timer6.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) + 10);
                }
                else
                {
                    timer3.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) - 10);
                    kart1.Enabled = false;
                    kart_1.Enabled = false;
                    kart2.Enabled = false;
                    kart_2.Enabled = false;
                    kart3.Enabled = false;
                    kart_3.Enabled = false;
                    kart4.Enabled = false;
                    kart_4.Enabled = false;
                }
            }
        }

        private void kart4_Click(object sender, EventArgs e)
        {
            kart4.Image = Properties.Resources._4;
            kart4.Enabled = false;
            if (birinciresim == null)
            {
                birinciresim = kart4;
            }
            else if (birinciresim != null && ikinciresim == null)
            {
                ikinciresim = kart4;
            }
            if (birinciresim != null && ikinciresim != null)
            {
                if (birinciresim.Tag == ikinciresim.Tag)
                {
                    birinciresim = null;
                    ikinciresim = null;
                    kart4.Enabled = false;
                    timer7.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) + 10);
                }
                else
                {
                    timer3.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) - 10);
                    kart1.Enabled = false;
                    kart_1.Enabled = false;
                    kart2.Enabled = false;
                    kart_2.Enabled = false;
                    kart3.Enabled = false;
                    kart_3.Enabled = false;
                    kart4.Enabled = false;
                    kart_4.Enabled = false;
                }
            }
        }
        private void kart_4_Click(object sender, EventArgs e)
        {
            kart_4.Image = Properties.Resources._4;
            kart_4.Enabled = false;
            if (birinciresim == null)
            {
                birinciresim = kart_4;
            }
            else if (birinciresim != null && ikinciresim == null)
            {
                ikinciresim = kart_4;
            }
            if (birinciresim != null && ikinciresim != null)
            {
                if (birinciresim.Tag == ikinciresim.Tag)
                {
                    birinciresim = null;
                    ikinciresim = null;
                    kart_4.Enabled = false;
                    timer7.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) + 10);
                }
                else
                {
                    timer3.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) - 10);
                    kart1.Enabled = false;
                    kart_1.Enabled = false;
                    kart2.Enabled = false;
                    kart_2.Enabled = false;
                    kart3.Enabled = false;
                    kart_3.Enabled = false;
                    kart4.Enabled = false;
                    kart_4.Enabled = false;
                }
            }
        }

        private void kart_1_Click(object sender, EventArgs e)
        {
            kart_1.Image = Properties.Resources._1;
            kart_1.Enabled = false;
            if (birinciresim == null)
            {
                birinciresim = kart_1;
            }
            else if (birinciresim != null && ikinciresim == null)
            {
                ikinciresim = kart_1;

            }
            if (birinciresim != null && ikinciresim != null)
            {
                if (birinciresim.Tag == ikinciresim.Tag)
                {

                    birinciresim = null;
                    ikinciresim = null;
                    kart_1.Enabled = false;
                    timer4.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) + 10);
                }
                else
                {
                    timer3.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) - 10);
                    kart1.Enabled = false;
                    kart_1.Enabled = false;
                    kart2.Enabled = false;
                    kart_2.Enabled = false;
                    kart3.Enabled = false;
                    kart_3.Enabled = false;
                    kart4.Enabled = false;
                    kart_4.Enabled = false;
                }
            }

        }

        private void kart_2_Click(object sender, EventArgs e)
        {
            kart_2.Image = Properties.Resources._2;
            kart_2.Enabled = false;
            if (birinciresim == null)
            {
                birinciresim = kart_2;
            }
            else if (birinciresim != null && ikinciresim == null)
            {
                ikinciresim = kart_2;
            }
            if (birinciresim != null && ikinciresim != null)
            {
                if (birinciresim.Tag == ikinciresim.Tag)
                {
                    birinciresim = null;
                    ikinciresim = null;
                    kart_2.Enabled = false;
                    timer5.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) + 10);
                }
                else
                {
                    timer3.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) - 10);
                    kart1.Enabled = false;
                    kart_1.Enabled = false;
                    kart2.Enabled = false;
                    kart_2.Enabled = false;
                    kart3.Enabled = false;
                    kart_3.Enabled = false;
                    kart4.Enabled = false;
                    kart_4.Enabled = false;
                }
            }
        }

        private void kart_3_Click(object sender, EventArgs e)
        {
            kart_3.Image = Properties.Resources._3;
            kart_3.Enabled = false;
            if (birinciresim == null)
            {
                birinciresim = kart_3;
            }
            else if (birinciresim != null && ikinciresim == null)
            {
                ikinciresim = kart_3;
            }
            if (birinciresim != null && ikinciresim != null)
            {
                if (birinciresim.Tag == ikinciresim.Tag)
                {
                    birinciresim = null;
                    ikinciresim = null;
                    kart_3.Enabled = false;
                    timer6.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) + 10);
                }
                else
                {
                    timer3.Start();
                    skor.Text = Convert.ToString(Convert.ToInt32(skor.Text) - 10);
                    kart1.Enabled = false;
                    kart_1.Enabled = false;
                    kart2.Enabled = false;
                    kart_2.Enabled = false;
                    kart3.Enabled = false;
                    kart_3.Enabled = false;
                    kart4.Enabled = false;
                    kart_4.Enabled = false;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            birinciresim.Image = Properties.Resources.kapak;
            ikinciresim.Image = Properties.Resources.kapak;
            birinciresim = null;
            ikinciresim = null;
            kart1.Enabled = true;
            kart_1.Enabled = true;
            kart2.Enabled = true;
            kart_2.Enabled = true;
            kart3.Enabled = true;
            kart_3.Enabled = true;
            kart4.Enabled = true;
            kart_4.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac += 1;
            if (sayac == 5)
            {
                timer10.Start();
                timer1.Stop();
                foreach (PictureBox resim in resimler.Controls)
                {
                    resim.Enabled = true;
                    resim.Image = Properties.Resources.kapak;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int sayac = int.Parse(gerisayım.Text);
            sayac = sayac - 1;
            gerisayım.Text = sayac.ToString();
            if (sayac == 0)
            {
                timer2.Stop();
                gerisayım.Text = "-";
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (kart_1.Enabled == false || kart1.Enabled == false)
            {
                timer4.Stop();
                kart1.Visible = false;
                kart_1.Visible = false;
                oyunbitti();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (kart_2.Enabled == false || kart2.Enabled == false)
            {
                timer5.Stop();
                kart2.Visible = false;
                kart_2.Visible = false;
                oyunbitti();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (kart_3.Enabled == false || kart3.Enabled == false)
            {
                timer6.Stop();
                kart3.Visible = false;
                kart_3.Visible = false;
                oyunbitti();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (kart_4.Enabled == false || kart4.Enabled == false)
            {
                timer7.Stop();
                kart4.Visible = false;
                kart_4.Visible = false;
                oyunbitti();

            }
        }
        private void oyunbitti() // oyunbitti diye bir sınıf oluşturdum ve tüm kartların visible' ı false olduğunda çalışması şeklinde koşul oluşturdum yani kart kapatma timerlarının hepsi çalıştığı zaman çalışıyor.
        {
            if (kart1.Visible == false && kart2.Visible == false && kart3.Visible == false && kart4.Visible == false &&  kart_1.Visible == false && kart_2.Visible == false && kart_3.Visible == false && kart_4.Visible == false )
            {
                timer10.Stop();
                MessageBox.Show("oyun bitti : ) skorunuz : " + skor.Text + " süreniz: " + dak.Text + " : " + san.Text);
                skor.Text = "0";
                saniye = 0;
                dakika = 0;
                san.Text = saniye.ToString();
                dak.Text = dakika.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            skor.Text = "0"; // skor bilgisini guncellıyorum
            timer10.Stop();
            sayac = 0;
            saniye = 0;
            dakika = 0;
            san.Text = saniye.ToString();
            dak.Text = dakika.ToString();
            Form5_Load(sender, e);
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye == 60)
            {
                dakika++;
                saniye = 0;
            }
            dak.Text = dakika.ToString();
            san.Text = saniye.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 d = new Form2();
            d.BackgroundImage = this.BackgroundImage;
            d.Show();
            this.Hide();
        }
    }
}
