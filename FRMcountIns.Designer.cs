namespace Reception
{
    partial class FRMcountIns
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtinsname = new System.Windows.Forms.TextBox();
            this.txtinscountid = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Country Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Country ID";
            // 
            // txtinsname
            // 
            this.txtinsname.Location = new System.Drawing.Point(92, 38);
            this.txtinsname.Name = "txtinsname";
            this.txtinsname.Size = new System.Drawing.Size(100, 20);
            this.txtinsname.TabIndex = 37;
            // 
            // txtinscountid
            // 
            this.txtinscountid.Location = new System.Drawing.Point(92, 12);
            this.txtinscountid.Name = "txtinscountid";
            this.txtinscountid.Size = new System.Drawing.Size(100, 20);
            this.txtinscountid.TabIndex = 36;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.BackgroundImage = global::Reception.Properties.Resources.add;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsert.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(42, 64);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(67, 37);
            this.btnInsert.TabIndex = 41;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndel.BackgroundImage = global::Reception.Properties.Resources.Close;
            this.btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(113, 64);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(68, 37);
            this.btndel.TabIndex = 40;
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // FRMcountIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(202, 122);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtinsname);
            this.Controls.Add(this.txtinscountid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMcountIns";
            this.Text = "Countries";
            this.Load += new System.EventHandler(this.FRMcountIns_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtinsname;
        private System.Windows.Forms.TextBox txtinscountid;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btndel;
    }
}