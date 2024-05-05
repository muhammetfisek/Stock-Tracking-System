
namespace ÜrünStokTakipSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Yönetici = new System.Windows.Forms.Button();
            this.btn_Calısan__212701069 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Yönetici
            // 
            this.btn_Yönetici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Yönetici.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yönetici.Location = new System.Drawing.Point(-7, -1);
            this.btn_Yönetici.Name = "btn_Yönetici";
            this.btn_Yönetici.Size = new System.Drawing.Size(921, 76);
            this.btn_Yönetici.TabIndex = 0;
            this.btn_Yönetici.Text = "Yönetici";
            this.btn_Yönetici.UseVisualStyleBackColor = false;
            this.btn_Yönetici.Click += new System.EventHandler(this.btn_Yönetici_Click);
            // 
            // btn_Calısan__212701069
            // 
            this.btn_Calısan__212701069.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Calısan__212701069.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Calısan__212701069.Location = new System.Drawing.Point(-7, 343);
            this.btn_Calısan__212701069.Name = "btn_Calısan__212701069";
            this.btn_Calısan__212701069.Size = new System.Drawing.Size(921, 82);
            this.btn_Calısan__212701069.TabIndex = 1;
            this.btn_Calısan__212701069.Text = "Çalışan";
            this.btn_Calısan__212701069.UseVisualStyleBackColor = false;
            this.btn_Calısan__212701069.Click += new System.EventHandler(this.btn_Calısan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 421);
            this.Controls.Add(this.btn_Calısan__212701069);
            this.Controls.Add(this.btn_Yönetici);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Giriş";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Yönetici;
        private System.Windows.Forms.Button btn_Calısan__212701069;
    }
}

