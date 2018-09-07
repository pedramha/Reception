namespace Reception
{
    partial class FrmReciept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReciept));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtpernight = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txttotalp = new System.Windows.Forms.TextBox();
            this.TxtRecieptNu = new System.Windows.Forms.TextBox();
            this.TxtGName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRnumb = new System.Windows.Forms.TextBox();
            this.CountryCode = new System.Windows.Forms.Label();
            this.comboUserID = new System.Windows.Forms.ComboBox();
            this.txttax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboUsedservId = new System.Windows.Forms.ComboBox();
            this.comboDisId = new System.Windows.Forms.ComboBox();
            this.txtgcardID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtstadur = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnrep = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtpernight);
            this.groupBox1.Controls.Add(this.txtdiscount);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btncalc);
            this.groupBox1.Controls.Add(this.txttotalp);
            this.groupBox1.Location = new System.Drawing.Point(341, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 202);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "Discount Amount";
            // 
            // txtpernight
            // 
            this.txtpernight.Location = new System.Drawing.Point(96, 45);
            this.txtpernight.Name = "txtpernight";
            this.txtpernight.Size = new System.Drawing.Size(100, 20);
            this.txtpernight.TabIndex = 71;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(96, 18);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(100, 20);
            this.txtdiscount.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Price Per Night";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Total Price";
            // 
            // txttotalp
            // 
            this.txttotalp.Location = new System.Drawing.Point(96, 73);
            this.txttotalp.Name = "txttotalp";
            this.txttotalp.Size = new System.Drawing.Size(100, 20);
            this.txttotalp.TabIndex = 67;
            // 
            // TxtRecieptNu
            // 
            this.TxtRecieptNu.Location = new System.Drawing.Point(102, 46);
            this.TxtRecieptNu.Name = "TxtRecieptNu";
            this.TxtRecieptNu.Size = new System.Drawing.Size(100, 20);
            this.TxtRecieptNu.TabIndex = 76;
            // 
            // TxtGName
            // 
            this.TxtGName.Location = new System.Drawing.Point(102, 79);
            this.TxtGName.Name = "TxtGName";
            this.TxtGName.Size = new System.Drawing.Size(100, 20);
            this.TxtGName.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Reciept Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Guest Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Room Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Used Service ID";
            // 
            // txtRnumb
            // 
            this.txtRnumb.Location = new System.Drawing.Point(102, 112);
            this.txtRnumb.Name = "txtRnumb";
            this.txtRnumb.Size = new System.Drawing.Size(100, 20);
            this.txtRnumb.TabIndex = 82;
            // 
            // CountryCode
            // 
            this.CountryCode.AutoSize = true;
            this.CountryCode.Location = new System.Drawing.Point(12, 145);
            this.CountryCode.Name = "CountryCode";
            this.CountryCode.Size = new System.Drawing.Size(40, 13);
            this.CountryCode.TabIndex = 83;
            this.CountryCode.Text = "UserID";
            // 
            // comboUserID
            // 
            this.comboUserID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboUserID.FormattingEnabled = true;
            this.comboUserID.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboUserID.Location = new System.Drawing.Point(102, 145);
            this.comboUserID.Name = "comboUserID";
            this.comboUserID.Size = new System.Drawing.Size(100, 21);
            this.comboUserID.TabIndex = 84;
            // 
            // txttax
            // 
            this.txttax.Location = new System.Drawing.Point(102, 247);
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(100, 20);
            this.txttax.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Discount ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Tax";
            // 
            // comboUsedservId
            // 
            this.comboUsedservId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboUsedservId.FormattingEnabled = true;
            this.comboUsedservId.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboUsedservId.Location = new System.Drawing.Point(102, 179);
            this.comboUsedservId.Name = "comboUsedservId";
            this.comboUsedservId.Size = new System.Drawing.Size(100, 21);
            this.comboUsedservId.TabIndex = 90;
            // 
            // comboDisId
            // 
            this.comboDisId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboDisId.FormattingEnabled = true;
            this.comboDisId.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboDisId.Location = new System.Drawing.Point(102, 213);
            this.comboDisId.Name = "comboDisId";
            this.comboDisId.Size = new System.Drawing.Size(100, 21);
            this.comboDisId.TabIndex = 91;
            // 
            // txtgcardID
            // 
            this.txtgcardID.Location = new System.Drawing.Point(102, 19);
            this.txtgcardID.Name = "txtgcardID";
            this.txtgcardID.Size = new System.Drawing.Size(100, 20);
            this.txtgcardID.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "Guest ID";
            // 
            // txtstadur
            // 
            this.txtstadur.Location = new System.Drawing.Point(102, 280);
            this.txtstadur.Name = "txtstadur";
            this.txtstadur.Size = new System.Drawing.Size(100, 20);
            this.txtstadur.TabIndex = 98;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 99;
            this.label10.Text = "Stay Duration";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(502, 1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(50, 34);
            this.btnclose.TabIndex = 103;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndel.BackgroundImage")));
            this.btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(208, 274);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(68, 46);
            this.btndel.TabIndex = 102;
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnrep
            // 
            this.btnrep.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnrep.BackgroundImage = global::Reception.Properties.Resources.Report;
            this.btnrep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnrep.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrep.Location = new System.Drawing.Point(433, 247);
            this.btnrep.Name = "btnrep";
            this.btnrep.Size = new System.Drawing.Size(104, 72);
            this.btnrep.TabIndex = 101;
            this.btnrep.UseVisualStyleBackColor = false;
            this.btnrep.Click += new System.EventHandler(this.btnrep_Click);
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalc.BackgroundImage = global::Reception.Properties.Resources.Calculater2_Black_and_Gold;
            this.btncalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncalc.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(92, 99);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(104, 93);
            this.btncalc.TabIndex = 66;
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnnew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnew.BackgroundImage")));
            this.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnew.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(208, 85);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(68, 46);
            this.btnnew.TabIndex = 97;
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnload.BackgroundImage")));
            this.btnload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnload.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(208, 22);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(68, 46);
            this.btnload.TabIndex = 96;
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnedit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnedit.BackgroundImage")));
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnedit.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(208, 211);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(68, 46);
            this.btnedit.TabIndex = 95;
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(208, 148);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(68, 46);
            this.btnInsert.TabIndex = 92;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // FrmReciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(569, 337);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnrep);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtstadur);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtgcardID);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.comboDisId);
            this.Controls.Add(this.comboUsedservId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttax);
            this.Controls.Add(this.comboUserID);
            this.Controls.Add(this.CountryCode);
            this.Controls.Add(this.txtRnumb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtGName);
            this.Controls.Add(this.TxtRecieptNu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReciept";
            this.Text = "Reciept";
            this.Load += new System.EventHandler(this.FrmReciept_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnrep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtpernight;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.TextBox txttotalp;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox TxtRecieptNu;
        private System.Windows.Forms.TextBox TxtGName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRnumb;
        private System.Windows.Forms.Label CountryCode;
        private System.Windows.Forms.ComboBox comboUserID;
        private System.Windows.Forms.TextBox txttax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboUsedservId;
        private System.Windows.Forms.ComboBox comboDisId;
        private System.Windows.Forms.TextBox txtgcardID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtstadur;
        private System.Windows.Forms.Label label10;
    }
}