using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gectı_kaldı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float yazili1,yazili2,devamsizlik,ortalama, durum;
            yazili1 = Convert.ToSingle(txtYazili1.Text);
            yazili2 = Convert.ToSingle(txtYazili2.Text);
            devamsizlik = Convert.ToSingle(txtDevamsizlik.Text);
            

            ortalama = (yazili1 + yazili2) / 2;

            if (ortalama >=50 && devamsizlik < 10)
            {
               
                lblDurum.Text = "GEÇTİNİZ";
              
                
            }
            else 
            {
                lblDurum.Text = "kaldınız";
               
            }
            lblOrtalama.Text = "Ortalama :" + ortalama.ToString();
         

        }
    }
}
