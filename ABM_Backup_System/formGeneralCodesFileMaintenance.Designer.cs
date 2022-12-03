namespace ABM_Backup_System
{
    partial class formGeneralCodesFileMaintenance
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Range Codes", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Opens Up The Ranges Codes Form.", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point))}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Product Codes", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Opens Up The Product Group Form.", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point))}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Credit Reason Codes", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Opens Up The Credit Reason Codes Form.", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point))}, -1);
            this.toolStrip_BottomMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Help = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_OK = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.listViewGeneralCodes = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDescription = new System.Windows.Forms.ColumnHeader();
            this.toolStrip_BottomMenu.SuspendLayout();
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
            this.toolStripButton_OK,
            this.toolStripSeparator4});
            this.toolStrip_BottomMenu.Location = new System.Drawing.Point(10, 478);
            this.toolStrip_BottomMenu.Name = "toolStrip_BottomMenu";
            this.toolStrip_BottomMenu.Size = new System.Drawing.Size(413, 76);
            this.toolStrip_BottomMenu.TabIndex = 24;
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
            // toolStripButton_OK
            // 
            this.toolStripButton_OK.AutoSize = false;
            this.toolStripButton_OK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripButton_OK.Image = global::ABM_Backup_System.Properties.Resources.OK;
            this.toolStripButton_OK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_OK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_OK.Name = "toolStripButton_OK";
            this.toolStripButton_OK.Size = new System.Drawing.Size(50, 61);
            this.toolStripButton_OK.Text = "OK";
            this.toolStripButton_OK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 76);
            // 
            // listViewGeneralCodes
            // 
            this.listViewGeneralCodes.BackColor = System.Drawing.Color.White;
            this.listViewGeneralCodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderDescription});
            this.listViewGeneralCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewGeneralCodes.FullRowSelect = true;
            this.listViewGeneralCodes.GridLines = true;
            this.listViewGeneralCodes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewGeneralCodes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listViewGeneralCodes.Location = new System.Drawing.Point(10, 10);
            this.listViewGeneralCodes.Name = "listViewGeneralCodes";
            this.listViewGeneralCodes.Size = new System.Drawing.Size(413, 468);
            this.listViewGeneralCodes.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewGeneralCodes.TabIndex = 25;
            this.listViewGeneralCodes.UseCompatibleStateImageBehavior = false;
            this.listViewGeneralCodes.View = System.Windows.Forms.View.Details;
            this.listViewGeneralCodes.DoubleClick += new System.EventHandler(this.listViewGeneralCodes_DoubleClick);
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 160;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 249;
            // 
            // formGeneralCodesFileMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 564);
            this.Controls.Add(this.listViewGeneralCodes);
            this.Controls.Add(this.toolStrip_BottomMenu);
            this.Name = "formGeneralCodesFileMaintenance";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formGeneralCodesFileMaintenance";
            this.Load += new System.EventHandler(this.formGeneralCodesFileMaintenance_Load);
            this.toolStrip_BottomMenu.ResumeLayout(false);
            this.toolStrip_BottomMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStrip toolStrip_BottomMenu;
        private ToolStripButton toolStripButton_Exit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton_Help;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton_OK;
        private ToolStripSeparator toolStripSeparator4;
        private ListView listViewGeneralCodes;
        private ColumnHeader columnHeaderTitle;
        private ColumnHeader columnHeaderDescription;
    }
}