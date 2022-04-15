using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaDersi
{
    public partial class Form1 : Form
    {
        int deger = 10;
        public Form1()
        {
            InitializeComponent();
        }

        public int ThisKullanimi(int deger)
        {
            this.deger = this.deger * deger;
            return this.deger;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Sonuç: " + ThisKullanimi(2));
        }
    }
}
