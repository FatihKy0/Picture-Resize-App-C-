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
    public partial class Form1 : Form
    {
        fatihhdonustur fdn =new fatihhdonustur();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            fdn.uzantıfrm(comboBox);
        }
        public void button1_Click(object sender, EventArgs e)
        {
            
           pictureBox1.Image= fdn.resimac();
            
        }
        
        string txtkayy;
        public void button2_Click(object sender, EventArgs e)
        {

            txtkayy=txtkay.Text;
            txtkay.Text=fdn.gozat(txtkayy);
               
        }
            int txtww, txthh;
        public void button3_Click(object sender, EventArgs e)
        {
            try
            {
                txtww = Convert.ToInt32(txtw.Text);
                txthh = Convert.ToInt32(txth.Text);
                fdn.yenidenboy(txtww, txthh, sender);
            }
            catch (Exception)
            {

                MessageBox.Show("Yükseklik ve Genişlik giriniz.");
            }
          
           
        }


        string txtyndd;
        public void button4_Click(object sender, EventArgs e)
        {
            txtyndd = txtynd.Text;
            txtkayy = txtkay.Text;
            txtynd.Text=fdn.kaydet(txtyndd,comboBox,txtkayy,sender);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtw_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtkay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtw_TextChanged(object sender, EventArgs e)
        {
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txth.Text = fdn.bosalt;
            txtw.Text=fdn.bosalt;
            txtkay.Text = fdn.bosalt;
        }
        
    }
}
