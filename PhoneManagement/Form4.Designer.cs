namespace PhoneManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cname = new System.Windows.Forms.TextBox();
            this.btn_Cadd = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Csurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Ccompany = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Cinsert_user = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxP = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCC = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(97, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // txt_Cname
            // 
            this.txt_Cname.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Cname.Location = new System.Drawing.Point(102, 103);
            this.txt_Cname.Name = "txt_Cname";
            this.txt_Cname.Size = new System.Drawing.Size(518, 34);
            this.txt_Cname.TabIndex = 0;
            // 
            // btn_Cadd
            // 
            this.btn_Cadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btn_Cadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Cadd.ForeColor = System.Drawing.Color.White;
            this.btn_Cadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cadd.ImageKey = "(none)";
            this.btn_Cadd.Location = new System.Drawing.Point(101, 607);
            this.btn_Cadd.Name = "btn_Cadd";
            this.btn_Cadd.Size = new System.Drawing.Size(521, 57);
            this.btn_Cadd.TabIndex = 7;
            this.btn_Cadd.Text = "Add";
            this.btn_Cadd.UseVisualStyleBackColor = false;
            this.btn_Cadd.Click += new System.EventHandler(this.btn_Cadd_Click);
            this.btn_Cadd.MouseEnter += new System.EventHandler(this.btn_Cadd_MouseEnter);
            this.btn_Cadd.MouseLeave += new System.EventHandler(this.btn_Cadd_MouseLeave);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "back.png");
            this.imageList1.Images.SetKeyName(1, "undo.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(97, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "SURNAME";
            // 
            // txt_Csurname
            // 
            this.txt_Csurname.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Csurname.Location = new System.Drawing.Point(102, 168);
            this.txt_Csurname.Name = "txt_Csurname";
            this.txt_Csurname.Size = new System.Drawing.Size(518, 34);
            this.txt_Csurname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(97, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "COMPANY";
            // 
            // txt_Ccompany
            // 
            this.txt_Ccompany.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Ccompany.Location = new System.Drawing.Point(101, 243);
            this.txt_Ccompany.Name = "txt_Ccompany";
            this.txt_Ccompany.Size = new System.Drawing.Size(518, 34);
            this.txt_Ccompany.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(98, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "COUNTRY CODE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(98, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "PREFIX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(98, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "NUMBER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(98, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "INSERT USER";
            // 
            // txt_Cinsert_user
            // 
            this.txt_Cinsert_user.Enabled = false;
            this.txt_Cinsert_user.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Cinsert_user.Location = new System.Drawing.Point(102, 552);
            this.txt_Cinsert_user.Name = "txt_Cinsert_user";
            this.txt_Cinsert_user.Size = new System.Drawing.Size(518, 34);
            this.txt_Cinsert_user.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ImageKey = "undo.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(694, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 49);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.maskedTextBox1.Location = new System.Drawing.Point(103, 474);
            this.maskedTextBox1.Mask = "000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(518, 34);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // maskedTextBoxP
            // 
            this.maskedTextBoxP.ForeColor = System.Drawing.SystemColors.GrayText;
            this.maskedTextBoxP.Location = new System.Drawing.Point(102, 396);
            this.maskedTextBoxP.Mask = "(999)";
            this.maskedTextBoxP.Name = "maskedTextBoxP";
            this.maskedTextBoxP.Size = new System.Drawing.Size(517, 34);
            this.maskedTextBoxP.TabIndex = 4;
            // 
            // maskedTextBoxCC
            // 
            this.maskedTextBoxCC.ForeColor = System.Drawing.SystemColors.GrayText;
            this.maskedTextBoxCC.Location = new System.Drawing.Point(101, 316);
            this.maskedTextBoxCC.Mask = "(999)";
            this.maskedTextBoxCC.Name = "maskedTextBoxCC";
            this.maskedTextBoxCC.Size = new System.Drawing.Size(517, 34);
            this.maskedTextBoxCC.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(257, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "Add new Contact";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 692);
            this.Controls.Add(this.maskedTextBoxP);
            this.Controls.Add(this.maskedTextBoxCC);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Cadd);
            this.Controls.Add(this.txt_Cinsert_user);
            this.Controls.Add(this.txt_Ccompany);
            this.Controls.Add(this.txt_Csurname);
            this.Controls.Add(this.txt_Cname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cname;
        private System.Windows.Forms.Button btn_Cadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Csurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Ccompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxP;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxCC;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_Cinsert_user;
    }
}