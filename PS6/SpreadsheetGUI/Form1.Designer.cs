namespace SS
{
    partial class Form1
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
            this.spreadsheetPanel1 = new SS.SpreadsheetPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuFileLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuHideLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.cellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuCellContents = new System.Windows.Forms.ToolStripMenuItem();
            this.valueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuTextBoxValue = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuCellBoxValue = new System.Windows.Forms.ToolStripMenuItem();
            this.exceptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuInvalidFormula = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuCircularException = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuSpreadSheetFormula = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contents_box = new System.Windows.Forms.TextBox();
            this.position_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.value_label = new System.Windows.Forms.Label();
            this.value_box = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spreadsheetPanel1
            // 
            this.spreadsheetPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spreadsheetPanel1.Location = new System.Drawing.Point(0, 53);
            this.spreadsheetPanel1.Name = "spreadsheetPanel1";
            this.spreadsheetPanel1.Size = new System.Drawing.Size(739, 296);
            this.spreadsheetPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(172, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMenuFileLocation,
            this.viewMenuHideLocation});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewMenuFileLocation
            // 
            this.viewMenuFileLocation.Enabled = false;
            this.viewMenuFileLocation.Name = "viewMenuFileLocation";
            this.viewMenuFileLocation.Size = new System.Drawing.Size(173, 22);
            this.viewMenuFileLocation.Text = "Show File Location";
            this.viewMenuFileLocation.Click += new System.EventHandler(this.viewMenuFileLocation_Click);
            // 
            // viewMenuHideLocation
            // 
            this.viewMenuHideLocation.Name = "viewMenuHideLocation";
            this.viewMenuHideLocation.Size = new System.Drawing.Size(173, 22);
            this.viewMenuHideLocation.Text = "Hide File Location";
            this.viewMenuHideLocation.Click += new System.EventHandler(this.viewMenuHideLocation_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savingToolStripMenuItem,
            this.cellToolStripMenuItem,
            this.exceptionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "Help";
            // 
            // savingToolStripMenuItem
            // 
            this.savingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuSave,
            this.helpMenuSaveAs});
            this.savingToolStripMenuItem.Name = "savingToolStripMenuItem";
            this.savingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.savingToolStripMenuItem.Text = "Saving";
            // 
            // helpMenuSave
            // 
            this.helpMenuSave.Name = "helpMenuSave";
            this.helpMenuSave.Size = new System.Drawing.Size(152, 22);
            this.helpMenuSave.Text = "Save";
            this.helpMenuSave.Click += new System.EventHandler(this.helpMenuSave_Click);
            // 
            // helpMenuSaveAs
            // 
            this.helpMenuSaveAs.Name = "helpMenuSaveAs";
            this.helpMenuSaveAs.Size = new System.Drawing.Size(152, 22);
            this.helpMenuSaveAs.Text = "SaveAs";
            this.helpMenuSaveAs.Click += new System.EventHandler(this.helpMenuSaveAs_Click);
            // 
            // cellToolStripMenuItem
            // 
            this.cellToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMenuCellContents,
            this.valueToolStripMenuItem});
            this.cellToolStripMenuItem.Name = "cellToolStripMenuItem";
            this.cellToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cellToolStripMenuItem.Text = "Cell";
            // 
            // viewMenuCellContents
            // 
            this.viewMenuCellContents.Name = "viewMenuCellContents";
            this.viewMenuCellContents.Size = new System.Drawing.Size(152, 22);
            this.viewMenuCellContents.Text = "Contents";
            this.viewMenuCellContents.Click += new System.EventHandler(this.viewMenuCellContents_Click);
            // 
            // valueToolStripMenuItem
            // 
            this.valueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMenuTextBoxValue,
            this.viewMenuCellBoxValue});
            this.valueToolStripMenuItem.Name = "valueToolStripMenuItem";
            this.valueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.valueToolStripMenuItem.Text = "Value";
            // 
            // viewMenuTextBoxValue
            // 
            this.viewMenuTextBoxValue.Name = "viewMenuTextBoxValue";
            this.viewMenuTextBoxValue.Size = new System.Drawing.Size(118, 22);
            this.viewMenuTextBoxValue.Text = "Text Box";
            this.viewMenuTextBoxValue.Click += new System.EventHandler(this.viewMenuTextBoxValue_Click);
            // 
            // viewMenuCellBoxValue
            // 
            this.viewMenuCellBoxValue.Name = "viewMenuCellBoxValue";
            this.viewMenuCellBoxValue.Size = new System.Drawing.Size(118, 22);
            this.viewMenuCellBoxValue.Text = "Cell Box";
            this.viewMenuCellBoxValue.Click += new System.EventHandler(this.viewMenuCellBoxValue_Click);
            // 
            // exceptionsToolStripMenuItem
            // 
            this.exceptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuInvalidFormula,
            this.helpMenuCircularException,
            this.helpMenuSpreadSheetFormula});
            this.exceptionsToolStripMenuItem.Name = "exceptionsToolStripMenuItem";
            this.exceptionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exceptionsToolStripMenuItem.Text = "Exceptions";
            // 
            // helpMenuInvalidFormula
            // 
            this.helpMenuInvalidFormula.Name = "helpMenuInvalidFormula";
            this.helpMenuInvalidFormula.Size = new System.Drawing.Size(186, 22);
            this.helpMenuInvalidFormula.Text = "Invalid Formula";
            this.helpMenuInvalidFormula.Click += new System.EventHandler(this.helpMenuInvalidFormula_Click);
            // 
            // helpMenuCircularException
            // 
            this.helpMenuCircularException.Name = "helpMenuCircularException";
            this.helpMenuCircularException.Size = new System.Drawing.Size(186, 22);
            this.helpMenuCircularException.Text = "Circular Exception";
            this.helpMenuCircularException.Click += new System.EventHandler(this.helpMenuCircularException_Click);
            // 
            // helpMenuSpreadSheetFormula
            // 
            this.helpMenuSpreadSheetFormula.Name = "helpMenuSpreadSheetFormula";
            this.helpMenuSpreadSheetFormula.Size = new System.Drawing.Size(186, 22);
            this.helpMenuSpreadSheetFormula.Text = "SpreadSheet.Formula";
            this.helpMenuSpreadSheetFormula.Click += new System.EventHandler(this.helpMenuSpreadSheetFormula_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contents_box
            // 
            this.contents_box.Location = new System.Drawing.Point(67, 27);
            this.contents_box.Name = "contents_box";
            this.contents_box.Size = new System.Drawing.Size(170, 20);
            this.contents_box.TabIndex = 4;
            this.contents_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.update_key_press);
            this.contents_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.update_key_press);
            // 
            // position_label
            // 
            this.position_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.position_label.AutoSize = true;
            this.position_label.Location = new System.Drawing.Point(12, 352);
            this.position_label.Name = "position_label";
            this.position_label.Size = new System.Drawing.Size(0, 13);
            this.position_label.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contents";
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.value_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_label.Location = new System.Drawing.Point(243, 30);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(52, 15);
            this.value_label.TabIndex = 6;
            this.value_label.Text = "A1 Value";
            // 
            // value_box
            // 
            this.value_box.Enabled = false;
            this.value_box.Location = new System.Drawing.Point(301, 27);
            this.value_box.Name = "value_box";
            this.value_box.Size = new System.Drawing.Size(170, 20);
            this.value_box.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 374);
            this.Controls.Add(this.value_box);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.position_label);
            this.Controls.Add(this.contents_box);
            this.Controls.Add(this.spreadsheetPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SpreadSheet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SpreadsheetPanel spreadsheetPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox contents_box;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Label position_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label value_label;
        private System.Windows.Forms.TextBox value_box;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuSave;
        private System.Windows.Forms.ToolStripMenuItem helpMenuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuFileLocation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem viewMenuHideLocation;
        private System.Windows.Forms.ToolStripMenuItem cellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuCellContents;
        private System.Windows.Forms.ToolStripMenuItem valueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuTextBoxValue;
        private System.Windows.Forms.ToolStripMenuItem viewMenuCellBoxValue;
        private System.Windows.Forms.ToolStripMenuItem exceptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuInvalidFormula;
        private System.Windows.Forms.ToolStripMenuItem helpMenuCircularException;
        private System.Windows.Forms.ToolStripMenuItem helpMenuSpreadSheetFormula;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    }
}

