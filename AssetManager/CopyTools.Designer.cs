namespace AssetManager
{
    partial class CopyTools
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
            this.CopyTest = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // CopyTest
            // 
            this.CopyTest.Location = new System.Drawing.Point(113, 87);
            this.CopyTest.Name = "CopyTest";
            this.CopyTest.Size = new System.Drawing.Size(123, 49);
            this.CopyTest.TabIndex = 0;
            this.CopyTest.Text = "Copy";
            this.CopyTest.UseSelectable = true;
            this.CopyTest.Click += new System.EventHandler(this.CopyTest_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            this.openFileDialog1.Filter = "files|*.json";
            // 
            // CopyTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 393);
            this.Controls.Add(this.CopyTest);
            this.Name = "CopyTools";
            this.Text = "CopyTools";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton CopyTest;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}