namespace Rinex_Tools_6
{
    partial class Merge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Merge));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radio_nav = new System.Windows.Forms.RadioButton();
            this.radio_obs = new System.Windows.Forms.RadioButton();
            this.radio_mdb = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbAnType = new System.Windows.Forms.ComboBox();
            this.tbAnH = new System.Windows.Forms.TextBox();
            this.tbAnNum = new System.Windows.Forms.TextBox();
            this.tbAg = new System.Windows.Forms.TextBox();
            this.tbOp = new System.Windows.Forms.TextBox();
            this.tbMN = new System.Windows.Forms.TextBox();
            this.tbMO = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnSource = new System.Windows.Forms.Button();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.cbSignals = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(245, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnMerge
            // 
            this.btnMerge.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnMerge.Location = new System.Drawing.Point(165, 463);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 23);
            this.btnMerge.TabIndex = 23;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(0, 514);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(484, 38);
            this.progress.TabIndex = 22;
            // 
            // tbStatus
            // 
            this.tbStatus.Enabled = false;
            this.tbStatus.Location = new System.Drawing.Point(0, 495);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(484, 20);
            this.tbStatus.TabIndex = 21;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.cbSignals);
            this.groupBox8.Controls.Add(this.radio_nav);
            this.groupBox8.Controls.Add(this.radio_obs);
            this.groupBox8.Controls.Add(this.radio_mdb);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.cbAnType);
            this.groupBox8.Controls.Add(this.tbAnH);
            this.groupBox8.Controls.Add(this.tbAnNum);
            this.groupBox8.Controls.Add(this.tbAg);
            this.groupBox8.Controls.Add(this.tbOp);
            this.groupBox8.Controls.Add(this.tbMN);
            this.groupBox8.Controls.Add(this.tbMO);
            this.groupBox8.Location = new System.Drawing.Point(12, 180);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(460, 273);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Header info";
            // 
            // radio_nav
            // 
            this.radio_nav.AutoSize = true;
            this.radio_nav.Location = new System.Drawing.Point(222, 244);
            this.radio_nav.Name = "radio_nav";
            this.radio_nav.Size = new System.Drawing.Size(45, 17);
            this.radio_nav.TabIndex = 18;
            this.radio_nav.Text = "Nav";
            this.radio_nav.UseVisualStyleBackColor = true;
            // 
            // radio_obs
            // 
            this.radio_obs.AutoSize = true;
            this.radio_obs.Location = new System.Drawing.Point(119, 244);
            this.radio_obs.Name = "radio_obs";
            this.radio_obs.Size = new System.Drawing.Size(44, 17);
            this.radio_obs.TabIndex = 17;
            this.radio_obs.Text = "Obs";
            this.radio_obs.UseVisualStyleBackColor = true;
            this.radio_obs.CheckedChanged += new System.EventHandler(this.radio_obs_CheckedChanged);
            // 
            // radio_mdb
            // 
            this.radio_mdb.AutoSize = true;
            this.radio_mdb.Checked = true;
            this.radio_mdb.Location = new System.Drawing.Point(20, 244);
            this.radio_mdb.Name = "radio_mdb";
            this.radio_mdb.Size = new System.Drawing.Size(49, 17);
            this.radio_mdb.TabIndex = 12;
            this.radio_mdb.TabStop = true;
            this.radio_mdb.Text = "MDB";
            this.radio_mdb.UseVisualStyleBackColor = true;
            this.radio_mdb.CheckedChanged += new System.EventHandler(this.radio_mdb_CheckedChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Antenna height";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Antenna number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Antenna type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(277, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Agency";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(277, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Operator";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(277, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Marker number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(277, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Marker name";
            // 
            // cbAnType
            // 
            this.cbAnType.Enabled = false;
            this.cbAnType.FormattingEnabled = true;
            this.cbAnType.Items.AddRange(new object[] {
            "\"LEIAR25         NONE\"",
            "\"LEIAT504        NONE\"",
            "\"LEIAX1202       NONE\"",
            "\"LEIAS10         NONE\""});
            this.cbAnType.Location = new System.Drawing.Point(17, 127);
            this.cbAnType.MaxLength = 50;
            this.cbAnType.Name = "cbAnType";
            this.cbAnType.Size = new System.Drawing.Size(257, 21);
            this.cbAnType.TabIndex = 9;
            // 
            // tbAnH
            // 
            this.tbAnH.Enabled = false;
            this.tbAnH.Location = new System.Drawing.Point(17, 180);
            this.tbAnH.MaxLength = 6;
            this.tbAnH.Name = "tbAnH";
            this.tbAnH.Size = new System.Drawing.Size(257, 20);
            this.tbAnH.TabIndex = 11;
            // 
            // tbAnNum
            // 
            this.tbAnNum.AutoCompleteCustomSource.AddRange(new string[] {
            "103261",
            "103291",
            "103292",
            "103293",
            "103294",
            "103295",
            "103296",
            "103297",
            "103298",
            "103299",
            "103300",
            "103301",
            "103310",
            "200736",
            "5480014",
            "5480049",
            "5480050",
            "5480079",
            "5480081",
            "5480090",
            "10271003",
            "10271008",
            "10271018",
            "10271021",
            "10271022",
            "10271023",
            "10281001",
            "10281003",
            "10281005",
            "10281008",
            "10281009",
            "10281011",
            "10281015",
            "10281017",
            "10281018",
            "10281019",
            "10301023",
            "10301027",
            "10301028",
            "10301035",
            "10301036",
            "10301037",
            "10301039",
            "10301041",
            "10301042",
            "10301043",
            "10301044",
            "10301045",
            "10301049",
            "10301050",
            "10321001",
            "10321004",
            "10321009",
            "10321008",
            "10321010",
            "10321013",
            "10321015",
            "10321016",
            "10321017",
            "10321018",
            "10321019",
            "10321020",
            "10321021",
            "10351035",
            "10351036",
            "10371007",
            "10371009",
            "10371015",
            "10371017",
            "10371021",
            "10371022",
            "10371024",
            "10371026",
            "10371027",
            "10371032",
            "10371035",
            "10371042",
            "10371048",
            "10401003",
            "10401004",
            "10401012"});
            this.tbAnNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbAnNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbAnNum.Enabled = false;
            this.tbAnNum.Location = new System.Drawing.Point(17, 154);
            this.tbAnNum.MaxLength = 40;
            this.tbAnNum.Name = "tbAnNum";
            this.tbAnNum.Size = new System.Drawing.Size(257, 20);
            this.tbAnNum.TabIndex = 10;
            // 
            // tbAg
            // 
            this.tbAg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbAg.Enabled = false;
            this.tbAg.Location = new System.Drawing.Point(17, 101);
            this.tbAg.MaxLength = 25;
            this.tbAg.Name = "tbAg";
            this.tbAg.Size = new System.Drawing.Size(257, 20);
            this.tbAg.TabIndex = 8;
            this.tbAg.Text = "C.R.A.A.G.";
            // 
            // tbOp
            // 
            this.tbOp.AutoCompleteCustomSource.AddRange(new string[] {
            "AIT AMIR",
            "BACHA",
            "BELLIK",
            "BOUGRINE",
            "MAHSAS",
            "MELIANI",
            "TERKI"});
            this.tbOp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbOp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbOp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbOp.Enabled = false;
            this.tbOp.Location = new System.Drawing.Point(17, 75);
            this.tbOp.MaxLength = 25;
            this.tbOp.Name = "tbOp";
            this.tbOp.Size = new System.Drawing.Size(257, 20);
            this.tbOp.TabIndex = 7;
            // 
            // tbMN
            // 
            this.tbMN.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.tbMN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbMN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbMN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMN.Enabled = false;
            this.tbMN.Location = new System.Drawing.Point(17, 49);
            this.tbMN.MaxLength = 4;
            this.tbMN.Name = "tbMN";
            this.tbMN.Size = new System.Drawing.Size(257, 20);
            this.tbMN.TabIndex = 6;
            // 
            // tbMO
            // 
            this.tbMO.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.tbMO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbMO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbMO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMO.Enabled = false;
            this.tbMO.Location = new System.Drawing.Point(17, 23);
            this.tbMO.MaxLength = 4;
            this.tbMO.Name = "tbMO";
            this.tbMO.Size = new System.Drawing.Size(257, 20);
            this.tbMO.TabIndex = 5;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbTo);
            this.groupBox7.Controls.Add(this.tbFrom);
            this.groupBox7.Location = new System.Drawing.Point(141, 118);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(141, 56);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "   From ...         to ...";
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbCode);
            this.groupBox6.Location = new System.Drawing.Point(12, 118);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(115, 56);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Station code";
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
            this.tbCode.TextChanged += new System.EventHandler(this.tbCode_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDestination);
            this.groupBox5.Controls.Add(this.btnSource);
            this.groupBox5.Controls.Add(this.tbDestination);
            this.groupBox5.Controls.Add(this.tbSource);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(460, 100);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Paths";
            // 
            // btnDestination
            // 
            this.btnDestination.Enabled = false;
            this.btnDestination.Location = new System.Drawing.Point(365, 53);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(75, 23);
            this.btnDestination.TabIndex = 3;
            this.btnDestination.Text = "Destination";
            this.btnDestination.UseVisualStyleBackColor = true;
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(365, 29);
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
            this.tbDestination.Size = new System.Drawing.Size(341, 20);
            this.tbDestination.TabIndex = 1;
            // 
            // tbSource
            // 
            this.tbSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSource.Location = new System.Drawing.Point(18, 29);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(341, 20);
            this.tbSource.TabIndex = 0;
            // 
            // cbSignals
            // 
            this.cbSignals.Enabled = false;
            this.cbSignals.FormattingEnabled = true;
            this.cbSignals.Items.AddRange(new object[] {
            "C1L1P2L2 (GNSS Spider)",
            "L1L2C1P2 (TEQC)"});
            this.cbSignals.Location = new System.Drawing.Point(17, 206);
            this.cbSignals.MaxLength = 50;
            this.cbSignals.Name = "cbSignals";
            this.cbSignals.Size = new System.Drawing.Size(257, 21);
            this.cbSignals.TabIndex = 19;
            this.cbSignals.Text = "C1L1P2L2 (GNSS Spider)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Order of signals";
            // 
            // Merge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 548);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Merge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge";
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton radio_mdb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbAnType;
        private System.Windows.Forms.TextBox tbAnH;
        private System.Windows.Forms.TextBox tbAnNum;
        private System.Windows.Forms.TextBox tbAg;
        private System.Windows.Forms.TextBox tbOp;
        private System.Windows.Forms.TextBox tbMN;
        private System.Windows.Forms.TextBox tbMO;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.RadioButton radio_nav;
        private System.Windows.Forms.RadioButton radio_obs;
        private System.Windows.Forms.ComboBox cbSignals;
        private System.Windows.Forms.Label label1;

    }
}