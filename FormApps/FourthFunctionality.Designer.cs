namespace FormApps
{
    partial class FourthFunctionality
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
            this.btnSort = new System.Windows.Forms.Button();
            this.listFile = new System.Windows.Forms.ListView();
            this.lblFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(178, 177);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(118, 23);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sıralama Yap";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // listFile
            // 
            this.listFile.HideSelection = false;
            this.listFile.Location = new System.Drawing.Point(165, 35);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(200, 103);
            this.listFile.TabIndex = 2;
            this.listFile.UseCompatibleStateImageBehavior = false;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(178, 13);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(35, 13);
            this.lblFile.TabIndex = 3;
            this.lblFile.Text = "label1";
            // 
            // FourthFunctionality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 248);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.btnSort);
            this.Name = "FourthFunctionality";
            this.Text = "Dördüncü İşlevsellik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListView listFile;
        private System.Windows.Forms.Label lblFile;
    }
}