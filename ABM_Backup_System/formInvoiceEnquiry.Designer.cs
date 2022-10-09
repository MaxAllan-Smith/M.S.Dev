namespace ABM_Backup_System
{
    partial class formInvoiceEnquiry
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
            this.toolStripButton_Sell = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Cancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.label_InvoiceNumber = new System.Windows.Forms.Label();
            this.textBox_InvoiceNumber = new System.Windows.Forms.TextBox();
            this.textBox_OperatorCode = new System.Windows.Forms.TextBox();
            this.label_OperatorCode = new System.Windows.Forms.Label();
            this.textBox_AccountNumber = new System.Windows.Forms.TextBox();
            this.label_AccountNumber = new System.Windows.Forms.Label();
            this.textBox_CustomerReference = new System.Windows.Forms.TextBox();
            this.label_CustomerReference = new System.Windows.Forms.Label();
            this.textBox_ProductCode = new System.Windows.Forms.TextBox();
            this.label_ProductCode = new System.Windows.Forms.Label();
            this.textBox_MfgCode = new System.Windows.Forms.TextBox();
            this.label_MfgCode = new System.Windows.Forms.Label();
            this.label_StartDate = new System.Windows.Forms.Label();
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label_EndDate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip_BottomMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.toolStripButton_Sell,
            this.toolStripButton_Cancel,
            this.toolStripSeparator4});
            this.toolStrip_BottomMenu.Location = new System.Drawing.Point(0, 508);
            this.toolStrip_BottomMenu.Name = "toolStrip_BottomMenu";
            this.toolStrip_BottomMenu.Size = new System.Drawing.Size(914, 85);
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
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 85);
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
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 85);
            // 
            // toolStripButton_Sell
            // 
            this.toolStripButton_Sell.AutoSize = false;
            this.toolStripButton_Sell.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripButton_Sell.Image = global::ABM_Backup_System.Properties.Resources.OK;
            this.toolStripButton_Sell.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Sell.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Sell.Name = "toolStripButton_Sell";
            this.toolStripButton_Sell.Size = new System.Drawing.Size(50, 61);
            this.toolStripButton_Sell.Text = "Sell";
            this.toolStripButton_Sell.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Sell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 85);
            // 
            // label_InvoiceNumber
            // 
            this.label_InvoiceNumber.AutoSize = true;
            this.label_InvoiceNumber.Location = new System.Drawing.Point(21, 20);
            this.label_InvoiceNumber.Name = "label_InvoiceNumber";
            this.label_InvoiceNumber.Size = new System.Drawing.Size(109, 17);
            this.label_InvoiceNumber.TabIndex = 23;
            this.label_InvoiceNumber.Text = "Invoice Number:";
            // 
            // textBox_InvoiceNumber
            // 
            this.textBox_InvoiceNumber.Location = new System.Drawing.Point(21, 40);
            this.textBox_InvoiceNumber.Name = "textBox_InvoiceNumber";
            this.textBox_InvoiceNumber.Size = new System.Drawing.Size(210, 25);
            this.textBox_InvoiceNumber.TabIndex = 24;
            // 
            // textBox_OperatorCode
            // 
            this.textBox_OperatorCode.Location = new System.Drawing.Point(21, 98);
            this.textBox_OperatorCode.Name = "textBox_OperatorCode";
            this.textBox_OperatorCode.Size = new System.Drawing.Size(210, 25);
            this.textBox_OperatorCode.TabIndex = 26;
            // 
            // label_OperatorCode
            // 
            this.label_OperatorCode.AutoSize = true;
            this.label_OperatorCode.Location = new System.Drawing.Point(21, 78);
            this.label_OperatorCode.Name = "label_OperatorCode";
            this.label_OperatorCode.Size = new System.Drawing.Size(101, 17);
            this.label_OperatorCode.TabIndex = 25;
            this.label_OperatorCode.Text = "Operator Code:";
            // 
            // textBox_AccountNumber
            // 
            this.textBox_AccountNumber.Location = new System.Drawing.Point(21, 156);
            this.textBox_AccountNumber.Name = "textBox_AccountNumber";
            this.textBox_AccountNumber.Size = new System.Drawing.Size(210, 25);
            this.textBox_AccountNumber.TabIndex = 28;
            // 
            // label_AccountNumber
            // 
            this.label_AccountNumber.AutoSize = true;
            this.label_AccountNumber.Location = new System.Drawing.Point(21, 136);
            this.label_AccountNumber.Name = "label_AccountNumber";
            this.label_AccountNumber.Size = new System.Drawing.Size(116, 17);
            this.label_AccountNumber.TabIndex = 27;
            this.label_AccountNumber.Text = "Account Number:";
            // 
            // textBox_CustomerReference
            // 
            this.textBox_CustomerReference.Location = new System.Drawing.Point(21, 214);
            this.textBox_CustomerReference.Name = "textBox_CustomerReference";
            this.textBox_CustomerReference.Size = new System.Drawing.Size(210, 25);
            this.textBox_CustomerReference.TabIndex = 30;
            // 
            // label_CustomerReference
            // 
            this.label_CustomerReference.AutoSize = true;
            this.label_CustomerReference.Location = new System.Drawing.Point(21, 194);
            this.label_CustomerReference.Name = "label_CustomerReference";
            this.label_CustomerReference.Size = new System.Drawing.Size(133, 17);
            this.label_CustomerReference.TabIndex = 29;
            this.label_CustomerReference.Text = "Customer Reference:";
            // 
            // textBox_ProductCode
            // 
            this.textBox_ProductCode.Location = new System.Drawing.Point(21, 272);
            this.textBox_ProductCode.Name = "textBox_ProductCode";
            this.textBox_ProductCode.Size = new System.Drawing.Size(210, 25);
            this.textBox_ProductCode.TabIndex = 32;
            // 
            // label_ProductCode
            // 
            this.label_ProductCode.AutoSize = true;
            this.label_ProductCode.Location = new System.Drawing.Point(21, 252);
            this.label_ProductCode.Name = "label_ProductCode";
            this.label_ProductCode.Size = new System.Drawing.Size(94, 17);
            this.label_ProductCode.TabIndex = 31;
            this.label_ProductCode.Text = "Product Code:";
            // 
            // textBox_MfgCode
            // 
            this.textBox_MfgCode.Location = new System.Drawing.Point(21, 330);
            this.textBox_MfgCode.Name = "textBox_MfgCode";
            this.textBox_MfgCode.Size = new System.Drawing.Size(210, 25);
            this.textBox_MfgCode.TabIndex = 34;
            // 
            // label_MfgCode
            // 
            this.label_MfgCode.AutoSize = true;
            this.label_MfgCode.Location = new System.Drawing.Point(21, 310);
            this.label_MfgCode.Name = "label_MfgCode";
            this.label_MfgCode.Size = new System.Drawing.Size(74, 17);
            this.label_MfgCode.TabIndex = 33;
            this.label_MfgCode.Text = "MFG Code:";
            // 
            // label_StartDate
            // 
            this.label_StartDate.AutoSize = true;
            this.label_StartDate.Location = new System.Drawing.Point(21, 368);
            this.label_StartDate.Name = "label_StartDate";
            this.label_StartDate.Size = new System.Drawing.Size(72, 17);
            this.label_StartDate.TabIndex = 35;
            this.label_StartDate.Text = "Start Date:";
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(21, 388);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(210, 25);
            this.dateTimePicker_StartDate.TabIndex = 36;
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(21, 446);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(210, 25);
            this.dateTimePicker_EndDate.TabIndex = 38;
            // 
            // label_EndDate
            // 
            this.label_EndDate.AutoSize = true;
            this.label_EndDate.Location = new System.Drawing.Point(21, 426);
            this.label_EndDate.Name = "label_EndDate";
            this.label_EndDate.Size = new System.Drawing.Size(72, 17);
            this.label_EndDate.TabIndex = 37;
            this.label_EndDate.Text = "Start Date:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(257, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(645, 483);
            this.dataGridView1.TabIndex = 39;
            // 
            // formInvoiceEnquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 593);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker_EndDate);
            this.Controls.Add(this.label_EndDate);
            this.Controls.Add(this.dateTimePicker_StartDate);
            this.Controls.Add(this.label_StartDate);
            this.Controls.Add(this.textBox_MfgCode);
            this.Controls.Add(this.label_MfgCode);
            this.Controls.Add(this.textBox_ProductCode);
            this.Controls.Add(this.label_ProductCode);
            this.Controls.Add(this.textBox_CustomerReference);
            this.Controls.Add(this.label_CustomerReference);
            this.Controls.Add(this.textBox_AccountNumber);
            this.Controls.Add(this.label_AccountNumber);
            this.Controls.Add(this.textBox_OperatorCode);
            this.Controls.Add(this.label_OperatorCode);
            this.Controls.Add(this.textBox_InvoiceNumber);
            this.Controls.Add(this.label_InvoiceNumber);
            this.Controls.Add(this.toolStrip_BottomMenu);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "formInvoiceEnquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Enquiry";
            this.toolStrip_BottomMenu.ResumeLayout(false);
            this.toolStrip_BottomMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip_BottomMenu;
        private ToolStripButton toolStripButton_Exit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton_Help;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton_Sell;
        private ToolStripButton toolStripButton_Cancel;
        private ToolStripSeparator toolStripSeparator4;
        private Label label_InvoiceNumber;
        private TextBox textBox_InvoiceNumber;
        private TextBox textBox_OperatorCode;
        private Label label_OperatorCode;
        private TextBox textBox_AccountNumber;
        private Label label_AccountNumber;
        private TextBox textBox_CustomerReference;
        private Label label_CustomerReference;
        private TextBox textBox_ProductCode;
        private Label label_ProductCode;
        private TextBox textBox_MfgCode;
        private Label label_MfgCode;
        private Label label_StartDate;
        private DateTimePicker dateTimePicker_StartDate;
        private DateTimePicker dateTimePicker_EndDate;
        private Label label_EndDate;
        private DataGridView dataGridView1;
    }
}