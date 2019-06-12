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
            this.unitToDeleteLabel = new System.Windows.Forms.Label();
            this.unitToDeleteInput = new System.Windows.Forms.ComboBox();
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
            this.unitSelectorCustomUnitTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unitSelectorCustomUnitTable.Name = "unitSelectorCustomUnitTable";
            this.unitSelectorCustomUnitTable.Size = new System.Drawing.Size(117, 233);
            this.unitSelectorCustomUnitTable.TabIndex = 0;
            this.unitSelectorCustomUnitTable.SelectedIndexChanged += new System.EventHandler(this.unitSelectorCustomUnitTable_SelectedIndexChanged);
            // 
            // customUnitsSetupArea
            // 
            this.customUnitsSetupArea.ColumnCount = 4;
            this.customUnitsSetupArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.customUnitsSetupArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.customUnitsSetupArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.customUnitsSetupArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.customUnitsSetupArea.Controls.Add(this.buttonsArea, 1, 6);
            this.customUnitsSetupArea.Controls.Add(this.unitToDeleteLabel, 1, 2);
            this.customUnitsSetupArea.Controls.Add(this.unitToDeleteInput, 2, 2);
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
            this.buttonsArea.ColumnCount = 3;
            this.customUnitsSetupArea.SetColumnSpan(this.buttonsArea, 2);
            this.buttonsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.buttonsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.buttonsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.buttonsArea.Controls.Add(this.cancelAddCustomUnitButton, 0, 0);
            this.buttonsArea.Controls.Add(this.deleteCustomUnitButton, 2, 0);
            this.buttonsArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsArea.Location = new System.Drawing.Point(19, 201);
            this.buttonsArea.Name = "buttonsArea";
            this.buttonsArea.RowCount = 1;
            this.buttonsArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsArea.Size = new System.Drawing.Size(293, 31);
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
            this.cancelAddCustomUnitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddCustomUnitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.cancelAddCustomUnitButton.Location = new System.Drawing.Point(3, 3);
            this.cancelAddCustomUnitButton.Name = "cancelAddCustomUnitButton";
            this.cancelAddCustomUnitButton.Size = new System.Drawing.Size(134, 25);
            this.cancelAddCustomUnitButton.TabIndex = 9;
            this.cancelAddCustomUnitButton.TabStop = false;
            this.cancelAddCustomUnitButton.Text = "&Cancel";
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
            this.deleteCustomUnitButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomUnitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.deleteCustomUnitButton.Location = new System.Drawing.Point(153, 2);
            this.deleteCustomUnitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteCustomUnitButton.Name = "deleteCustomUnitButton";
            this.deleteCustomUnitButton.Size = new System.Drawing.Size(138, 27);
            this.deleteCustomUnitButton.TabIndex = 2;
            this.deleteCustomUnitButton.Text = "&Delete";
            this.deleteCustomUnitButton.UseVisualStyleBackColor = false;
            this.deleteCustomUnitButton.Click += new System.EventHandler(this.deleteCustomUnitButton_Click);
            // 
            // unitToDeleteLabel
            // 
            this.unitToDeleteLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.unitToDeleteLabel.AutoSize = true;
            this.unitToDeleteLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.unitToDeleteLabel.Location = new System.Drawing.Point(19, 81);
            this.unitToDeleteLabel.Name = "unitToDeleteLabel";
            this.unitToDeleteLabel.Size = new System.Drawing.Size(72, 13);
            this.unitToDeleteLabel.TabIndex = 12;
            this.unitToDeleteLabel.Text = "Unit to Delete";
            this.unitToDeleteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unitToDeleteInput
            // 
            this.unitToDeleteInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.unitToDeleteInput.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.unitToDeleteInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unitToDeleteInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitToDeleteInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unitToDeleteInput.ForeColor = System.Drawing.SystemColors.Window;
            this.unitToDeleteInput.Location = new System.Drawing.Point(151, 76);
            this.unitToDeleteInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.unitToDeleteInput.Name = "unitToDeleteInput";
            this.unitToDeleteInput.Size = new System.Drawing.Size(162, 21);
            this.unitToDeleteInput.Sorted = true;
            this.unitToDeleteInput.TabIndex = 1;
            // 
            // DeleteCustomUnitsBox
            // 
            this.AcceptButton = this.deleteCustomUnitButton;
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
            this.customUnitsSetupArea.PerformLayout();
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
        private System.Windows.Forms.Label unitToDeleteLabel;
        private System.Windows.Forms.ComboBox unitToDeleteInput;
    }
}