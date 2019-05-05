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
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUnitConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitSelector = new System.Windows.Forms.TabControl();
            this.lengthConverter = new System.Windows.Forms.TabPage();
            this.lengthConverterTable = new System.Windows.Forms.TableLayoutPanel();
            this.lengthToValueOutput = new System.Windows.Forms.TextBox();
            this.lengthFromUnitInput = new System.Windows.Forms.ComboBox();
            this.lengthToUnitOutput = new System.Windows.Forms.ComboBox();
            this.lengthFromValueInput = new System.Windows.Forms.TextBox();
            this.areaConverter = new System.Windows.Forms.TabPage();
            this.areaConverterTable = new System.Windows.Forms.TableLayoutPanel();
            this.areaToValueOutput = new System.Windows.Forms.TextBox();
            this.areaFromUnitInput = new System.Windows.Forms.ComboBox();
            this.areaToUnitOutput = new System.Windows.Forms.ComboBox();
            this.areaFromValueInput = new System.Windows.Forms.TextBox();
            this.volumeConverter = new System.Windows.Forms.TabPage();
            this.volumeConverterTable = new System.Windows.Forms.TableLayoutPanel();
            this.volumeToValueOutput = new System.Windows.Forms.TextBox();
            this.volumeFromUnitInput = new System.Windows.Forms.ComboBox();
            this.volumeToUnitOutput = new System.Windows.Forms.ComboBox();
            this.volumeFromValueInput = new System.Windows.Forms.TextBox();
            this.timeConverter = new System.Windows.Forms.TabPage();
            this.timeConverterTable = new System.Windows.Forms.TableLayoutPanel();
            this.timeToValueOutput = new System.Windows.Forms.TextBox();
            this.timeFromUnitInput = new System.Windows.Forms.ComboBox();
            this.timeToUnitOutput = new System.Windows.Forms.ComboBox();
            this.timeFromValueInput = new System.Windows.Forms.TextBox();
            this.speedConverter = new System.Windows.Forms.TabPage();
            this.speedConverterTable = new System.Windows.Forms.TableLayoutPanel();
            this.speedToValueOutput = new System.Windows.Forms.TextBox();
            this.speedFromUnitInput = new System.Windows.Forms.ComboBox();
            this.speedToUnitOutput = new System.Windows.Forms.ComboBox();
            this.speedFromValueInput = new System.Windows.Forms.TextBox();
            this.massConverter = new System.Windows.Forms.TabPage();
            this.massConverterTable = new System.Windows.Forms.TableLayoutPanel();
            this.massToValueOutput = new System.Windows.Forms.TextBox();
            this.massFromUnitInput = new System.Windows.Forms.ComboBox();
            this.massToUnitOutput = new System.Windows.Forms.ComboBox();
            this.massFromValueInput = new System.Windows.Forms.TextBox();
            this.energyConverter = new System.Windows.Forms.TabPage();
            this.energyConverterTable = new System.Windows.Forms.TableLayoutPanel();
            this.energyToValueOutput = new System.Windows.Forms.TextBox();
            this.energyFromUnitInput = new System.Windows.Forms.ComboBox();
            this.energyToUnitOutput = new System.Windows.Forms.ComboBox();
            this.energyFromValueInput = new System.Windows.Forms.TextBox();
            this.dataSizeConverter = new System.Windows.Forms.TabPage();
            this.dataSizeConverterTable = new System.Windows.Forms.TableLayoutPanel();
            this.dataSizeToValueOutput = new System.Windows.Forms.TextBox();
            this.dataSizeFromUnitInput = new System.Windows.Forms.ComboBox();
            this.dataSizeToUnitOutput = new System.Windows.Forms.ComboBox();
            this.dataSizeFromValueInput = new System.Windows.Forms.TextBox();
            this.lengthCalculateButton = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusIndicator = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainArea = new System.Windows.Forms.TableLayoutPanel();
            this.menuBar.SuspendLayout();
            this.unitSelector.SuspendLayout();
            this.lengthConverter.SuspendLayout();
            this.lengthConverterTable.SuspendLayout();
            this.areaConverter.SuspendLayout();
            this.areaConverterTable.SuspendLayout();
            this.volumeConverter.SuspendLayout();
            this.volumeConverterTable.SuspendLayout();
            this.timeConverter.SuspendLayout();
            this.timeConverterTable.SuspendLayout();
            this.speedConverter.SuspendLayout();
            this.speedConverterTable.SuspendLayout();
            this.massConverter.SuspendLayout();
            this.massConverterTable.SuspendLayout();
            this.energyConverter.SuspendLayout();
            this.energyConverterTable.SuspendLayout();
            this.dataSizeConverter.SuspendLayout();
            this.dataSizeConverterTable.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.mainArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(462, 28);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "Unit Converter Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUnitConverterToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutUnitConverterToolStripMenuItem
            // 
            this.aboutUnitConverterToolStripMenuItem.Name = "aboutUnitConverterToolStripMenuItem";
            this.aboutUnitConverterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutUnitConverterToolStripMenuItem.Text = "About Unit Converter";
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
            this.unitSelector.Controls.Add(this.dataSizeConverter);
            this.unitSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitSelector.Location = new System.Drawing.Point(3, 3);
            this.unitSelector.Name = "unitSelector";
            this.unitSelector.SelectedIndex = 0;
            this.unitSelector.Size = new System.Drawing.Size(456, 122);
            this.unitSelector.TabIndex = 1;
            this.unitSelector.TabStop = false;
            // 
            // lengthConverter
            // 
            this.lengthConverter.BackColor = System.Drawing.SystemColors.Control;
            this.lengthConverter.Controls.Add(this.lengthConverterTable);
            this.lengthConverter.Cursor = System.Windows.Forms.Cursors.Default;
            this.lengthConverter.Location = new System.Drawing.Point(4, 25);
            this.lengthConverter.Name = "lengthConverter";
            this.lengthConverter.Size = new System.Drawing.Size(448, 93);
            this.lengthConverter.TabIndex = 0;
            this.lengthConverter.Text = "Length";
            // 
            // lengthConverterTable
            // 
            this.lengthConverterTable.ColumnCount = 2;
            this.lengthConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.lengthConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.lengthConverterTable.Controls.Add(this.lengthToValueOutput, 1, 1);
            this.lengthConverterTable.Controls.Add(this.lengthFromUnitInput, 0, 0);
            this.lengthConverterTable.Controls.Add(this.lengthToUnitOutput, 0, 1);
            this.lengthConverterTable.Controls.Add(this.lengthFromValueInput, 1, 0);
            this.lengthConverterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lengthConverterTable.Location = new System.Drawing.Point(0, 0);
            this.lengthConverterTable.Name = "lengthConverterTable";
            this.lengthConverterTable.RowCount = 2;
            this.lengthConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lengthConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lengthConverterTable.Size = new System.Drawing.Size(448, 93);
            this.lengthConverterTable.TabIndex = 0;
            // 
            // lengthToValueOutput
            // 
            this.lengthToValueOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lengthToValueOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthToValueOutput.Location = new System.Drawing.Point(182, 57);
            this.lengthToValueOutput.MaxLength = 256;
            this.lengthToValueOutput.Name = "lengthToValueOutput";
            this.lengthToValueOutput.ReadOnly = true;
            this.lengthToValueOutput.ShortcutsEnabled = false;
            this.lengthToValueOutput.Size = new System.Drawing.Size(250, 24);
            this.lengthToValueOutput.TabIndex = 0;
            this.lengthToValueOutput.TabStop = false;
            // 
            // lengthFromUnitInput
            // 
            this.lengthFromUnitInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lengthFromUnitInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lengthFromUnitInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lengthFromUnitInput.Location = new System.Drawing.Point(16, 11);
            this.lengthFromUnitInput.Name = "lengthFromUnitInput";
            this.lengthFromUnitInput.Size = new System.Drawing.Size(160, 24);
            this.lengthFromUnitInput.Sorted = true;
            this.lengthFromUnitInput.TabIndex = 0;
            // 
            // lengthToUnitOutput
            // 
            this.lengthToUnitOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lengthToUnitOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lengthToUnitOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lengthToUnitOutput.Location = new System.Drawing.Point(16, 57);
            this.lengthToUnitOutput.Name = "lengthToUnitOutput";
            this.lengthToUnitOutput.Size = new System.Drawing.Size(160, 24);
            this.lengthToUnitOutput.Sorted = true;
            this.lengthToUnitOutput.TabIndex = 1;
            // 
            // lengthFromValueInput
            // 
            this.lengthFromValueInput.AllowDrop = true;
            this.lengthFromValueInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lengthFromValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthFromValueInput.Location = new System.Drawing.Point(182, 11);
            this.lengthFromValueInput.MaxLength = 256;
            this.lengthFromValueInput.Name = "lengthFromValueInput";
            this.lengthFromValueInput.Size = new System.Drawing.Size(250, 24);
            this.lengthFromValueInput.TabIndex = 2;
            this.lengthFromValueInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lengthFromValueInput_KeyDown);
            // 
            // areaConverter
            // 
            this.areaConverter.BackColor = System.Drawing.SystemColors.Control;
            this.areaConverter.Controls.Add(this.areaConverterTable);
            this.areaConverter.Cursor = System.Windows.Forms.Cursors.Default;
            this.areaConverter.Location = new System.Drawing.Point(4, 25);
            this.areaConverter.Name = "areaConverter";
            this.areaConverter.Size = new System.Drawing.Size(448, 93);
            this.areaConverter.TabIndex = 1;
            this.areaConverter.Text = "Area";
            // 
            // areaConverterTable
            // 
            this.areaConverterTable.ColumnCount = 2;
            this.areaConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.areaConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.areaConverterTable.Controls.Add(this.areaToValueOutput, 1, 1);
            this.areaConverterTable.Controls.Add(this.areaFromUnitInput, 0, 0);
            this.areaConverterTable.Controls.Add(this.areaToUnitOutput, 0, 1);
            this.areaConverterTable.Controls.Add(this.areaFromValueInput, 1, 0);
            this.areaConverterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.areaConverterTable.Location = new System.Drawing.Point(0, 0);
            this.areaConverterTable.Name = "areaConverterTable";
            this.areaConverterTable.RowCount = 2;
            this.areaConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.areaConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.areaConverterTable.Size = new System.Drawing.Size(448, 93);
            this.areaConverterTable.TabIndex = 2;
            // 
            // areaToValueOutput
            // 
            this.areaToValueOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.areaToValueOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaToValueOutput.Location = new System.Drawing.Point(182, 57);
            this.areaToValueOutput.MaxLength = 256;
            this.areaToValueOutput.Name = "areaToValueOutput";
            this.areaToValueOutput.ReadOnly = true;
            this.areaToValueOutput.ShortcutsEnabled = false;
            this.areaToValueOutput.Size = new System.Drawing.Size(250, 24);
            this.areaToValueOutput.TabIndex = 0;
            this.areaToValueOutput.TabStop = false;
            // 
            // areaFromUnitInput
            // 
            this.areaFromUnitInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.areaFromUnitInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.areaFromUnitInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areaFromUnitInput.Location = new System.Drawing.Point(16, 11);
            this.areaFromUnitInput.Name = "areaFromUnitInput";
            this.areaFromUnitInput.Size = new System.Drawing.Size(160, 24);
            this.areaFromUnitInput.Sorted = true;
            this.areaFromUnitInput.TabIndex = 0;
            // 
            // areaToUnitOutput
            // 
            this.areaToUnitOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.areaToUnitOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.areaToUnitOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areaToUnitOutput.Location = new System.Drawing.Point(16, 57);
            this.areaToUnitOutput.Name = "areaToUnitOutput";
            this.areaToUnitOutput.Size = new System.Drawing.Size(160, 24);
            this.areaToUnitOutput.Sorted = true;
            this.areaToUnitOutput.TabIndex = 1;
            // 
            // areaFromValueInput
            // 
            this.areaFromValueInput.AllowDrop = true;
            this.areaFromValueInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.areaFromValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaFromValueInput.Location = new System.Drawing.Point(182, 11);
            this.areaFromValueInput.MaxLength = 256;
            this.areaFromValueInput.Name = "areaFromValueInput";
            this.areaFromValueInput.Size = new System.Drawing.Size(250, 24);
            this.areaFromValueInput.TabIndex = 2;
            this.areaFromValueInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.areaFromValueInput_KeyDown);
            // 
            // volumeConverter
            // 
            this.volumeConverter.BackColor = System.Drawing.SystemColors.Control;
            this.volumeConverter.Controls.Add(this.volumeConverterTable);
            this.volumeConverter.Cursor = System.Windows.Forms.Cursors.Default;
            this.volumeConverter.Location = new System.Drawing.Point(4, 25);
            this.volumeConverter.Name = "volumeConverter";
            this.volumeConverter.Size = new System.Drawing.Size(448, 93);
            this.volumeConverter.TabIndex = 2;
            this.volumeConverter.Text = "Volume";
            // 
            // volumeConverterTable
            // 
            this.volumeConverterTable.ColumnCount = 2;
            this.volumeConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.volumeConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.volumeConverterTable.Controls.Add(this.volumeToValueOutput, 1, 1);
            this.volumeConverterTable.Controls.Add(this.volumeFromUnitInput, 0, 0);
            this.volumeConverterTable.Controls.Add(this.volumeToUnitOutput, 0, 1);
            this.volumeConverterTable.Controls.Add(this.volumeFromValueInput, 1, 0);
            this.volumeConverterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumeConverterTable.Location = new System.Drawing.Point(0, 0);
            this.volumeConverterTable.Name = "volumeConverterTable";
            this.volumeConverterTable.RowCount = 2;
            this.volumeConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.volumeConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.volumeConverterTable.Size = new System.Drawing.Size(448, 93);
            this.volumeConverterTable.TabIndex = 4;
            // 
            // volumeToValueOutput
            // 
            this.volumeToValueOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.volumeToValueOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeToValueOutput.Location = new System.Drawing.Point(182, 57);
            this.volumeToValueOutput.MaxLength = 256;
            this.volumeToValueOutput.Name = "volumeToValueOutput";
            this.volumeToValueOutput.ReadOnly = true;
            this.volumeToValueOutput.ShortcutsEnabled = false;
            this.volumeToValueOutput.Size = new System.Drawing.Size(250, 24);
            this.volumeToValueOutput.TabIndex = 0;
            this.volumeToValueOutput.TabStop = false;
            // 
            // volumeFromUnitInput
            // 
            this.volumeFromUnitInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.volumeFromUnitInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeFromUnitInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.volumeFromUnitInput.Location = new System.Drawing.Point(16, 10);
            this.volumeFromUnitInput.Name = "volumeFromUnitInput";
            this.volumeFromUnitInput.Size = new System.Drawing.Size(160, 24);
            this.volumeFromUnitInput.Sorted = true;
            this.volumeFromUnitInput.TabIndex = 0;
            // 
            // volumeToUnitOutput
            // 
            this.volumeToUnitOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.volumeToUnitOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeToUnitOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.volumeToUnitOutput.Location = new System.Drawing.Point(16, 57);
            this.volumeToUnitOutput.Name = "volumeToUnitOutput";
            this.volumeToUnitOutput.Size = new System.Drawing.Size(160, 24);
            this.volumeToUnitOutput.Sorted = true;
            this.volumeToUnitOutput.TabIndex = 1;
            // 
            // volumeFromValueInput
            // 
            this.volumeFromValueInput.AllowDrop = true;
            this.volumeFromValueInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.volumeFromValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeFromValueInput.Location = new System.Drawing.Point(182, 11);
            this.volumeFromValueInput.MaxLength = 256;
            this.volumeFromValueInput.Name = "volumeFromValueInput";
            this.volumeFromValueInput.Size = new System.Drawing.Size(250, 24);
            this.volumeFromValueInput.TabIndex = 2;
            this.volumeFromValueInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.volumeFromValueInput_KeyDown);
            // 
            // timeConverter
            // 
            this.timeConverter.BackColor = System.Drawing.SystemColors.Control;
            this.timeConverter.Controls.Add(this.timeConverterTable);
            this.timeConverter.Location = new System.Drawing.Point(4, 25);
            this.timeConverter.Name = "timeConverter";
            this.timeConverter.Size = new System.Drawing.Size(448, 93);
            this.timeConverter.TabIndex = 7;
            this.timeConverter.Text = "Time";
            // 
            // timeConverterTable
            // 
            this.timeConverterTable.ColumnCount = 2;
            this.timeConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.timeConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.timeConverterTable.Controls.Add(this.timeToValueOutput, 1, 1);
            this.timeConverterTable.Controls.Add(this.timeFromUnitInput, 0, 0);
            this.timeConverterTable.Controls.Add(this.timeToUnitOutput, 0, 1);
            this.timeConverterTable.Controls.Add(this.timeFromValueInput, 1, 0);
            this.timeConverterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeConverterTable.Location = new System.Drawing.Point(0, 0);
            this.timeConverterTable.Name = "timeConverterTable";
            this.timeConverterTable.RowCount = 2;
            this.timeConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timeConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timeConverterTable.Size = new System.Drawing.Size(448, 93);
            this.timeConverterTable.TabIndex = 1;
            // 
            // timeToValueOutput
            // 
            this.timeToValueOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timeToValueOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeToValueOutput.Location = new System.Drawing.Point(182, 57);
            this.timeToValueOutput.MaxLength = 256;
            this.timeToValueOutput.Name = "timeToValueOutput";
            this.timeToValueOutput.ReadOnly = true;
            this.timeToValueOutput.ShortcutsEnabled = false;
            this.timeToValueOutput.Size = new System.Drawing.Size(250, 24);
            this.timeToValueOutput.TabIndex = 0;
            this.timeToValueOutput.TabStop = false;
            // 
            // timeFromUnitInput
            // 
            this.timeFromUnitInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timeFromUnitInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeFromUnitInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeFromUnitInput.Location = new System.Drawing.Point(16, 11);
            this.timeFromUnitInput.Name = "timeFromUnitInput";
            this.timeFromUnitInput.Size = new System.Drawing.Size(160, 24);
            this.timeFromUnitInput.Sorted = true;
            this.timeFromUnitInput.TabIndex = 0;
            // 
            // timeToUnitOutput
            // 
            this.timeToUnitOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timeToUnitOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeToUnitOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeToUnitOutput.Location = new System.Drawing.Point(16, 57);
            this.timeToUnitOutput.Name = "timeToUnitOutput";
            this.timeToUnitOutput.Size = new System.Drawing.Size(160, 24);
            this.timeToUnitOutput.Sorted = true;
            this.timeToUnitOutput.TabIndex = 1;
            // 
            // timeFromValueInput
            // 
            this.timeFromValueInput.AllowDrop = true;
            this.timeFromValueInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timeFromValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFromValueInput.Location = new System.Drawing.Point(182, 11);
            this.timeFromValueInput.MaxLength = 256;
            this.timeFromValueInput.Name = "timeFromValueInput";
            this.timeFromValueInput.Size = new System.Drawing.Size(250, 24);
            this.timeFromValueInput.TabIndex = 2;
            this.timeFromValueInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timeFromValueInput_KeyDown);
            // 
            // speedConverter
            // 
            this.speedConverter.BackColor = System.Drawing.SystemColors.Control;
            this.speedConverter.Controls.Add(this.speedConverterTable);
            this.speedConverter.Cursor = System.Windows.Forms.Cursors.Default;
            this.speedConverter.Location = new System.Drawing.Point(4, 25);
            this.speedConverter.Name = "speedConverter";
            this.speedConverter.Size = new System.Drawing.Size(448, 93);
            this.speedConverter.TabIndex = 5;
            this.speedConverter.Text = "Speed";
            // 
            // speedConverterTable
            // 
            this.speedConverterTable.ColumnCount = 2;
            this.speedConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.speedConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.speedConverterTable.Controls.Add(this.speedToValueOutput, 1, 1);
            this.speedConverterTable.Controls.Add(this.speedFromUnitInput, 0, 0);
            this.speedConverterTable.Controls.Add(this.speedToUnitOutput, 0, 1);
            this.speedConverterTable.Controls.Add(this.speedFromValueInput, 1, 0);
            this.speedConverterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedConverterTable.Location = new System.Drawing.Point(0, 0);
            this.speedConverterTable.Name = "speedConverterTable";
            this.speedConverterTable.RowCount = 2;
            this.speedConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.speedConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.speedConverterTable.Size = new System.Drawing.Size(448, 93);
            this.speedConverterTable.TabIndex = 1;
            // 
            // speedToValueOutput
            // 
            this.speedToValueOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.speedToValueOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedToValueOutput.Location = new System.Drawing.Point(182, 57);
            this.speedToValueOutput.MaxLength = 256;
            this.speedToValueOutput.Name = "speedToValueOutput";
            this.speedToValueOutput.ReadOnly = true;
            this.speedToValueOutput.ShortcutsEnabled = false;
            this.speedToValueOutput.Size = new System.Drawing.Size(250, 24);
            this.speedToValueOutput.TabIndex = 0;
            this.speedToValueOutput.TabStop = false;
            // 
            // speedFromUnitInput
            // 
            this.speedFromUnitInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.speedFromUnitInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speedFromUnitInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speedFromUnitInput.Location = new System.Drawing.Point(16, 11);
            this.speedFromUnitInput.Name = "speedFromUnitInput";
            this.speedFromUnitInput.Size = new System.Drawing.Size(160, 24);
            this.speedFromUnitInput.Sorted = true;
            this.speedFromUnitInput.TabIndex = 0;
            // 
            // speedToUnitOutput
            // 
            this.speedToUnitOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.speedToUnitOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speedToUnitOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speedToUnitOutput.Location = new System.Drawing.Point(16, 57);
            this.speedToUnitOutput.Name = "speedToUnitOutput";
            this.speedToUnitOutput.Size = new System.Drawing.Size(160, 24);
            this.speedToUnitOutput.Sorted = true;
            this.speedToUnitOutput.TabIndex = 1;
            // 
            // speedFromValueInput
            // 
            this.speedFromValueInput.AllowDrop = true;
            this.speedFromValueInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.speedFromValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedFromValueInput.Location = new System.Drawing.Point(182, 11);
            this.speedFromValueInput.MaxLength = 256;
            this.speedFromValueInput.Name = "speedFromValueInput";
            this.speedFromValueInput.Size = new System.Drawing.Size(250, 24);
            this.speedFromValueInput.TabIndex = 2;
            this.speedFromValueInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedFromValueInput_KeyDown);
            // 
            // massConverter
            // 
            this.massConverter.BackColor = System.Drawing.SystemColors.Control;
            this.massConverter.Controls.Add(this.massConverterTable);
            this.massConverter.Cursor = System.Windows.Forms.Cursors.Default;
            this.massConverter.Location = new System.Drawing.Point(4, 25);
            this.massConverter.Name = "massConverter";
            this.massConverter.Size = new System.Drawing.Size(448, 93);
            this.massConverter.TabIndex = 6;
            this.massConverter.Text = "Mass";
            // 
            // massConverterTable
            // 
            this.massConverterTable.ColumnCount = 2;
            this.massConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.massConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.massConverterTable.Controls.Add(this.massToValueOutput, 1, 1);
            this.massConverterTable.Controls.Add(this.massFromUnitInput, 0, 0);
            this.massConverterTable.Controls.Add(this.massToUnitOutput, 0, 1);
            this.massConverterTable.Controls.Add(this.massFromValueInput, 1, 0);
            this.massConverterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.massConverterTable.Location = new System.Drawing.Point(0, 0);
            this.massConverterTable.Name = "massConverterTable";
            this.massConverterTable.RowCount = 2;
            this.massConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.massConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.massConverterTable.Size = new System.Drawing.Size(448, 93);
            this.massConverterTable.TabIndex = 1;
            // 
            // massToValueOutput
            // 
            this.massToValueOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.massToValueOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.massToValueOutput.Location = new System.Drawing.Point(182, 57);
            this.massToValueOutput.MaxLength = 256;
            this.massToValueOutput.Name = "massToValueOutput";
            this.massToValueOutput.ReadOnly = true;
            this.massToValueOutput.ShortcutsEnabled = false;
            this.massToValueOutput.Size = new System.Drawing.Size(250, 24);
            this.massToValueOutput.TabIndex = 0;
            this.massToValueOutput.TabStop = false;
            // 
            // massFromUnitInput
            // 
            this.massFromUnitInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.massFromUnitInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.massFromUnitInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.massFromUnitInput.Location = new System.Drawing.Point(16, 11);
            this.massFromUnitInput.Name = "massFromUnitInput";
            this.massFromUnitInput.Size = new System.Drawing.Size(160, 24);
            this.massFromUnitInput.Sorted = true;
            this.massFromUnitInput.TabIndex = 0;
            // 
            // massToUnitOutput
            // 
            this.massToUnitOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.massToUnitOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.massToUnitOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.massToUnitOutput.Location = new System.Drawing.Point(16, 57);
            this.massToUnitOutput.Name = "massToUnitOutput";
            this.massToUnitOutput.Size = new System.Drawing.Size(160, 24);
            this.massToUnitOutput.Sorted = true;
            this.massToUnitOutput.TabIndex = 1;
            // 
            // massFromValueInput
            // 
            this.massFromValueInput.AllowDrop = true;
            this.massFromValueInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.massFromValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.massFromValueInput.Location = new System.Drawing.Point(182, 11);
            this.massFromValueInput.MaxLength = 256;
            this.massFromValueInput.Name = "massFromValueInput";
            this.massFromValueInput.Size = new System.Drawing.Size(250, 24);
            this.massFromValueInput.TabIndex = 2;
            this.massFromValueInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.massFromValueInput_KeyDown);
            // 
            // energyConverter
            // 
            this.energyConverter.BackColor = System.Drawing.SystemColors.Control;
            this.energyConverter.Controls.Add(this.energyConverterTable);
            this.energyConverter.Cursor = System.Windows.Forms.Cursors.Default;
            this.energyConverter.Location = new System.Drawing.Point(4, 25);
            this.energyConverter.Name = "energyConverter";
            this.energyConverter.Size = new System.Drawing.Size(448, 93);
            this.energyConverter.TabIndex = 4;
            this.energyConverter.Text = "Energy";
            // 
            // energyConverterTable
            // 
            this.energyConverterTable.ColumnCount = 2;
            this.energyConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.energyConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.energyConverterTable.Controls.Add(this.energyToValueOutput, 1, 1);
            this.energyConverterTable.Controls.Add(this.energyFromUnitInput, 0, 0);
            this.energyConverterTable.Controls.Add(this.energyToUnitOutput, 0, 1);
            this.energyConverterTable.Controls.Add(this.energyFromValueInput, 1, 0);
            this.energyConverterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.energyConverterTable.Location = new System.Drawing.Point(0, 0);
            this.energyConverterTable.Name = "energyConverterTable";
            this.energyConverterTable.RowCount = 2;
            this.energyConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.energyConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.energyConverterTable.Size = new System.Drawing.Size(448, 93);
            this.energyConverterTable.TabIndex = 1;
            // 
            // energyToValueOutput
            // 
            this.energyToValueOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.energyToValueOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyToValueOutput.Location = new System.Drawing.Point(182, 57);
            this.energyToValueOutput.MaxLength = 256;
            this.energyToValueOutput.Name = "energyToValueOutput";
            this.energyToValueOutput.ReadOnly = true;
            this.energyToValueOutput.ShortcutsEnabled = false;
            this.energyToValueOutput.Size = new System.Drawing.Size(250, 24);
            this.energyToValueOutput.TabIndex = 0;
            this.energyToValueOutput.TabStop = false;
            // 
            // energyFromUnitInput
            // 
            this.energyFromUnitInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.energyFromUnitInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.energyFromUnitInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.energyFromUnitInput.Location = new System.Drawing.Point(16, 11);
            this.energyFromUnitInput.Name = "energyFromUnitInput";
            this.energyFromUnitInput.Size = new System.Drawing.Size(160, 24);
            this.energyFromUnitInput.Sorted = true;
            this.energyFromUnitInput.TabIndex = 0;
            // 
            // energyToUnitOutput
            // 
            this.energyToUnitOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.energyToUnitOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.energyToUnitOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.energyToUnitOutput.Location = new System.Drawing.Point(16, 57);
            this.energyToUnitOutput.Name = "energyToUnitOutput";
            this.energyToUnitOutput.Size = new System.Drawing.Size(160, 24);
            this.energyToUnitOutput.Sorted = true;
            this.energyToUnitOutput.TabIndex = 1;
            // 
            // energyFromValueInput
            // 
            this.energyFromValueInput.AllowDrop = true;
            this.energyFromValueInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.energyFromValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyFromValueInput.Location = new System.Drawing.Point(182, 11);
            this.energyFromValueInput.MaxLength = 256;
            this.energyFromValueInput.Name = "energyFromValueInput";
            this.energyFromValueInput.Size = new System.Drawing.Size(250, 24);
            this.energyFromValueInput.TabIndex = 2;
            this.energyFromValueInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.energyFromValueInput_KeyDown);
            // 
            // dataSizeConverter
            // 
            this.dataSizeConverter.BackColor = System.Drawing.SystemColors.Control;
            this.dataSizeConverter.Controls.Add(this.dataSizeConverterTable);
            this.dataSizeConverter.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataSizeConverter.Location = new System.Drawing.Point(4, 25);
            this.dataSizeConverter.Name = "dataSizeConverter";
            this.dataSizeConverter.Size = new System.Drawing.Size(448, 93);
            this.dataSizeConverter.TabIndex = 3;
            this.dataSizeConverter.Text = "Data Size";
            // 
            // dataSizeConverterTable
            // 
            this.dataSizeConverterTable.ColumnCount = 2;
            this.dataSizeConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.dataSizeConverterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.dataSizeConverterTable.Controls.Add(this.dataSizeToValueOutput, 1, 1);
            this.dataSizeConverterTable.Controls.Add(this.dataSizeFromUnitInput, 0, 0);
            this.dataSizeConverterTable.Controls.Add(this.dataSizeToUnitOutput, 0, 1);
            this.dataSizeConverterTable.Controls.Add(this.dataSizeFromValueInput, 1, 0);
            this.dataSizeConverterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSizeConverterTable.Location = new System.Drawing.Point(0, 0);
            this.dataSizeConverterTable.Name = "dataSizeConverterTable";
            this.dataSizeConverterTable.RowCount = 2;
            this.dataSizeConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dataSizeConverterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dataSizeConverterTable.Size = new System.Drawing.Size(448, 93);
            this.dataSizeConverterTable.TabIndex = 1;
            // 
            // dataSizeToValueOutput
            // 
            this.dataSizeToValueOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataSizeToValueOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataSizeToValueOutput.Location = new System.Drawing.Point(182, 57);
            this.dataSizeToValueOutput.MaxLength = 256;
            this.dataSizeToValueOutput.Name = "dataSizeToValueOutput";
            this.dataSizeToValueOutput.ReadOnly = true;
            this.dataSizeToValueOutput.ShortcutsEnabled = false;
            this.dataSizeToValueOutput.Size = new System.Drawing.Size(250, 24);
            this.dataSizeToValueOutput.TabIndex = 0;
            this.dataSizeToValueOutput.TabStop = false;
            // 
            // dataSizeFromUnitInput
            // 
            this.dataSizeFromUnitInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataSizeFromUnitInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataSizeFromUnitInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataSizeFromUnitInput.Location = new System.Drawing.Point(16, 11);
            this.dataSizeFromUnitInput.Name = "dataSizeFromUnitInput";
            this.dataSizeFromUnitInput.Size = new System.Drawing.Size(160, 24);
            this.dataSizeFromUnitInput.TabIndex = 0;
            // 
            // dataSizeToUnitOutput
            // 
            this.dataSizeToUnitOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataSizeToUnitOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataSizeToUnitOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataSizeToUnitOutput.Location = new System.Drawing.Point(16, 57);
            this.dataSizeToUnitOutput.Name = "dataSizeToUnitOutput";
            this.dataSizeToUnitOutput.Size = new System.Drawing.Size(160, 24);
            this.dataSizeToUnitOutput.TabIndex = 1;
            // 
            // dataSizeFromValueInput
            // 
            this.dataSizeFromValueInput.AllowDrop = true;
            this.dataSizeFromValueInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataSizeFromValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataSizeFromValueInput.Location = new System.Drawing.Point(182, 11);
            this.dataSizeFromValueInput.MaxLength = 256;
            this.dataSizeFromValueInput.Name = "dataSizeFromValueInput";
            this.dataSizeFromValueInput.Size = new System.Drawing.Size(250, 24);
            this.dataSizeFromValueInput.TabIndex = 2;
            this.dataSizeFromValueInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataSizeFromValueInput_KeyDown);
            // 
            // lengthCalculateButton
            // 
            this.lengthCalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lengthCalculateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lengthCalculateButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthCalculateButton.Location = new System.Drawing.Point(10, 131);
            this.lengthCalculateButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lengthCalculateButton.Name = "lengthCalculateButton";
            this.lengthCalculateButton.Size = new System.Drawing.Size(442, 34);
            this.lengthCalculateButton.TabIndex = 3;
            this.lengthCalculateButton.Text = "Calculate";
            this.lengthCalculateButton.UseVisualStyleBackColor = true;
            this.lengthCalculateButton.Click += new System.EventHandler(this.lengthCalculateButton_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusIndicator});
            this.statusBar.Location = new System.Drawing.Point(0, 208);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(462, 25);
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
            this.mainArea.Controls.Add(this.unitSelector, 0, 0);
            this.mainArea.Controls.Add(this.lengthCalculateButton, 0, 1);
            this.mainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainArea.Location = new System.Drawing.Point(0, 28);
            this.mainArea.Name = "mainArea";
            this.mainArea.RowCount = 3;
            this.mainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.mainArea.Size = new System.Drawing.Size(462, 180);
            this.mainArea.TabIndex = 3;
            this.mainArea.Paint += new System.Windows.Forms.PaintEventHandler(this.mainArea_Paint);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 233);
            this.Controls.Add(this.mainArea);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 400);
            this.MinimumSize = new System.Drawing.Size(480, 280);
            this.Name = "MainScreen";
            this.Text = "Unit Converter";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.unitSelector.ResumeLayout(false);
            this.lengthConverter.ResumeLayout(false);
            this.lengthConverterTable.ResumeLayout(false);
            this.lengthConverterTable.PerformLayout();
            this.areaConverter.ResumeLayout(false);
            this.areaConverterTable.ResumeLayout(false);
            this.areaConverterTable.PerformLayout();
            this.volumeConverter.ResumeLayout(false);
            this.volumeConverterTable.ResumeLayout(false);
            this.volumeConverterTable.PerformLayout();
            this.timeConverter.ResumeLayout(false);
            this.timeConverterTable.ResumeLayout(false);
            this.timeConverterTable.PerformLayout();
            this.speedConverter.ResumeLayout(false);
            this.speedConverterTable.ResumeLayout(false);
            this.speedConverterTable.PerformLayout();
            this.massConverter.ResumeLayout(false);
            this.massConverterTable.ResumeLayout(false);
            this.massConverterTable.PerformLayout();
            this.energyConverter.ResumeLayout(false);
            this.energyConverterTable.ResumeLayout(false);
            this.energyConverterTable.PerformLayout();
            this.dataSizeConverter.ResumeLayout(false);
            this.dataSizeConverterTable.ResumeLayout(false);
            this.dataSizeConverterTable.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.mainArea.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage dataSizeConverter;
        private System.Windows.Forms.Button lengthCalculateButton;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusIndicator;
        private System.Windows.Forms.TableLayoutPanel mainArea;
        private System.Windows.Forms.TableLayoutPanel lengthConverterTable;
        private System.Windows.Forms.ComboBox lengthFromUnitInput;
        private System.Windows.Forms.ComboBox lengthToUnitOutput;
        private System.Windows.Forms.TextBox lengthFromValueInput;
        private System.Windows.Forms.TextBox lengthToValueOutput;
        private System.Windows.Forms.TabPage massConverter;
        private System.Windows.Forms.TableLayoutPanel energyConverterTable;
        private System.Windows.Forms.TextBox energyToValueOutput;
        private System.Windows.Forms.ComboBox energyFromUnitInput;
        private System.Windows.Forms.ComboBox energyToUnitOutput;
        private System.Windows.Forms.TextBox energyFromValueInput;
        private System.Windows.Forms.TableLayoutPanel speedConverterTable;
        private System.Windows.Forms.TextBox speedToValueOutput;
        private System.Windows.Forms.ComboBox speedFromUnitInput;
        private System.Windows.Forms.ComboBox speedToUnitOutput;
        private System.Windows.Forms.TextBox speedFromValueInput;
        private System.Windows.Forms.TableLayoutPanel massConverterTable;
        private System.Windows.Forms.TextBox massToValueOutput;
        private System.Windows.Forms.ComboBox massFromUnitInput;
        private System.Windows.Forms.ComboBox massToUnitOutput;
        private System.Windows.Forms.TextBox massFromValueInput;
        private System.Windows.Forms.TableLayoutPanel dataSizeConverterTable;
        private System.Windows.Forms.TextBox dataSizeToValueOutput;
        private System.Windows.Forms.ComboBox dataSizeFromUnitInput;
        private System.Windows.Forms.ComboBox dataSizeToUnitOutput;
        private System.Windows.Forms.TextBox dataSizeFromValueInput;
        private System.Windows.Forms.TabPage timeConverter;
        private System.Windows.Forms.TableLayoutPanel timeConverterTable;
        private System.Windows.Forms.TextBox timeToValueOutput;
        private System.Windows.Forms.ComboBox timeFromUnitInput;
        private System.Windows.Forms.ComboBox timeToUnitOutput;
        private System.Windows.Forms.TextBox timeFromValueInput;
        private System.Windows.Forms.TableLayoutPanel volumeConverterTable;
        private System.Windows.Forms.TextBox volumeToValueOutput;
        private System.Windows.Forms.ComboBox volumeFromUnitInput;
        private System.Windows.Forms.ComboBox volumeToUnitOutput;
        private System.Windows.Forms.TextBox volumeFromValueInput;
        private System.Windows.Forms.TableLayoutPanel areaConverterTable;
        private System.Windows.Forms.TextBox areaToValueOutput;
        private System.Windows.Forms.ComboBox areaFromUnitInput;
        private System.Windows.Forms.ComboBox areaToUnitOutput;
        private System.Windows.Forms.TextBox areaFromValueInput;
    }
}

