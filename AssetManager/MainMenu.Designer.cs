namespace AssetManager
{
    partial class MainMenu
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
            this.BtnAssetTool = new MetroFramework.Controls.MetroButton();
            this.BtnCopyTools = new MetroFramework.Controls.MetroButton();
            this.Combox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnAssetTool
            // 
            this.BtnAssetTool.Location = new System.Drawing.Point(92, 127);
            this.BtnAssetTool.Name = "BtnAssetTool";
            this.BtnAssetTool.Size = new System.Drawing.Size(163, 57);
            this.BtnAssetTool.TabIndex = 0;
            this.BtnAssetTool.Text = "Asset Tools";
            this.BtnAssetTool.UseSelectable = true;
            this.BtnAssetTool.Click += new System.EventHandler(this.BtnAssetTool_Click);
            // 
            // BtnCopyTools
            // 
            this.BtnCopyTools.Location = new System.Drawing.Point(92, 213);
            this.BtnCopyTools.Name = "BtnCopyTools";
            this.BtnCopyTools.Size = new System.Drawing.Size(163, 57);
            this.BtnCopyTools.TabIndex = 1;
            this.BtnCopyTools.Text = "Copy Tools";
            this.BtnCopyTools.UseSelectable = true;
            this.BtnCopyTools.Click += new System.EventHandler(this.BtnCopyTools_Click);
            // 
            // Combox1
            // 
            this.Combox1.FormattingEnabled = true;
            this.Combox1.Items.AddRange(new object[] {
            "Android",
            "IOS"});
            this.Combox1.Location = new System.Drawing.Point(115, 80);
            this.Combox1.Name = "Combox1";
            this.Combox1.Size = new System.Drawing.Size(121, 21);
            this.Combox1.TabIndex = 2;
            this.Combox1.SelectedIndexChanged += new System.EventHandler(this.Combox1_SelectedIndexChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 293);
            this.Controls.Add(this.Combox1);
            this.Controls.Add(this.BtnCopyTools);
            this.Controls.Add(this.BtnAssetTool);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnAssetTool;
        private MetroFramework.Controls.MetroButton BtnCopyTools;
        private System.Windows.Forms.ComboBox Combox1;
    }
}