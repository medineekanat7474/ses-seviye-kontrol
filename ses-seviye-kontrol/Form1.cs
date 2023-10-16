using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ses_seviye_kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbSes_Scroll(object sender, EventArgs e)
        {
            int deger = tbSes.Value;
            lblSesDegeri.Text=deger.ToString();
            if (deger >= 0 && deger < 25)
            {
                lblSesSeviyesi.Text = "ses seviyesi düşük";
            }
            else if (deger >= 25 && deger < 70)
            {
                lblSesSeviyesi.Text = "ses seviyesi normal";
            }
            else if (deger >= 70 && deger < 90)
            {
                lblSesSeviyesi.Text = "ses seviyesi yüksek";
            }
            else
            {
                lblSesSeviyesi.Text = "ses seviyesi çok yüksek";
            }
        }
    }
}
