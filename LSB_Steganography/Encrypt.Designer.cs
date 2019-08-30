namespace LSB_Steganography
{
    partial class Encrypt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msgBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sltImgbtn = new System.Windows.Forms.Button();
            this.Encryptbtn = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(459, 109);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(249, 20);
            this.msgBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the message";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(459, 42);
            this.label2.MaximumSize = new System.Drawing.Size(300, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select an Image";
            // 
            // sltImgbtn
            // 
            this.sltImgbtn.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.sltImgbtn.Location = new System.Drawing.Point(376, 145);
            this.sltImgbtn.Name = "sltImgbtn";
            this.sltImgbtn.Size = new System.Drawing.Size(131, 54);
            this.sltImgbtn.TabIndex = 6;
            this.sltImgbtn.Text = "Select an image";
            this.sltImgbtn.UseVisualStyleBackColor = true;
            this.sltImgbtn.Click += new System.EventHandler(this.sltImgbtn_Click);
            // 
            // Encryptbtn
            // 
            this.Encryptbtn.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.Encryptbtn.Location = new System.Drawing.Point(562, 143);
            this.Encryptbtn.Name = "Encryptbtn";
            this.Encryptbtn.Size = new System.Drawing.Size(104, 56);
            this.Encryptbtn.TabIndex = 7;
            this.Encryptbtn.Text = "Encrypt";
            this.Encryptbtn.UseVisualStyleBackColor = true;
            this.Encryptbtn.Click += new System.EventHandler(this.Encryptbtn_Click);
            // 
            // picBox1
            // 
            this.picBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox1.Location = new System.Drawing.Point(12, 12);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(291, 325);
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LawnGreen;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.label3.Location = new System.Drawing.Point(321, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Image Selected";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.button1.Location = new System.Drawing.Point(628, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::LSB_Steganography.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(732, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Encryptbtn);
            this.Controls.Add(this.sltImgbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.picBox1);
            this.Name = "Encrypt";
            this.Text = "Encrypt in a Image";
            this.Load += new System.EventHandler(this.Encrypt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sltImgbtn;
        private System.Windows.Forms.Button Encryptbtn;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}