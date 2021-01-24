namespace Rinex_Tools_6
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.btn_rinex = new System.Windows.Forms.Button();
            this.btn_decimate = new System.Windows.Forms.Button();
            this.btn_compare = new System.Windows.Forms.Button();
            this.btn_merge = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_about = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Crinex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rinex
            // 
            this.btn_rinex.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rinex.Location = new System.Drawing.Point(10, 144);
            this.btn_rinex.Name = "btn_rinex";
            this.btn_rinex.Size = new System.Drawing.Size(120, 74);
            this.btn_rinex.TabIndex = 0;
            this.btn_rinex.Text = "MDB to Rinex";
            this.btn_rinex.UseVisualStyleBackColor = true;
            this.btn_rinex.Click += new System.EventHandler(this.btn_rinex_Click);
            this.btn_rinex.MouseHover += new System.EventHandler(this.btn_rinex_MouseHover);
            // 
            // btn_decimate
            // 
            this.btn_decimate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decimate.Location = new System.Drawing.Point(136, 224);
            this.btn_decimate.Name = "btn_decimate";
            this.btn_decimate.Size = new System.Drawing.Size(120, 74);
            this.btn_decimate.TabIndex = 1;
            this.btn_decimate.Text = "Decimate";
            this.btn_decimate.UseVisualStyleBackColor = true;
            this.btn_decimate.Click += new System.EventHandler(this.btn_decimate_Click);
            this.btn_decimate.MouseHover += new System.EventHandler(this.btn_decimate_MouseHover);
            // 
            // btn_compare
            // 
            this.btn_compare.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compare.Location = new System.Drawing.Point(10, 224);
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.Size = new System.Drawing.Size(120, 74);
            this.btn_compare.TabIndex = 2;
            this.btn_compare.Text = "Compare headers";
            this.btn_compare.UseVisualStyleBackColor = true;
            this.btn_compare.Click += new System.EventHandler(this.btn_compare_Click);
            this.btn_compare.MouseHover += new System.EventHandler(this.btn_compare_MouseHover_1);
            // 
            // btn_merge
            // 
            this.btn_merge.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_merge.Location = new System.Drawing.Point(136, 144);
            this.btn_merge.Name = "btn_merge";
            this.btn_merge.Size = new System.Drawing.Size(120, 74);
            this.btn_merge.TabIndex = 3;
            this.btn_merge.Text = "Concatenate";
            this.btn_merge.UseVisualStyleBackColor = true;
            this.btn_merge.Click += new System.EventHandler(this.btn_merge_Click);
            this.btn_merge.MouseHover += new System.EventHandler(this.btn_merge_MouseHover);
            // 
            // btn_sort
            // 
            this.btn_sort.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sort.Location = new System.Drawing.Point(10, 304);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(120, 74);
            this.btn_sort.TabIndex = 4;
            this.btn_sort.Text = "Sort Data";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            this.btn_sort.MouseHover += new System.EventHandler(this.btn_sort_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rinex Tools CRAAG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_about
            // 
            this.btn_about.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.Location = new System.Drawing.Point(201, 384);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(54, 27);
            this.btn_about.TabIndex = 6;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            this.btn_about.MouseHover += new System.EventHandler(this.btn_about_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Crinex
            // 
            this.btn_Crinex.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Crinex.Location = new System.Drawing.Point(135, 304);
            this.btn_Crinex.Name = "btn_Crinex";
            this.btn_Crinex.Size = new System.Drawing.Size(120, 74);
            this.btn_Crinex.TabIndex = 8;
            this.btn_Crinex.Text = "Crinex <=> Rinex";
            this.btn_Crinex.UseVisualStyleBackColor = true;
            this.btn_Crinex.Click += new System.EventHandler(this.btn_Crinex_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 418);
            this.Controls.Add(this.btn_Crinex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_merge);
            this.Controls.Add(this.btn_compare);
            this.Controls.Add(this.btn_decimate);
            this.Controls.Add(this.btn_rinex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rinex Tools CRAAG 7";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rinex;
        private System.Windows.Forms.Button btn_decimate;
        private System.Windows.Forms.Button btn_compare;
        private System.Windows.Forms.Button btn_merge;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Crinex;
    }
}