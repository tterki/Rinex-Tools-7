namespace Rinex_Tools_6
{
    partial class Rinex
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rinex));
            this.progress = new System.Windows.Forms.ProgressBar();
            this.tbstatus = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRinex = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkSN = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSignals = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAnType = new System.Windows.Forms.ComboBox();
            this.tbAnH = new System.Windows.Forms.TextBox();
            this.tbAnNum = new System.Windows.Forms.TextBox();
            this.tbAg = new System.Windows.Forms.TextBox();
            this.tbOp = new System.Windows.Forms.TextBox();
            this.tbMN = new System.Windows.Forms.TextBox();
            this.tbMO = new System.Windows.Forms.TextBox();
            this.checkNav = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkAddPath = new System.Windows.Forms.CheckBox();
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnSource = new System.Windows.Forms.Button();
            this.tbDestination1 = new System.Windows.Forms.TextBox();
            this.tbSource1 = new System.Windows.Forms.TextBox();
            this.checkGlonass = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(0, 542);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(484, 38);
            this.progress.TabIndex = 21;
            // 
            // tbstatus
            // 
            this.tbstatus.Enabled = false;
            this.tbstatus.Location = new System.Drawing.Point(0, 522);
            this.tbstatus.Name = "tbstatus";
            this.tbstatus.Size = new System.Drawing.Size(484, 20);
            this.tbstatus.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(245, 487);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRinex
            // 
            this.btnRinex.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnRinex.Location = new System.Drawing.Point(165, 487);
            this.btnRinex.Name = "btnRinex";
            this.btnRinex.Size = new System.Drawing.Size(75, 23);
            this.btnRinex.TabIndex = 22;
            this.btnRinex.Text = "Rinex";
            this.btnRinex.UseVisualStyleBackColor = true;
            this.btnRinex.Click += new System.EventHandler(this.btnRinex_Click);
            this.btnRinex.MouseHover += new System.EventHandler(this.btnRinex_MouseHover);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbTo);
            this.groupBox4.Controls.Add(this.tbFrom);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Location = new System.Drawing.Point(141, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 83);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "   From ...                     to ...";
            // 
            // tbTo
            // 
            this.tbTo.AutoCompleteCustomSource.AddRange(new string[] {
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
            "CABS",
            "CAEH",
            "CAEK",
            "CBBR",
            "CBCK",
            "CBEJ",
            "CCOL",
            "CFKZ",
            "CJIJ",
            "CJSR",
            "CKAL",
            "CKHR",
            "CKTS",
            "CMAR",
            "CNAJ",
            "CNGR",
            "CRHA",
            "CSVB",
            "CTCH",
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
            "OAIN",
            "OAIR",
            "OASF",
            "OBBL",
            "OBHM",
            "ODJA",
            "OJGS",
            "OKHE",
            "OKHM",
            "OLHC",
            "ORAN",
            "OSDA",
            "OTSS",
            "TTAM"});
            this.tbTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTo.Location = new System.Drawing.Point(113, 45);
            this.tbTo.MaxLength = 4;
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(78, 20);
            this.tbTo.TabIndex = 4;
            this.tbTo.Text = "1";
            this.tbTo.TextChanged += new System.EventHandler(this.tbTo_TextChanged_1);
            // 
            // tbFrom
            // 
            this.tbFrom.AutoCompleteCustomSource.AddRange(new string[] {
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
            "CABS",
            "CAEH",
            "CAEK",
            "CBBR",
            "CBCK",
            "CBEJ",
            "CCOL",
            "CFKZ",
            "CJIJ",
            "CJSR",
            "CKAL",
            "CKHR",
            "CKTS",
            "CMAR",
            "CNAJ",
            "CNGR",
            "CRHA",
            "CSVB",
            "CTCH",
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
            "OAIN",
            "OAIR",
            "OASF",
            "OBBL",
            "OBHM",
            "ODJA",
            "OJGS",
            "OKHE",
            "OKHM",
            "OLHC",
            "ORAN",
            "OSDA",
            "OTSS",
            "TTAM"});
            this.tbFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFrom.Location = new System.Drawing.Point(18, 45);
            this.tbFrom.MaxLength = 4;
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(77, 20);
            this.tbFrom.TabIndex = 3;
            this.tbFrom.Text = "1";
            this.tbFrom.TextChanged += new System.EventHandler(this.tbFrom_TextChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(113, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(78, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged_1);
            this.dateTimePicker2.MouseHover += new System.EventHandler(this.dateTimePicker2_MouseHover);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(78, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.MouseHover += new System.EventHandler(this.dateTimePicker1_MouseHover);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbCode);
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 56);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Station code";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkSN);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbSignals);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbAnType);
            this.groupBox2.Controls.Add(this.tbAnH);
            this.groupBox2.Controls.Add(this.tbAnNum);
            this.groupBox2.Controls.Add(this.tbAg);
            this.groupBox2.Controls.Add(this.tbOp);
            this.groupBox2.Controls.Add(this.tbMN);
            this.groupBox2.Controls.Add(this.tbMO);
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 265);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Header info";
            // 
            // checkSN
            // 
            this.checkSN.AutoSize = true;
            this.checkSN.Location = new System.Drawing.Point(19, 233);
            this.checkSN.Name = "checkSN";
            this.checkSN.Size = new System.Drawing.Size(80, 17);
            this.checkSN.TabIndex = 24;
            this.checkSN.Text = "Add S1, S2";
            this.checkSN.UseVisualStyleBackColor = true;
            this.checkSN.MouseHover += new System.EventHandler(this.checkSN_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Order of signals";
            // 
            // cbSignals
            // 
            this.cbSignals.FormattingEnabled = true;
            this.cbSignals.Items.AddRange(new object[] {
            "C1L1P2L2 (GNSS Spider)",
            "L1L2C1P2 (TEQC)"});
            this.cbSignals.Location = new System.Drawing.Point(17, 206);
            this.cbSignals.MaxLength = 50;
            this.cbSignals.Name = "cbSignals";
            this.cbSignals.Size = new System.Drawing.Size(257, 21);
            this.cbSignals.TabIndex = 17;
            this.cbSignals.Text = "C1L1P2L2 (GNSS Spider)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Antenna height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Antenna number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Antenna type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Agency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Operator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Marker number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Marker name";
            // 
            // cbAnType
            // 
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
            this.tbAnNum.Location = new System.Drawing.Point(17, 154);
            this.tbAnNum.MaxLength = 40;
            this.tbAnNum.Name = "tbAnNum";
            this.tbAnNum.Size = new System.Drawing.Size(257, 20);
            this.tbAnNum.TabIndex = 10;
            // 
            // tbAg
            // 
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
            this.tbMO.Location = new System.Drawing.Point(17, 23);
            this.tbMO.MaxLength = 4;
            this.tbMO.Name = "tbMO";
            this.tbMO.Size = new System.Drawing.Size(257, 20);
            this.tbMO.TabIndex = 5;
            this.tbMO.Tag = "";
            // 
            // checkNav
            // 
            this.checkNav.AutoSize = true;
            this.checkNav.Location = new System.Drawing.Point(362, 129);
            this.checkNav.Name = "checkNav";
            this.checkNav.Size = new System.Drawing.Size(103, 17);
            this.checkNav.TabIndex = 12;
            this.checkNav.Text = "Add nav. file (.n)";
            this.checkNav.UseVisualStyleBackColor = true;
            this.checkNav.MouseHover += new System.EventHandler(this.checkNav_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkAddPath);
            this.groupBox1.Controls.Add(this.btnDestination);
            this.groupBox1.Controls.Add(this.btnSource);
            this.groupBox1.Controls.Add(this.tbDestination1);
            this.groupBox1.Controls.Add(this.tbSource1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paths";
            // 
            // checkAddPath
            // 
            this.checkAddPath.AutoSize = true;
            this.checkAddPath.Enabled = false;
            this.checkAddPath.Location = new System.Drawing.Point(19, 45);
            this.checkAddPath.Name = "checkAddPath";
            this.checkAddPath.Size = new System.Drawing.Size(116, 17);
            this.checkAddPath.TabIndex = 4;
            this.checkAddPath.Text = "+ \"...\\Year\\Code\\\"";
            this.checkAddPath.UseVisualStyleBackColor = true;
            this.checkAddPath.CheckedChanged += new System.EventHandler(this.checkAddPath_CheckedChanged);
            // 
            // btnDestination
            // 
            this.btnDestination.Enabled = false;
            this.btnDestination.Location = new System.Drawing.Point(365, 66);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(75, 23);
            this.btnDestination.TabIndex = 3;
            this.btnDestination.Text = "Destination";
            this.btnDestination.UseVisualStyleBackColor = true;
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(365, 21);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 23);
            this.btnSource.TabIndex = 1;
            this.btnSource.Text = "Source";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click_1);
            this.btnSource.MouseHover += new System.EventHandler(this.btnSource_MouseHover);
            // 
            // tbDestination1
            // 
            this.tbDestination1.Enabled = false;
            this.tbDestination1.Location = new System.Drawing.Point(18, 68);
            this.tbDestination1.Name = "tbDestination1";
            this.tbDestination1.Size = new System.Drawing.Size(341, 20);
            this.tbDestination1.TabIndex = 1;
            // 
            // tbSource1
            // 
            this.tbSource1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSource1.Location = new System.Drawing.Point(18, 21);
            this.tbSource1.Name = "tbSource1";
            this.tbSource1.Size = new System.Drawing.Size(341, 20);
            this.tbSource1.TabIndex = 0;
            this.tbSource1.MouseHover += new System.EventHandler(this.tbSource1_MouseHover);
            // 
            // checkGlonass
            // 
            this.checkGlonass.AutoSize = true;
            this.checkGlonass.Location = new System.Drawing.Point(362, 157);
            this.checkGlonass.Name = "checkGlonass";
            this.checkGlonass.Size = new System.Drawing.Size(86, 17);
            this.checkGlonass.TabIndex = 17;
            this.checkGlonass.Text = "Add Glonass";
            this.checkGlonass.UseVisualStyleBackColor = true;
            this.checkGlonass.MouseHover += new System.EventHandler(this.checkGlonass_MouseHover);
            // 
            // Rinex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 576);
            this.Controls.Add(this.checkGlonass);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.tbstatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRinex);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rinex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDB to RNX";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.TextBox tbstatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRinex;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkNav;
        private System.Windows.Forms.ComboBox cbAnType;
        private System.Windows.Forms.TextBox tbAnH;
        private System.Windows.Forms.TextBox tbAnNum;
        private System.Windows.Forms.TextBox tbAg;
        private System.Windows.Forms.TextBox tbOp;
        private System.Windows.Forms.TextBox tbMN;
        private System.Windows.Forms.TextBox tbMO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TextBox tbDestination1;
        private System.Windows.Forms.TextBox tbSource1;
        private System.Windows.Forms.ComboBox cbSignals;
        private System.Windows.Forms.CheckBox checkGlonass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkSN;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox checkAddPath;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;

    }
}

