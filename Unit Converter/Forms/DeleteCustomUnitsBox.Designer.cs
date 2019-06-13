namespace Unit_Converter
{
    partial class DeleteCustomUnitsBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCustomUnitsBox));
            this.addCustomUnitsArea = new System.Windows.Forms.TableLayoutPanel();
            this.unitSelectorCustomUnitTable = new System.Windows.Forms.ListBox();
            this.customUnitsSetupArea = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsArea = new System.Windows.Forms.TableLayoutPanel();
            this.cancelAddCustomUnitButton = new System.Windows.Forms.Button();
            this.deleteCustomUnitButton = new System.Windows.Forms.Button();
            this.unitToDeleteCheckBox = new System.Windows.Forms.CheckedListBox();
            this.deleteCustomUnitButtonAndClose = new System.Windows.Forms.Button();
            this.addCustomUnitsArea.SuspendLayout();
            this.customUnitsSetupArea.SuspendLayout();
            this.buttonsArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCustomUnitsArea
            // 
            this.addCustomUnitsArea.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addCustomUnitsArea.ColumnCount = 2;
            this.addCustomUnitsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.addCustomUnitsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.addCustomUnitsArea.Controls.Add(this.unitSelectorCustomUnitTable, 0, 0);
            this.addCustomUnitsArea.Controls.Add(this.customUnitsSetupArea, 1, 0);
            this.addCustomUnitsArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCustomUnitsArea.Location = new System.Drawing.Point(0, 0);
            this.addCustomUnitsArea.Name = "addCustomUnitsArea";
            this.addCustomUnitsArea.RowCount = 1;
            this.addCustomUnitsArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addCustomUnitsArea.Size = new System.Drawing.Size(464, 241);
            this.addCustomUnitsArea.TabIndex = 2;
            // 
            // unitSelectorCustomUnitTable
            // 
            this.unitSelectorCustomUnitTable.BackColor = System.Drawing.Color.Gray;
            this.unitSelectorCustomUnitTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitSelectorCustomUnitTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unitSelectorCustomUnitTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitSelectorCustomUnitTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitSelectorCustomUnitTable.ForeColor = System.Drawing.SystemColors.Window;
            this.unitSelectorCustomUnitTable.FormattingEnabled = true;
            this.unitSelectorCustomUnitTable.Items.AddRange(new object[] {
            "Length",
            "Area",
            "Volume",
            "Time",
            "Speed",
            "Flow Rate (Area)",
            "Flow Rate (Volume)",
            "Flow Rate (Mass)",
            "Mass",
            "Energy",
            "Pressure",
            "Temperature",
            "Luminance",
            "Illuminance",
            "Angle",
            "Data Size"});
            this.unitSelectorCustomUnitTable.Location = new System.Drawing.Point(4, 4);
            this.unitSelectorCustomUnitTable.Margin = new System.Windows.Forms.Padding(4);
            this.unitSelectorCustomUnitTable.Name = "unitSelectorCustomUnitTable";
            this.unitSelectorCustomUnitTable.Size = new System.Drawing.Size(117, 233);
            this.unitSelectorCustomUnitTable.TabIndex = 0;
            this.unitSelectorCustomUnitTable.SelectedIndexChanged += new System.EventHandler(this.unitSelectorCustomUnitTable_SelectedIndexChanged);
            // 
            // customUnitsSetupArea
            // 
            this.customUnitsSetupArea.ColumnCount = 3;
            this.customUnitsSetupArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.customUnitsSetupArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.customUnitsSetupArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.customUnitsSetupArea.Controls.Add(this.unitToDeleteCheckBox, 1, 0);
            this.customUnitsSetupArea.Controls.Add(this.buttonsArea, 0, 6);
            this.customUnitsSetupArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customUnitsSetupArea.Location = new System.Drawing.Point(128, 3);
            this.customUnitsSetupArea.Name = "customUnitsSetupArea";
            this.customUnitsSetupArea.RowCount = 7;
            this.customUnitsSetupArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.customUnitsSetupArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.customUnitsSetupArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.customUnitsSetupArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.customUnitsSetupArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.customUnitsSetupArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.customUnitsSetupArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.customUnitsSetupArea.Size = new System.Drawing.Size(333, 235);
            this.customUnitsSetupArea.TabIndex = 2;
            // 
            // buttonsArea
            // 
            this.buttonsArea.ColumnCount = 5;
            this.customUnitsSetupArea.SetColumnSpan(this.buttonsArea, 3);
            this.buttonsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.buttonsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.buttonsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.buttonsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.buttonsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.buttonsArea.Controls.Add(this.deleteCustomUnitButtonAndClose, 4, 0);
            this.buttonsArea.Controls.Add(this.deleteCustomUnitButton, 2, 0);
            this.buttonsArea.Controls.Add(this.cancelAddCustomUnitButton, 0, 0);
            this.buttonsArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsArea.Location = new System.Drawing.Point(3, 201);
            this.buttonsArea.Name = "buttonsArea";
            this.buttonsArea.RowCount = 1;
            this.buttonsArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsArea.Size = new System.Drawing.Size(327, 31);
            this.buttonsArea.TabIndex = 11;
            // 
            // cancelAddCustomUnitButton
            // 
            this.cancelAddCustomUnitButton.BackColor = System.Drawing.Color.DarkGray;
            this.cancelAddCustomUnitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelAddCustomUnitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelAddCustomUnitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelAddCustomUnitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelAddCustomUnitButton.FlatAppearance.BorderSize = 0;
            this.cancelAddCustomUnitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelAddCustomUnitButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.cancelAddCustomUnitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAddCustomUnitButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddCustomUnitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.cancelAddCustomUnitButton.Location = new System.Drawing.Point(3, 3);
            this.cancelAddCustomUnitButton.Name = "cancelAddCustomUnitButton";
            this.cancelAddCustomUnitButton.Size = new System.Drawing.Size(98, 25);
            this.cancelAddCustomUnitButton.TabIndex = 9;
            this.cancelAddCustomUnitButton.TabStop = false;
            this.cancelAddCustomUnitButton.Text = "&Close";
            this.cancelAddCustomUnitButton.UseVisualStyleBackColor = false;
            this.cancelAddCustomUnitButton.Click += new System.EventHandler(this.cancelAddCustomUnitButton_Click);
            // 
            // deleteCustomUnitButton
            // 
            this.deleteCustomUnitButton.BackColor = System.Drawing.Color.DarkGray;
            this.deleteCustomUnitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCustomUnitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deleteCustomUnitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteCustomUnitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteCustomUnitButton.FlatAppearance.BorderSize = 0;
            this.deleteCustomUnitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteCustomUnitButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.deleteCustomUnitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCustomUnitButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomUnitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.deleteCustomUnitButton.Location = new System.Drawing.Point(113, 3);
            this.deleteCustomUnitButton.Name = "deleteCustomUnitButton";
            this.deleteCustomUnitButton.Size = new System.Drawing.Size(98, 25);
            this.deleteCustomUnitButton.TabIndex = 2;
            this.deleteCustomUnitButton.Text = "&Delete";
            this.deleteCustomUnitButton.UseVisualStyleBackColor = false;
            this.deleteCustomUnitButton.Click += new System.EventHandler(this.deleteCustomUnitButton_Click);
            // 
            // unitToDeleteCheckBox
            // 
            this.unitToDeleteCheckBox.BackColor = System.Drawing.Color.Gray;
            this.unitToDeleteCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitToDeleteCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.unitToDeleteCheckBox.FormattingEnabled = true;
            this.unitToDeleteCheckBox.Items.AddRange(new object[] {
            "asdf",
            "wer",
            "wers"});
            this.unitToDeleteCheckBox.Location = new System.Drawing.Point(86, 3);
            this.unitToDeleteCheckBox.Name = "unitToDeleteCheckBox";
            this.customUnitsSetupArea.SetRowSpan(this.unitToDeleteCheckBox, 6);
            this.unitToDeleteCheckBox.Size = new System.Drawing.Size(160, 192);
            this.unitToDeleteCheckBox.Sorted = true;
            this.unitToDeleteCheckBox.TabIndex = 13;
            // 
            // deleteCustomUnitButtonAndClose
            // 
            this.deleteCustomUnitButtonAndClose.BackColor = System.Drawing.Color.DarkGray;
            this.deleteCustomUnitButtonAndClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCustomUnitButtonAndClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deleteCustomUnitButtonAndClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteCustomUnitButtonAndClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteCustomUnitButtonAndClose.FlatAppearance.BorderSize = 0;
            this.deleteCustomUnitButtonAndClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteCustomUnitButtonAndClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.deleteCustomUnitButtonAndClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCustomUnitButtonAndClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomUnitButtonAndClose.ForeColor = System.Drawing.SystemColors.Window;
            this.deleteCustomUnitButtonAndClose.Location = new System.Drawing.Point(222, 2);
            this.deleteCustomUnitButtonAndClose.Margin = new System.Windows.Forms.Padding(2);
            this.deleteCustomUnitButtonAndClose.Name = "deleteCustomUnitButtonAndClose";
            this.deleteCustomUnitButtonAndClose.Size = new System.Drawing.Size(103, 27);
            this.deleteCustomUnitButtonAndClose.TabIndex = 14;
            this.deleteCustomUnitButtonAndClose.Text = "D&elete and Close";
            this.deleteCustomUnitButtonAndClose.UseVisualStyleBackColor = false;
            this.deleteCustomUnitButtonAndClose.Click += new System.EventHandler(this.deleteCustomUnitButtonAndClose_Click);
            // 
            // DeleteCustomUnitsBox
            // 
            this.AcceptButton = this.deleteCustomUnitButtonAndClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.cancelAddCustomUnitButton;
            this.ClientSize = new System.Drawing.Size(464, 241);
            this.ControlBox = false;
            this.Controls.Add(this.addCustomUnitsArea);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteCustomUnitsBox";
            this.Text = "Delete a Custom Unit";
            this.addCustomUnitsArea.ResumeLayout(false);
            this.customUnitsSetupArea.ResumeLayout(false);
            this.buttonsArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel addCustomUnitsArea;
        private System.Windows.Forms.ListBox unitSelectorCustomUnitTable;
        private System.Windows.Forms.TableLayoutPanel customUnitsSetupArea;
        private System.Windows.Forms.TableLayoutPanel buttonsArea;
        private System.Windows.Forms.Button cancelAddCustomUnitButton;
        private System.Windows.Forms.Button deleteCustomUnitButton;
        private System.Windows.Forms.CheckedListBox unitToDeleteCheckBox;
        private System.Windows.Forms.Button deleteCustomUnitButtonAndClose;
    }
}