namespace Reception
{
    partial class CashFrm
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
            this.btncorrect = new System.Windows.Forms.Button();
            this.btnrec = new System.Windows.Forms.Button();
            this.btnendShidt = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Number";
            // 
            // txtcashID
            // 
            this.txtcashID.Location = new System.Drawing.Point(66, 21);
            this.txtcashID.Name = "txtcashID";
            this.txtcashID.Size = new System.Drawing.Size(100, 20);
            this.txtcashID.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "UserID";
            // 
            // TXTuserID
            // 
            this.TXTuserID.Location = new System.Drawing.Point(66, 47);
            this.TXTuserID.Name = "TXTuserID";
            this.TXTuserID.Size = new System.Drawing.Size(100, 20);
            this.TXTuserID.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Amount";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(66, 73);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(100, 20);
            this.txtamount.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 66;
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
            this.ComboShiftId.Location = new System.Drawing.Point(66, 99);
            this.ComboShiftId.Name = "ComboShiftId";
            this.ComboShiftId.Size = new System.Drawing.Size(56, 21);
            this.ComboShiftId.Sorted = true;
            this.ComboShiftId.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Discription";
            // 
            // txtDiscript
            // 
            this.txtDiscript.Location = new System.Drawing.Point(66, 126);
            this.txtDiscript.Multiline = true;
            this.txtDiscript.Name = "txtDiscript";
            this.txtDiscript.Size = new System.Drawing.Size(157, 103);
            this.txtDiscript.TabIndex = 67;
            // 
            // btncorrect
            // 
            this.btncorrect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncorrect.BackgroundImage = global::Reception.Properties.Resources.Edit;
            this.btncorrect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncorrect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncorrect.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncorrect.Location = new System.Drawing.Point(268, 200);
            this.btncorrect.Name = "btncorrect";
            this.btncorrect.Size = new System.Drawing.Size(87, 52);
            this.btncorrect.TabIndex = 74;
            this.btncorrect.UseVisualStyleBackColor = false;
            this.btncorrect.Click += new System.EventHandler(this.btncorrect_Click);
            // 
            // btnrec
            // 
            this.btnrec.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnrec.BackgroundImage = global::Reception.Properties.Resources.application;
            this.btnrec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnrec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnrec.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrec.Location = new System.Drawing.Point(268, 148);
            this.btnrec.Name = "btnrec";
            this.btnrec.Size = new System.Drawing.Size(87, 46);
            this.btnrec.TabIndex = 73;
            this.btnrec.UseVisualStyleBackColor = false;
            this.btnrec.Click += new System.EventHandler(this.btnrec_Click);
            // 
            // btnendShidt
            // 
            this.btnendShidt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnendShidt.BackgroundImage = global::Reception.Properties.Resources.Delete__1_;
            this.btnendShidt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnendShidt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnendShidt.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnendShidt.Location = new System.Drawing.Point(268, 34);
            this.btnendShidt.Name = "btnendShidt";
            this.btnendShidt.Size = new System.Drawing.Size(87, 52);
            this.btnendShidt.TabIndex = 72;
            this.btnendShidt.UseVisualStyleBackColor = false;
            this.btnendShidt.Click += new System.EventHandler(this.btnendShidt_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReport.BackgroundImage = global::Reception.Properties.Resources.Report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReport.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(268, 90);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(87, 52);
            this.btnReport.TabIndex = 71;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClose.BackgroundImage = global::Reception.Properties.Resources.Close;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(268, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(87, 32);
            this.BtnClose.TabIndex = 70;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CashFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(385, 287);
            this.Controls.Add(this.btncorrect);
            this.Controls.Add(this.btnrec);
            this.Controls.Add(this.btnendShidt);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.BtnClose);
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
            this.Name = "CashFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash";
            this.Load += new System.EventHandler(this.CashFrm_Load);
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
        private System.Windows.Forms.Button btncorrect;
        private System.Windows.Forms.Button btnrec;
        private System.Windows.Forms.Button btnendShidt;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button BtnClose;
    }
}