using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMetotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ornMetin = "";

        #region Örnek 1
        private void BtnCOMPARETO_Click(object sender, EventArgs e)
        {
            ornMetin = txtGirisAlani.Text;
            int result = ornMetin.CompareTo("araba");
            string mesaj = "";
            switch (result)
            {
                case -1:
                    mesaj = "Kelime, anahtar kelime ile eşleşmemektedir. Eksik karakter mevcut";
                    break;
                case 0:
                    mesaj = "Kelime, anahtar kelime ile eşleşmektedir.";
                    break;
                case 1:
                    mesaj = "Kelime, anahtar kelime ile eşleşmemektedir. Fazla karakter mevcut";
                    break;
                default:
                    break;
            }
            MessageBox.Show(mesaj);
        }
        #endregion

        #region Örnek 2
        private void BtnCONTAINS_Click(object sender, EventArgs e)
        {
            ornMetin = txtGirisAlani.Text;
            bool result = ornMetin.Contains("adam");
            MessageBox.Show($"Aradığınız kelime metin içerisinde geçme{(result ? "" : "me")}ktedir");
        }
        #endregion

        #region Örnek 3
        private void BtnSTARTSWITH_Click(object sender, EventArgs e)
        {
            ornMetin = txtGirisAlani.Text;
            bool result = ornMetin.StartsWith("bil");
            MessageBox.Show($"Metin parametrede gösterdiğiniz anahtar kelime ile başlama{(result ? "" : "ma")}ktadır");
        }
        #endregion

        #region Örnek 4
        private void BtnENDSWITH_Click(object sender, EventArgs e)
        {
            ornMetin = txtGirisAlani.Text;
            bool result = ornMetin.EndsWith("dam");
            MessageBox.Show($"Kelime parametrede gönderdiğiniz değer ile bit{(result ? "" : "me")}mektedir.");
        }
        #endregion

        #region Örnek 5
        private void BtnINDEXOF_Click(object sender, EventArgs e)
        {
            ornMetin = txtGirisAlani.Text;
            int index = ornMetin.IndexOf('@');
            MessageBox.Show(index > -1 ? "Aradığınız karakterin metin içerisindeki index değeri: " + index : "Metin içerisinde aradığınız parametre yer almamaktadır.");
        }
        #endregion

        #region Örnek 6
        private void BtnLASTINDEXOF_Click(object sender, EventArgs e)
        {
            ornMetin = txtGirisAlani.Text;
            int index = ornMetin.LastIndexOf('a');
            MessageBox.Show(index > -1 ? "Aradığınız karakterin metin içerisindeki index değeri: " + index : "Metin içerisinde aradığınız parametre yer almamaktadır.");
        }
        #endregion

        #region Örnek 7
        private void BtnREMOVE_Click(object sender, EventArgs e)
        {
            ornMetin = txtGirisAlani.Text;
            //ornMetin = ornMetin.Remove(5); -- bu kullanımda 5. index numaralı karakterden sonrasını siler
            ornMetin = ornMetin.Remove(3, 2); // bu kullanımda ise index nosu 3 olandan başlayarak 2 karakter siler ve kaldığı yerden metni devam ettirir. 3 = index no, 2 = silinecek eleman sayısı.
            MessageBox.Show(ornMetin);
        }
        #endregion

        #region Örnek 8
        private void BtnREPLACE_Click(object sender, EventArgs e)
        {
            ornMetin = txtGirisAlani.Text;

            //ornMetin = ornMetin.Replace("adam", "hatun");

            ornMetin = ornMetin.Replace("ı", "i").Replace("ç", "c").Replace("ü", "u").Replace("ğ", "g").Replace("ö", "o").Replace("ş", "s");       
            
            MessageBox.Show(ornMetin);
        }
        #endregion

        #region Örnek 9
        private void BtnSPLIT_Click(object sender, EventArgs e)
        {
            /*
              
             string[] mailadresleri = txtGirisAlani.Text.Split(';');
             foreach (string mail in mailadresleri)
             {
                 MessageBox.Show(mail);
             }

            */

            //kullanıcının girdiği dataları : ; , + gibi gördüğü yerden ayırıp öb içinde yazdır

            string[] mailadresleri = txtGirisAlani.Text.Split(';', ',', ':', '.', '+');
            foreach (string mail in mailadresleri)
            {
                MessageBox.Show(mail);
            }
        }
        #endregion

        #region Örnek 10
        private void BtnINSERT_Click(object sender, EventArgs e)
        {
            ornMetin = txtGirisAlani.Text;
            ornMetin = ornMetin.Insert(5, "cik");
            MessageBox.Show(ornMetin);
        }
        #endregion

        #region Örnek 11
        private void BtnTOLOWERTOUPPER_Click(object sender, EventArgs e)
        {
            this.Text = txtGirisAlani.Text.ToLower();
            MessageBox.Show(txtGirisAlani.Text.ToUpper());
        }
        #endregion

        #region Örnek 12
        private void BtnSUBSTRING_Click(object sender, EventArgs e)
        {
            ornMetin = txtGirisAlani.Text;
            //ornMetin = ornMetin.Substring(5);
            ornMetin = ornMetin.Substring(3, 2);
            MessageBox.Show(ornMetin);

            //remove komutunun tam tersi çalışıyo. remove da verilen index nodan sonrasını silerken burada öncesini siler
        }
        #endregion

        #region Örnek 13
        private void BtnTOCHARARRAY_Click(object sender, EventArgs e)
        {
            ornMetin = txtGirisAlani.Text;
            char[] karakterler = ornMetin.ToCharArray();

            //dışarıdan girilen metindeki her bir karakterin ASCII değerleri toplamı kaçtır?

            int toplam = 0;
            foreach (char karakter in karakterler)
            {
                toplam += karakter; //her işlemde toplamı karakter kadar artır demek
            }
            MessageBox.Show(toplam.ToString());
        }
        #endregion

        #region Örnek 14
        private void BtnTRIM_Click(object sender, EventArgs e)
        {
            ornMetin = txtGirisAlani.Text;
            int l1 = ornMetin.Length;
            ornMetin = ornMetin.Trim();
            int l2 = ornMetin.Length;

            MessageBox.Show($"Metin boşluklar dahil toplamda {l1} karakterden;\nboşluklar silinerek toplam {l2} karakterden oluşmaktadır");

            //bu komut yalnızca baştaki ve sondaki boşlukları siler. aradakilere ellemez.
            //"".TrimEnd() -- yalnızca metnin sonundaki boşlukları siler
            //"".TrimStart() -- yalnızca metnin başındaki boşlukları siler
        }
        #endregion
    }
}
