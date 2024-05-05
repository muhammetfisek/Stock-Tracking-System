
namespace ÜrünStokTakipSistemi
{
    partial class FrmYöneticiGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYöneticiGiris));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.msk_YoneticiTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txt_Sifre);
            this.groupBox1.Controls.Add(this.msk_YoneticiTc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(236, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici Bilgileri";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(213, 152);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(140, 36);
            this.txt_Sifre.TabIndex = 3;
            this.txt_Sifre.UseSystemPasswordChar = true;
            // 
            // msk_YoneticiTc
            // 
            this.msk_YoneticiTc.Location = new System.Drawing.Point(213, 86);
            this.msk_YoneticiTc.Mask = "00000000000";
            this.msk_YoneticiTc.Name = "msk_YoneticiTc";
            this.msk_YoneticiTc.Size = new System.Drawing.Size(140, 36);
            this.msk_YoneticiTc.TabIndex = 2;
            this.msk_YoneticiTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici TC_no:";
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Giris.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.Location = new System.Drawing.Point(363, 277);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(199, 80);
            this.btn_Giris.TabIndex = 1;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // FrmYöneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmYöneticiGiris";
            this.Text = "FrmYöneticiGiris";
            this.Load += new System.EventHandler(this.FrmYöneticiGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.MaskedTextBox msk_YoneticiTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Giris;
    }
}