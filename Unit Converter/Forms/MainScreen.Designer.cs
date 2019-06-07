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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
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
            this.converterTable = new System.Windows.Forms.TableLayoutPanel();
            this.toValueOutput = new System.Windows.Forms.TextBox();
            this.fromUnitInput = new System.Windows.Forms.ComboBox();
            this.toUnitOutput = new System.Windows.Forms.ComboBox();
            this.fromValueInput = new System.Windows.Forms.TextBox();
            this.mainArea = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.swapButton = new System.Windows.Forms.Button();
            this.unitSelectorTable = new System.Windows.Forms.ListBox();
            this.mainScreenTable = new System.Windows.Forms.TableLayoutPanel();
            this.statusIndicator = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.menuBar.SuspendLayout();
            this.converterTable.SuspendLayout();
            this.mainArea.SuspendLayout();
            this.buttonsTable.SuspendLayout();
            this.mainScreenTable.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.Control;
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(464, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "Unit Converter Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.roundOffToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.alwaysOnTopToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Space)));
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On &Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // roundOffToolStripMenuItem
            // 
            this.roundOffToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            this.roundOffToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.roundOffToolStripMenuItem.Name = "roundOffToolStripMenuItem";
            this.roundOffToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.roundOffToolStripMenuItem.Text = "Set &Precision";
            // 
            // doNotRoundOffToolStripMenuItem
            // 
            this.doNotRoundOffToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.doNotRoundOffToolStripMenuItem.Checked = true;
            this.doNotRoundOffToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doNotRoundOffToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.doNotRoundOffToolStripMenuItem.Name = "doNotRoundOffToolStripMenuItem";
            this.doNotRoundOffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.doNotRoundOffToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.doNotRoundOffToolStripMenuItem.Text = "&None";
            this.doNotRoundOffToolStripMenuItem.Click += new System.EventHandler(this.doNotRoundOffToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.testToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(240, 6);
            // 
            // wholeNumberToolStripMenuItem
            // 
            this.wholeNumberToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wholeNumberToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.wholeNumberToolStripMenuItem.Name = "wholeNumberToolStripMenuItem";
            this.wholeNumberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.wholeNumberToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.wholeNumberToolStripMenuItem.Text = "&Whole Number";
            this.wholeNumberToolStripMenuItem.Click += new System.EventHandler(this.wholeNumberToolStripMenuItem_Click);
            // 
            // decimalPlacesToolStripMenuItem1
            // 
            this.decimalPlacesToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.decimalPlacesToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Window;
            this.decimalPlacesToolStripMenuItem1.Name = "decimalPlacesToolStripMenuItem1";
            this.decimalPlacesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D1)));
            this.decimalPlacesToolStripMenuItem1.Size = new System.Drawing.Size(243, 22);
            this.decimalPlacesToolStripMenuItem1.Text = "&1 Decimal Place";
            this.decimalPlacesToolStripMenuItem1.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem1_Click);
            // 
            // decimalPlacesToolStripMenuItem2
            // 
            this.decimalPlacesToolStripMenuItem2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.decimalPlacesToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Window;
            this.decimalPlacesToolStripMenuItem2.Name = "decimalPlacesToolStripMenuItem2";
            this.decimalPlacesToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D2)));
            this.decimalPlacesToolStripMenuItem2.Size = new System.Drawing.Size(243, 22);
            this.decimalPlacesToolStripMenuItem2.Text = "&2 Decimal Places";
            this.decimalPlacesToolStripMenuItem2.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem2_Click);
            // 
            // decimalPlacesToolStripMenuItem3
            // 
            this.decimalPlacesToolStripMenuItem3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.decimalPlacesToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.Window;
            this.decimalPlacesToolStripMenuItem3.Name = "decimalPlacesToolStripMenuItem3";
            this.decimalPlacesToolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D3)));
            this.decimalPlacesToolStripMenuItem3.Size = new System.Drawing.Size(243, 22);
            this.decimalPlacesToolStripMenuItem3.Text = "&3 Decimal Places";
            this.decimalPlacesToolStripMenuItem3.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem3_Click);
            // 
            // decimalPlacesToolStripMenuItem4
            // 
            this.decimalPlacesToolStripMenuItem4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.decimalPlacesToolStripMenuItem4.ForeColor = System.Drawing.SystemColors.Window;
            this.decimalPlacesToolStripMenuItem4.Name = "decimalPlacesToolStripMenuItem4";
            this.decimalPlacesToolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D4)));
            this.decimalPlacesToolStripMenuItem4.Size = new System.Drawing.Size(243, 22);
            this.decimalPlacesToolStripMenuItem4.Text = "&4 Decimal Places";
            this.decimalPlacesToolStripMenuItem4.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem4_Click);
            // 
            // decimalPlacesToolStripMenuItem5
            // 
            this.decimalPlacesToolStripMenuItem5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.decimalPlacesToolStripMenuItem5.ForeColor = System.Drawing.SystemColors.Window;
            this.decimalPlacesToolStripMenuItem5.Name = "decimalPlacesToolStripMenuItem5";
            this.decimalPlacesToolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D5)));
            this.decimalPlacesToolStripMenuItem5.Size = new System.Drawing.Size(243, 22);
            this.decimalPlacesToolStripMenuItem5.Text = "&5 Decimal Places";
            this.decimalPlacesToolStripMenuItem5.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem5_Click);
            // 
            // decimalPlacesToolStripMenuItem6
            // 
            this.decimalPlacesToolStripMenuItem6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.decimalPlacesToolStripMenuItem6.ForeColor = System.Drawing.SystemColors.Window;
            this.decimalPlacesToolStripMenuItem6.Name = "decimalPlacesToolStripMenuItem6";
            this.decimalPlacesToolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D6)));
            this.decimalPlacesToolStripMenuItem6.Size = new System.Drawing.Size(243, 22);
            this.decimalPlacesToolStripMenuItem6.Text = "&6 Decimal Places";
            this.decimalPlacesToolStripMenuItem6.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem6_Click);
            // 
            // decimalPlacesToolStripMenuItem7
            // 
            this.decimalPlacesToolStripMenuItem7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.decimalPlacesToolStripMenuItem7.ForeColor = System.Drawing.SystemColors.Window;
            this.decimalPlacesToolStripMenuItem7.Name = "decimalPlacesToolStripMenuItem7";
            this.decimalPlacesToolStripMenuItem7.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D7)));
            this.decimalPlacesToolStripMenuItem7.Size = new System.Drawing.Size(243, 22);
            this.decimalPlacesToolStripMenuItem7.Text = "&7 Decimal Places";
            this.decimalPlacesToolStripMenuItem7.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem7_Click);
            // 
            // decimalPlacesToolStripMenuItem8
            // 
            this.decimalPlacesToolStripMenuItem8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.decimalPlacesToolStripMenuItem8.ForeColor = System.Drawing.SystemColors.Window;
            this.decimalPlacesToolStripMenuItem8.Name = "decimalPlacesToolStripMenuItem8";
            this.decimalPlacesToolStripMenuItem8.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D8)));
            this.decimalPlacesToolStripMenuItem8.Size = new System.Drawing.Size(243, 22);
            this.decimalPlacesToolStripMenuItem8.Text = "&8 Decimal Places";
            this.decimalPlacesToolStripMenuItem8.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem8_Click);
            // 
            // decimalPlacesToolStripMenuItem9
            // 
            this.decimalPlacesToolStripMenuItem9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.decimalPlacesToolStripMenuItem9.ForeColor = System.Drawing.SystemColors.Window;
            this.decimalPlacesToolStripMenuItem9.Name = "decimalPlacesToolStripMenuItem9";
            this.decimalPlacesToolStripMenuItem9.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D9)));
            this.decimalPlacesToolStripMenuItem9.Size = new System.Drawing.Size(243, 22);
            this.decimalPlacesToolStripMenuItem9.Text = "&9 Decimal Places";
            this.decimalPlacesToolStripMenuItem9.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem9_Click);
            // 
            // decimalPlacesToolStripMenuItem10
            // 
            this.decimalPlacesToolStripMenuItem10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.decimalPlacesToolStripMenuItem10.ForeColor = System.Drawing.SystemColors.Window;
            this.decimalPlacesToolStripMenuItem10.Name = "decimalPlacesToolStripMenuItem10";
            this.decimalPlacesToolStripMenuItem10.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.decimalPlacesToolStripMenuItem10.Size = new System.Drawing.Size(243, 22);
            this.decimalPlacesToolStripMenuItem10.Text = "1&0 Decimal Places";
            this.decimalPlacesToolStripMenuItem10.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem10_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUnitConverterToolStripMenuItem});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // aboutUnitConverterToolStripMenuItem
            // 
            this.aboutUnitConverterToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aboutUnitConverterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.aboutUnitConverterToolStripMenuItem.Name = "aboutUnitConverterToolStripMenuItem";
            this.aboutUnitConverterToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutUnitConverterToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.aboutUnitConverterToolStripMenuItem.Text = "&About Unit Converter";
            this.aboutUnitConverterToolStripMenuItem.Click += new System.EventHandler(this.aboutUnitConverterToolStripMenuItem_Click);
            // 
            // converterTable
            // 
            this.converterTable.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.converterTable.ColumnCount = 2;
            this.converterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.converterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.converterTable.Controls.Add(this.toValueOutput, 1, 1);
            this.converterTable.Controls.Add(this.fromUnitInput, 0, 0);
            this.converterTable.Controls.Add(this.toUnitOutput, 0, 1);
            this.converterTable.Controls.Add(this.fromValueInput, 1, 0);
            this.converterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.converterTable.Location = new System.Drawing.Point(2, 2);
            this.converterTable.Margin = new System.Windows.Forms.Padding(2);
            this.converterTable.Name = "converterTable";
            this.converterTable.RowCount = 2;
            this.converterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.converterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.converterTable.Size = new System.Drawing.Size(331, 73);
            this.converterTable.TabIndex = 1;
            // 
            // toValueOutput
            // 
            this.toValueOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toValueOutput.BackColor = System.Drawing.Color.Olive;
            this.toValueOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toValueOutput.Cursor = System.Windows.Forms.Cursors.No;
            this.toValueOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toValueOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.toValueOutput.Location = new System.Drawing.Point(167, 40);
            this.toValueOutput.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.toValueOutput.MaxLength = 256;
            this.toValueOutput.Name = "toValueOutput";
            this.toValueOutput.ReadOnly = true;
            this.toValueOutput.ShortcutsEnabled = false;
            this.toValueOutput.Size = new System.Drawing.Size(162, 21);
            this.toValueOutput.TabIndex = 3;
            this.toValueOutput.TabStop = false;
            this.toValueOutput.TextChanged += new System.EventHandler(this.toValueOutput_TextChanged);
            // 
            // fromUnitInput
            // 
            this.fromUnitInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromUnitInput.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fromUnitInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fromUnitInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromUnitInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromUnitInput.ForeColor = System.Drawing.SystemColors.Window;
            this.fromUnitInput.Location = new System.Drawing.Point(2, 11);
            this.fromUnitInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.fromUnitInput.Name = "fromUnitInput";
            this.fromUnitInput.Size = new System.Drawing.Size(161, 21);
            this.fromUnitInput.Sorted = true;
            this.fromUnitInput.TabIndex = 1;
            this.fromUnitInput.SelectedIndexChanged += new System.EventHandler(this.fromUnitInput_SelectedIndexChanged);
            // 
            // toUnitOutput
            // 
            this.toUnitOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toUnitOutput.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toUnitOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toUnitOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toUnitOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toUnitOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.toUnitOutput.Location = new System.Drawing.Point(2, 40);
            this.toUnitOutput.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.toUnitOutput.Name = "toUnitOutput";
            this.toUnitOutput.Size = new System.Drawing.Size(161, 21);
            this.toUnitOutput.Sorted = true;
            this.toUnitOutput.TabIndex = 2;
            this.toUnitOutput.SelectedIndexChanged += new System.EventHandler(this.toUnitOutput_SelectedIndexChanged);
            // 
            // fromValueInput
            // 
            this.fromValueInput.AllowDrop = true;
            this.fromValueInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromValueInput.BackColor = System.Drawing.Color.Olive;
            this.fromValueInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fromValueInput.ForeColor = System.Drawing.Color.White;
            this.fromValueInput.Location = new System.Drawing.Point(167, 11);
            this.fromValueInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.fromValueInput.MaxLength = 256;
            this.fromValueInput.Name = "fromValueInput";
            this.fromValueInput.Size = new System.Drawing.Size(162, 21);
            this.fromValueInput.TabIndex = 3;
            this.fromValueInput.TextChanged += new System.EventHandler(this.fromValueInput_TextChanged);
            this.fromValueInput.Enter += new System.EventHandler(this.fromValueInput_Enter);
            this.fromValueInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fromValueInput_KeyDown);
            this.fromValueInput.Leave += new System.EventHandler(this.fromValueInput_Leave);
            // 
            // mainArea
            // 
            this.mainArea.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainArea.ColumnCount = 1;
            this.mainArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainArea.Controls.Add(this.converterTable, 0, 0);
            this.mainArea.Controls.Add(this.buttonsTable, 0, 1);
            this.mainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainArea.Location = new System.Drawing.Point(127, 2);
            this.mainArea.Margin = new System.Windows.Forms.Padding(2);
            this.mainArea.Name = "mainArea";
            this.mainArea.RowCount = 3;
            this.mainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.mainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.mainArea.Size = new System.Drawing.Size(335, 111);
            this.mainArea.TabIndex = 3;
            // 
            // buttonsTable
            // 
            this.buttonsTable.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonsTable.ColumnCount = 2;
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.Controls.Add(this.swapButton, 0, 0);
            this.buttonsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTable.Location = new System.Drawing.Point(0, 77);
            this.buttonsTable.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsTable.Name = "buttonsTable";
            this.buttonsTable.RowCount = 1;
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.buttonsTable.Size = new System.Drawing.Size(335, 32);
            this.buttonsTable.TabIndex = 4;
            // 
            // swapButton
            // 
            this.swapButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonsTable.SetColumnSpan(this.swapButton, 2);
            this.swapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swapButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swapButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.swapButton.FlatAppearance.BorderSize = 0;
            this.swapButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.swapButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.swapButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swapButton.ForeColor = System.Drawing.SystemColors.Window;
            this.swapButton.Location = new System.Drawing.Point(2, 2);
            this.swapButton.Margin = new System.Windows.Forms.Padding(2);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(331, 28);
            this.swapButton.TabIndex = 0;
            this.swapButton.TabStop = false;
            this.swapButton.Text = "&Swap";
            this.swapButton.UseVisualStyleBackColor = false;
            this.swapButton.Click += new System.EventHandler(this.swapButton_Click);
            // 
            // unitSelectorTable
            // 
            this.unitSelectorTable.BackColor = System.Drawing.Color.Olive;
            this.unitSelectorTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitSelectorTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unitSelectorTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitSelectorTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitSelectorTable.ForeColor = System.Drawing.SystemColors.Window;
            this.unitSelectorTable.FormattingEnabled = true;
            this.unitSelectorTable.Items.AddRange(new object[] {
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
            this.unitSelectorTable.Location = new System.Drawing.Point(4, 4);
            this.unitSelectorTable.Margin = new System.Windows.Forms.Padding(4);
            this.unitSelectorTable.Name = "unitSelectorTable";
            this.unitSelectorTable.Size = new System.Drawing.Size(117, 107);
            this.unitSelectorTable.TabIndex = 0;
            this.unitSelectorTable.SelectedIndexChanged += new System.EventHandler(this.unitSelectorTable_SelectedIndexChanged);
            // 
            // mainScreenTable
            // 
            this.mainScreenTable.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainScreenTable.ColumnCount = 2;
            this.mainScreenTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.mainScreenTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.mainScreenTable.Controls.Add(this.unitSelectorTable, 0, 0);
            this.mainScreenTable.Controls.Add(this.mainArea, 1, 0);
            this.mainScreenTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainScreenTable.Location = new System.Drawing.Point(0, 24);
            this.mainScreenTable.Name = "mainScreenTable";
            this.mainScreenTable.RowCount = 1;
            this.mainScreenTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainScreenTable.Size = new System.Drawing.Size(464, 115);
            this.mainScreenTable.TabIndex = 5;
            // 
            // statusIndicator
            // 
            this.statusIndicator.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusIndicator.Name = "statusIndicator";
            this.statusIndicator.Size = new System.Drawing.Size(39, 17);
            this.statusIndicator.Text = "Ready";
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusIndicator});
            this.statusBar.Location = new System.Drawing.Point(0, 139);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusBar.Size = new System.Drawing.Size(464, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusBar";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 161);
            this.Controls.Add(this.mainScreenTable);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 320);
            this.MinimumSize = new System.Drawing.Size(480, 200);
            this.Name = "MainScreen";
            this.Text = "Unit Converter";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.converterTable.ResumeLayout(false);
            this.converterTable.PerformLayout();
            this.mainArea.ResumeLayout(false);
            this.buttonsTable.ResumeLayout(false);
            this.mainScreenTable.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUnitConverterToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel mainArea;
        private System.Windows.Forms.TableLayoutPanel converterTable;
        private System.Windows.Forms.ComboBox fromUnitInput;
        private System.Windows.Forms.ComboBox toUnitOutput;
        private System.Windows.Forms.TextBox fromValueInput;
        private System.Windows.Forms.TextBox toValueOutput;
        private System.Windows.Forms.TableLayoutPanel buttonsTable;
        private System.Windows.Forms.Button swapButton;
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
        private System.Windows.Forms.ListBox unitSelectorTable;
        private System.Windows.Forms.TableLayoutPanel mainScreenTable;
        private System.Windows.Forms.ToolStripStatusLabel statusIndicator;
        private System.Windows.Forms.StatusStrip statusBar;
    }
}

