namespace Rinex_Tools_6
{
    partial class Decimate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Decimate));
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tbInputRate = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbOutputRate = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btnDecimate = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.tbstatus = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnSource = new System.Windows.Forms.Button();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.tbTo);
            this.groupBox13.Controls.Add(this.tbFrom);
            this.groupBox13.Location = new System.Drawing.Point(141, 118);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(141, 56);
            this.groupBox13.TabIndex = 32;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "   From ...         to ...";
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
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.tbCode);
            this.groupBox14.Location = new System.Drawing.Point(12, 118);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(115, 56);
            this.groupBox14.TabIndex = 31;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Station code";
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
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.tbInputRate);
            this.groupBox12.Controls.Add(this.label24);
            this.groupBox12.Controls.Add(this.cbOutputRate);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Location = new System.Drawing.Point(12, 180);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(316, 88);
            this.groupBox12.TabIndex = 30;
            this.groupBox12.TabStop = false;
            // 
            // tbInputRate
            // 
            this.tbInputRate.Enabled = false;
            this.tbInputRate.Location = new System.Drawing.Point(18, 19);
            this.tbInputRate.Name = "tbInputRate";
            this.tbInputRate.Size = new System.Drawing.Size(78, 20);
            this.tbInputRate.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Enabled = false;
            this.label24.Location = new System.Drawing.Point(102, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(128, 13);
            this.label24.TabIndex = 20;
            this.label24.Text = "Input rate ( if < 1 second )";
            // 
            // cbOutputRate
            // 
            this.cbOutputRate.FormattingEnabled = true;
            this.cbOutputRate.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "30",
            "60",
            "120",
            "180"});
            this.cbOutputRate.Location = new System.Drawing.Point(18, 50);
            this.cbOutputRate.MaxLength = 30;
            this.cbOutputRate.Name = "cbOutputRate";
            this.cbOutputRate.Size = new System.Drawing.Size(78, 21);
            this.cbOutputRate.TabIndex = 5;
            this.cbOutputRate.Text = "30";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(102, 53);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 19;
            this.label23.Text = "Output rate";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancel.Location = new System.Drawing.Point(173, 274);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 27;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btnDecimate
            // 
            this.btnDecimate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDecimate.Location = new System.Drawing.Point(93, 274);
            this.btnDecimate.Name = "btnDecimate";
            this.btnDecimate.Size = new System.Drawing.Size(75, 23);
            this.btnDecimate.TabIndex = 26;
            this.btnDecimate.Text = "Decimate";
            this.btnDecimate.UseVisualStyleBackColor = true;
            this.btnDecimate.Click += new System.EventHandler(this.btnDecimate_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(0, 325);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(340, 38);
            this.progress.TabIndex = 29;
            // 
            // tbstatus
            // 
            this.tbstatus.Enabled = false;
            this.tbstatus.Location = new System.Drawing.Point(0, 306);
            this.tbstatus.Name = "tbstatus";
            this.tbstatus.Size = new System.Drawing.Size(340, 20);
            this.tbstatus.TabIndex = 28;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnDestination);
            this.groupBox11.Controls.Add(this.btnSource);
            this.groupBox11.Controls.Add(this.tbDestination);
            this.groupBox11.Controls.Add(this.tbSource);
            this.groupBox11.Location = new System.Drawing.Point(12, 12);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(317, 100);
            this.groupBox11.TabIndex = 25;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Paths";
            // 
            // btnDestination
            // 
            this.btnDestination.Enabled = false;
            this.btnDestination.Location = new System.Drawing.Point(221, 53);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(75, 23);
            this.btnDestination.TabIndex = 3;
            this.btnDestination.Text = "Destination";
            this.btnDestination.UseVisualStyleBackColor = true;
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(221, 27);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 23);
            this.btnSource.TabIndex = 1;
            this.btnSource.Text = "Source";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // tbDestination
            // 
            this.tbDestination.Enabled = false;
            this.tbDestination.Location = new System.Drawing.Point(18, 55);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(197, 20);
            this.tbDestination.TabIndex = 1;
            // 
            // tbSource
            // 
            this.tbSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSource.Location = new System.Drawing.Point(18, 29);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(197, 20);
            this.tbSource.TabIndex = 0;
            // 
            // Decimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 356);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btnDecimate);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.tbstatus);
            this.Controls.Add(this.groupBox11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Decimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decimate";
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox tbInputRate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbOutputRate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btnDecimate;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.TextBox tbstatus;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.TextBox tbSource;

    }
}