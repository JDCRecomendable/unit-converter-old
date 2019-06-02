namespace Unit_Converter
{
    partial class MainScreen
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doNotRoundOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.wholeNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUnitConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitSelector = new System.Windows.Forms.TabControl();
            this.lengthConverter = new System.Windows.Forms.TabPage();
            this.areaConverter = new System.Windows.Forms.TabPage();
            this.volumeConverter = new System.Windows.Forms.TabPage();
            this.timeConverter = new System.Windows.Forms.TabPage();
            this.speedConverter = new System.Windows.Forms.TabPage();
            this.massConverter = new System.Windows.Forms.TabPage();
            this.energyConverter = new System.Windows.Forms.TabPage();
            this.temperatureConverter = new System.Windows.Forms.TabPage();
            this.dataSizeConverter = new System.Windows.Forms.TabPage();
            this.converterTable = new System.Windows.Forms.TableLayoutPanel();
            this.toValueOutput = new System.Windows.Forms.TextBox();
            this.fromUnitInput = new System.Windows.Forms.ComboBox();
            this.toUnitOutput = new System.Windows.Forms.ComboBox();
            this.fromValueInput = new System.Windows.Forms.TextBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusIndicator = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainArea = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.swapButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.menuBar.SuspendLayout();
            this.unitSelector.SuspendLayout();
            this.converterTable.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.mainArea.SuspendLayout();
            this.buttonsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(459, 28);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "Unit Converter Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.roundOffToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Space)));
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On &Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // roundOffToolStripMenuItem
            // 
            this.roundOffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doNotRoundOffToolStripMenuItem,
            this.testToolStripMenuItem,
            this.wholeNumberToolStripMenuItem,
            this.decimalPlacesToolStripMenuItem1,
            this.decimalPlacesToolStripMenuItem2,
            this.decimalPlacesToolStripMenuItem3,
            this.decimalPlacesToolStripMenuItem4,
            this.decimalPlacesToolStripMenuItem5,
            this.decimalPlacesToolStripMenuItem6,
            this.decimalPlacesToolStripMenuItem7,
            this.decimalPlacesToolStripMenuItem8,
            this.decimalPlacesToolStripMenuItem9,
            this.decimalPlacesToolStripMenuItem10});
            this.roundOffToolStripMenuItem.Name = "roundOffToolStripMenuItem";
            this.roundOffToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.roundOffToolStripMenuItem.Text = "&Round Off...";
            // 
            // doNotRoundOffToolStripMenuItem
            // 
            this.doNotRoundOffToolStripMenuItem.Checked = true;
            this.doNotRoundOffToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doNotRoundOffToolStripMenuItem.Name = "doNotRoundOffToolStripMenuItem";
            this.doNotRoundOffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.doNotRoundOffToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.doNotRoundOffToolStripMenuItem.Text = "&None";
            this.doNotRoundOffToolStripMenuItem.Click += new System.EventHandler(this.doNotRoundOffToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(201, 6);
            // 
            // wholeNumberToolStripMenuItem
            // 
            this.wholeNumberToolStripMenuItem.Name = "wholeNumberToolStripMenuItem";
            this.wholeNumberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.wholeNumberToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.wholeNumberToolStripMenuItem.Text = "&Whole Number";
            this.wholeNumberToolStripMenuItem.Click += new System.EventHandler(this.wholeNumberToolStripMenuItem_Click);
            // 
            // decimalPlacesToolStripMenuItem1
            // 
            this.decimalPlacesToolStripMenuItem1.Name = "decimalPlacesToolStripMenuItem1";
            this.decimalPlacesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D1)));
            this.decimalPlacesToolStripMenuItem1.Size = new System.Drawing.Size(294, 26);
            this.decimalPlacesToolStripMenuItem1.Text = "&1 Decimal Place";
            this.decimalPlacesToolStripMenuItem1.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem1_Click);
            // 
            // decimalPlacesToolStripMenuItem2
            // 
            this.decimalPlacesToolStripMenuItem2.Name = "decimalPlacesToolStripMenuItem2";
            this.decimalPlacesToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D2)));
            this.decimalPlacesToolStripMenuItem2.Size = new System.Drawing.Size(294, 26);
            this.decimalPlacesToolStripMenuItem2.Text = "&2 Decimal Places";
            this.decimalPlacesToolStripMenuItem2.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem2_Click);
            // 
            // decimalPlacesToolStripMenuItem3
            // 
            this.decimalPlacesToolStripMenuItem3.Name = "decimalPlacesToolStripMenuItem3";
            this.decimalPlacesToolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D3)));
            this.decimalPlacesToolStripMenuItem3.Size = new System.Drawing.Size(294, 26);
            this.decimalPlacesToolStripMenuItem3.Text = "&3 Decimal Places";
            this.decimalPlacesToolStripMenuItem3.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem3_Click);
            // 
            // decimalPlacesToolStripMenuItem4
            // 
            this.decimalPlacesToolStripMenuItem4.Name = "decimalPlacesToolStripMenuItem4";
            this.decimalPlacesToolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D4)));
            this.decimalPlacesToolStripMenuItem4.Size = new System.Drawing.Size(294, 26);
            this.decimalPlacesToolStripMenuItem4.Text = "&4 Decimal Places";
            this.decimalPlacesToolStripMenuItem4.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem4_Click);
            // 
            // decimalPlacesToolStripMenuItem5
            // 
            this.decimalPlacesToolStripMenuItem5.Name = "decimalPlacesToolStripMenuItem5";
            this.decimalPlacesToolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D5)));
            this.decimalPlacesToolStripMenuItem5.Size = new System.Drawing.Size(294, 26);
            this.decimalPlacesToolStripMenuItem5.Text = "&5 Decimal Places";
            this.decimalPlacesToolStripMenuItem5.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem5_Click);
            // 
            // decimalPlacesToolStripMenuItem6
            // 
            this.decimalPlacesToolStripMenuItem6.Name = "decimalPlacesToolStripMenuItem6";
            this.decimalPlacesToolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D6)));
            this.decimalPlacesToolStripMenuItem6.Size = new System.Drawing.Size(294, 26);
            this.decimalPlacesToolStripMenuItem6.Text = "&6 Decimal Places";
            this.decimalPlacesToolStripMenuItem6.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem6_Click);
            // 
            // decimalPlacesToolStripMenuItem7
            // 
            this.decimalPlacesToolStripMenuItem7.Name = "decimalPlacesToolStripMenuItem7";
            this.decimalPlacesToolStripMenuItem7.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D7)));
            this.decimalPlacesToolStripMenuItem7.Size = new System.Drawing.Size(294, 26);
            this.decimalPlacesToolStripMenuItem7.Text = "&7 Decimal Places";
            this.decimalPlacesToolStripMenuItem7.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem7_Click);
            // 
            // decimalPlacesToolStripMenuItem8
            // 
            this.decimalPlacesToolStripMenuItem8.Name = "decimalPlacesToolStripMenuItem8";
            this.decimalPlacesToolStripMenuItem8.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D8)));
            this.decimalPlacesToolStripMenuItem8.Size = new System.Drawing.Size(294, 26);
            this.decimalPlacesToolStripMenuItem8.Text = "&8 Decimal Places";
            this.decimalPlacesToolStripMenuItem8.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem8_Click);
            // 
            // decimalPlacesToolStripMenuItem9
            // 
            this.decimalPlacesToolStripMenuItem9.Name = "decimalPlacesToolStripMenuItem9";
            this.decimalPlacesToolStripMenuItem9.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D9)));
            this.decimalPlacesToolStripMenuItem9.Size = new System.Drawing.Size(294, 26);
            this.decimalPlacesToolStripMenuItem9.Text = "&9 Decimal Places";
            this.decimalPlacesToolStripMenuItem9.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem9_Click);
            // 
            // decimalPlacesToolStripMenuItem10
            // 
            this.decimalPlacesToolStripMenuItem10.Name = "decimalPlacesToolStripMenuItem10";
            this.decimalPlacesToolStripMenuItem10.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D0)));
            this.decimalPlacesToolStripMenuItem10.Size = new System.Drawing.Size(294, 26);
            this.decimalPlacesToolStripMenuItem10.Text = "1&0 Decimal Places";
            this.decimalPlacesToolStripMenuItem10.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem10_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUnitConverterToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // aboutUnitConverterToolStripMenuItem
            // 
            this.aboutUnitConverterToolStripMenuItem.Name = "aboutUnitConverterToolStripMenuItem";
            this.aboutUnitConverterToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutUnitConverterToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.aboutUnitConverterToolStripMenuItem.Text = "&About Unit Converter";
            this.aboutUnitConverterToolStripMenuItem.Click += new System.EventHandler(this.aboutUnitConverterToolStripMenuItem_Click);
            // 
            // unitSelector
            // 
            this.unitSelector.Controls.Add(this.lengthConverter);
            this.unitSelector.Controls.Add(this.areaConverter);
            this.unitSelector.Controls.Add(this.volumeConverter);
            this.unitSelector.Controls.Add(this.timeConverter);
            this.unitSelector.Controls.Add(this.speedConverter);
            this.unitSelector.Controls.Add(this.massConverter);
            this.unitSelector.Controls.Add(this.energyConverter);
            this.unitSelector.Controls.Add(this.temperatureConverter);
            this.unitSelector.Controls.Add(this.dataSizeConverter);
            this.unitSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitSelector.Location = new System.Drawing.Point(3, 2);
            this.unitSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unitSelector.Name = "unitSelector";
            this.unitSelector.SelectedIndex = 0;
            this.unitSelector.Size = new System.Drawing.Size(453, 28);
            this.unitSelector.TabIndex = 0;
            // 
            // lengthConverter
            // 
            this.lengthConverter.BackColor = System.Drawing.SystemColors.Control;
            this.lengthConverter.Cursor = System.Windows.Forms.Cursors.Default;
            this.lengthConverter.Location = new System.Drawing.Point(4, 25);
            this.lengthConverter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lengthConverter.Name = "lengthConverter";
            this.lengthConverter.Size = new System.Drawing.Size(445, 0);
            this.lengthConverter.TabIndex = 0;
            this.lengthConverter.Text = "Length";
            // 
            // areaConverter
            // 
            this.areaConverter.BackColor = System.Drawing.SystemColors.Control;
            this.areaConverter.Cursor = System.Windows.Forms.Cursors.Default;
            this.areaConverter.Location = new System.Drawing.Point(4, 25);
            this.areaConverter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.areaConverter.Name = "areaConverter";
            this.areaConverter.Size = new System.Drawing.Size(445, 0);
            this.areaConverter.TabIndex = 1;
            this.areaConverter.Text = "Area";
            // 
            // volumeConverter
            // 
            this.volumeConverter.BackColor = System.Drawing.SystemColors.Control;
            this.volumeConverter.Cursor = System.Windows.Forms.Cursors.Default;
            this.volumeConverter.Location = new System.Drawing.Point(4, 25);
            this.volumeConverter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.volumeConverter.Name = "volumeConverter";
            this.volumeConverter.Size = new System.Drawing.Size(445, 0);
            this.volumeConverter.TabIndex = 2;
            this.volumeConverter.Text = "Volume";
            // 
            // timeConverter
            // 
            this.timeConverter.BackColor = System.Drawing.SystemColors.Control;
            this.timeConverter.Location = new System.Drawing.Point(4, 25);
            this.timeConverter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeConverter.Name = "timeConverter";
            this.timeConverter.Size = new System.Drawing.Size(445, 0);
            this.timeConverter.TabIndex = 7;
            this.timeConverter.Text = "Time";
            // 
            // speedConverter
            // 
            this.speedConverter.BackColor = System.Drawing.SystemColors.Control;
            this.speedConverter.Cursor = System.Windows.Forms.Cursors.Default;
            this.speedConverter.Location = new System.Drawing.Point(4, 25);
            this.speedConverter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speedConverter.Name = "speedConverter";
            this.speedConverter.Size = new System.Drawing.Size(445, 0);
            this.speedConverter.TabIndex = 5;
            this.speedConverter.Text = "Speed";
            // 
            // massConverter
            // 
            this.massConverter.BackColor = System.Drawing.SystemColors.Control;
            this.massConverter.Cursor = System.Windows.Forms.Cursors.Default;
            this.massConverter.Location = new System.Drawing.Point(4, 25);
            this.massConverter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.massConverter.Name = "massConverter";
            this.massConverter.Size = new System.Drawing.Size(445, 0);
            this.massConverter.TabIndex = 6;
            this.massConverter.Text = "Mass";
            // 
            // energyConverter
            // 
            this.energyConverter.BackColor = System.Drawing.SystemColors.Control;
            this.energyConverter.Cursor = System.Windows.Forms.Cursors.Default;
            this.energyConverter.Location = new System.Drawing.Point(4, 25);
            this.energyConverter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.energyConverter.Name = "energyConverter";
            this.energyConverter.Size = new System.Drawing.Size(445, 0);
            this.energyConverter.TabIndex = 4;
            this.energyConverter.Text = "Energy";
            // 
            // temperatureConverter
            // 
            this.temperatureConverter.BackColor = System.Drawing.SystemColors.Control;
            this.temperatureConverter.Location = new System.Drawing.Point(4, 25);
            this.temperatureConverter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.temperatureConverter.Name = "temperatureConverter";
            this.temperatureConverter.Size = new System.Drawing.Size(445, 0);
            this.temperatureConverter.TabIndex = 8;
            this.temperatureConverter.Text = "Temperature";
            // 
            // dataSizeConverter
            // 
            this.dataSizeConverter.BackColor = System.Drawing.SystemColors.Control;
            this.dataSizeConverter.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataSizeConverter.Location = new System.Drawing.Point(4, 25);
            this.dataSizeConverter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataSizeConverter.Name = "dataSizeConverter";
            this.dataSizeConverter.Size = new System.Drawing.Size(445, 0);
            this.dataSizeConverter.TabIndex = 3;
            this.dataSizeConverter.Text = "Data Size";
            // 
            // converterTable
            // 
            this.converterTable.ColumnCount = 2;
            this.converterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.converterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.converterTable.Controls.Add(this.toValueOutput, 1, 1);
            this.converterTable.Controls.Add(this.fromUnitInput, 0, 0);
            this.converterTable.Controls.Add(this.toUnitOutput, 0, 1);
            this.converterTable.Controls.Add(this.fromValueInput, 1, 0);
            this.converterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.converterTable.Location = new System.Drawing.Point(3, 34);
            this.converterTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.converterTable.Name = "converterTable";
            this.converterTable.RowCount = 2;
            this.converterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.converterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.converterTable.Size = new System.Drawing.Size(453, 104);
            this.converterTable.TabIndex = 1;
            // 
            // toValueOutput
            // 
            this.toValueOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toValueOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toValueOutput.Location = new System.Drawing.Point(229, 66);
            this.toValueOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toValueOutput.MaxLength = 256;
            this.toValueOutput.Name = "toValueOutput";
            this.toValueOutput.ReadOnly = true;
            this.toValueOutput.ShortcutsEnabled = false;
            this.toValueOutput.Size = new System.Drawing.Size(200, 24);
            this.toValueOutput.TabIndex = 3;
            this.toValueOutput.TabStop = false;
            // 
            // fromUnitInput
            // 
            this.fromUnitInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fromUnitInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fromUnitInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromUnitInput.Location = new System.Drawing.Point(23, 14);
            this.fromUnitInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fromUnitInput.Name = "fromUnitInput";
            this.fromUnitInput.Size = new System.Drawing.Size(200, 24);
            this.fromUnitInput.Sorted = true;
            this.fromUnitInput.TabIndex = 0;
            this.fromUnitInput.SelectedIndexChanged += new System.EventHandler(this.fromUnitInput_SelectedIndexChanged);
            // 
            // toUnitOutput
            // 
            this.toUnitOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.toUnitOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toUnitOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toUnitOutput.Location = new System.Drawing.Point(23, 66);
            this.toUnitOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toUnitOutput.Name = "toUnitOutput";
            this.toUnitOutput.Size = new System.Drawing.Size(200, 24);
            this.toUnitOutput.Sorted = true;
            this.toUnitOutput.TabIndex = 1;
            this.toUnitOutput.SelectedIndexChanged += new System.EventHandler(this.toUnitOutput_SelectedIndexChanged);
            // 
            // fromValueInput
            // 
            this.fromValueInput.AllowDrop = true;
            this.fromValueInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fromValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromValueInput.Location = new System.Drawing.Point(229, 14);
            this.fromValueInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fromValueInput.MaxLength = 256;
            this.fromValueInput.Name = "fromValueInput";
            this.fromValueInput.Size = new System.Drawing.Size(200, 24);
            this.fromValueInput.TabIndex = 2;
            this.fromValueInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fromValueInput_KeyDown);
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.SystemColors.Control;
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusIndicator});
            this.statusBar.Location = new System.Drawing.Point(0, 222);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusBar.Size = new System.Drawing.Size(459, 25);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusBar";
            // 
            // statusIndicator
            // 
            this.statusIndicator.Name = "statusIndicator";
            this.statusIndicator.Size = new System.Drawing.Size(50, 20);
            this.statusIndicator.Text = "Ready";
            // 
            // mainArea
            // 
            this.mainArea.BackColor = System.Drawing.SystemColors.Control;
            this.mainArea.ColumnCount = 1;
            this.mainArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainArea.Controls.Add(this.converterTable, 0, 1);
            this.mainArea.Controls.Add(this.unitSelector, 0, 0);
            this.mainArea.Controls.Add(this.buttonsTable, 0, 2);
            this.mainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainArea.Location = new System.Drawing.Point(0, 28);
            this.mainArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainArea.Name = "mainArea";
            this.mainArea.RowCount = 4;
            this.mainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.mainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.mainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.mainArea.Size = new System.Drawing.Size(459, 194);
            this.mainArea.TabIndex = 3;
            // 
            // buttonsTable
            // 
            this.buttonsTable.ColumnCount = 2;
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.Controls.Add(this.swapButton, 0, 0);
            this.buttonsTable.Controls.Add(this.calculateButton, 1, 0);
            this.buttonsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTable.Location = new System.Drawing.Point(4, 144);
            this.buttonsTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonsTable.Name = "buttonsTable";
            this.buttonsTable.RowCount = 1;
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.buttonsTable.Size = new System.Drawing.Size(451, 41);
            this.buttonsTable.TabIndex = 4;
            // 
            // swapButton
            // 
            this.swapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swapButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swapButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swapButton.Location = new System.Drawing.Point(11, 2);
            this.swapButton.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(203, 37);
            this.swapButton.TabIndex = 0;
            this.swapButton.TabStop = false;
            this.swapButton.Text = "Swap";
            this.swapButton.UseVisualStyleBackColor = true;
            this.swapButton.Click += new System.EventHandler(this.swapButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(236, 2);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(204, 37);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 247);
            this.Controls.Add(this.mainArea);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(634, 309);
            this.MinimumSize = new System.Drawing.Size(474, 285);
            this.Name = "MainScreen";
            this.Text = "Unit Converter";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.unitSelector.ResumeLayout(false);
            this.converterTable.ResumeLayout(false);
            this.converterTable.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.mainArea.ResumeLayout(false);
            this.buttonsTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUnitConverterToolStripMenuItem;
        private System.Windows.Forms.TabControl unitSelector;
        private System.Windows.Forms.TabPage lengthConverter;
        private System.Windows.Forms.TabPage areaConverter;
        private System.Windows.Forms.TabPage volumeConverter;
        private System.Windows.Forms.TabPage energyConverter;
        private System.Windows.Forms.TabPage speedConverter;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusIndicator;
        private System.Windows.Forms.TableLayoutPanel mainArea;
        private System.Windows.Forms.TableLayoutPanel converterTable;
        private System.Windows.Forms.ComboBox fromUnitInput;
        private System.Windows.Forms.ComboBox toUnitOutput;
        private System.Windows.Forms.TextBox fromValueInput;
        private System.Windows.Forms.TextBox toValueOutput;
        private System.Windows.Forms.TabPage massConverter;
        private System.Windows.Forms.TabPage timeConverter;
        private System.Windows.Forms.TabPage temperatureConverter;
        private System.Windows.Forms.TableLayoutPanel buttonsTable;
        private System.Windows.Forms.Button swapButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TabPage dataSizeConverter;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roundOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doNotRoundOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem10;
        private System.Windows.Forms.ToolStripSeparator testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wholeNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem1;
    }
}

