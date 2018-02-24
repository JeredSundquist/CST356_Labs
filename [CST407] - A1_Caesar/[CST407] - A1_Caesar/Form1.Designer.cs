namespace _CST407____A1_Caesar
{
    partial class CaesarCipher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaesarCipher));
            this.Decrypt_txb = new System.Windows.Forms.TextBox();
            this.plainText_btn = new System.Windows.Forms.Button();
            this.plainText_lbl = new System.Windows.Forms.Label();
            this.cipherText_lbl = new System.Windows.Forms.Label();
            this.cipherText_tbx = new System.Windows.Forms.TextBox();
            this.Decrypt_btn = new System.Windows.Forms.Button();
            this.key_lbl = new System.Windows.Forms.Label();
            this.key_tbx = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Decrypt_txb
            // 
            this.Decrypt_txb.Location = new System.Drawing.Point(9, 75);
            this.Decrypt_txb.Name = "Decrypt_txb";
            this.Decrypt_txb.Size = new System.Drawing.Size(100, 20);
            this.Decrypt_txb.TabIndex = 1;
            this.Decrypt_txb.TextChanged += new System.EventHandler(this.plainText_txb_TextChanged);
            // 
            // plainText_btn
            // 
            this.plainText_btn.Location = new System.Drawing.Point(23, 101);
            this.plainText_btn.Name = "plainText_btn";
            this.plainText_btn.Size = new System.Drawing.Size(75, 23);
            this.plainText_btn.TabIndex = 2;
            this.plainText_btn.Text = "Encrypt";
            this.plainText_btn.UseVisualStyleBackColor = true;
            this.plainText_btn.Click += new System.EventHandler(this.plainText_btn_Click);
            // 
            // plainText_lbl
            // 
            this.plainText_lbl.AutoSize = true;
            this.plainText_lbl.Location = new System.Drawing.Point(31, 59);
            this.plainText_lbl.Name = "plainText_lbl";
            this.plainText_lbl.Size = new System.Drawing.Size(54, 13);
            this.plainText_lbl.TabIndex = 6;
            this.plainText_lbl.Text = "Plain Text";
            // 
            // cipherText_lbl
            // 
            this.cipherText_lbl.AutoSize = true;
            this.cipherText_lbl.Location = new System.Drawing.Point(290, 64);
            this.cipherText_lbl.Name = "cipherText_lbl";
            this.cipherText_lbl.Size = new System.Drawing.Size(61, 13);
            this.cipherText_lbl.TabIndex = 7;
            this.cipherText_lbl.Text = "Cipher Text";
            // 
            // cipherText_tbx
            // 
            this.cipherText_tbx.Location = new System.Drawing.Point(268, 80);
            this.cipherText_tbx.Name = "cipherText_tbx";
            this.cipherText_tbx.Size = new System.Drawing.Size(100, 20);
            this.cipherText_tbx.TabIndex = 3;
            this.cipherText_tbx.TextChanged += new System.EventHandler(this.cipherText_tbx_TextChanged);
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.Location = new System.Drawing.Point(282, 106);
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(75, 23);
            this.Decrypt_btn.TabIndex = 4;
            this.Decrypt_btn.Text = "Decrypt";
            this.Decrypt_btn.UseVisualStyleBackColor = true;
            this.Decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click);
            // 
            // key_lbl
            // 
            this.key_lbl.AutoSize = true;
            this.key_lbl.Location = new System.Drawing.Point(177, 7);
            this.key_lbl.Name = "key_lbl";
            this.key_lbl.Size = new System.Drawing.Size(25, 13);
            this.key_lbl.TabIndex = 5;
            this.key_lbl.Text = "Key";
            // 
            // key_tbx
            // 
            this.key_tbx.Location = new System.Drawing.Point(140, 23);
            this.key_tbx.Name = "key_tbx";
            this.key_tbx.Size = new System.Drawing.Size(100, 20);
            this.key_tbx.TabIndex = 0;
            this.key_tbx.TextChanged += new System.EventHandler(this.key_tbx_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_CST407____A1_Caesar.Properties.Resources.CircleArrow;
            this.pictureBox1.Location = new System.Drawing.Point(140, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CaesarCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_CST407____A1_Caesar.Properties.Resources.BinaryCode;
            this.ClientSize = new System.Drawing.Size(380, 157);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.key_tbx);
            this.Controls.Add(this.key_lbl);
            this.Controls.Add(this.Decrypt_btn);
            this.Controls.Add(this.cipherText_tbx);
            this.Controls.Add(this.cipherText_lbl);
            this.Controls.Add(this.plainText_lbl);
            this.Controls.Add(this.plainText_btn);
            this.Controls.Add(this.Decrypt_txb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaesarCipher";
            this.Text = "Caesar Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Decrypt_txb;
        private System.Windows.Forms.Button plainText_btn;
        private System.Windows.Forms.Label plainText_lbl;
        private System.Windows.Forms.Label cipherText_lbl;
        private System.Windows.Forms.TextBox cipherText_tbx;
        private System.Windows.Forms.Button Decrypt_btn;
        private System.Windows.Forms.Label key_lbl;
        private System.Windows.Forms.TextBox key_tbx;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

