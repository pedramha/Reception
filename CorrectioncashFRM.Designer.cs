namespace Reception
{
    partial class CorrectioncashFRM
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
            this.txtcashID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTuserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboShiftId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiscript = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Number";
            // 
            // txtcashID
            // 
            this.txtcashID.Location = new System.Drawing.Point(63, 25);
            this.txtcashID.Name = "txtcashID";
            this.txtcashID.Size = new System.Drawing.Size(100, 20);
            this.txtcashID.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "UserID";
            // 
            // TXTuserID
            // 
            this.TXTuserID.Location = new System.Drawing.Point(63, 66);
            this.TXTuserID.Name = "TXTuserID";
            this.TXTuserID.Size = new System.Drawing.Size(100, 20);
            this.TXTuserID.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Amount";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(63, 102);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(100, 20);
            this.txtamount.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "ShiftID";
            // 
            // ComboShiftId
            // 
            this.ComboShiftId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboShiftId.FormattingEnabled = true;
            this.ComboShiftId.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ComboShiftId.Location = new System.Drawing.Point(63, 128);
            this.ComboShiftId.Name = "ComboShiftId";
            this.ComboShiftId.Size = new System.Drawing.Size(56, 21);
            this.ComboShiftId.Sorted = true;
            this.ComboShiftId.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Discription";
            // 
            // txtDiscript
            // 
            this.txtDiscript.Location = new System.Drawing.Point(63, 164);
            this.txtDiscript.Multiline = true;
            this.txtDiscript.Name = "txtDiscript";
            this.txtDiscript.Size = new System.Drawing.Size(157, 103);
            this.txtDiscript.TabIndex = 79;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEdit.BackgroundImage = global::Reception.Properties.Resources.Edit;
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEdit.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(241, 31);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(85, 55);
            this.BtnEdit.TabIndex = 82;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndel.BackgroundImage = global::Reception.Properties.Resources.Delete;
            this.btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(332, 31);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(85, 55);
            this.btndel.TabIndex = 81;
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLast);
            this.groupBox3.Controls.Add(this.btnFirst);
            this.groupBox3.Controls.Add(this.btnprev);
            this.groupBox3.Controls.Add(this.btnnext);
            this.groupBox3.Location = new System.Drawing.Point(245, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 135);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Move";
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLast.BackgroundImage = global::Reception.Properties.Resources.button_black_last;
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLast.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(91, 73);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(70, 48);
            this.btnLast.TabIndex = 36;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFirst.BackgroundImage = global::Reception.Properties.Resources.button_black_first;
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFirst.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(15, 73);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(70, 48);
            this.btnFirst.TabIndex = 33;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnprev
            // 
            this.btnprev.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnprev.BackgroundImage = global::Reception.Properties.Resources.Previous;
            this.btnprev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnprev.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprev.Location = new System.Drawing.Point(15, 19);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(70, 48);
            this.btnprev.TabIndex = 34;
            this.btnprev.UseVisualStyleBackColor = false;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnnext.BackgroundImage = global::Reception.Properties.Resources.Next;
            this.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnnext.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.Location = new System.Drawing.Point(91, 19);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(70, 48);
            this.btnnext.TabIndex = 35;
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // CorrectioncashFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(457, 301);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiscript);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboShiftId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTuserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcashID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CorrectioncashFRM";
            this.Text = "Correction";
            this.Load += new System.EventHandler(this.CorrectioncashFRM_Load);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcashID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTuserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboShiftId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiscript;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
    }
}