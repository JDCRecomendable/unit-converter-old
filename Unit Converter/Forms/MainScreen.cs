using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class MainScreen : Form
    {
        // (1) INITIALISATION - Create the main screen
        public MainScreen()
        {
            InitializeComponent();
            this.ActiveControl = unitSelectorTable;
            unitSelectorTable.Focus();
            unitSelectorTable.SelectedIndex = 0;
        }

        // (1) INITIALISATION - Define round-off value variable
        // (-1 if not to round off)
        short roundOffValue = -1;

        // (1) INITIALISATION - Define indicator when fromValueInput
        // is empty
        bool fromValueInputEmpty = true;

        // (1) INITIALISATION - Define list to contain round-off menu items
        List<ToolStripMenuItem> roundOffMenuItems = new List<ToolStripMenuItem>();

        // (1) INITIALISATION - Define lists to contain units
        List<Unit> lengthUnits = new List<Unit>();
        List<Unit> areaUnits = new List<Unit>();
        List<Unit> volumeUnits = new List<Unit>();
        List<Unit> timeUnits = new List<Unit>();
        List<Unit> speedUnits = new List<Unit>();
        List<Unit> massUnits = new List<Unit>();
        List<Unit> energyUnits = new List<Unit>();
        List<Unit> temperatureUnits = new List<Unit>();
        List<Unit> dataSizeUnits = new List<Unit>();


        // (1) INITIALISATION - Load elements to main screen controls
        private void MainScreen_Load(object sender, EventArgs e)
        {
            // Round-Off Value
            roundOffMenuItems.Add(doNotRoundOffToolStripMenuItem);
            roundOffMenuItems.Add(wholeNumberToolStripMenuItem);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem1);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem2);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem3);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem4);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem5);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem6);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem7);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem8);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem9);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem10);

            // UNIT TYPE 0 - Length
            lengthUnits.Add(LengthUnits.metre);
            lengthUnits.Add(LengthUnits.nauticalMile);
            lengthUnits.Add(LengthUnits.kilometre);
            lengthUnits.Add(LengthUnits.decimetre);
            lengthUnits.Add(LengthUnits.centimetre);
            lengthUnits.Add(LengthUnits.millimetre);
            lengthUnits.Add(LengthUnits.micrometre);
            lengthUnits.Add(LengthUnits.nanometre);
            lengthUnits.Add(LengthUnits.angstrom);
            lengthUnits.Add(LengthUnits.mile);
            lengthUnits.Add(LengthUnits.furlong);
            lengthUnits.Add(LengthUnits.chain);
            lengthUnits.Add(LengthUnits.rod);
            lengthUnits.Add(LengthUnits.horseLength);
            lengthUnits.Add(LengthUnits.fathom);
            lengthUnits.Add(LengthUnits.yard);
            lengthUnits.Add(LengthUnits.foot);
            lengthUnits.Add(LengthUnits.inch);

            // UNIT TYPE 1 - Area
            areaUnits.Add(AreaUnits.squareMetre);
            areaUnits.Add(AreaUnits.squareKilometre);
            areaUnits.Add(AreaUnits.squareDecimetre);
            areaUnits.Add(AreaUnits.squareCentimetre);
            areaUnits.Add(AreaUnits.squareMillimetre);
            areaUnits.Add(AreaUnits.squareMicrometre);
            areaUnits.Add(AreaUnits.are);
            areaUnits.Add(AreaUnits.stremma);
            areaUnits.Add(AreaUnits.hectare);
            areaUnits.Add(AreaUnits.tetrad);
            areaUnits.Add(AreaUnits.hectad);
            areaUnits.Add(AreaUnits.myriad);
            areaUnits.Add(AreaUnits.squareMile);
            areaUnits.Add(AreaUnits.squareYard);
            areaUnits.Add(AreaUnits.squareFoot);
            areaUnits.Add(AreaUnits.squareInch);
            areaUnits.Add(AreaUnits.acre);
            areaUnits.Add(AreaUnits.rood);
            areaUnits.Add(AreaUnits.section);
            areaUnits.Add(AreaUnits.township);

            // UNIT TYPE 2 - Volume
            volumeUnits.Add(VolumeUnits.cubicMetre);
            volumeUnits.Add(VolumeUnits.cubicCentimetre);
            volumeUnits.Add(VolumeUnits.cubicMillimetre);
            volumeUnits.Add(VolumeUnits.cubicYard);
            volumeUnits.Add(VolumeUnits.cubicFoot);
            volumeUnits.Add(VolumeUnits.cubicInch);
            volumeUnits.Add(VolumeUnits.litre);
            volumeUnits.Add(VolumeUnits.millilitre);
            volumeUnits.Add(VolumeUnits.barrel);
            volumeUnits.Add(VolumeUnits.gallon);
            volumeUnits.Add(VolumeUnits.quart);
            volumeUnits.Add(VolumeUnits.pint);
            volumeUnits.Add(VolumeUnits.cup);
            volumeUnits.Add(VolumeUnits.tablespoon);
            volumeUnits.Add(VolumeUnits.teaspoon);

            // UNIT TYPE 3 - Time
            timeUnits.Add(TimeUnits.second);
            timeUnits.Add(TimeUnits.millisecond);
            timeUnits.Add(TimeUnits.microsecond);
            timeUnits.Add(TimeUnits.nanosecond);
            timeUnits.Add(TimeUnits.minute);
            timeUnits.Add(TimeUnits.hour);
            timeUnits.Add(TimeUnits.day);
            timeUnits.Add(TimeUnits.week);
            timeUnits.Add(TimeUnits.fortnight);
            timeUnits.Add(TimeUnits.year);
            timeUnits.Add(TimeUnits.yearLeap);

            // UNIT TYPE 4 - Speed
            speedUnits.Add(SpeedUnits.metrePerSecond);
            speedUnits.Add(SpeedUnits.metrePerMinute);
            speedUnits.Add(SpeedUnits.metrePerHour);
            speedUnits.Add(SpeedUnits.kilometrePerSecond);
            speedUnits.Add(SpeedUnits.kilometrePerMinute);
            speedUnits.Add(SpeedUnits.kilometrePerHour);
            speedUnits.Add(SpeedUnits.speedOfLight);
            speedUnits.Add(SpeedUnits.footPerSecond);
            speedUnits.Add(SpeedUnits.footPerMinute);
            speedUnits.Add(SpeedUnits.footPerHour);
            speedUnits.Add(SpeedUnits.milePerSecond);
            speedUnits.Add(SpeedUnits.milePerMinute);
            speedUnits.Add(SpeedUnits.milePerHour);
            speedUnits.Add(SpeedUnits.mach);
            speedUnits.Add(SpeedUnits.knot);

            // UNIT TYPE 5 - Mass
            massUnits.Add(MassUnits.kilogram);
            massUnits.Add(MassUnits.gram);
            massUnits.Add(MassUnits.carat);
            massUnits.Add(MassUnits.milligram);
            massUnits.Add(MassUnits.microgram);
            massUnits.Add(MassUnits.tonne);
            massUnits.Add(MassUnits.kilotonne);
            massUnits.Add(MassUnits.pound);
            massUnits.Add(MassUnits.ounce);
            massUnits.Add(MassUnits.stoneUK);
            massUnits.Add(MassUnits.tonShort);
            massUnits.Add(MassUnits.tonLong);
            massUnits.Add(MassUnits.kilotonShort);
            massUnits.Add(MassUnits.kilotonLong);

            // UNIT TYPE 6 - Energy
            energyUnits.Add(EnergyUnits.joule);
            energyUnits.Add(EnergyUnits.kilojoule);
            energyUnits.Add(EnergyUnits.megajoule);
            energyUnits.Add(EnergyUnits.wattHour);
            energyUnits.Add(EnergyUnits.kilowattHour);
            energyUnits.Add(EnergyUnits.megawattHour);
            energyUnits.Add(EnergyUnits.calorie);
            energyUnits.Add(EnergyUnits.kilocalorie);
            energyUnits.Add(EnergyUnits.btu);

            // UNIT TYPE 7 - Temperature
            temperatureUnits.Add(TemperatureUnits.kelvin);
            temperatureUnits.Add(TemperatureUnits.celsius);
            temperatureUnits.Add(TemperatureUnits.fahrenheit);

            // UNIT TYPE 8 - Data Size
            dataSizeUnits.Add(DataSizeUnits.sizeByte);
            dataSizeUnits.Add(DataSizeUnits.sizeKilobyte);
            dataSizeUnits.Add(DataSizeUnits.sizeMegabyte);
            dataSizeUnits.Add(DataSizeUnits.sizeGigabyte);
            dataSizeUnits.Add(DataSizeUnits.sizeTerabyte);
            dataSizeUnits.Add(DataSizeUnits.sizePetabyte);

            // Load initial units
            foreach (Unit element in lengthUnits)
            {
                fromUnitInput.Items.Add(element.getName());
                toUnitOutput.Items.Add(element.getName());
            }

            // Reset fromValueInput
            SetFromValueInputTextToDefault(true);
        }

        // (2) MENU BAR EVENTS - Open the About box to show the application
        // credits
        private void aboutUnitConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        // (2) MENU BAR EVENTS - Toggle "Always On Top" feature
        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
                alwaysOnTopToolStripMenuItem.Checked = false;
            }
            else
            {
                this.TopMost = true;
                alwaysOnTopToolStripMenuItem.Checked = true;
            }
        }

        // (2) MENU BAR EVENTS - Helper function to uncheck all menu strip items
        private void UncheckAllRoundOffMenuItems()
        {
            foreach (ToolStripMenuItem element in roundOffMenuItems)
                element.Checked = false;
        }

        // (2) MENU BAR EVENTS - Helper function to set round-off value
        private void SetRoundOffValue(short value)
        {
            UncheckAllRoundOffMenuItems();
            roundOffValue = value;

            switch (value)
            {
                case -1:
                    doNotRoundOffToolStripMenuItem.Checked = true;
                    break;
                case 0:
                    wholeNumberToolStripMenuItem.Checked = true;
                    break;
                case 1:
                    decimalPlacesToolStripMenuItem1.Checked = true;
                    break;
                case 2:
                    decimalPlacesToolStripMenuItem2.Checked = true;
                    break;
                case 3:
                    decimalPlacesToolStripMenuItem3.Checked = true;
                    break;
                case 4:
                    decimalPlacesToolStripMenuItem4.Checked = true;
                    break;
                case 5:
                    decimalPlacesToolStripMenuItem5.Checked = true;
                    break;
                case 6:
                    decimalPlacesToolStripMenuItem6.Checked = true;
                    break;
                case 7:
                    decimalPlacesToolStripMenuItem7.Checked = true;
                    break;
                case 8:
                    decimalPlacesToolStripMenuItem8.Checked = true;
                    break;
                case 9:
                    decimalPlacesToolStripMenuItem9.Checked = true;
                    break;
                case (10):
                    decimalPlacesToolStripMenuItem10.Checked = true;
                    break;
            }

            ExecuteCalculation();
            statusIndicator.Text = StatusMessages.roundOffValueSet;
        }

        // (2) MENU BAR EVENTS - Set to not round off
        private void doNotRoundOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetRoundOffValue(-1);
        }

        // (2) MENU BAR EVENTS - Set round-off value to 0
        private void wholeNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetRoundOffValue(0);
        }

        // (2) MENU BAR EVENTS - Set round-off value to 1
        private void decimalPlacesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetRoundOffValue(1);
        }

        // (2) MENU BAR EVENTS - Set round-off value to 2
        private void decimalPlacesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SetRoundOffValue(2);
        }

        // (2) MENU BAR EVENTS - Set round-off value to 3
        private void decimalPlacesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SetRoundOffValue(3);
        }

        // (2) MENU BAR EVENTS - Set round-off value to 4
        private void decimalPlacesToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SetRoundOffValue(4);
        }

        // (2) MENU BAR EVENTS - Set round-off value to 5
        private void decimalPlacesToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SetRoundOffValue(5);
        }

        // (2) MENU BAR EVENTS - Set round-off value to 6
        private void decimalPlacesToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            SetRoundOffValue(6);
        }

        // (2) MENU BAR EVENTS - Set round-off value to 7
        private void decimalPlacesToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            SetRoundOffValue(7);
        }

        // (2) MENU BAR EVENTS - Set round-off value to 8
        private void decimalPlacesToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            SetRoundOffValue(8);
        }

        // (2) MENU BAR EVENTS - Set round-off value to 9
        private void decimalPlacesToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            SetRoundOffValue(9);
        }

        // (2) MENU BAR EVENTS - Set round-off value to 10
        private void decimalPlacesToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            SetRoundOffValue(10);
        }

        // (2) MENU BAR EVENTS - Close the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // (3) UNIT TYPE EVENTS - Helper function to add units in the combo box
        // for multiplicative units that use the Unit class
        private void AddComboBoxValues(List<Unit> unitList)
        {
            foreach (Unit element in unitList)
            {
                fromUnitInput.Items.Add(element.getName());
                toUnitOutput.Items.Add(element.getName());
            }
        }

        // (3) UNIT TYPE EVENTS - Do when unit type is changed
        private void unitSelectorTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool changedComboBoxValues = true;

            fromUnitInput.Items.Clear();
            toUnitOutput.Items.Clear();
            SetFromValueInputTextToDefault(true);
            toValueOutput.Clear();

            if (unitSelectorTable.SelectedIndex == UnitTypeIndices.length)
                AddComboBoxValues(lengthUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.area)
                AddComboBoxValues(areaUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.volume)
                AddComboBoxValues(volumeUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.time)
                AddComboBoxValues(timeUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.speed)
                AddComboBoxValues(speedUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.mass)
                AddComboBoxValues(massUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.energy)
                AddComboBoxValues(energyUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.temperature)
                AddComboBoxValues(temperatureUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.dataSize)
                AddComboBoxValues(dataSizeUnits);
            else
            {
                changedComboBoxValues = false;
                statusIndicator.Text = StatusMessages.unitTypeError;
            }

            if (changedComboBoxValues)
                statusIndicator.Text = StatusMessages.ready;
        }

        // (4) CONTROLS - Helper function to set fromValueInput text
        // when it gains or loses focus
        private void SetFromValueInputTextToDefault(bool reset)
        {
            if (reset)
            {
                fromValueInput.Text = FromValueInputConstants.defaultString;
                fromValueInput.ForeColor = FromValueInputConstants.grey;
                fromValueInputEmpty = true;
            }
            else
            {
                fromValueInput.Text = FromValueInputConstants.emptyString;
                fromValueInput.ForeColor = FromValueInputConstants.black;
                fromValueInputEmpty = false;
            }
        }

        // (4) CONTROLS - Do when fromValueInput gains focus
        private void fromValueInput_Enter(object sender, EventArgs e)
        {
            if (fromValueInputEmpty)
                SetFromValueInputTextToDefault(false);
        }

        // (4) CONTROLS - Do when fromValueInput loses focus
        private void fromValueInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fromValueInput.Text))
                SetFromValueInputTextToDefault(true);
        }

        // (4) CONTROLS - Attempt to calculate when fromUnitInput changed
        private void fromUnitInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toUnitOutput.SelectedIndex > -1 &&
            !(string.IsNullOrWhiteSpace(fromValueInput.Text)))
                ExecuteCalculation();
        }

        // (4) CONTROLS - Attempt to calculate when fromUnitInput changed
        private void toUnitOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fromUnitInput.SelectedIndex > -1 &&
            !(string.IsNullOrWhiteSpace(fromValueInput.Text)))
                ExecuteCalculation();
        }

        // (4) CONTROLS - Calculate when button clicked
        private void calculateButton_Click(object sender, EventArgs e)
        {
            ExecuteCalculation();
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void fromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteCalculation();
                e.SuppressKeyPress = true;
            }
        }

        // (5) SWAP - Swap the input and output units
        private void swapButton_Click(object sender, EventArgs e)
        {
            string tempUnitHolder;  // hold the unit temporarily here
            if (fromUnitInput.SelectedItem != toUnitOutput.SelectedItem)
            {
                tempUnitHolder = (string)fromUnitInput.SelectedItem;
                fromUnitInput.SelectedItem = (string)toUnitOutput.SelectedItem;
                toUnitOutput.SelectedItem = tempUnitHolder;
                ExecuteCalculation();
                statusIndicator.Text = StatusMessages.swapped;
            }
            else
                statusIndicator.Text = StatusMessages.invalidSwap;
        }

        // (6) CALCULATION - Helper function that calculates the result value
        // for multiplicative units that use Unit class and modifies status
        private void CalculateConversion(List<Unit> unitList)
        {
            // Raw data from the user-inputtable text box
            string rawValue;

            // Shows whether raw user input data can be parsed to double
            bool canParse;

            // Shows if the user has not selected a unit for fromUnitInput
            // combo box
            bool fromInputHasValue = false;

            // Shows if the user has not selected a unit for toUnitOutput
            // combo box
            bool toOutputHasValue = false;

            // Variables used to store intermediate and final values for
            // returning to the user
            double unitValue = 0;
            double resultUnitValue = 0;

            rawValue = fromValueInput.Text;
            canParse = double.TryParse(rawValue, result: out double inputValue);

            if (canParse)
            {
                foreach (Unit element in unitList)
                {
                    if ((string)fromUnitInput.SelectedItem == element.getName())
                    {
                        unitValue = element.convertToSiValue(inputValue);
                        fromInputHasValue = true;
                        break;
                    }
                }

                foreach (Unit element in unitList)
                {
                    if ((string)toUnitOutput.SelectedItem == element.getName())
                    {
                        resultUnitValue = element.convertFromSiValue(unitValue);
                        toOutputHasValue = true;
                        break;
                    }
                }

                if (fromInputHasValue && toOutputHasValue)
                {
                    if (roundOffValue >= 0)
                        toValueOutput.Text = Math.Round(resultUnitValue, roundOffValue).ToString();
                    else
                        toValueOutput.Text = resultUnitValue.ToString();
                    statusIndicator.Text = StatusMessages.done;
                }
                else
                    statusIndicator.Text = StatusMessages.unitError;
            }
            else
                statusIndicator.Text = StatusMessages.invalidInput;
        }

        // (6) CALCULATION - Execute the calculation process
        private void ExecuteCalculation()
        {
            if (unitSelectorTable.SelectedIndex == UnitTypeIndices.length)
                CalculateConversion(lengthUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.area)
                CalculateConversion(areaUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.volume)
                CalculateConversion(volumeUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.time)
                CalculateConversion(timeUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.speed)
                CalculateConversion(speedUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.mass)
                CalculateConversion(massUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.energy)
                CalculateConversion(energyUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.temperature)
                CalculateConversion(temperatureUnits);
            else if (unitSelectorTable.SelectedIndex == UnitTypeIndices.dataSize)
                CalculateConversion(dataSizeUnits);
            else
                statusIndicator.Text = StatusMessages.unitTypeError;
        }
    }
}