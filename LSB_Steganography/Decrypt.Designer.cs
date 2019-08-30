namespace LSB_Steganography
{
    partial class Decrypt
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
            this.label1 = new System.Windows.Forms.Label();
            this.shMessage = new System.Windows.Forms.TextBox();
            this.sEnImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.decryptbtn = new System.Windows.Forms.Button();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.label1.Location = new System.Drawing.Point(9, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Decrypted Message";
            // 
            // shMessage
            // 
            this.shMessage.Location = new System.Drawing.Point(143, 302);
            this.shMessage.Multiline = true;
            this.shMessage.Name = "shMessage";
            this.shMessage.ReadOnly = true;
            this.shMessage.Size = new System.Drawing.Size(407, 20);
            this.shMessage.TabIndex = 2;
            // 
            // sEnImage
            // 
            this.sEnImage.BackColor = System.Drawing.SystemColors.Control;
            this.sEnImage.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.sEnImage.Location = new System.Drawing.Point(263, 120);
            this.sEnImage.Name = "sEnImage";
            this.sEnImage.Size = new System.Drawing.Size(95, 40);
            this.sEnImage.TabIndex = 3;
            this.sEnImage.Text = "Select image";
            this.sEnImage.UseVisualStyleBackColor = false;
            this.sEnImage.Click += new System.EventHandler(this.sEnImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(363, 49);
            this.label2.MaximumSize = new System.Drawing.Size(300, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select an Image";
            // 
            // decryptbtn
            // 
            this.decryptbtn.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.decryptbtn.Location = new System.Drawing.Point(423, 110);
            this.decryptbtn.Name = "decryptbtn";
            this.decryptbtn.Size = new System.Drawing.Size(98, 60);
            this.decryptbtn.TabIndex = 5;
            this.decryptbtn.Text = "Decrypt";
            this.decryptbtn.UseVisualStyleBackColor = true;
            this.decryptbtn.Click += new System.EventHandler(this.decryptbtn_Click);
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(12, 12);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(226, 269);
            this.picBox2.TabIndex = 0;
            this.picBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.button1.Location = new System.Drawing.Point(488, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Beige;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(244, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selected Image";
            // 
            // Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LSB_Steganography.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(592, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.decryptbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sEnImage);
            this.Controls.Add(this.shMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox2);
            this.Name = "Decrypt";
            this.Text = "Decrypt from Image";
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shMessage;
        private System.Windows.Forms.Button sEnImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decryptbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}