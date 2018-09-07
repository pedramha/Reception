namespace Reception
{
    partial class UserFRM
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
            this.ComboShift = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newbtn = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.editBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FirstBtn = new System.Windows.Forms.Button();
            this.LastBTN = new System.Windows.Forms.Button();
            this.prevbtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnRep = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboShift
            // 
            this.ComboShift.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboShift.FormattingEnabled = true;
            this.ComboShift.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ComboShift.Location = new System.Drawing.Point(77, 152);
            this.ComboShift.Name = "ComboShift";
            this.ComboShift.Size = new System.Drawing.Size(59, 21);
            this.ComboShift.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newbtn);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.deletebtn);
            this.groupBox2.Controls.Add(this.editBTN);
            this.groupBox2.Location = new System.Drawing.Point(314, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 147);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modify DataBase";
            // 
            // newbtn
            // 
            this.newbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newbtn.BackgroundImage = global::Reception.Properties.Resources.New;
            this.newbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newbtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbtn.Location = new System.Drawing.Point(11, 20);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(79, 53);
            this.newbtn.TabIndex = 22;
            this.newbtn.UseVisualStyleBackColor = false;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.BackgroundImage = global::Reception.Properties.Resources.add;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsert.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(11, 79);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(79, 56);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deletebtn.BackgroundImage = global::Reception.Properties.Resources.Delete;
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deletebtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(124, 77);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(70, 58);
            this.deletebtn.TabIndex = 21;
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // editBTN
            // 
            this.editBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editBTN.BackgroundImage = global::Reception.Properties.Resources.Edit;
            this.editBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editBTN.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBTN.Location = new System.Drawing.Point(124, 20);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(70, 53);
            this.editBTN.TabIndex = 20;
            this.editBTN.UseVisualStyleBackColor = false;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FirstBtn);
            this.groupBox1.Controls.Add(this.LastBTN);
            this.groupBox1.Controls.Add(this.prevbtn);
            this.groupBox1.Controls.Add(this.nextbtn);
            this.groupBox1.Location = new System.Drawing.Point(25, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 87);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // FirstBtn
            // 
            this.FirstBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstBtn.BackgroundImage = global::Reception.Properties.Resources.button_black_first;
            this.FirstBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FirstBtn.Location = new System.Drawing.Point(15, 22);
            this.FirstBtn.Name = "FirstBtn";
            this.FirstBtn.Size = new System.Drawing.Size(54, 45);
            this.FirstBtn.TabIndex = 20;
            this.FirstBtn.UseVisualStyleBackColor = false;
            this.FirstBtn.Click += new System.EventHandler(this.FirstBtn_Click);
            // 
            // LastBTN
            // 
            this.LastBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LastBTN.BackgroundImage = global::Reception.Properties.Resources.button_black_last;
            this.LastBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LastBTN.Location = new System.Drawing.Point(186, 22);
            this.LastBTN.Name = "LastBTN";
            this.LastBTN.Size = new System.Drawing.Size(59, 45);
            this.LastBTN.TabIndex = 19;
            this.LastBTN.UseVisualStyleBackColor = false;
            this.LastBTN.Click += new System.EventHandler(this.LastBTN_Click);
            // 
            // prevbtn
            // 
            this.prevbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prevbtn.BackgroundImage = global::Reception.Properties.Resources.Previous;
            this.prevbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.prevbtn.Location = new System.Drawing.Point(75, 22);
            this.prevbtn.Name = "prevbtn";
            this.prevbtn.Size = new System.Drawing.Size(49, 45);
            this.prevbtn.TabIndex = 18;
            this.prevbtn.UseVisualStyleBackColor = false;
            this.prevbtn.Click += new System.EventHandler(this.prevbtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nextbtn.BackgroundImage = global::Reception.Properties.Resources.Next;
            this.nextbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextbtn.Location = new System.Drawing.Point(130, 22);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(50, 45);
            this.nextbtn.TabIndex = 17;
            this.nextbtn.UseVisualStyleBackColor = false;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "ShiftID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Name";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(7, 15);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(64, 13);
            this.ID.TabIndex = 30;
            this.ID.Text = "EmployeeID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(77, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(207, 20);
            this.textBox4.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 20);
            this.textBox3.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 26;
            // 
            // BtnRep
            // 
            this.BtnRep.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRep.BackgroundImage = global::Reception.Properties.Resources.Report;
            this.BtnRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRep.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRep.Location = new System.Drawing.Point(314, 63);
            this.BtnRep.Name = "BtnRep";
            this.BtnRep.Size = new System.Drawing.Size(97, 74);
            this.BtnRep.TabIndex = 38;
            this.BtnRep.UseVisualStyleBackColor = false;
            this.BtnRep.Click += new System.EventHandler(this.BtnRep_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClose.BackgroundImage = global::Reception.Properties.Resources.Close;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(454, -2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(64, 44);
            this.BtnClose.TabIndex = 25;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // UserFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(535, 317);
            this.Controls.Add(this.BtnRep);
            this.Controls.Add(this.ComboShift);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserFRM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "r";
            this.Load += new System.EventHandler(this.UserFRM_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRep;
        private System.Windows.Forms.ComboBox ComboShift;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FirstBtn;
        private System.Windows.Forms.Button LastBTN;
        private System.Windows.Forms.Button prevbtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnClose;
    }
}