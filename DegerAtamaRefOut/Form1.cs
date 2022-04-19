using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegerAtamaRefOut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// "deger" metodu
        /// </summary>
        /// <param name="deger"></param>
        /// <returns></returns>
        public int DegerAtama(int deger)
        {
            deger = 100;
            return deger;
        }
        /// <summary>
        /// REF ile deger metodu
        /// </summary>
        /// <param name="refdeger"></param>
        /// <returns></returns>
        public int RefDegerAtama(ref int refdeger)
        {
            refdeger = 100;
            return refdeger;
        }
        /// <summary>
        /// OUT ile deger metodu
        /// </summary>
        /// <param name="outdeger"></param>
        /// <returns></returns>
        public int OutDegerAtama(out int outdeger)
        {
            outdeger= 100;
            return outdeger;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 1;
            MessageBox.Show("Metot çağrısından önce: " + a.ToString());
            DegerAtama(a);
            MessageBox.Show("Metot çağrısından sonra: " + a.ToString());
            //
            //Yukarıda değer atama ve sonra çağırmaişlemi gerçekleştirildi.
            //Dönen değerin aynı olduğuna dikkat!
            //
            int b = 1;
            MessageBox.Show("Ref ile metot çağrısından önce: " + b.ToString());
            RefDegerAtama(ref b);
            MessageBox.Show("Ref ile metot çağrısından sonra: " + b.ToString());
            //
            //Yukarıda ref ile yapılan tanınlamaların ardından değerin değiştiği gözleniyor.
            //
            int c;
            OutDegerAtama(out c);
            MessageBox.Show("Out ile metot çağırmadan sonra: " + c.ToString());
            //
            //Yukarıda out ile kullanılan değişkene ilk değer atanmadı. 
        }
    }
}
