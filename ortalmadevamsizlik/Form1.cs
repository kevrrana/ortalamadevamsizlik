using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalmadevamsizlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        double ortalama, devamsizlik, sonuc;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            ortalama=Convert.ToDouble(txtOrtalama.Text);
            devamsizlik=Convert.ToDouble(txtOrtalama.Text);
             if(ortalama>=50 && devamsizlik < 10)
            {
                lblSonuc.Text = "SONUÇ: Geçtinizz:)";
            }
             else
            {
                lblSonuc.Text = "SONUÇ:Kaldınız:( ";
            }

        }
    }
}
