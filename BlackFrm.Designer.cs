namespace Reception
{
    partial class BlackFrm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtreason = new System.Windows.Forms.TextBox();
            this.txtnatID = new System.Windows.Forms.TextBox();
            this.TXTname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLast);
            this.groupBox3.Controls.Add(this.btnFirst);
            this.groupBox3.Controls.Add(this.btnprev);
            this.groupBox3.Controls.Add(this.btnnext);
            this.groupBox3.Location = new System.Drawing.Point(22, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 168);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Move";
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLast.BackgroundImage = global::Reception.Properties.Resources.button_black_last;
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLast.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(92, 86);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(77, 61);
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
            this.btnFirst.Location = new System.Drawing.Point(9, 86);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(77, 61);
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
            this.btnprev.Location = new System.Drawing.Point(9, 19);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(77, 61);
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
            this.btnnext.Location = new System.Drawing.Point(92, 19);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(77, 61);
            this.btnnext.TabIndex = 35;
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.BtnEdit);
            this.groupBox2.Controls.Add(this.btndel);
            this.groupBox2.Location = new System.Drawing.Point(246, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 169);
            this.groupBox2.TabIndex = 68;
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
            this.btnNew.Size = new System.Drawing.Size(94, 59);
            this.btnNew.TabIndex = 31;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.BackgroundImage = global::Reception.Properties.Resources.add;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsert.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(6, 91);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 59);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEdit.BackgroundImage = global::Reception.Properties.Resources.Edit;
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEdit.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(113, 91);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(94, 59);
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
            this.btndel.Location = new System.Drawing.Point(113, 26);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(94, 59);
            this.btndel.TabIndex = 29;
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Reason";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "National ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "GuestID";
            // 
            // txtreason
            // 
            this.txtreason.Location = new System.Drawing.Point(79, 86);
            this.txtreason.Multiline = true;
            this.txtreason.Name = "txtreason";
            this.txtreason.Size = new System.Drawing.Size(159, 90);
            this.txtreason.TabIndex = 63;
            // 
            // txtnatID
            // 
            this.txtnatID.Location = new System.Drawing.Point(79, 62);
            this.txtnatID.Name = "txtnatID";
            this.txtnatID.Size = new System.Drawing.Size(100, 20);
            this.txtnatID.TabIndex = 62;
            // 
            // TXTname
            // 
            this.TXTname.Location = new System.Drawing.Point(79, 36);
            this.TXTname.Name = "TXTname";
            this.TXTname.Size = new System.Drawing.Size(100, 20);
            this.TXTname.TabIndex = 61;
            this.TXTname.TextChanged += new System.EventHandler(this.TXTname_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(79, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 60;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsearch.BackgroundImage = global::Reception.Properties.Resources.Search;
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsearch.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(252, 10);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(128, 121);
            this.btnsearch.TabIndex = 70;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClose.BackgroundImage = global::Reception.Properties.Resources.Close;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(423, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(68, 41);
            this.BtnClose.TabIndex = 59;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BlackFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(490, 393);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtreason);
            this.Controls.Add(this.txtnatID);
            this.Controls.Add(this.TXTname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BlackFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black";
            this.Load += new System.EventHandler(this.BlackFrm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtreason;
        private System.Windows.Forms.TextBox txtnatID;
        private System.Windows.Forms.TextBox TXTname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button BtnClose;
    }
}