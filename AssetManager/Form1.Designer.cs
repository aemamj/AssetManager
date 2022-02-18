namespace AssetManager
{
    partial class AssetEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetEditor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnMinesUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnPlusUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtBoxPath = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnLoad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ChBoxLoad = new Bunifu.Framework.UI.BunifuCheckbox();
            this.LbCheckLoadPachOrFile = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LbUpdateFile = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChkUpdate = new Bunifu.Framework.UI.BunifuCheckbox();
            this.BtnUpAllVersion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnDownAllVersion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChkCopyUpdate = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChkSaveBase = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChkSaveAs = new Bunifu.Framework.UI.BunifuCheckbox();
            this.BtnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(819, 463);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // BtnSave
            // 
            this.BtnSave.Active = false;
            this.BtnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSave.BorderRadius = 0;
            this.BtnSave.ButtonText = "Save";
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSave.Iconimage")));
            this.BtnSave.Iconimage_right = null;
            this.BtnSave.Iconimage_right_Selected = null;
            this.BtnSave.Iconimage_Selected = null;
            this.BtnSave.IconMarginLeft = 0;
            this.BtnSave.IconMarginRight = 0;
            this.BtnSave.IconRightVisible = true;
            this.BtnSave.IconRightZoom = 0D;
            this.BtnSave.IconVisible = true;
            this.BtnSave.IconZoom = 90D;
            this.BtnSave.IsTab = false;
            this.BtnSave.Location = new System.Drawing.Point(731, 556);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSave.selected = false;
            this.BtnSave.Size = new System.Drawing.Size(111, 48);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Textcolor = System.Drawing.Color.White;
            this.BtnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Search
            // 
            this.Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Search.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search.HintForeColor = System.Drawing.Color.Empty;
            this.Search.HintText = "";
            this.Search.isPassword = false;
            this.Search.LineFocusedColor = System.Drawing.Color.Blue;
            this.Search.LineIdleColor = System.Drawing.Color.Gray;
            this.Search.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Search.LineThickness = 3;
            this.Search.Location = new System.Drawing.Point(23, 533);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.MaxLength = 32767;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(379, 33);
            this.Search.TabIndex = 3;
            this.Search.Text = "Serach Asset";
            this.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Search.OnValueChanged += new System.EventHandler(this.Search_OnValueChanged);
            // 
            // BtnMinesUpdate
            // 
            this.BtnMinesUpdate.Active = false;
            this.BtnMinesUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnMinesUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnMinesUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMinesUpdate.BorderRadius = 0;
            this.BtnMinesUpdate.ButtonText = "-";
            this.BtnMinesUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinesUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.BtnMinesUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnMinesUpdate.Iconimage = null;
            this.BtnMinesUpdate.Iconimage_right = null;
            this.BtnMinesUpdate.Iconimage_right_Selected = null;
            this.BtnMinesUpdate.Iconimage_Selected = null;
            this.BtnMinesUpdate.IconMarginLeft = 0;
            this.BtnMinesUpdate.IconMarginRight = 0;
            this.BtnMinesUpdate.IconRightVisible = true;
            this.BtnMinesUpdate.IconRightZoom = 0D;
            this.BtnMinesUpdate.IconVisible = true;
            this.BtnMinesUpdate.IconZoom = 90D;
            this.BtnMinesUpdate.IsTab = false;
            this.BtnMinesUpdate.Location = new System.Drawing.Point(819, 32);
            this.BtnMinesUpdate.Name = "BtnMinesUpdate";
            this.BtnMinesUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnMinesUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnMinesUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnMinesUpdate.selected = false;
            this.BtnMinesUpdate.Size = new System.Drawing.Size(23, 25);
            this.BtnMinesUpdate.TabIndex = 4;
            this.BtnMinesUpdate.Text = "-";
            this.BtnMinesUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMinesUpdate.Textcolor = System.Drawing.Color.White;
            this.BtnMinesUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinesUpdate.Click += new System.EventHandler(this.BtnMinesUpdate_Click);
            // 
            // BtnPlusUpdate
            // 
            this.BtnPlusUpdate.Active = false;
            this.BtnPlusUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnPlusUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnPlusUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPlusUpdate.BorderRadius = 0;
            this.BtnPlusUpdate.ButtonText = "+";
            this.BtnPlusUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlusUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.BtnPlusUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnPlusUpdate.Iconimage = null;
            this.BtnPlusUpdate.Iconimage_right = null;
            this.BtnPlusUpdate.Iconimage_right_Selected = null;
            this.BtnPlusUpdate.Iconimage_Selected = null;
            this.BtnPlusUpdate.IconMarginLeft = 0;
            this.BtnPlusUpdate.IconMarginRight = 0;
            this.BtnPlusUpdate.IconRightVisible = true;
            this.BtnPlusUpdate.IconRightZoom = 0D;
            this.BtnPlusUpdate.IconVisible = true;
            this.BtnPlusUpdate.IconZoom = 90D;
            this.BtnPlusUpdate.IsTab = false;
            this.BtnPlusUpdate.Location = new System.Drawing.Point(790, 32);
            this.BtnPlusUpdate.Name = "BtnPlusUpdate";
            this.BtnPlusUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnPlusUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnPlusUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnPlusUpdate.selected = false;
            this.BtnPlusUpdate.Size = new System.Drawing.Size(23, 25);
            this.BtnPlusUpdate.TabIndex = 5;
            this.BtnPlusUpdate.Text = "+";
            this.BtnPlusUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPlusUpdate.Textcolor = System.Drawing.Color.White;
            this.BtnPlusUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlusUpdate.Click += new System.EventHandler(this.BtnPlusUpdate_Click);
            // 
            // TxtBoxPath
            // 
            this.TxtBoxPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtBoxPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtBoxPath.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtBoxPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxPath.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtBoxPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxPath.HintForeColor = System.Drawing.Color.Empty;
            this.TxtBoxPath.HintText = "";
            this.TxtBoxPath.isPassword = false;
            this.TxtBoxPath.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtBoxPath.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtBoxPath.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtBoxPath.LineThickness = 3;
            this.TxtBoxPath.Location = new System.Drawing.Point(23, 574);
            this.TxtBoxPath.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxPath.MaxLength = 32767;
            this.TxtBoxPath.Name = "TxtBoxPath";
            this.TxtBoxPath.Size = new System.Drawing.Size(379, 33);
            this.TxtBoxPath.TabIndex = 6;
            this.TxtBoxPath.Text = "Path";
            this.TxtBoxPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Active = false;
            this.BtnLoad.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLoad.BorderRadius = 0;
            this.BtnLoad.ButtonText = "Load";
            this.BtnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLoad.DisabledColor = System.Drawing.Color.Gray;
            this.BtnLoad.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnLoad.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnLoad.Iconimage")));
            this.BtnLoad.Iconimage_right = null;
            this.BtnLoad.Iconimage_right_Selected = null;
            this.BtnLoad.Iconimage_Selected = null;
            this.BtnLoad.IconMarginLeft = 0;
            this.BtnLoad.IconMarginRight = 0;
            this.BtnLoad.IconRightVisible = true;
            this.BtnLoad.IconRightZoom = 0D;
            this.BtnLoad.IconVisible = true;
            this.BtnLoad.IconZoom = 90D;
            this.BtnLoad.IsTab = false;
            this.BtnLoad.Location = new System.Drawing.Point(614, 556);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnLoad.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnLoad.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnLoad.selected = false;
            this.BtnLoad.Size = new System.Drawing.Size(111, 48);
            this.BtnLoad.TabIndex = 7;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLoad.Textcolor = System.Drawing.Color.White;
            this.BtnLoad.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoad.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // ChBoxLoad
            // 
            this.ChBoxLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChBoxLoad.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChBoxLoad.Checked = false;
            this.ChBoxLoad.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChBoxLoad.ForeColor = System.Drawing.Color.White;
            this.ChBoxLoad.Location = new System.Drawing.Point(588, 556);
            this.ChBoxLoad.Name = "ChBoxLoad";
            this.ChBoxLoad.Size = new System.Drawing.Size(20, 20);
            this.ChBoxLoad.TabIndex = 8;
            // 
            // LbCheckLoadPachOrFile
            // 
            this.LbCheckLoadPachOrFile.AutoSize = true;
            this.LbCheckLoadPachOrFile.Location = new System.Drawing.Point(506, 560);
            this.LbCheckLoadPachOrFile.Name = "LbCheckLoadPachOrFile";
            this.LbCheckLoadPachOrFile.Size = new System.Drawing.Size(76, 13);
            this.LbCheckLoadPachOrFile.TabIndex = 9;
            this.LbCheckLoadPachOrFile.Text = "Load From File";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.LocalizedResources;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "files|*.json";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "files|*.json";
            // 
            // LbUpdateFile
            // 
            this.LbUpdateFile.AutoSize = true;
            this.LbUpdateFile.Location = new System.Drawing.Point(506, 586);
            this.LbUpdateFile.Name = "LbUpdateFile";
            this.LbUpdateFile.Size = new System.Drawing.Size(61, 13);
            this.LbUpdateFile.TabIndex = 11;
            this.LbUpdateFile.Text = "Update List";
            // 
            // ChkUpdate
            // 
            this.ChkUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkUpdate.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkUpdate.Checked = false;
            this.ChkUpdate.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkUpdate.ForeColor = System.Drawing.Color.White;
            this.ChkUpdate.Location = new System.Drawing.Point(588, 582);
            this.ChkUpdate.Name = "ChkUpdate";
            this.ChkUpdate.Size = new System.Drawing.Size(20, 20);
            this.ChkUpdate.TabIndex = 10;
            // 
            // BtnUpAllVersion
            // 
            this.BtnUpAllVersion.Active = false;
            this.BtnUpAllVersion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnUpAllVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnUpAllVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpAllVersion.BorderRadius = 0;
            this.BtnUpAllVersion.ButtonText = "+";
            this.BtnUpAllVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpAllVersion.DisabledColor = System.Drawing.Color.Gray;
            this.BtnUpAllVersion.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnUpAllVersion.Iconimage = null;
            this.BtnUpAllVersion.Iconimage_right = null;
            this.BtnUpAllVersion.Iconimage_right_Selected = null;
            this.BtnUpAllVersion.Iconimage_Selected = null;
            this.BtnUpAllVersion.IconMarginLeft = 0;
            this.BtnUpAllVersion.IconMarginRight = 0;
            this.BtnUpAllVersion.IconRightVisible = true;
            this.BtnUpAllVersion.IconRightZoom = 0D;
            this.BtnUpAllVersion.IconVisible = true;
            this.BtnUpAllVersion.IconZoom = 90D;
            this.BtnUpAllVersion.IsTab = false;
            this.BtnUpAllVersion.Location = new System.Drawing.Point(480, 32);
            this.BtnUpAllVersion.Name = "BtnUpAllVersion";
            this.BtnUpAllVersion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnUpAllVersion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnUpAllVersion.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnUpAllVersion.selected = false;
            this.BtnUpAllVersion.Size = new System.Drawing.Size(23, 25);
            this.BtnUpAllVersion.TabIndex = 14;
            this.BtnUpAllVersion.Text = "+";
            this.BtnUpAllVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpAllVersion.Textcolor = System.Drawing.Color.White;
            this.BtnUpAllVersion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpAllVersion.Click += new System.EventHandler(this.BtnUpAllVersion_Click);
            // 
            // BtnDownAllVersion
            // 
            this.BtnDownAllVersion.Active = false;
            this.BtnDownAllVersion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnDownAllVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnDownAllVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDownAllVersion.BorderRadius = 0;
            this.BtnDownAllVersion.ButtonText = "-";
            this.BtnDownAllVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDownAllVersion.DisabledColor = System.Drawing.Color.Gray;
            this.BtnDownAllVersion.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDownAllVersion.Iconimage = null;
            this.BtnDownAllVersion.Iconimage_right = null;
            this.BtnDownAllVersion.Iconimage_right_Selected = null;
            this.BtnDownAllVersion.Iconimage_Selected = null;
            this.BtnDownAllVersion.IconMarginLeft = 0;
            this.BtnDownAllVersion.IconMarginRight = 0;
            this.BtnDownAllVersion.IconRightVisible = true;
            this.BtnDownAllVersion.IconRightZoom = 0D;
            this.BtnDownAllVersion.IconVisible = true;
            this.BtnDownAllVersion.IconZoom = 90D;
            this.BtnDownAllVersion.IsTab = false;
            this.BtnDownAllVersion.Location = new System.Drawing.Point(509, 32);
            this.BtnDownAllVersion.Name = "BtnDownAllVersion";
            this.BtnDownAllVersion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnDownAllVersion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnDownAllVersion.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnDownAllVersion.selected = false;
            this.BtnDownAllVersion.Size = new System.Drawing.Size(23, 25);
            this.BtnDownAllVersion.TabIndex = 13;
            this.BtnDownAllVersion.Text = "-";
            this.BtnDownAllVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDownAllVersion.Textcolor = System.Drawing.Color.White;
            this.BtnDownAllVersion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDownAllVersion.Click += new System.EventHandler(this.BtnDownAllVersion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Verion All Add";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(408, 586);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel1.TabIndex = 16;
            this.bunifuCustomLabel1.Text = "CopyUpdate";
            // 
            // ChkCopyUpdate
            // 
            this.ChkCopyUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkCopyUpdate.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkCopyUpdate.Checked = false;
            this.ChkCopyUpdate.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkCopyUpdate.ForeColor = System.Drawing.Color.White;
            this.ChkCopyUpdate.Location = new System.Drawing.Point(480, 582);
            this.ChkCopyUpdate.Name = "ChkCopyUpdate";
            this.ChkCopyUpdate.Size = new System.Drawing.Size(20, 20);
            this.ChkCopyUpdate.TabIndex = 15;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(760, 537);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(56, 13);
            this.bunifuCustomLabel2.TabIndex = 18;
            this.bunifuCustomLabel2.Text = "SaveBase";
            // 
            // ChkSaveBase
            // 
            this.ChkSaveBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkSaveBase.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkSaveBase.Checked = false;
            this.ChkSaveBase.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkSaveBase.ForeColor = System.Drawing.Color.White;
            this.ChkSaveBase.Location = new System.Drawing.Point(822, 533);
            this.ChkSaveBase.Name = "ChkSaveBase";
            this.ChkSaveBase.Size = new System.Drawing.Size(20, 20);
            this.ChkSaveBase.TabIndex = 17;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(620, 537);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(79, 13);
            this.bunifuCustomLabel3.TabIndex = 20;
            this.bunifuCustomLabel3.Text = "Save As base..";
            // 
            // ChkSaveAs
            // 
            this.ChkSaveAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkSaveAs.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkSaveAs.Checked = false;
            this.ChkSaveAs.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkSaveAs.ForeColor = System.Drawing.Color.White;
            this.ChkSaveAs.Location = new System.Drawing.Point(705, 533);
            this.ChkSaveAs.Name = "ChkSaveAs";
            this.ChkSaveAs.Size = new System.Drawing.Size(20, 20);
            this.ChkSaveAs.TabIndex = 19;
            // 
            // BtnReset
            // 
            this.BtnReset.Active = false;
            this.BtnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReset.BorderRadius = 0;
            this.BtnReset.ButtonText = "Reset";
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.DisabledColor = System.Drawing.Color.Gray;
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnReset.Iconimage = null;
            this.BtnReset.Iconimage_right = null;
            this.BtnReset.Iconimage_right_Selected = null;
            this.BtnReset.Iconimage_Selected = null;
            this.BtnReset.IconMarginLeft = 0;
            this.BtnReset.IconMarginRight = 0;
            this.BtnReset.IconRightVisible = true;
            this.BtnReset.IconRightZoom = 0D;
            this.BtnReset.IconVisible = true;
            this.BtnReset.IconZoom = 90D;
            this.BtnReset.IsTab = false;
            this.BtnReset.Location = new System.Drawing.Point(273, 32);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnReset.selected = false;
            this.BtnReset.Size = new System.Drawing.Size(68, 25);
            this.BtnReset.TabIndex = 21;
            this.BtnReset.Text = "Reset";
            this.BtnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReset.Textcolor = System.Drawing.Color.White;
            this.BtnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // AssetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 609);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.ChkSaveAs);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.ChkSaveBase);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.ChkCopyUpdate);
            this.Controls.Add(this.BtnUpAllVersion);
            this.Controls.Add(this.BtnDownAllVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbUpdateFile);
            this.Controls.Add(this.ChkUpdate);
            this.Controls.Add(this.LbCheckLoadPachOrFile);
            this.Controls.Add(this.ChBoxLoad);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.TxtBoxPath);
            this.Controls.Add(this.BtnPlusUpdate);
            this.Controls.Add(this.BtnMinesUpdate);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AssetEditor";
            this.Text = "Asset Editor";
            this.Load += new System.EventHandler(this.AssetEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSave;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Search;
        private Bunifu.Framework.UI.BunifuFlatButton BtnMinesUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton BtnPlusUpdate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtBoxPath;
        private Bunifu.Framework.UI.BunifuFlatButton BtnLoad;
        private Bunifu.Framework.UI.BunifuCheckbox ChBoxLoad;
        private Bunifu.Framework.UI.BunifuCustomLabel LbCheckLoadPachOrFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Bunifu.Framework.UI.BunifuCustomLabel LbUpdateFile;
        private Bunifu.Framework.UI.BunifuCheckbox ChkUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton BtnUpAllVersion;
        private Bunifu.Framework.UI.BunifuFlatButton BtnDownAllVersion;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCheckbox ChkCopyUpdate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCheckbox ChkSaveBase;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCheckbox ChkSaveAs;
        private Bunifu.Framework.UI.BunifuFlatButton BtnReset;
    }
}

