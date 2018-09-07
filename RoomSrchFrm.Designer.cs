namespace Reception
{
    partial class RoomSrchFrm
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtsitnmb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.txtrmnumb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "By Situation Number";
            // 
            // txtsitnmb
            // 
            this.txtsitnmb.Location = new System.Drawing.Point(117, 103);
            this.txtsitnmb.Name = "txtsitnmb";
            this.txtsitnmb.Size = new System.Drawing.Size(86, 20);
            this.txtsitnmb.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "By Price";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(117, 77);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(86, 20);
            this.txtprice.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "By Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "ByRoom Number";
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(117, 51);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(86, 20);
            this.txttype.TabIndex = 53;
            // 
            // txtrmnumb
            // 
            this.txtrmnumb.Location = new System.Drawing.Point(117, 25);
            this.txtrmnumb.Name = "txtrmnumb";
            this.txtrmnumb.Size = new System.Drawing.Size(86, 20);
            this.txtrmnumb.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 360);
            this.dataGridView1.TabIndex = 62;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtrmnumb);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txttype);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.txtsitnmb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 217);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.BackgroundImage = global::Reception.Properties.Resources.Search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(23, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 63);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClose.BackgroundImage = global::Reception.Properties.Resources.Close;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(12, 307);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(66, 52);
            this.BtnClose.TabIndex = 60;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "SEARCH ROOMS";
            // 
            // RoomSrchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(718, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RoomSrchFrm";
            this.Text = "Room Search";
            this.Load += new System.EventHandler(this.RoomSrchFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsitnmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.TextBox txtrmnumb;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
    }
}