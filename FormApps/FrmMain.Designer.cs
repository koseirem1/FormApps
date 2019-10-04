namespace FormApps
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlevselliklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstFunctionality = new System.Windows.Forms.ToolStripMenuItem();
            this.secondFunctionality = new System.Windows.Forms.ToolStripMenuItem();
            this.thirdFunctionality = new System.Windows.Forms.ToolStripMenuItem();
            this.fourthFunctionality = new System.Windows.Forms.ToolStripMenuItem();
            this.fifthFunctionality = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlevselliklerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlevselliklerToolStripMenuItem
            // 
            this.işlevselliklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstFunctionality,
            this.secondFunctionality,
            this.thirdFunctionality,
            this.fourthFunctionality,
            this.fifthFunctionality});
            this.işlevselliklerToolStripMenuItem.Name = "işlevselliklerToolStripMenuItem";
            this.işlevselliklerToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.işlevselliklerToolStripMenuItem.Text = "İşlevsellikler";
            // 
            // firstFunctionality
            // 
            this.firstFunctionality.Name = "firstFunctionality";
            this.firstFunctionality.Size = new System.Drawing.Size(180, 22);
            this.firstFunctionality.Text = "Birinci İşlevsellik";
            this.firstFunctionality.Click += new System.EventHandler(this.FirstFunctionality_Click);
            // 
            // secondFunctionality
            // 
            this.secondFunctionality.Name = "secondFunctionality";
            this.secondFunctionality.Size = new System.Drawing.Size(180, 22);
            this.secondFunctionality.Text = "İkinci İşlevsellik";
            this.secondFunctionality.Click += new System.EventHandler(this.SecondFunctionality_Click);
            // 
            // thirdFunctionality
            // 
            this.thirdFunctionality.Name = "thirdFunctionality";
            this.thirdFunctionality.Size = new System.Drawing.Size(180, 22);
            this.thirdFunctionality.Text = "Üçüncü İşlevsellik";
            this.thirdFunctionality.Click += new System.EventHandler(this.ThirdFunctionality_Click);
            // 
            // fourthFunctionality
            // 
            this.fourthFunctionality.Name = "fourthFunctionality";
            this.fourthFunctionality.Size = new System.Drawing.Size(180, 22);
            this.fourthFunctionality.Text = "Dördüncü İşlevsellik";
            this.fourthFunctionality.Click += new System.EventHandler(this.FourthFunctionality_Click);
            // 
            // fifthFunctionality
            // 
            this.fifthFunctionality.Name = "fifthFunctionality";
            this.fifthFunctionality.Size = new System.Drawing.Size(180, 22);
            this.fifthFunctionality.Text = "Beşinci İşlevsellik";
            this.fifthFunctionality.Click += new System.EventHandler(this.FifthFunctionality_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 310);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "İşlevsellikler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlevselliklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstFunctionality;
        private System.Windows.Forms.ToolStripMenuItem secondFunctionality;
        private System.Windows.Forms.ToolStripMenuItem thirdFunctionality;
        private System.Windows.Forms.ToolStripMenuItem fourthFunctionality;
        private System.Windows.Forms.ToolStripMenuItem fifthFunctionality;
    }
}

