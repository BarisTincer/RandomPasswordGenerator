using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        bool kucukHarfVarMi, buyukHarfVarMi, rakamVarMi, ozelKarakterVarMi;
        int sifreUzunlugu, sifreSayisi;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            txtSifreler.Text = "";//her ürettiğinde textbox'ı temizlemesi için.
            string seciliKarakterler = "";

            kucukHarfVarMi = chkKucukHarf.Checked;
            buyukHarfVarMi = chkBuyukHarf.Checked;
            rakamVarMi = chkRakam.Checked;
            ozelKarakterVarMi = chkOzelKarakter.Checked;

            sifreSayisi = (int)nudSifreSayisi.Value;
            sifreUzunlugu = (int)nudSifreUzunlugu.Value;

            if (!(ozelKarakterVarMi || rakamVarMi || buyukHarfVarMi || kucukHarfVarMi))
            {
                MessageBox.Show("En az bir parametre seçiniz!");
                return;
            }

            KucukHarfEkle(ref seciliKarakterler);
            BuyukHarfEkle(ref seciliKarakterler);
            RakamEkle(ref seciliKarakterler);
            OzelKarakterEkle(ref seciliKarakterler);
            SifreUret(seciliKarakterler);
        }

        private void SifreUret(string seciliKarakterler)
        {
            for (int i = 0; i < sifreSayisi; i++)
            {
                string sifre = "";
                for (int j = 0; j < sifreUzunlugu; j++)
                {
                    sifre += seciliKarakterler[rnd.Next(seciliKarakterler.Length)];
                }
                txtSifreler.Text += $"{i + 1}-)" + sifre;
                txtSifreler.Text += "\r\n";
                txtSifreler.Text += "\r\n";
            }
        }

        private void OzelKarakterEkle(ref string seciliKarakterler)
        {
            if (ozelKarakterVarMi)//33 47, 58 64, 91 96, 123 126
            {
                for (int i = 33; i <= 47; i++)
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
                for (int i = 58; i <= 64; i++)
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
                for (int i = 91; i <= 96; i++)
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
                for (int i = 123; i <= 126; i++)
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
            }
        }

        private void RakamEkle(ref string seciliKarakterler)
        {
            if (rakamVarMi)//48 57
            {
                for (int i = 48; i <= 57; i++)
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
            }
        }

        private void BuyukHarfEkle(ref string seciliKarakterler)
        {
            if (buyukHarfVarMi)//65 A 90 Z
            {
                for (int i = 65; i <= 90; i++)
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
            }
        }

        public void KucukHarfEkle(ref string seciliKarakterler)
        {
            if (kucukHarfVarMi)//97 a 122 z
            {
                for (int i = 97; i <= 122; i++)
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
            }
        }
    }
}
