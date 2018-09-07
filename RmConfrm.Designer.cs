namespace Reception
{
    partial class RmConfrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtrmcon = new System.Windows.Forms.TextBox();
            this.TxtromID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Condition";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Room Number";
            // 
            // Txtrmcon
            // 
            this.Txtrmcon.Location = new System.Drawing.Point(93, 48);
            this.Txtrmcon.Name = "Txtrmcon";
            this.Txtrmcon.Size = new System.Drawing.Size(100, 20);
            this.Txtrmcon.TabIndex = 25;
            // 
            // TxtromID
            // 
            this.TxtromID.Location = new System.Drawing.Point(93, 12);
            this.TxtromID.Name = "TxtromID";
            this.TxtromID.Size = new System.Drawing.Size(100, 20);
            this.TxtromID.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.BtnEdit);
            this.groupBox2.Controls.Add(this.btndel);
            this.groupBox2.Location = new System.Drawing.Point(227, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 136);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit DataBase";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNew.BackgroundImage = global::Reception.Properties.Resources.New;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNew.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(6, 26);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(64, 46);
            this.btnNew.TabIndex = 31;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImage = global::Reception.Properties.Resources.add;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 46);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEdit.BackgroundImage = global::Reception.Properties.Resources.Edit;
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEdit.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(76, 78);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(64, 46);
            this.BtnEdit.TabIndex = 30;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndel.BackgroundImage = global::Reception.Properties.Resources.Delete;
            this.btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(76, 26);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(64, 46);
            this.btndel.TabIndex = 29;
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLast);
            this.groupBox3.Controls.Add(this.btnFirst);
            this.groupBox3.Controls.Add(this.btnprev);
            this.groupBox3.Controls.Add(this.btnnext);
            this.groupBox3.Location = new System.Drawing.Point(15, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 136);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Move";
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLast.BackgroundImage = global::Reception.Properties.Resources.button_black_last;
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLast.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(83, 75);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(62, 50);
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
            this.btnFirst.Location = new System.Drawing.Point(15, 75);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(62, 50);
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
            this.btnprev.Size = new System.Drawing.Size(62, 50);
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
            this.btnnext.Location = new System.Drawing.Point(83, 19);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(62, 50);
            this.btnnext.TabIndex = 35;
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClose.BackgroundImage = global::Reception.Properties.Resources.Close;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(319, -3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(58, 47);
            this.BtnClose.TabIndex = 40;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // RmConfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(387, 236);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtrmcon);
            this.Controls.Add(this.TxtromID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RmConfrm";
            this.Text = "Room Condition";
            this.Load += new System.EventHandler(this.RmConfrm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtrmcon;
        private System.Windows.Forms.TextBox TxtromID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button BtnClose;
    }
}