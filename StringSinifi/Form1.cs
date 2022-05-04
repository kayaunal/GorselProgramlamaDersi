using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringSinifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ifade = textBox1.Text;
            char[] dizi = new char[20];
            ifade.CopyTo(4, dizi, 0, 7);
            foreach (char eleman in dizi)
            {
                listBox1.Items.Add(eleman);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ifade = "Açıköğretim Fakültesi";
            string klon = (string)ifade.Clone();
            MessageBox.Show(klon);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cumle = "bana yardım eder misin?";
            string ekCumle = cumle.Insert(0, "Lütfen ");
            MessageBox.Show(ekCumle);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ifade = "Açıköğretim Fakültesi";
            string yeniIfade = ifade.Replace("Açıköğretim", "İkinci Üniversite");
            MessageBox.Show(yeniIfade);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cumle = "Açıköğretim Fakültesi";
            string sonuc = cumle.Substring(cumle.Length - 9);
            MessageBox.Show(sonuc);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string veriTabanindakiParola = "Giris.123";
            string parolaCheck = textBox2.Text;
            int sonuc = string.Compare(veriTabanindakiParola, parolaCheck);
            if (sonuc == 0)
            {
                MessageBox.Show("Parola doğru");
            }
            else MessageBox.Show("Parola hatalı!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ifade = textBox3.Text;
            string arananKelime = textBox4.Text;
            int sonuc = ifade.IndexOf(arananKelime);
            if (sonuc != -1)
            {
                MessageBox.Show("Aranan kelimenin bulunduğu index: " + sonuc.ToString());
            }
            else
            {
                MessageBox.Show("Aranan kelime bulunamamaktadır.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string dataFromTextBox5 = textBox5.Text;
            int boyut = dataFromTextBox5.Length;
            MessageBox.Show("Yazılan ifadenin 'lenght' ile hesaplanan karakter sayısı: " + boyut);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string dataFromTextBox5 = textBox5.Text;
            int boyut = dataFromTextBox5.Count();
            MessageBox.Show("Yazılan ifadenin 'count() ile hesaplanan' karakter sayısı" + boyut);
        }
        //Aşağıdaki bölüme daha sonra şöyle bir uygulama geliştirilecek:
        //
        //Kullanıcıdan alınan bir metin içerisinde yine kullanıcıdan
        //alınan bir kelimeyi arayan, aranan kelimenin bu metinde
        //kaç kez geçtiğini bulan ve tüm bu kelimeyi yine kullanıcıdan
        //alınan ikinci bir kelime ile değiştiren uygulama
        private void button11_Click(object sender, EventArgs e)
        {
            string dataFromTextBox6 = textBox6.Text;
            string dataFromTextBox7 = textBox7.Text;
            bool sonuc = dataFromTextBox6.Contains(dataFromTextBox7);
            int sayi = 0;
            if (sonuc == true)
            {
                for (int i = 0; i < dataFromTextBox6.Length; i++)
                {
                    i++;
                }
            MessageBox.Show("Metin içerisinde " + sayi + " adet " + dataFromTextBox7 + " bulunmaktadır.");
            }
            else
            {
                MessageBox.Show("Sonuç bulunamadı");
            }
        }
    }
}
