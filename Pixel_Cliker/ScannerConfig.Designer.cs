namespace Pixel_Cliker
{
    partial class ScannerConfig
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbScreen = new System.Windows.Forms.RadioButton();
            this.rdbAreaScan = new System.Windows.Forms.RadioButton();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbRightClick = new System.Windows.Forms.RadioButton();
            this.rdbLeftClick = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(35, 19);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 3;
            this.txtX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtX_KeyDown);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(173, 19);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 7;
            this.txtY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtY_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Y";
            // 
            // rdbScreen
            // 
            this.rdbScreen.AutoSize = true;
            this.rdbScreen.Location = new System.Drawing.Point(321, 48);
            this.rdbScreen.Name = "rdbScreen";
            this.rdbScreen.Size = new System.Drawing.Size(59, 17);
            this.rdbScreen.TabIndex = 9;
            this.rdbScreen.TabStop = true;
            this.rdbScreen.Text = "Screen";
            this.rdbScreen.UseVisualStyleBackColor = true;
            // 
            // rdbAreaScan
            // 
            this.rdbAreaScan.AutoSize = true;
            this.rdbAreaScan.Location = new System.Drawing.Point(321, 18);
            this.rdbAreaScan.Name = "rdbAreaScan";
            this.rdbAreaScan.Size = new System.Drawing.Size(75, 17);
            this.rdbAreaScan.TabIndex = 10;
            this.rdbAreaScan.TabStop = true;
            this.rdbAreaScan.Text = "Area Scan";
            this.rdbAreaScan.UseVisualStyleBackColor = true;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveConfig.Location = new System.Drawing.Point(416, 12);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(54, 23);
            this.btnSaveConfig.TabIndex = 11;
            this.btnSaveConfig.Text = "Save";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 53);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area Scan";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnPickColor);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 118);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Define Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Press F2 to define";
            // 
            // btnPickColor
            // 
            this.btnPickColor.Location = new System.Drawing.Point(147, 41);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(75, 23);
            this.btnPickColor.TabIndex = 15;
            this.btnPickColor.Text = "Pick Color";
            this.btnPickColor.UseVisualStyleBackColor = true;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            this.btnPickColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPickColor_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picColor);
            this.groupBox3.Location = new System.Drawing.Point(25, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(87, 78);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color";
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.Color.Green;
            this.picColor.Location = new System.Drawing.Point(9, 19);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(69, 50);
            this.picColor.TabIndex = 0;
            this.picColor.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtInterval);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.rdbRightClick);
            this.groupBox4.Controls.Add(this.rdbLeftClick);
            this.groupBox4.Location = new System.Drawing.Point(268, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 118);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Click";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "m/s";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(102, 68);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(100, 20);
            this.txtInterval.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Interval";
            // 
            // rdbRightClick
            // 
            this.rdbRightClick.AutoSize = true;
            this.rdbRightClick.Location = new System.Drawing.Point(111, 37);
            this.rdbRightClick.Name = "rdbRightClick";
            this.rdbRightClick.Size = new System.Drawing.Size(50, 17);
            this.rdbRightClick.TabIndex = 1;
            this.rdbRightClick.TabStop = true;
            this.rdbRightClick.Text = "Right";
            this.rdbRightClick.UseVisualStyleBackColor = true;
            // 
            // rdbLeftClick
            // 
            this.rdbLeftClick.AutoSize = true;
            this.rdbLeftClick.Location = new System.Drawing.Point(53, 37);
            this.rdbLeftClick.Name = "rdbLeftClick";
            this.rdbLeftClick.Size = new System.Drawing.Size(43, 17);
            this.rdbLeftClick.TabIndex = 0;
            this.rdbLeftClick.TabStop = true;
            this.rdbLeftClick.Text = "Left";
            this.rdbLeftClick.UseVisualStyleBackColor = true;
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadConfig.Location = new System.Drawing.Point(481, 12);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(54, 23);
            this.btnLoadConfig.TabIndex = 15;
            this.btnLoadConfig.Text = "Load ";
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(416, 42);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PixelScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 195);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLoadConfig);
            this.Controls.Add(this.rdbAreaScan);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.rdbScreen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveConfig);
            this.Name = "PixelScanner";
            this.Text = "PixelScanner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PixelScanner_FormClosed);
            this.Load += new System.EventHandler(this.PixelScanner_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbScreen;
        private System.Windows.Forms.RadioButton rdbAreaScan;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPickColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbRightClick;
        private System.Windows.Forms.RadioButton rdbLeftClick;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnLoadConfig;
        private System.Windows.Forms.Button btnBack;
    }
}