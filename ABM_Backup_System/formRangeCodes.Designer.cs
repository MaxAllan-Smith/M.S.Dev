namespace ABM_Backup_System
{
    partial class formRangeCodes
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
            this.toolStripButton_Add = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.listViewRangeCodes = new System.Windows.Forms.ListView();
            this.columnHeaderLno = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderRangeCode = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderRangeCodeDescription = new System.Windows.Forms.ColumnHeader();
            this.panelUserInput = new System.Windows.Forms.Panel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxRangeCode = new System.Windows.Forms.TextBox();
            this.labelRangeCode = new System.Windows.Forms.Label();
            this.toolStrip_BottomMenu.SuspendLayout();
            this.panelUserInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_BottomMenu
            // 
            this.toolStrip_BottomMenu.AutoSize = false;
            this.toolStrip_BottomMenu.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip_BottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip_BottomMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_BottomMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Exit,
            this.toolStripSeparator1,
            this.toolStripButton_Help,
            this.toolStripSeparator2,
            this.toolStripButton_Add,
            this.toolStripSeparator4});
            this.toolStrip_BottomMenu.Location = new System.Drawing.Point(10, 495);
            this.toolStrip_BottomMenu.Name = "toolStrip_BottomMenu";
            this.toolStrip_BottomMenu.Size = new System.Drawing.Size(540, 76);
            this.toolStrip_BottomMenu.TabIndex = 25;
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
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 76);
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
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 76);
            // 
            // toolStripButton_Add
            // 
            this.toolStripButton_Add.AutoSize = false;
            this.toolStripButton_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripButton_Add.Image = global::ABM_Backup_System.Properties.Resources.OK;
            this.toolStripButton_Add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Add.Name = "toolStripButton_Add";
            this.toolStripButton_Add.Size = new System.Drawing.Size(50, 61);
            this.toolStripButton_Add.Text = "Add";
            this.toolStripButton_Add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Add.Click += new System.EventHandler(this.toolStripButton_Add_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 76);
            // 
            // listViewRangeCodes
            // 
            this.listViewRangeCodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLno,
            this.columnHeaderRangeCode,
            this.columnHeaderRangeCodeDescription});
            this.listViewRangeCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRangeCodes.FullRowSelect = true;
            this.listViewRangeCodes.GridLines = true;
            this.listViewRangeCodes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRangeCodes.Location = new System.Drawing.Point(10, 10);
            this.listViewRangeCodes.Name = "listViewRangeCodes";
            this.listViewRangeCodes.Size = new System.Drawing.Size(540, 485);
            this.listViewRangeCodes.TabIndex = 26;
            this.listViewRangeCodes.UseCompatibleStateImageBehavior = false;
            this.listViewRangeCodes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderLno
            // 
            this.columnHeaderLno.Text = "Lno";
            this.columnHeaderLno.Width = 50;
            // 
            // columnHeaderRangeCode
            // 
            this.columnHeaderRangeCode.Text = "Range Code";
            this.columnHeaderRangeCode.Width = 100;
            // 
            // columnHeaderRangeCodeDescription
            // 
            this.columnHeaderRangeCodeDescription.Text = "Description";
            this.columnHeaderRangeCodeDescription.Width = 376;
            // 
            // panelUserInput
            // 
            this.panelUserInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUserInput.Controls.Add(this.textBoxDescription);
            this.panelUserInput.Controls.Add(this.labelDescription);
            this.panelUserInput.Controls.Add(this.textBoxRangeCode);
            this.panelUserInput.Controls.Add(this.labelRangeCode);
            this.panelUserInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUserInput.Location = new System.Drawing.Point(10, 435);
            this.panelUserInput.Name = "panelUserInput";
            this.panelUserInput.Size = new System.Drawing.Size(540, 60);
            this.panelUserInput.TabIndex = 27;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(154, 23);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(340, 23);
            this.textBoxDescription.TabIndex = 3;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(154, 5);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(67, 15);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description";
            // 
            // textBoxRangeCode
            // 
            this.textBoxRangeCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxRangeCode.Location = new System.Drawing.Point(46, 23);
            this.textBoxRangeCode.Name = "textBoxRangeCode";
            this.textBoxRangeCode.Size = new System.Drawing.Size(92, 23);
            this.textBoxRangeCode.TabIndex = 1;
            this.textBoxRangeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRangeCode
            // 
            this.labelRangeCode.AutoSize = true;
            this.labelRangeCode.Location = new System.Drawing.Point(46, 5);
            this.labelRangeCode.Name = "labelRangeCode";
            this.labelRangeCode.Size = new System.Drawing.Size(71, 15);
            this.labelRangeCode.TabIndex = 0;
            this.labelRangeCode.Text = "Range Code";
            // 
            // formRangeCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 581);
            this.Controls.Add(this.panelUserInput);
            this.Controls.Add(this.listViewRangeCodes);
            this.Controls.Add(this.toolStrip_BottomMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formRangeCodes";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formRangeCodes";
            this.Load += new System.EventHandler(this.formRangeCodes_Load);
            this.toolStrip_BottomMenu.ResumeLayout(false);
            this.toolStrip_BottomMenu.PerformLayout();
            this.panelUserInput.ResumeLayout(false);
            this.panelUserInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStrip toolStrip_BottomMenu;
        private ToolStripButton toolStripButton_Exit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton_Help;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton_Add;
        private ToolStripSeparator toolStripSeparator4;
        private ListView listViewRangeCodes;
        private ColumnHeader columnHeaderLno;
        private ColumnHeader columnHeaderRangeCode;
        private ColumnHeader columnHeaderRangeCodeDescription;
        private Panel panelUserInput;
        private TextBox textBoxDescription;
        private Label labelDescription;
        private TextBox textBoxRangeCode;
        private Label labelRangeCode;
    }
}