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
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shMessage = new System.Windows.Forms.TextBox();
            this.sEnImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.decryptbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(12, 12);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(213, 241);
            this.picBox2.TabIndex = 0;
            this.picBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Decrypted Message";
            // 
            // shMessage
            // 
            this.shMessage.Location = new System.Drawing.Point(143, 302);
            this.shMessage.Multiline = true;
            this.shMessage.Name = "shMessage";
            this.shMessage.ReadOnly = true;
            this.shMessage.Size = new System.Drawing.Size(378, 20);
            this.shMessage.TabIndex = 2;
            // 
            // sEnImage
            // 
            this.sEnImage.Location = new System.Drawing.Point(231, 44);
            this.sEnImage.Name = "sEnImage";
            this.sEnImage.Size = new System.Drawing.Size(112, 23);
            this.sEnImage.TabIndex = 3;
            this.sEnImage.Text = "Select image";
            this.sEnImage.UseVisualStyleBackColor = true;
            this.sEnImage.Click += new System.EventHandler(this.sEnImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(369, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select an Image To Decrypt";
            // 
            // decryptbtn
            // 
            this.decryptbtn.Location = new System.Drawing.Point(331, 149);
            this.decryptbtn.Name = "decryptbtn";
            this.decryptbtn.Size = new System.Drawing.Size(75, 23);
            this.decryptbtn.TabIndex = 5;
            this.decryptbtn.Text = "Decrypt";
            this.decryptbtn.UseVisualStyleBackColor = true;
            this.decryptbtn.Click += new System.EventHandler(this.decryptbtn_Click);
            // 
            // Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 363);
            this.Controls.Add(this.decryptbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sEnImage);
            this.Controls.Add(this.shMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox2);
            this.Name = "Decrypt";
            this.Text = "Decrypt";
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
    }
}