using System;
using System.Drawing;
using System.Windows.Forms;

namespace LSB_Steganography
{
    public partial class Decrypt : Form
    {
        private Bitmap DecryptedBitmap;
        private Image DecryptedImage;

        public Decrypt()
        {
            InitializeComponent();
        }

        private void sEnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.Filter = "Image Files(*.png) | *.png;";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                label2.Text = openDialog.FileName.ToString();
                picBox2.ImageLocation = label2.Text;
                picBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                DecryptedImage = Image.FromFile(label2.Text);
                DecryptedBitmap = new Bitmap(DecryptedImage);
            }


            
        }

        private void decryptbtn_Click(object sender, EventArgs e)
        {

            if (label2.Text == "Select an Image")
            {
                MessageBox.Show("Select the Image to Decrypt");
            }
            else
            {
                Bitmap img = new Bitmap(label2.Text);
                String msg = "";
                Color lastpixel = img.GetPixel(img.Width - 1, img.Height - 1);
                int msgLength = lastpixel.B;
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color pixel = img.GetPixel(i, j);

                        if (i < 1 && j < msgLength)
                        {
                            int value = pixel.B;
                            char c = Convert.ToChar(value);
                            String letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });
                            Console.WriteLine("letter : " + letter + " value : " + value);
                            msg = msg + letter;

                         }
                    }
                }

            shMessage.Text = msg;
            if (shMessage.Text == "")
            {
                MessageBox.Show("No hidden message");
            }
            else
            {
                
                MessageBox.Show("Decryption Successfull");
            }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f3 = new Form1();
            this.Hide();
            f3.ShowDialog();
            this.Close();

        }
    }
}
