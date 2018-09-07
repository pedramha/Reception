namespace Reception
{
    partial class DiscountFrm
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
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
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtdisamnt = new System.Windows.Forms.TextBox();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClose.BackgroundImage = global::Reception.Properties.Resources.Close;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(387, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(59, 39);
            this.BtnClose.TabIndex = 77;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsearch.BackgroundImage = global::Reception.Properties.Resources.Search;
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsearch.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(294, 185);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(122, 74);
            this.btnsearch.TabIndex = 76;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLast);
            this.groupBox3.Controls.Add(this.btnFirst);
            this.groupBox3.Controls.Add(this.btnprev);
            this.groupBox3.Controls.Add(this.btnnext);
            this.groupBox3.Location = new System.Drawing.Point(15, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 74);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Move";
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLast.BackgroundImage = global::Reception.Properties.Resources.button_black_last;
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLast.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(192, 19);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(56, 39);
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
            this.btnFirst.Location = new System.Drawing.Point(6, 19);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(56, 39);
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
            this.btnprev.Location = new System.Drawing.Point(68, 19);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(56, 39);
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
            this.btnnext.Location = new System.Drawing.Point(130, 19);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(56, 39);
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
            this.groupBox2.Location = new System.Drawing.Point(294, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 141);
            this.groupBox2.TabIndex = 74;
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
            this.btnNew.Size = new System.Drawing.Size(64, 47);
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
            this.btnInsert.Location = new System.Drawing.Point(6, 79);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(64, 49);
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
            this.BtnEdit.Location = new System.Drawing.Point(76, 79);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(64, 49);
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
            this.btndel.Size = new System.Drawing.Size(64, 47);
            this.btndel.TabIndex = 29;
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Discount Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Discount ID";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(110, 63);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(159, 90);
            this.txtdesc.TabIndex = 70;
            // 
            // txtdisamnt
            // 
            this.txtdisamnt.Location = new System.Drawing.Point(110, 39);
            this.txtdisamnt.Name = "txtdisamnt";
            this.txtdisamnt.Size = new System.Drawing.Size(100, 20);
            this.txtdisamnt.TabIndex = 69;
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(110, 13);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(100, 20);
            this.TXTID.TabIndex = 68;
            // 
            // DiscountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(466, 309);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtdisamnt);
            this.Controls.Add(this.TXTID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DiscountFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discount";
            this.Load += new System.EventHandler(this.DiscountFrm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
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
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtdisamnt;
        private System.Windows.Forms.TextBox TXTID;
    }
}