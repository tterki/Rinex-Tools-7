namespace Rinex_Tools_7
{
    partial class Crinex
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSource = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.check_Z = new System.Windows.Forms.CheckBox();
            this.radio_CRXtoRNX = new System.Windows.Forms.RadioButton();
            this.radio_RNXtoCRX = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSource);
            this.groupBox1.Controls.Add(this.tbPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 56);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paths";
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(329, 19);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 23);
            this.btnSource.TabIndex = 1;
            this.btnSource.Text = "Source";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // tbPath
            // 
            this.tbPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbPath.Location = new System.Drawing.Point(18, 21);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(305, 20);
            this.tbPath.TabIndex = 0;
            // 
            // check_Z
            // 
            this.check_Z.AutoSize = true;
            this.check_Z.Enabled = false;
            this.check_Z.Location = new System.Drawing.Point(302, 21);
            this.check_Z.Name = "check_Z";
            this.check_Z.Size = new System.Drawing.Size(104, 17);
            this.check_Z.TabIndex = 18;
            this.check_Z.Text = "compression (.Z)";
            this.check_Z.UseVisualStyleBackColor = true;
            // 
            // radio_CRXtoRNX
            // 
            this.radio_CRXtoRNX.AutoSize = true;
            this.radio_CRXtoRNX.Checked = true;
            this.radio_CRXtoRNX.Location = new System.Drawing.Point(19, 20);
            this.radio_CRXtoRNX.Name = "radio_CRXtoRNX";
            this.radio_CRXtoRNX.Size = new System.Drawing.Size(85, 17);
            this.radio_CRXtoRNX.TabIndex = 19;
            this.radio_CRXtoRNX.TabStop = true;
            this.radio_CRXtoRNX.Text = "CRX to RNX";
            this.radio_CRXtoRNX.UseVisualStyleBackColor = true;
            this.radio_CRXtoRNX.CheckedChanged += new System.EventHandler(this.radio_CRXtoRNX_CheckedChanged);
            // 
            // radio_RNXtoCRX
            // 
            this.radio_RNXtoCRX.AutoSize = true;
            this.radio_RNXtoCRX.Location = new System.Drawing.Point(169, 19);
            this.radio_RNXtoCRX.Name = "radio_RNXtoCRX";
            this.radio_RNXtoCRX.Size = new System.Drawing.Size(85, 17);
            this.radio_RNXtoCRX.TabIndex = 20;
            this.radio_RNXtoCRX.Text = "RNX to CRX";
            this.radio_RNXtoCRX.UseVisualStyleBackColor = true;
            this.radio_RNXtoCRX.CheckedChanged += new System.EventHandler(this.radio_RNXtoCRX_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_RNXtoCRX);
            this.groupBox2.Controls.Add(this.check_Z);
            this.groupBox2.Controls.Add(this.radio_CRXtoRNX);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 54);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conversion";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.Location = new System.Drawing.Point(-1, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 20);
            this.textBox1.TabIndex = 2;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(-1, 182);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(452, 31);
            this.progress.TabIndex = 22;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(188, 134);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Crinex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 212);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Crinex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hatanaka conversion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.CheckBox check_Z;
        private System.Windows.Forms.RadioButton radio_CRXtoRNX;
        private System.Windows.Forms.RadioButton radio_RNXtoCRX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolTip toolTip;
    }
}