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
            this.Hide();
            f1.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Decrypt f2 = new Decrypt();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }
    }
}
