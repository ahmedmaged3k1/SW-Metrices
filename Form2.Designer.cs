namespace SW_Metrices
{
    partial class Form2
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
            this.Title = new System.Windows.Forms.Label();
            this.EIF_lbl = new System.Windows.Forms.Label();
            this.ILF_lbl = new System.Windows.Forms.Label();
            this.EI_lbl = new System.Windows.Forms.Label();
            this.EO_lbl = new System.Windows.Forms.Label();
            this.EInquiry_lbl = new System.Windows.Forms.Label();
            this.Simple_lbl = new System.Windows.Forms.Label();
            this.Average_lbl = new System.Windows.Forms.Label();
            this.Complex_lbl = new System.Windows.Forms.Label();
            this.External_Interface_simple = new System.Windows.Forms.TextBox();
            this.External_Interface_Average = new System.Windows.Forms.TextBox();
            this.External_Interface_Complex = new System.Windows.Forms.TextBox();
            this.Internal_Logical_Simple = new System.Windows.Forms.TextBox();
            this.Internal_Logical_Average = new System.Windows.Forms.TextBox();
            this.Internal_Logical_Complex = new System.Windows.Forms.TextBox();
            this.External_Input_Simple = new System.Windows.Forms.TextBox();
            this.External_Input_Average = new System.Windows.Forms.TextBox();
            this.External_Input_Complex = new System.Windows.Forms.TextBox();
            this.External_Output_Simple = new System.Windows.Forms.TextBox();
            this.External_Output_Average = new System.Windows.Forms.TextBox();
            this.External_Output_Complex = new System.Windows.Forms.TextBox();
            this.External_Inquiry_Simple = new System.Windows.Forms.TextBox();
            this.External_Inquiry_Average = new System.Windows.Forms.TextBox();
            this.External_Inquiry_Complex = new System.Windows.Forms.TextBox();
            this.UFP_btn = new System.Windows.Forms.Button();
            this.TCF_btn = new System.Windows.Forms.Button();
            this.Answer_lbl = new System.Windows.Forms.Label();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Title.Location = new System.Drawing.Point(122, 52);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(404, 36);
            this.Title.TabIndex = 0;
            this.Title.Text = "Enter the following value:";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // EIF_lbl
            // 
            this.EIF_lbl.AutoSize = true;
            this.EIF_lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EIF_lbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EIF_lbl.Location = new System.Drawing.Point(57, 166);
            this.EIF_lbl.Name = "EIF_lbl";
            this.EIF_lbl.Size = new System.Drawing.Size(208, 21);
            this.EIF_lbl.TabIndex = 1;
            this.EIF_lbl.Text = "External Interface Files";
            this.EIF_lbl.Click += new System.EventHandler(this.EIF_lbl_Click);
            // 
            // ILF_lbl
            // 
            this.ILF_lbl.AutoSize = true;
            this.ILF_lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ILF_lbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ILF_lbl.Location = new System.Drawing.Point(57, 210);
            this.ILF_lbl.Name = "ILF_lbl";
            this.ILF_lbl.Size = new System.Drawing.Size(180, 21);
            this.ILF_lbl.TabIndex = 2;
            this.ILF_lbl.Text = "Internal Logical File";
            this.ILF_lbl.Click += new System.EventHandler(this.ILF_lbl_Click);
            // 
            // EI_lbl
            // 
            this.EI_lbl.AutoSize = true;
            this.EI_lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EI_lbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EI_lbl.Location = new System.Drawing.Point(57, 261);
            this.EI_lbl.Name = "EI_lbl";
            this.EI_lbl.Size = new System.Drawing.Size(133, 21);
            this.EI_lbl.TabIndex = 3;
            this.EI_lbl.Text = "External Input";
            // 
            // EO_lbl
            // 
            this.EO_lbl.AutoSize = true;
            this.EO_lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EO_lbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EO_lbl.Location = new System.Drawing.Point(57, 310);
            this.EO_lbl.Name = "EO_lbl";
            this.EO_lbl.Size = new System.Drawing.Size(145, 21);
            this.EO_lbl.TabIndex = 4;
            this.EO_lbl.Text = "External Output";
            this.EO_lbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // EInquiry_lbl
            // 
            this.EInquiry_lbl.AutoSize = true;
            this.EInquiry_lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EInquiry_lbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EInquiry_lbl.Location = new System.Drawing.Point(57, 359);
            this.EInquiry_lbl.Name = "EInquiry_lbl";
            this.EInquiry_lbl.Size = new System.Drawing.Size(148, 21);
            this.EInquiry_lbl.TabIndex = 5;
            this.EInquiry_lbl.Text = "External Inquiry";
            // 
            // Simple_lbl
            // 
            this.Simple_lbl.AutoSize = true;
            this.Simple_lbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Simple_lbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Simple_lbl.Location = new System.Drawing.Point(331, 119);
            this.Simple_lbl.Name = "Simple_lbl";
            this.Simple_lbl.Size = new System.Drawing.Size(59, 18);
            this.Simple_lbl.TabIndex = 6;
            this.Simple_lbl.Text = "Simple";
            // 
            // Average_lbl
            // 
            this.Average_lbl.AutoSize = true;
            this.Average_lbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Average_lbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Average_lbl.Location = new System.Drawing.Point(508, 119);
            this.Average_lbl.Name = "Average_lbl";
            this.Average_lbl.Size = new System.Drawing.Size(70, 18);
            this.Average_lbl.TabIndex = 7;
            this.Average_lbl.Text = "Average";
            // 
            // Complex_lbl
            // 
            this.Complex_lbl.AutoSize = true;
            this.Complex_lbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complex_lbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Complex_lbl.Location = new System.Drawing.Point(681, 119);
            this.Complex_lbl.Name = "Complex_lbl";
            this.Complex_lbl.Size = new System.Drawing.Size(72, 18);
            this.Complex_lbl.TabIndex = 8;
            this.Complex_lbl.Text = "Complex";
            // 
            // External_Interface_simple
            // 
            this.External_Interface_simple.Location = new System.Drawing.Point(334, 164);
            this.External_Interface_simple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.External_Interface_simple.Name = "External_Interface_simple";
            this.External_Interface_simple.Size = new System.Drawing.Size(89, 22);
            this.External_Interface_simple.TabIndex = 9;
            this.External_Interface_simple.TextChanged += new System.EventHandler(this.External_Interface_simple_TextChanged);
            // 
            // External_Interface_Average
            // 
            this.External_Interface_Average.Location = new System.Drawing.Point(512, 164);
            this.External_Interface_Average.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.External_Interface_Average.Name = "External_Interface_Average";
            this.External_Interface_Average.Size = new System.Drawing.Size(89, 22);
            this.External_Interface_Average.TabIndex = 10;
            this.External_Interface_Average.TextChanged += new System.EventHandler(this.External_Interface_Average_TextChanged);
            // 
            // External_Interface_Complex
            // 
            this.External_Interface_Complex.Location = new System.Drawing.Point(684, 164);
            this.External_Interface_Complex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.External_Interface_Complex.Name = "External_Interface_Complex";
            this.External_Interface_Complex.Size = new System.Drawing.Size(89, 22);
            this.External_Interface_Complex.TabIndex = 11;
            this.External_Interface_Complex.TextChanged += new System.EventHandler(this.External_Interface_Complex_TextChanged);
            // 
            // Internal_Logical_Simple
            // 
            this.Internal_Logical_Simple.Location = new System.Drawing.Point(334, 209);
            this.Internal_Logical_Simple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Internal_Logical_Simple.Name = "Internal_Logical_Simple";
            this.Internal_Logical_Simple.Size = new System.Drawing.Size(89, 22);
            this.Internal_Logical_Simple.TabIndex = 12;
            // 
            // Internal_Logical_Average
            // 
            this.Internal_Logical_Average.Location = new System.Drawing.Point(512, 211);
            this.Internal_Logical_Average.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Internal_Logical_Average.Name = "Internal_Logical_Average";
            this.Internal_Logical_Average.Size = new System.Drawing.Size(89, 22);
            this.Internal_Logical_Average.TabIndex = 13;
            // 
            // Internal_Logical_Complex
            // 
            this.Internal_Logical_Complex.Location = new System.Drawing.Point(684, 209);
            this.Internal_Logical_Complex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Internal_Logical_Complex.Name = "Internal_Logical_Complex";
            this.Internal_Logical_Complex.Size = new System.Drawing.Size(89, 22);
            this.Internal_Logical_Complex.TabIndex = 14;
            // 
            // External_Input_Simple
            // 
            this.External_Input_Simple.Location = new System.Drawing.Point(334, 259);
            this.External_Input_Simple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.External_Input_Simple.Name = "External_Input_Simple";
            this.External_Input_Simple.Size = new System.Drawing.Size(89, 22);
            this.External_Input_Simple.TabIndex = 15;
            // 
            // External_Input_Average
            // 
            this.External_Input_Average.Location = new System.Drawing.Point(512, 259);
            this.External_Input_Average.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.External_Input_Average.Name = "External_Input_Average";
            this.External_Input_Average.Size = new System.Drawing.Size(89, 22);
            this.External_Input_Average.TabIndex = 16;
            // 
            // External_Input_Complex
            // 
            this.External_Input_Complex.Location = new System.Drawing.Point(684, 259);
            this.External_Input_Complex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.External_Input_Complex.Name = "External_Input_Complex";
            this.External_Input_Complex.Size = new System.Drawing.Size(89, 22);
            this.External_Input_Complex.TabIndex = 17;
            // 
            // External_Output_Simple
            // 
            this.External_Output_Simple.Location = new System.Drawing.Point(334, 308);
            this.External_Output_Simple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.External_Output_Simple.Name = "External_Output_Simple";
            this.External_Output_Simple.Size = new System.Drawing.Size(89, 22);
            this.External_Output_Simple.TabIndex = 18;
            // 
            // External_Output_Average
            // 
            this.External_Output_Average.Location = new System.Drawing.Point(512, 308);
            this.External_Output_Average.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.External_Output_Average.Name = "External_Output_Average";
            this.External_Output_Average.Size = new System.Drawing.Size(89, 22);
            this.External_Output_Average.TabIndex = 19;
            // 
            // External_Output_Complex
            // 
            this.External_Output_Complex.Location = new System.Drawing.Point(684, 308);
            this.External_Output_Complex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.External_Output_Complex.Name = "External_Output_Complex";
            this.External_Output_Complex.Size = new System.Drawing.Size(89, 22);
            this.External_Output_Complex.TabIndex = 20;
            // 
            // External_Inquiry_Simple
            // 
            this.External_Inquiry_Simple.Location = new System.Drawing.Point(334, 358);
            this.External_Inquiry_Simple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.External_Inquiry_Simple.Name = "External_Inquiry_Simple";
            this.External_Inquiry_Simple.Size = new System.Drawing.Size(89, 22);
            this.External_Inquiry_Simple.TabIndex = 21;
            // 
            // External_Inquiry_Average
            // 
            this.External_Inquiry_Average.Location = new System.Drawing.Point(512, 358);
            this.External_Inquiry_Average.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.External_Inquiry_Average.Name = "External_Inquiry_Average";
            this.External_Inquiry_Average.Size = new System.Drawing.Size(89, 22);
            this.External_Inquiry_Average.TabIndex = 22;
            // 
            // External_Inquiry_Complex
            // 
            this.External_Inquiry_Complex.Location = new System.Drawing.Point(684, 358);
            this.External_Inquiry_Complex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.External_Inquiry_Complex.Name = "External_Inquiry_Complex";
            this.External_Inquiry_Complex.Size = new System.Drawing.Size(89, 22);
            this.External_Inquiry_Complex.TabIndex = 23;
            // 
            // UFP_btn
            // 
            this.UFP_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.UFP_btn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UFP_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UFP_btn.Location = new System.Drawing.Point(52, 433);
            this.UFP_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UFP_btn.Name = "UFP_btn";
            this.UFP_btn.Size = new System.Drawing.Size(162, 47);
            this.UFP_btn.TabIndex = 24;
            this.UFP_btn.Text = "Calculate UFP";
            this.UFP_btn.UseVisualStyleBackColor = false;
            this.UFP_btn.Click += new System.EventHandler(this.UFP_btn_Click);
            // 
            // TCF_btn
            // 
            this.TCF_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.TCF_btn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCF_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TCF_btn.Location = new System.Drawing.Point(720, 522);
            this.TCF_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TCF_btn.Name = "TCF_btn";
            this.TCF_btn.Size = new System.Drawing.Size(130, 46);
            this.TCF_btn.TabIndex = 25;
            this.TCF_btn.Text = "To Calculate TCF";
            this.TCF_btn.UseVisualStyleBackColor = false;
            this.TCF_btn.Click += new System.EventHandler(this.TCF_btn_Click);
            // 
            // Answer_lbl
            // 
            this.Answer_lbl.AutoSize = true;
            this.Answer_lbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Answer_lbl.Location = new System.Drawing.Point(236, 442);
            this.Answer_lbl.Name = "Answer_lbl";
            this.Answer_lbl.Size = new System.Drawing.Size(42, 24);
            this.Answer_lbl.TabIndex = 26;
            this.Answer_lbl.Text = "<<";
            this.Answer_lbl.Click += new System.EventHandler(this.Answer_lbl_Click);
            // 
            // Reset_btn
            // 
            this.Reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.Reset_btn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reset_btn.Location = new System.Drawing.Point(52, 510);
            this.Reset_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(162, 49);
            this.Reset_btn.TabIndex = 27;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = false;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SW_Metrices.Properties.Resources.sticker_4;
            this.pictureBox1.Location = new System.Drawing.Point(20, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(870, 596);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Answer_lbl);
            this.Controls.Add(this.TCF_btn);
            this.Controls.Add(this.UFP_btn);
            this.Controls.Add(this.External_Inquiry_Complex);
            this.Controls.Add(this.External_Inquiry_Average);
            this.Controls.Add(this.External_Inquiry_Simple);
            this.Controls.Add(this.External_Output_Complex);
            this.Controls.Add(this.External_Output_Average);
            this.Controls.Add(this.External_Output_Simple);
            this.Controls.Add(this.External_Input_Complex);
            this.Controls.Add(this.External_Input_Average);
            this.Controls.Add(this.External_Input_Simple);
            this.Controls.Add(this.Internal_Logical_Complex);
            this.Controls.Add(this.Internal_Logical_Average);
            this.Controls.Add(this.Internal_Logical_Simple);
            this.Controls.Add(this.External_Interface_Complex);
            this.Controls.Add(this.External_Interface_Average);
            this.Controls.Add(this.External_Interface_simple);
            this.Controls.Add(this.Complex_lbl);
            this.Controls.Add(this.Average_lbl);
            this.Controls.Add(this.Simple_lbl);
            this.Controls.Add(this.EInquiry_lbl);
            this.Controls.Add(this.EO_lbl);
            this.Controls.Add(this.EI_lbl);
            this.Controls.Add(this.ILF_lbl);
            this.Controls.Add(this.EIF_lbl);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FP Calculator";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label EIF_lbl;
        private System.Windows.Forms.Label ILF_lbl;
        private System.Windows.Forms.Label EI_lbl;
        private System.Windows.Forms.Label EO_lbl;
        private System.Windows.Forms.Label EInquiry_lbl;
        private System.Windows.Forms.Label Simple_lbl;
        private System.Windows.Forms.Label Average_lbl;
        private System.Windows.Forms.Label Complex_lbl;
        private System.Windows.Forms.TextBox External_Interface_simple;
        private System.Windows.Forms.TextBox External_Interface_Average;
        private System.Windows.Forms.TextBox External_Interface_Complex;
        private System.Windows.Forms.TextBox Internal_Logical_Simple;
        private System.Windows.Forms.TextBox Internal_Logical_Average;
        private System.Windows.Forms.TextBox Internal_Logical_Complex;
        private System.Windows.Forms.TextBox External_Input_Simple;
        private System.Windows.Forms.TextBox External_Input_Average;
        private System.Windows.Forms.TextBox External_Input_Complex;
        private System.Windows.Forms.TextBox External_Output_Simple;
        private System.Windows.Forms.TextBox External_Output_Average;
        private System.Windows.Forms.TextBox External_Output_Complex;
        private System.Windows.Forms.TextBox External_Inquiry_Simple;
        private System.Windows.Forms.TextBox External_Inquiry_Average;
        private System.Windows.Forms.TextBox External_Inquiry_Complex;
        private System.Windows.Forms.Button UFP_btn;
        private System.Windows.Forms.Button TCF_btn;
        private System.Windows.Forms.Label Answer_lbl;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}