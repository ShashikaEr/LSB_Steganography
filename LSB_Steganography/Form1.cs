using System;
using System.Windows.Forms;

namespace LSB_Steganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encrypt f1 = new Encrypt();   
            f1.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Decrypt f2 = new Decrypt();
            f2.ShowDialog();
        }
    }
}
