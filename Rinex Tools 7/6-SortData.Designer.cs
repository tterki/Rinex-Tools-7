namespace Rinex_Tools_6
{
    partial class SortData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortData));
            this.progress = new System.Windows.Forms.ProgressBar();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.btn_Source = new System.Windows.Forms.Button();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(0, 201);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(334, 38);
            this.progress.TabIndex = 38;
            // 
            // tbStatus
            // 
            this.tbStatus.Enabled = false;
            this.tbStatus.Location = new System.Drawing.Point(0, 182);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(334, 20);
            this.tbStatus.TabIndex = 37;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancel.Location = new System.Drawing.Point(173, 153);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 35;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Sort
            // 
            this.btn_Sort.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_Sort.Location = new System.Drawing.Point(93, 153);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(75, 23);
            this.btn_Sort.TabIndex = 34;
            this.btn_Sort.Text = "Sort Data";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.tbTo);
            this.groupBox16.Controls.Add(this.tbFrom);
            this.groupBox16.Location = new System.Drawing.Point(141, 88);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(141, 56);
            this.groupBox16.TabIndex = 33;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "   From ...         to ...";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(79, 21);
            this.tbTo.MaxLength = 3;
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(42, 20);
            this.tbTo.TabIndex = 4;
            this.tbTo.Text = "366";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(18, 21);
            this.tbFrom.MaxLength = 3;
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(42, 20);
            this.tbFrom.TabIndex = 3;
            this.tbFrom.Text = "1";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.tbCode);
            this.groupBox17.Location = new System.Drawing.Point(12, 88);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(115, 56);
            this.groupBox17.TabIndex = 32;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Station code";
            // 
            // tbCode
            // 
            this.tbCode.AutoCompleteCustomSource.AddRange(new string[] {
            "ABKD",
            "ABSD",
            "ABZH",
            "ADCK",
            "ADJF",
            "AFDJ",
            "AFRS",
            "AKDR",
            "AKET",
            "ATKJ",
            "BJML",
            "BOUD",
            "BOUF",
            "BOUG",
            "BOUI",
            "BOUS",
            "CABS",
            "CAEH",
            "CAEK",
            "CBBR",
            "CBCK",
            "CBEJ",
            "CCOL",
            "CDJP",
            "CDPN",
            "CFKZ",
            "CHBL",
            "CJIJ",
            "CJSR",
            "CKAL",
            "CKHR",
            "CKTS",
            "CMAR",
            "CNAJ",
            "CNGR",
            "CPIN",
            "CRHA",
            "CSVB",
            "CTCH",
            "DLYP",
            "DODA",
            "DRBD",
            "EADB",
            "EARB",
            "EASA",
            "EBGR",
            "EBNH",
            "EECH",
            "EKMS",
            "EMHD",
            "ESKN",
            "ETJN",
            "EZEA",
            "KHRS",
            "MHLM",
            "OAIN",
            "OAIR",
            "OASF",
            "OBBL",
            "OBHM",
            "ODJA",
            "OJGS",
            "OKHE",
            "OKHM",
            "OLDA",
            "OLHC",
            "ORAN",
            "OSDA",
            "OTSS",
            "TBCH",
            "THNP",
            "TTAM",
            "ZMRI"});
            this.tbCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCode.Location = new System.Drawing.Point(19, 21);
            this.tbCode.MaxLength = 4;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(77, 20);
            this.tbCode.TabIndex = 2;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.btn_Source);
            this.groupBox15.Controls.Add(this.tbSource);
            this.groupBox15.Location = new System.Drawing.Point(12, 12);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(308, 70);
            this.groupBox15.TabIndex = 31;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Paths";
            // 
            // btn_Source
            // 
            this.btn_Source.Location = new System.Drawing.Point(212, 27);
            this.btn_Source.Name = "btn_Source";
            this.btn_Source.Size = new System.Drawing.Size(75, 23);
            this.btn_Source.TabIndex = 1;
            this.btn_Source.Text = "Source";
            this.btn_Source.UseVisualStyleBackColor = true;
            this.btn_Source.Click += new System.EventHandler(this.btn_Source_Click);
            // 
            // tbSource
            // 
            this.tbSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSource.Location = new System.Drawing.Point(18, 29);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(188, 20);
            this.tbSource.TabIndex = 0;
            // 
            // SortData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 234);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox17);
            this.Controls.Add(this.groupBox15);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SortData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort Data";
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button btn_Source;
        private System.Windows.Forms.TextBox tbSource;
    }
}