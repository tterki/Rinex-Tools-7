namespace Rinex_Tools_6
{
    partial class Compare
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compare));
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbRate = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbAnType = new System.Windows.Forms.ComboBox();
            this.tbAnH = new System.Windows.Forms.TextBox();
            this.tbAnNum = new System.Windows.Forms.TextBox();
            this.tbRn3 = new System.Windows.Forms.TextBox();
            this.tbMN = new System.Windows.Forms.TextBox();
            this.tbMO = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnSource = new System.Windows.Forms.Button();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.label25);
            this.groupBox18.Controls.Add(this.tbFrom);
            this.groupBox18.Controls.Add(this.tbTo);
            this.groupBox18.Controls.Add(this.label18);
            this.groupBox18.Location = new System.Drawing.Point(484, 88);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(74, 177);
            this.groupBox18.TabIndex = 22;
            this.groupBox18.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 91);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 13);
            this.label25.TabIndex = 20;
            this.label25.Text = "To";
            // 
            // tbFrom
            // 
            this.tbFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFrom.Location = new System.Drawing.Point(20, 46);
            this.tbFrom.MaxLength = 25;
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(32, 20);
            this.tbFrom.TabIndex = 5;
            this.tbFrom.Text = "1";
            // 
            // tbTo
            // 
            this.tbTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTo.Location = new System.Drawing.Point(20, 107);
            this.tbTo.MaxLength = 3;
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(32, 20);
            this.tbTo.TabIndex = 19;
            this.tbTo.Text = "366";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "From";
            // 
            // btn_clear
            // 
            this.btn_clear.ForeColor = System.Drawing.Color.Red;
            this.btn_clear.Location = new System.Drawing.Point(540, 447);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(27, 23);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "Clr";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(338, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCheck.Location = new System.Drawing.Point(176, 455);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 19;
            this.btnCheck.Text = "Check";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(0, 506);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(571, 38);
            this.progress.TabIndex = 18;
            // 
            // tbStatus
            // 
            this.tbStatus.Enabled = false;
            this.tbStatus.Location = new System.Drawing.Point(0, 487);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(571, 20);
            this.tbStatus.TabIndex = 17;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ReceiverSN,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Logg});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(0, 275);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(571, 169);
            this.dataGridView.TabIndex = 16;
            this.dataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // ReceiverSN
            // 
            this.ReceiverSN.HeaderText = "Rec num";
            this.ReceiverSN.Name = "ReceiverSN";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MO";
            this.Column2.Name = "Column2";
            this.Column2.Width = 55;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MN";
            this.Column3.Name = "Column3";
            this.Column3.Width = 55;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ant type";
            this.Column4.Name = "Column4";
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ant num";
            this.Column5.Name = "Column5";
            this.Column5.Width = 75;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "h(m)";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Logg
            // 
            this.Logg.HeaderText = "Rate(s)";
            this.Logg.Name = "Logg";
            this.Logg.Width = 60;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label22);
            this.groupBox10.Controls.Add(this.cbRate);
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.label20);
            this.groupBox10.Controls.Add(this.label21);
            this.groupBox10.Controls.Add(this.cbAnType);
            this.groupBox10.Controls.Add(this.tbAnH);
            this.groupBox10.Controls.Add(this.tbAnNum);
            this.groupBox10.Controls.Add(this.tbRn3);
            this.groupBox10.Controls.Add(this.tbMN);
            this.groupBox10.Controls.Add(this.tbMO);
            this.groupBox10.Location = new System.Drawing.Point(12, 88);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(456, 177);
            this.groupBox10.TabIndex = 15;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Header model";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(156, 140);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 13);
            this.label22.TabIndex = 18;
            this.label22.Text = "seconds (Logging rate)";
            // 
            // cbRate
            // 
            this.cbRate.FormattingEnabled = true;
            this.cbRate.Items.AddRange(new object[] {
            "1",
            "10",
            "15",
            "30",
            "60",
            "120"});
            this.cbRate.Location = new System.Drawing.Point(70, 137);
            this.cbRate.MaxLength = 30;
            this.cbRate.Name = "cbRate";
            this.cbRate.Size = new System.Drawing.Size(80, 21);
            this.cbRate.TabIndex = 9;
            this.cbRate.Text = "30";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(343, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Ant height";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(343, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Ant type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(156, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Ant number";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(156, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Rec number";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(343, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "Marker number";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(156, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 10;
            this.label21.Text = "Marker name";
            // 
            // cbAnType
            // 
            this.cbAnType.FormattingEnabled = true;
            this.cbAnType.Items.AddRange(new object[] {
            "LEIAR25         NONE",
            "LEIAT504        NONE",
            "LEIAX1202       NONE",
            "LEIAS10         NONE",
            "Ashtech CR5200"});
            this.cbAnType.Location = new System.Drawing.Point(70, 84);
            this.cbAnType.MaxLength = 50;
            this.cbAnType.Name = "cbAnType";
            this.cbAnType.Size = new System.Drawing.Size(267, 21);
            this.cbAnType.TabIndex = 6;
            // 
            // tbAnH
            // 
            this.tbAnH.Location = new System.Drawing.Point(257, 111);
            this.tbAnH.MaxLength = 6;
            this.tbAnH.Name = "tbAnH";
            this.tbAnH.Size = new System.Drawing.Size(80, 20);
            this.tbAnH.TabIndex = 8;
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
            this.tbAnNum.Location = new System.Drawing.Point(70, 111);
            this.tbAnNum.MaxLength = 40;
            this.tbAnNum.Name = "tbAnNum";
            this.tbAnNum.Size = new System.Drawing.Size(80, 20);
            this.tbAnNum.TabIndex = 7;
            // 
            // tbRn3
            // 
            this.tbRn3.AutoCompleteCustomSource.AddRange(new string[] {
            "462240",
            "462275",
            "462286",
            "462287",
            "462393",
            "462394",
            "462396",
            "462397",
            "462398",
            "462399",
            "462400",
            "462402",
            "462404",
            "462405",
            "462406",
            "462407",
            "462408",
            "462411",
            "462412",
            "496473",
            "496477",
            "496495",
            "496498",
            "496499",
            "496502",
            "496503",
            "496509",
            "496510",
            "496511",
            "496514",
            "496515",
            "496517",
            "496518",
            "496519",
            "496521",
            "496522",
            "496523",
            "496524",
            "496525",
            "496529",
            "496532",
            "496533",
            "496534",
            "496535",
            "496536",
            "496538",
            "496542",
            "496543",
            "496544",
            "496545",
            "496546",
            "496547",
            "496548",
            "496549",
            "496550",
            "496552",
            "496554",
            "496557",
            "496558",
            "496560",
            "496563",
            "496564",
            "496565",
            "496631",
            "496632",
            "496633",
            "496636",
            "496638",
            "496641",
            "496642",
            "496644",
            "496646",
            "496649",
            "496659",
            "496661",
            "496666"});
            this.tbRn3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbRn3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbRn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRn3.Location = new System.Drawing.Point(70, 58);
            this.tbRn3.MaxLength = 25;
            this.tbRn3.Name = "tbRn3";
            this.tbRn3.Size = new System.Drawing.Size(80, 20);
            this.tbRn3.TabIndex = 4;
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
            this.tbMN.Location = new System.Drawing.Point(258, 32);
            this.tbMN.MaxLength = 4;
            this.tbMN.Name = "tbMN";
            this.tbMN.Size = new System.Drawing.Size(80, 20);
            this.tbMN.TabIndex = 3;
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
            this.tbMO.Location = new System.Drawing.Point(70, 32);
            this.tbMO.MaxLength = 4;
            this.tbMO.Name = "tbMO";
            this.tbMO.Size = new System.Drawing.Size(80, 20);
            this.tbMO.TabIndex = 2;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnSource);
            this.groupBox9.Controls.Add(this.tbSource);
            this.groupBox9.Location = new System.Drawing.Point(12, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(546, 70);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Path";
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(456, 27);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 23);
            this.btnSource.TabIndex = 1;
            this.btnSource.Text = "Source";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // tbSource
            // 
            this.tbSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSource.Location = new System.Drawing.Point(18, 29);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(425, 20);
            this.tbSource.TabIndex = 0;
            // 
            // btnModify
            // 
            this.btnModify.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnModify.Location = new System.Drawing.Point(257, 455);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 23;
            this.btnModify.Text = "Modify";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 541);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.groupBox18);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Compare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compare";
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbRate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbAnType;
        private System.Windows.Forms.TextBox tbAnH;
        private System.Windows.Forms.TextBox tbAnNum;
        private System.Windows.Forms.TextBox tbRn3;
        private System.Windows.Forms.TextBox tbMN;
        private System.Windows.Forms.TextBox tbMO;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logg;
    }
}