using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegerDondurenMetot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Geriye değer döndüren metot tanımlandı.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int DegerDondurenToplama(int a, int b)
        {
            int sonuc = a + b;
            return sonuc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(DegerDondurenToplama(9, 3).ToString());
            MessageBox.Show(Toplama(3,5).ToString());
        }
        /// <summary>
        /// Geriye değer döndüren metot tanımlama örneği. Bu metot aldığı iki sayıyı çarpıp ilk sayıya ekliyor.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Toplama (int a, int b)
        {
            int sonuc = a + (a * b);
            return sonuc;
        }
    }
}
