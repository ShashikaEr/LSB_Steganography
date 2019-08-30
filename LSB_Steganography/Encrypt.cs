using System;
using System.Windows.Forms;

namespace LSB_Steganography
{
    public partial class Encrypt : Form
    {
        public Encrypt()
        {
            InitializeComponent();
        }

        
        private void sltImgbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files(*.png) | *.png;";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string loc = openDialog.FileName.ToString();
                label2.Text = loc;
                picBox1.ImageLocation = loc;
                
            }
        }
    }
}
