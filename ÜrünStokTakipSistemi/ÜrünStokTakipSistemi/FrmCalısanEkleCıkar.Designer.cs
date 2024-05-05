
namespace ÜrünStokTakipSistemi
{
    partial class FrmCalısanEkleCıkar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalısanEkleCıkar));
            this.btn_Calısanekle = new System.Windows.Forms.Button();
            this.btn_Calısancıkar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Calısanekle
            // 
            this.btn_Calısanekle.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Calısanekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Calısanekle.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Calısanekle.Location = new System.Drawing.Point(1, 273);
            this.btn_Calısanekle.Name = "btn_Calısanekle";
            this.btn_Calısanekle.Size = new System.Drawing.Size(178, 148);
            this.btn_Calısanekle.TabIndex = 0;
            this.btn_Calısanekle.Text = "Çalışan ekle";
            this.btn_Calısanekle.UseVisualStyleBackColor = false;
            this.btn_Calısanekle.Click += new System.EventHandler(this.btn_Calısanekle_Click);
            // 
            // btn_Calısancıkar
            // 
            this.btn_Calısancıkar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Calısancıkar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Calısancıkar.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Calısancıkar.Location = new System.Drawing.Point(604, 275);
            this.btn_Calısancıkar.Name = "btn_Calısancıkar";
            this.btn_Calısancıkar.Size = new System.Drawing.Size(178, 146);
            this.btn_Calısancıkar.TabIndex = 1;
            this.btn_Calısancıkar.Text = "Çalışan Çıkar";
            this.btn_Calısancıkar.UseVisualStyleBackColor = false;
            this.btn_Calısancıkar.Click += new System.EventHandler(this.btn_Calısancıkar_Click);
            // 
            // FrmCalısanEkleCıkar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 418);
            this.Controls.Add(this.btn_Calısancıkar);
            this.Controls.Add(this.btn_Calısanekle);
            this.Name = "FrmCalısanEkleCıkar";
            this.Text = "FrmCalısanEkleCıkar";
            this.Load += new System.EventHandler(this.FrmCalısanEkleCıkar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Calısanekle;
        private System.Windows.Forms.Button btn_Calısancıkar;
    }
}