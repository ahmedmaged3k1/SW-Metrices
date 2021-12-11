namespace SW_Metrices
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FP_Calculation_btn = new System.Windows.Forms.Button();
            this.UFP_Valu_lbl = new System.Windows.Forms.Label();
            this.TCF_Value_lbl = new System.Windows.Forms.Label();
            this.FP_value_lbl = new System.Windows.Forms.Label();
            this.LOC_Value_lbl = new System.Windows.Forms.Label();
            this.UFP_Answer_lbl = new System.Windows.Forms.Label();
            this.TCF_Answer_lbl = new System.Windows.Forms.Label();
            this.FP_Answer_lbl = new System.Windows.Forms.Label();
            this.LOC_Answer_lbl = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(162, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the AVC value :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Assembly Language",
            "C",
            "COBQL/Fortran",
            "Pascal",
            "Ada",
            "C++",
            "Visual Basic",
            "Object Oriented Languages",
            "Smalltalk",
            "Code Generator (power Builder",
            "SQL/Oracle",
            "Spreadsheets",
            "Graphical Languages (Icons)"});
            this.comboBox1.Location = new System.Drawing.Point(68, 134);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(484, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FP_Calculation_btn
            // 
            this.FP_Calculation_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.FP_Calculation_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FP_Calculation_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FP_Calculation_btn.Location = new System.Drawing.Point(606, 114);
            this.FP_Calculation_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FP_Calculation_btn.Name = "FP_Calculation_btn";
            this.FP_Calculation_btn.Size = new System.Drawing.Size(188, 54);
            this.FP_Calculation_btn.TabIndex = 3;
            this.FP_Calculation_btn.Text = "Calculate FP";
            this.FP_Calculation_btn.UseVisualStyleBackColor = false;
            this.FP_Calculation_btn.Click += new System.EventHandler(this.FP_Calculation_btn_Click);
            // 
            // UFP_Valu_lbl
            // 
            this.UFP_Valu_lbl.AutoSize = true;
            this.UFP_Valu_lbl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UFP_Valu_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UFP_Valu_lbl.Location = new System.Drawing.Point(65, 240);
            this.UFP_Valu_lbl.Name = "UFP_Valu_lbl";
            this.UFP_Valu_lbl.Size = new System.Drawing.Size(150, 29);
            this.UFP_Valu_lbl.TabIndex = 4;
            this.UFP_Valu_lbl.Text = "UFP Value :";
            // 
            // TCF_Value_lbl
            // 
            this.TCF_Value_lbl.AutoSize = true;
            this.TCF_Value_lbl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCF_Value_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TCF_Value_lbl.Location = new System.Drawing.Point(65, 302);
            this.TCF_Value_lbl.Name = "TCF_Value_lbl";
            this.TCF_Value_lbl.Size = new System.Drawing.Size(147, 29);
            this.TCF_Value_lbl.TabIndex = 5;
            this.TCF_Value_lbl.Text = "TCF Value :";
            // 
            // FP_value_lbl
            // 
            this.FP_value_lbl.AutoSize = true;
            this.FP_value_lbl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FP_value_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FP_value_lbl.Location = new System.Drawing.Point(65, 366);
            this.FP_value_lbl.Name = "FP_value_lbl";
            this.FP_value_lbl.Size = new System.Drawing.Size(132, 29);
            this.FP_value_lbl.TabIndex = 6;
            this.FP_value_lbl.Text = "FP Value :";
            // 
            // LOC_Value_lbl
            // 
            this.LOC_Value_lbl.AutoSize = true;
            this.LOC_Value_lbl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOC_Value_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LOC_Value_lbl.Location = new System.Drawing.Point(62, 430);
            this.LOC_Value_lbl.Name = "LOC_Value_lbl";
            this.LOC_Value_lbl.Size = new System.Drawing.Size(150, 29);
            this.LOC_Value_lbl.TabIndex = 7;
            this.LOC_Value_lbl.Text = "LOC Value :";
            this.LOC_Value_lbl.Click += new System.EventHandler(this.LOC_Value_lbl_Click);
            // 
            // UFP_Answer_lbl
            // 
            this.UFP_Answer_lbl.AutoSize = true;
            this.UFP_Answer_lbl.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UFP_Answer_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UFP_Answer_lbl.Location = new System.Drawing.Point(276, 240);
            this.UFP_Answer_lbl.Name = "UFP_Answer_lbl";
            this.UFP_Answer_lbl.Size = new System.Drawing.Size(37, 33);
            this.UFP_Answer_lbl.TabIndex = 8;
            this.UFP_Answer_lbl.Text = "<<";
            this.UFP_Answer_lbl.Click += new System.EventHandler(this.UFP_Answer_lbl_Click);
            // 
            // TCF_Answer_lbl
            // 
            this.TCF_Answer_lbl.AutoSize = true;
            this.TCF_Answer_lbl.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCF_Answer_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TCF_Answer_lbl.Location = new System.Drawing.Point(276, 302);
            this.TCF_Answer_lbl.Name = "TCF_Answer_lbl";
            this.TCF_Answer_lbl.Size = new System.Drawing.Size(37, 33);
            this.TCF_Answer_lbl.TabIndex = 9;
            this.TCF_Answer_lbl.Text = "<<";
            // 
            // FP_Answer_lbl
            // 
            this.FP_Answer_lbl.AutoSize = true;
            this.FP_Answer_lbl.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FP_Answer_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FP_Answer_lbl.Location = new System.Drawing.Point(276, 366);
            this.FP_Answer_lbl.Name = "FP_Answer_lbl";
            this.FP_Answer_lbl.Size = new System.Drawing.Size(37, 33);
            this.FP_Answer_lbl.TabIndex = 10;
            this.FP_Answer_lbl.Text = "<<";
            // 
            // LOC_Answer_lbl
            // 
            this.LOC_Answer_lbl.AutoSize = true;
            this.LOC_Answer_lbl.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOC_Answer_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LOC_Answer_lbl.Location = new System.Drawing.Point(276, 426);
            this.LOC_Answer_lbl.Name = "LOC_Answer_lbl";
            this.LOC_Answer_lbl.Size = new System.Drawing.Size(37, 33);
            this.LOC_Answer_lbl.TabIndex = 11;
            this.LOC_Answer_lbl.Text = "<<";
            this.LOC_Answer_lbl.Click += new System.EventHandler(this.LOC_Answer_lbl_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.Exit_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit_btn.Location = new System.Drawing.Point(370, 509);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(112, 65);
            this.Exit_btn.TabIndex = 12;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SW_Metrices.Properties.Resources.sticker_4;
            this.pictureBox1.Location = new System.Drawing.Point(60, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(871, 595);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.LOC_Answer_lbl);
            this.Controls.Add(this.FP_Answer_lbl);
            this.Controls.Add(this.TCF_Answer_lbl);
            this.Controls.Add(this.UFP_Answer_lbl);
            this.Controls.Add(this.LOC_Value_lbl);
            this.Controls.Add(this.FP_value_lbl);
            this.Controls.Add(this.TCF_Value_lbl);
            this.Controls.Add(this.UFP_Valu_lbl);
            this.Controls.Add(this.FP_Calculation_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FP Calculator";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FP_Calculation_btn;
        private System.Windows.Forms.Label UFP_Valu_lbl;
        private System.Windows.Forms.Label TCF_Value_lbl;
        private System.Windows.Forms.Label FP_value_lbl;
        private System.Windows.Forms.Label LOC_Value_lbl;
        private System.Windows.Forms.Label UFP_Answer_lbl;
        private System.Windows.Forms.Label TCF_Answer_lbl;
        private System.Windows.Forms.Label FP_Answer_lbl;
        private System.Windows.Forms.Label LOC_Answer_lbl;
        private System.Windows.Forms.Button Exit_btn;
    }
}