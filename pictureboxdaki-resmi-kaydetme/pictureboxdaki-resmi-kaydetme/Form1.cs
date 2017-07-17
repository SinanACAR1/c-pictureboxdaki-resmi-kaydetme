using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureboxdaki_resmi_kaydetme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum harfler   //RESİMLERİN İSİMLERİ ÇAKISMAMASI İÇİN RASTGELE HARFLER
        {
            a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, r, s, t, u, v, y, z
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int harf = rnd.Next(0, 24);//RESİM ADLARI ÇAKIŞMAMASI İÇİN RASTGELE HARFLER ÜRETİLMESİ
            int sayi = rnd.Next(0, 100);//RESİM ADLARI ÇAKIŞMAMASI İÇİN RASTGELE SAYI ÜRETİLMESİ

            pictureBox1.Image.Save(Application.StartupPath + "\\aa\\Resim" + ((harfler)(harf)).ToString().ToUpper() + sayi.ToString() + ".png");
            //YUKARDAKİ "\\aa\\Resim" YAZAN YER RESİMİ NEREYE VE HANGİ ADLA KAYDEDİCEĞİNİ BELİRLER SONDAKİ .PNG YAZISI HANGİ UZANTIDA KAYDEDİCEĞİNİ BELİRLER
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            OpenFileDialog dosya = new OpenFileDialog(); 
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";  //dosya uzantılarını filtreliyoruz
            dosya.Title = "Dosya Seç"; //Başlık
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox1.ImageLocation = DosyaYolu;
        }
    }
}
