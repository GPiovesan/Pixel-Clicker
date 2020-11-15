namespace Pixel_Cliker
{
    partial class MainMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImageScan = new System.Windows.Forms.Button();
            this.btnPixelScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImageScan
            // 
            this.btnImageScan.Location = new System.Drawing.Point(71, 103);
            this.btnImageScan.Name = "btnImageScan";
            this.btnImageScan.Size = new System.Drawing.Size(75, 23);
            this.btnImageScan.TabIndex = 0;
            this.btnImageScan.Text = "Image Scan";
            this.btnImageScan.UseVisualStyleBackColor = true;
            this.btnImageScan.Click += new System.EventHandler(this.btnImageScan_Click);
            // 
            // btnPixelScan
            // 
            this.btnPixelScan.Location = new System.Drawing.Point(71, 161);
            this.btnPixelScan.Name = "btnPixelScan";
            this.btnPixelScan.Size = new System.Drawing.Size(75, 23);
            this.btnPixelScan.TabIndex = 1;
            this.btnPixelScan.Text = "Pixel Scan";
            this.btnPixelScan.UseVisualStyleBackColor = true;
            this.btnPixelScan.Click += new System.EventHandler(this.btnPixelScan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPixelScan);
            this.Controls.Add(this.btnImageScan);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImageScan;
        private System.Windows.Forms.Button btnPixelScan;
        private System.Windows.Forms.Label label1;
    }
}

