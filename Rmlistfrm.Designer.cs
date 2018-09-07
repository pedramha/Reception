namespace Reception
{
    partial class Rmlistfrm
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
            this.ID = new System.Windows.Forms.Label();
            this.txtroomnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsitnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newbtn = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.editBTN = new System.Windows.Forms.Button();
            this.FirstBtn = new System.Windows.Forms.Button();
            this.LastBTN = new System.Windows.Forms.Button();
            this.prevbtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.rmcondition = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(10, 28);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(35, 13);
            this.ID.TabIndex = 22;
            this.ID.Text = "Room";
            // 
            // txtroomnumber
            // 
            this.txtroomnumber.Location = new System.Drawing.Point(103, 28);
            this.txtroomnumber.Name = "txtroomnumber";
            this.txtroomnumber.Size = new System.Drawing.Size(207, 20);
            this.txtroomnumber.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Type";
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(103, 54);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(207, 20);
            this.txttype.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Situation Number";
            // 
            // txtsitnum
            // 
            this.txtsitnum.Location = new System.Drawing.Point(103, 80);
            this.txtsitnum.Name = "txtsitnum";
            this.txtsitnum.Size = new System.Drawing.Size(207, 20);
            this.txtsitnum.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Price Overnight";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(103, 106);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(207, 20);
            this.txtprice.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FirstBtn);
            this.groupBox1.Controls.Add(this.LastBTN);
            this.groupBox1.Controls.Add(this.prevbtn);
            this.groupBox1.Controls.Add(this.nextbtn);
            this.groupBox1.Location = new System.Drawing.Point(13, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 142);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newbtn);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.deletebtn);
            this.groupBox2.Controls.Add(this.editBTN);
            this.groupBox2.Location = new System.Drawing.Point(245, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 142);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modify DataBase";
            // 
            // newbtn
            // 
            this.newbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newbtn.BackgroundImage = global::Reception.Properties.Resources.New;
            this.newbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newbtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbtn.Location = new System.Drawing.Point(6, 19);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(74, 50);
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
            this.btnInsert.Location = new System.Drawing.Point(6, 75);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(74, 54);
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
            this.deletebtn.Location = new System.Drawing.Point(97, 15);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(74, 54);
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
            this.editBTN.Location = new System.Drawing.Point(97, 75);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(74, 50);
            this.editBTN.TabIndex = 20;
            this.editBTN.UseVisualStyleBackColor = false;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // FirstBtn
            // 
            this.FirstBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstBtn.BackgroundImage = global::Reception.Properties.Resources.button_black_first;
            this.FirstBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FirstBtn.Location = new System.Drawing.Point(6, 79);
            this.FirstBtn.Name = "FirstBtn";
            this.FirstBtn.Size = new System.Drawing.Size(68, 54);
            this.FirstBtn.TabIndex = 20;
            this.FirstBtn.UseVisualStyleBackColor = false;
            this.FirstBtn.Click += new System.EventHandler(this.FirstBtn_Click);
            // 
            // LastBTN
            // 
            this.LastBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LastBTN.BackgroundImage = global::Reception.Properties.Resources.button_black_last;
            this.LastBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LastBTN.Location = new System.Drawing.Point(80, 79);
            this.LastBTN.Name = "LastBTN";
            this.LastBTN.Size = new System.Drawing.Size(69, 54);
            this.LastBTN.TabIndex = 19;
            this.LastBTN.UseVisualStyleBackColor = false;
            this.LastBTN.Click += new System.EventHandler(this.LastBTN_Click);
            // 
            // prevbtn
            // 
            this.prevbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prevbtn.BackgroundImage = global::Reception.Properties.Resources.Previous;
            this.prevbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.prevbtn.Location = new System.Drawing.Point(6, 19);
            this.prevbtn.Name = "prevbtn";
            this.prevbtn.Size = new System.Drawing.Size(68, 54);
            this.prevbtn.TabIndex = 18;
            this.prevbtn.UseVisualStyleBackColor = false;
            this.prevbtn.Click += new System.EventHandler(this.prevbtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nextbtn.BackgroundImage = global::Reception.Properties.Resources.Next;
            this.nextbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextbtn.Location = new System.Drawing.Point(80, 19);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(69, 54);
            this.nextbtn.TabIndex = 17;
            this.nextbtn.UseVisualStyleBackColor = false;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // rmcondition
            // 
            this.rmcondition.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rmcondition.BackgroundImage = global::Reception.Properties.Resources.application;
            this.rmcondition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rmcondition.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmcondition.Location = new System.Drawing.Point(337, 26);
            this.rmcondition.Name = "rmcondition";
            this.rmcondition.Size = new System.Drawing.Size(85, 100);
            this.rmcondition.TabIndex = 29;
            this.rmcondition.UseVisualStyleBackColor = false;
            this.rmcondition.Click += new System.EventHandler(this.rmcondition_Click);
            // 
            // Rmlistfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(439, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rmcondition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsitnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtroomnumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Rmlistfrm";
            this.Text = "Rooms List";
            this.Load += new System.EventHandler(this.Rmlistfrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtroomnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsitnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button rmcondition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FirstBtn;
        private System.Windows.Forms.Button LastBTN;
        private System.Windows.Forms.Button prevbtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editBTN;
    }
}