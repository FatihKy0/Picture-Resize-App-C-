using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resimboyutlandırıcı
{
    class fatihhdonustur:Donustur,Iboyuts
   {
        public fatihhdonustur() { MessageBox.Show(DateTime.Now.ToLongDateString()); }
        ~fatihhdonustur() { MessageBox.Show(" By\n --------- \n"+DateTime.Now.ToLongTimeString()); }
        Image img;string yol;
        string[] uzantilar = { ".PNG", ".JPEG", ".JPG", ".EMF", ".TIFF", ".BMP", ".ico", ".WMF"};
        public string bosalt;
        public string Bosalt {
            get { return bosalt; }
            set { bosalt="";}
        }

        public virtual void uzantıfrm(ComboBox comboBox)
       {
           for (int i = 0; i < uzantilar.Length; i++)
               comboBox.Items.Add(uzantilar[i]);
       }
        public Image resimac() {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "uzantı | *.png;*.jpg;*.jpeg;*.emf*.tiff;*.bmp;*.ico;*.wmf;*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                yol = ofd.FileName;
                img = Image.FromFile(ofd.FileName);
            }
            return img;
        }
       
        
        public void yenidenboy(int w, int h , Object sender) 
        
        {
            try
            {
                img = yenboy(img, w, h);
                ((Button)sender).Enabled = false;
                MessageBox.Show("Yeniden Boyutlandı");
            }
            catch (Exception)
            {

            }
        }
        public Image yenboy(Image image) {
            Bitmap bmp = new Bitmap(800, 600);
            Graphics grafik = Graphics.FromImage(bmp);
            grafik.DrawImage(image, 0, 0, 800, 600);
            grafik.Dispose();

            return bmp;
            
        }
        public  Image yenboy(Image image, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics grafik = Graphics.FromImage(bmp);
            grafik.DrawImage(image, 0, 0, w, h);
            grafik.Dispose();

            return bmp;
        }
        public override string gozat(string txtkayy)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                txtkayy = fbd.SelectedPath.ToString();
            return txtkayy;
        }
        public override string kaydet(string txtyndd, ComboBox comboBox, string txtkayy, Object sender)
        {
            if (txtyndd == "")
            {
                return txtyndd = "Fatih";
            }
            try
            {
                img.Save(txtkayy + "\\" + txtyndd + uzantilar[comboBox.SelectedIndex]);
                ((Button)sender).Enabled = false;
                MessageBox.Show("Fotoğraf Kaydedildi");
            }
            catch (Exception)
            {

            }
            return txtyndd;

        }
    }
}
