using System;
using System.Drawing;
using System.Windows.Forms;

namespace LSB_Steganography
{
    public partial class Encrypt : Form
    {
        private Image sTrueImage;
        private Image sImage;
        private Bitmap STrueBitmap;
     

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
                picBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                sImage = Image.FromFile(label2.Text);
                sTrueImage = Image.FromFile(label2.Text);
                STrueBitmap = new Bitmap(sTrueImage);

            }
        }

        private void Encryptbtn_Click(object sender, EventArgs e)
        {
            int msgSize = msgBox.Text.Length;
            double msglength = System.Text.ASCIIEncoding.ASCII.GetByteCount(msgBox.Text);
            double msgsize = msglength / 1024;




            if (msgBox.Text == "")
            {
                MessageBox.Show("Message Box is Empty");

            }
            else if (label2.Text == "Select an Image")
            {
                MessageBox.Show("Select an Image");

            }
            else if (msgSize > 255)
            {

                MessageBox.Show("Maximum number of characters is 255");
            }
            else
            {
                //
                Bitmap img = new Bitmap(label2.Text);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color pixel = img.GetPixel(i, j);
                        if (i < 1 && j < msgBox.TextLength)
                        {
                            Console.WriteLine("R= [" + i + "][" + j + "]=" + pixel.R);
                            Console.WriteLine("G= [" + i + "][" + j + "]=" + pixel.G);
                            Console.WriteLine("B= [" + i + "][" + j + "]=" + pixel.B);
                            char letter = Convert.ToChar(msgBox.Text.Substring(j, 1));
                            int value = Convert.ToInt32(letter);
                            Console.WriteLine("letter :" + letter + " value :" + value);
                            img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));

                        }
                        if (i == img.Width - 1 && j == img.Height - 1)
                        {
                            img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, msgBox.TextLength));
                        }

                    }

                }
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Image Files (*.png) | *.png";
             
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    label2.Text = saveFile.FileName.ToString();
                    picBox1.ImageLocation = label2.Text;
                    img.Save(label2.Text);
                }
                MessageBox.Show("Image Saved Successfully");
            }



            //
        }

        private void Encrypt_Load(object sender, EventArgs e)
        {

        }
    }
}
