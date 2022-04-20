using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParamsAnahtarSozcugu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Params anahtar sözcüğü, aynı tipte olmak şartıyla metot içerisinde kullanılacak parametre sayısının
        //bilinmediği bu gibi durumlarda kullanılmaktadır.
        //Ayrıca dizi ile kullanılmasına rağmen diziyi bilinen dizi yapısından farklı bir şekilde tutar.

        public int ParamsEnBuyukSayiyiBul(params int[] sayilar)
        {
            int enBuyukSayi = -1;
            if (sayilar.Length > 0)
                enBuyukSayi = sayilar[0];
            for (int i = 1; i < sayilar.Length; i++)
            {
                if (enBuyukSayi < sayilar[i])
                    enBuyukSayi = sayilar[i];
            }
            return enBuyukSayi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("En büyük sayı: " + ParamsEnBuyukSayiyiBul(7, 10, 3, 4, 9));
        }
    }
}
