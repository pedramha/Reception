namespace Reception
{
    partial class Login
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.Enterbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(87, 48);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(143, 20);
            this.txtPass.TabIndex = 5;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(88, 25);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(143, 20);
            this.txtUser.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "UserName";
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelbtn.BackgroundImage = global::Reception.Properties.Resources.Close;
            this.cancelbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.Location = new System.Drawing.Point(156, 90);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 45);
            this.cancelbtn.TabIndex = 9;
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // Enterbtn
            // 
            this.Enterbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enterbtn.BackgroundImage = global::Reception.Properties.Resources.Window_Enter;
            this.Enterbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Enterbtn.Location = new System.Drawing.Point(28, 90);
            this.Enterbtn.Name = "Enterbtn";
            this.Enterbtn.Size = new System.Drawing.Size(75, 45);
            this.Enterbtn.TabIndex = 8;
            this.Enterbtn.UseVisualStyleBackColor = false;
            this.Enterbtn.Click += new System.EventHandler(this.Enterbtn_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.Enterbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.CancelButton = this.cancelbtn;
            this.ClientSize = new System.Drawing.Size(264, 168);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.Enterbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button Enterbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
    }
}

