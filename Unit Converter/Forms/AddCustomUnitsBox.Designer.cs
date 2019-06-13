namespace Unit_Converter
{
    partial class AddCustomUnitsBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomUnitsBox));
            this.addCustomUnitsArea = new System.Windows.Forms.TableLayoutPanel();
            this.unitSelectorCustomUnitTable = new System.Windows.Forms.ListBox();
            this.customUnitsSetupArea = new System.Windows.Forms.TableLayoutPanel();
            this.customUnitNameInput = new System.Windows.Forms.TextBox();
            this.nameCustomUnitLabel = new System.Windows.Forms.Label();
            this.compareAgainstUnitLabel = new System.Windows.Forms.Label();
            this.gradientUnitLabel = new System.Windows.Forms.Label();
            this.gradientUnitInput = new System.Windows.Forms.TextBox();
            this.interceptUnitLabel = new System.Windows.Forms.Label();
            this.interceptUnitInput = new System.Windows.Forms.TextBox();
            this.customUnitLabel = new System.Windows.Forms.Label();
            this.customUnitMandatoryNoticeLabel = new System.Windows.Forms.Label();
            this.compareUnitInput = new System.Windows.Forms.ComboBox();
            this.buttonsArea = new System.Windows.Forms.TableLayoutPanel();
            this.createCustomUnitButtonAndClose = new System.Windows.Forms.Button();
            this.cancelAddCustomUnitButton = new System.Windows.Forms.Button();
            this.createCustomUnitButton = new System.Windows.Forms.Button();
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
            this.addCustomUnitsArea.TabIndex = 1;
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
            this.customUnitsSetupArea.Controls.Add(this.customUnitNameInput, 2, 0);
            this.customUnitsSetupArea.Controls.Add(this.nameCustomUnitLabel, 1, 0);
            this.customUnitsSetupArea.Controls.Add(this.compareAgainstUnitLabel, 1, 1);
            this.customUnitsSetupArea.Controls.Add(this.gradientUnitLabel, 1, 3);
            this.customUnitsSetupArea.Controls.Add(this.gradientUnitInput, 2, 3);
            this.customUnitsSetupArea.Controls.Add(this.interceptUnitLabel, 1, 4);
            this.customUnitsSetupArea.Controls.Add(this.interceptUnitInput, 2, 4);
            this.customUnitsSetupArea.Controls.Add(this.customUnitLabel, 1, 2);
            this.customUnitsSetupArea.Controls.Add(this.customUnitMandatoryNoticeLabel, 1, 5);
            this.customUnitsSetupArea.Controls.Add(this.compareUnitInput, 2, 1);
            this.customUnitsSetupArea.Controls.Add(this.buttonsArea, 1, 6);
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
            // customUnitNameInput
            // 
            this.customUnitNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customUnitNameInput.BackColor = System.Drawing.Color.Gray;
            this.customUnitNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customUnitNameInput.ForeColor = System.Drawing.Color.White;
            this.customUnitNameInput.Location = new System.Drawing.Point(152, 6);
            this.customUnitNameInput.Name = "customUnitNameInput";
            this.customUnitNameInput.Size = new System.Drawing.Size(160, 20);
            this.customUnitNameInput.TabIndex = 1;
            this.customUnitNameInput.Enter += new System.EventHandler(this.customUnitNameInput_Enter);
            this.customUnitNameInput.Leave += new System.EventHandler(this.customUnitNameInput_Leave);
            // 
            // nameCustomUnitLabel
            // 
            this.nameCustomUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameCustomUnitLabel.AutoSize = true;
            this.nameCustomUnitLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.nameCustomUnitLabel.Location = new System.Drawing.Point(19, 9);
            this.nameCustomUnitLabel.Name = "nameCustomUnitLabel";
            this.nameCustomUnitLabel.Size = new System.Drawing.Size(111, 13);
            this.nameCustomUnitLabel.TabIndex = 0;
            this.nameCustomUnitLabel.Text = "Name of Custom Unit*";
            this.nameCustomUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // compareAgainstUnitLabel
            // 
            this.compareAgainstUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.compareAgainstUnitLabel.AutoSize = true;
            this.compareAgainstUnitLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.compareAgainstUnitLabel.Location = new System.Drawing.Point(19, 41);
            this.compareAgainstUnitLabel.Name = "compareAgainstUnitLabel";
            this.compareAgainstUnitLabel.Size = new System.Drawing.Size(91, 13);
            this.compareAgainstUnitLabel.TabIndex = 2;
            this.compareAgainstUnitLabel.Text = "Compare Against*";
            this.compareAgainstUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradientUnitLabel
            // 
            this.gradientUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gradientUnitLabel.AutoSize = true;
            this.gradientUnitLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.gradientUnitLabel.Location = new System.Drawing.Point(19, 120);
            this.gradientUnitLabel.Name = "gradientUnitLabel";
            this.gradientUnitLabel.Size = new System.Drawing.Size(68, 13);
            this.gradientUnitLabel.TabIndex = 3;
            this.gradientUnitLabel.Text = "Gradient (m)*";
            this.gradientUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradientUnitInput
            // 
            this.gradientUnitInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientUnitInput.BackColor = System.Drawing.Color.Gray;
            this.gradientUnitInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientUnitInput.ForeColor = System.Drawing.Color.White;
            this.gradientUnitInput.Location = new System.Drawing.Point(152, 117);
            this.gradientUnitInput.Name = "gradientUnitInput";
            this.gradientUnitInput.Size = new System.Drawing.Size(160, 20);
            this.gradientUnitInput.TabIndex = 3;
            this.gradientUnitInput.Enter += new System.EventHandler(this.gradientUnitInput_Enter);
            this.gradientUnitInput.Leave += new System.EventHandler(this.gradientUnitInput_Leave);
            // 
            // interceptUnitLabel
            // 
            this.interceptUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.interceptUnitLabel.AutoSize = true;
            this.interceptUnitLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.interceptUnitLabel.Location = new System.Drawing.Point(19, 152);
            this.interceptUnitLabel.Name = "interceptUnitLabel";
            this.interceptUnitLabel.Size = new System.Drawing.Size(71, 13);
            this.interceptUnitLabel.TabIndex = 5;
            this.interceptUnitLabel.Text = "y-intercept (c)";
            this.interceptUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // interceptUnitInput
            // 
            this.interceptUnitInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.interceptUnitInput.BackColor = System.Drawing.Color.Gray;
            this.interceptUnitInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interceptUnitInput.ForeColor = System.Drawing.Color.White;
            this.interceptUnitInput.Location = new System.Drawing.Point(152, 149);
            this.interceptUnitInput.Name = "interceptUnitInput";
            this.interceptUnitInput.Size = new System.Drawing.Size(160, 20);
            this.interceptUnitInput.TabIndex = 4;
            this.interceptUnitInput.Enter += new System.EventHandler(this.interceptUnitInput_Enter);
            this.interceptUnitInput.Leave += new System.EventHandler(this.interceptUnitInput_Leave);
            // 
            // customUnitLabel
            // 
            this.customUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customUnitLabel.AutoSize = true;
            this.customUnitsSetupArea.SetColumnSpan(this.customUnitLabel, 2);
            this.customUnitLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customUnitLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.customUnitLabel.Location = new System.Drawing.Point(19, 68);
            this.customUnitLabel.Name = "customUnitLabel";
            this.customUnitLabel.Size = new System.Drawing.Size(293, 39);
            this.customUnitLabel.TabIndex = 7;
            this.customUnitLabel.Text = "y = mx + c,\r\nwhere y is the unit to compare against,\r\nand x is the custom unit";
            this.customUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customUnitMandatoryNoticeLabel
            // 
            this.customUnitMandatoryNoticeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customUnitMandatoryNoticeLabel.AutoSize = true;
            this.customUnitsSetupArea.SetColumnSpan(this.customUnitMandatoryNoticeLabel, 2);
            this.customUnitMandatoryNoticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customUnitMandatoryNoticeLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.customUnitMandatoryNoticeLabel.Location = new System.Drawing.Point(230, 180);
            this.customUnitMandatoryNoticeLabel.Name = "customUnitMandatoryNoticeLabel";
            this.customUnitMandatoryNoticeLabel.Size = new System.Drawing.Size(82, 13);
            this.customUnitMandatoryNoticeLabel.TabIndex = 9;
            this.customUnitMandatoryNoticeLabel.Text = "*mandatory field";
            this.customUnitMandatoryNoticeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // compareUnitInput
            // 
            this.compareUnitInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compareUnitInput.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.compareUnitInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compareUnitInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compareUnitInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compareUnitInput.ForeColor = System.Drawing.SystemColors.Window;
            this.compareUnitInput.Location = new System.Drawing.Point(151, 39);
            this.compareUnitInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.compareUnitInput.Name = "compareUnitInput";
            this.compareUnitInput.Size = new System.Drawing.Size(162, 21);
            this.compareUnitInput.Sorted = true;
            this.compareUnitInput.TabIndex = 2;
            // 
            // buttonsArea
            // 
            this.buttonsArea.ColumnCount = 5;
            this.customUnitsSetupArea.SetColumnSpan(this.buttonsArea, 2);
            this.buttonsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.buttonsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.buttonsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.buttonsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.buttonsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.buttonsArea.Controls.Add(this.createCustomUnitButtonAndClose, 4, 0);
            this.buttonsArea.Controls.Add(this.cancelAddCustomUnitButton, 0, 0);
            this.buttonsArea.Controls.Add(this.createCustomUnitButton, 2, 0);
            this.buttonsArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsArea.Location = new System.Drawing.Point(19, 201);
            this.buttonsArea.Name = "buttonsArea";
            this.buttonsArea.RowCount = 1;
            this.buttonsArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsArea.Size = new System.Drawing.Size(293, 31);
            this.buttonsArea.TabIndex = 11;
            // 
            // createCustomUnitButtonAndClose
            // 
            this.createCustomUnitButtonAndClose.BackColor = System.Drawing.Color.DarkGray;
            this.createCustomUnitButtonAndClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCustomUnitButtonAndClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.createCustomUnitButtonAndClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createCustomUnitButtonAndClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createCustomUnitButtonAndClose.FlatAppearance.BorderSize = 0;
            this.createCustomUnitButtonAndClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createCustomUnitButtonAndClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.createCustomUnitButtonAndClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCustomUnitButtonAndClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCustomUnitButtonAndClose.ForeColor = System.Drawing.SystemColors.Window;
            this.createCustomUnitButtonAndClose.Location = new System.Drawing.Point(198, 2);
            this.createCustomUnitButtonAndClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createCustomUnitButtonAndClose.Name = "createCustomUnitButtonAndClose";
            this.createCustomUnitButtonAndClose.Size = new System.Drawing.Size(93, 27);
            this.createCustomUnitButtonAndClose.TabIndex = 5;
            this.createCustomUnitButtonAndClose.Text = "A&dd and Close";
            this.createCustomUnitButtonAndClose.UseVisualStyleBackColor = false;
            this.createCustomUnitButtonAndClose.Click += new System.EventHandler(this.createCustomUnitButtonAndClose_Click);
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
            this.cancelAddCustomUnitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddCustomUnitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.cancelAddCustomUnitButton.Location = new System.Drawing.Point(3, 3);
            this.cancelAddCustomUnitButton.Name = "cancelAddCustomUnitButton";
            this.cancelAddCustomUnitButton.Size = new System.Drawing.Size(87, 25);
            this.cancelAddCustomUnitButton.TabIndex = 0;
            this.cancelAddCustomUnitButton.TabStop = false;
            this.cancelAddCustomUnitButton.Text = "&Close";
            this.cancelAddCustomUnitButton.UseVisualStyleBackColor = false;
            this.cancelAddCustomUnitButton.Click += new System.EventHandler(this.cancelAddCustomUnitButton_Click);
            // 
            // createCustomUnitButton
            // 
            this.createCustomUnitButton.BackColor = System.Drawing.Color.DarkGray;
            this.createCustomUnitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCustomUnitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.createCustomUnitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createCustomUnitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createCustomUnitButton.FlatAppearance.BorderSize = 0;
            this.createCustomUnitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createCustomUnitButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.createCustomUnitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCustomUnitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCustomUnitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.createCustomUnitButton.Location = new System.Drawing.Point(101, 3);
            this.createCustomUnitButton.Name = "createCustomUnitButton";
            this.createCustomUnitButton.Size = new System.Drawing.Size(87, 25);
            this.createCustomUnitButton.TabIndex = 5;
            this.createCustomUnitButton.TabStop = false;
            this.createCustomUnitButton.Text = "&Add";
            this.createCustomUnitButton.UseVisualStyleBackColor = false;
            this.createCustomUnitButton.Click += new System.EventHandler(this.createCustomUnitButton_Click);
            // 
            // AddCustomUnitsBox
            // 
            this.AcceptButton = this.createCustomUnitButtonAndClose;
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
            this.Name = "AddCustomUnitsBox";
            this.Text = "Add a Custom Unit";
            this.Load += new System.EventHandler(this.AddCustomUnitsScreen_Load);
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
        private System.Windows.Forms.TextBox customUnitNameInput;
        private System.Windows.Forms.Label nameCustomUnitLabel;
        private System.Windows.Forms.Label compareAgainstUnitLabel;
        private System.Windows.Forms.Label gradientUnitLabel;
        private System.Windows.Forms.TextBox gradientUnitInput;
        private System.Windows.Forms.Label interceptUnitLabel;
        private System.Windows.Forms.TextBox interceptUnitInput;
        private System.Windows.Forms.Label customUnitLabel;
        private System.Windows.Forms.Button createCustomUnitButton;
        private System.Windows.Forms.Label customUnitMandatoryNoticeLabel;
        private System.Windows.Forms.ComboBox compareUnitInput;
        private System.Windows.Forms.TableLayoutPanel buttonsArea;
        private System.Windows.Forms.Button cancelAddCustomUnitButton;
        private System.Windows.Forms.Button createCustomUnitButtonAndClose;
    }
}