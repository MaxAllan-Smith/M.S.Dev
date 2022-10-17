namespace ABM_Backup_System
{
    partial class formLogin
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
            this.toolStrip_BottomMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Help = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Login = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Cancel = new System.Windows.Forms.ToolStripButton();
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.toolStrip_BottomMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_BottomMenu
            // 
            this.toolStrip_BottomMenu.AutoSize = false;
            this.toolStrip_BottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip_BottomMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_BottomMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Exit,
            this.toolStripSeparator1,
            this.toolStripButton_Help,
            this.toolStripSeparator2,
            this.toolStripButton_Login,
            this.toolStripButton_Cancel});
            this.toolStrip_BottomMenu.Location = new System.Drawing.Point(0, 215);
            this.toolStrip_BottomMenu.Name = "toolStrip_BottomMenu";
            this.toolStrip_BottomMenu.Size = new System.Drawing.Size(390, 72);
            this.toolStrip_BottomMenu.TabIndex = 22;
            this.toolStrip_BottomMenu.Text = "toolStrip1";
            // 
            // toolStripButton_Exit
            // 
            this.toolStripButton_Exit.AutoSize = false;
            this.toolStripButton_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripButton_Exit.Image = global::ABM_Backup_System.Properties.Resources.Exit;
            this.toolStripButton_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Exit.Name = "toolStripButton_Exit";
            this.toolStripButton_Exit.Size = new System.Drawing.Size(50, 61);
            this.toolStripButton_Exit.Text = "Exit";
            this.toolStripButton_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Exit.Click += new System.EventHandler(this.toolStripButton_Exit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripButton_Help
            // 
            this.toolStripButton_Help.AutoSize = false;
            this.toolStripButton_Help.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripButton_Help.Image = global::ABM_Backup_System.Properties.Resources.question_mark;
            this.toolStripButton_Help.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Help.Name = "toolStripButton_Help";
            this.toolStripButton_Help.Size = new System.Drawing.Size(50, 61);
            this.toolStripButton_Help.Text = "Help";
            this.toolStripButton_Help.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripButton_Login
            // 
            this.toolStripButton_Login.AutoSize = false;
            this.toolStripButton_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripButton_Login.Image = global::ABM_Backup_System.Properties.Resources.OK;
            this.toolStripButton_Login.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Login.Name = "toolStripButton_Login";
            this.toolStripButton_Login.Size = new System.Drawing.Size(50, 61);
            this.toolStripButton_Login.Text = "Login";
            this.toolStripButton_Login.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Login.ToolTipText = "Login";
            this.toolStripButton_Login.Click += new System.EventHandler(this.toolStripButton_Login_Click);
            // 
            // toolStripButton_Cancel
            // 
            this.toolStripButton_Cancel.AutoSize = false;
            this.toolStripButton_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripButton_Cancel.Image = global::ABM_Backup_System.Properties.Resources.Cancel;
            this.toolStripButton_Cancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Cancel.Name = "toolStripButton_Cancel";
            this.toolStripButton_Cancel.Size = new System.Drawing.Size(50, 61);
            this.toolStripButton_Cancel.Text = "Cancel";
            this.toolStripButton_Cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(60, 45);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(72, 17);
            this.label_Username.TabIndex = 23;
            this.label_Username.Text = "Username:";
            // 
            // textBox_Username
            // 
            this.textBox_Username.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_Username.Location = new System.Drawing.Point(60, 65);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(273, 25);
            this.textBox_Username.TabIndex = 24;
            this.textBox_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Username_KeyDown);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(60, 123);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(273, 25);
            this.textBox_Password.TabIndex = 26;
            this.textBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Password_KeyDown);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(60, 103);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(69, 17);
            this.label_Password.TabIndex = 25;
            this.label_Password.Text = "Password:";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 287);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.toolStrip_BottomMenu);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formLogin_FormClosing);
            this.toolStrip_BottomMenu.ResumeLayout(false);
            this.toolStrip_BottomMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip_BottomMenu;
        private ToolStripButton toolStripButton_Exit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton_Help;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton_Cancel;
        private Label label_Username;
        private TextBox textBox_Username;
        private TextBox textBox_Password;
        private Label label_Password;
        private ToolStripButton toolStripButton_Login;
    }
}