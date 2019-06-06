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
        List<Unit> flowVolumeUnits = new List<Unit>();
        List<Unit> flowMassUnits = new List<Unit>();
        List<Unit> massUnits = new List<Unit>();
        List<Unit> energyUnits = new List<Unit>();
        List<Unit> pressureUnits = new List<Unit>();
        List<Unit> temperatureUnits = new List<Unit>();
        List<Unit> luminanceUnits = new List<Unit>();
        List<Unit> illuminanceUnits = new List<Unit>();
        List<Unit> angleUnits = new List<Unit>();
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
            lengthUnits.Add(LengthUnit.metre);
            lengthUnits.Add(LengthUnit.nauticalMile);
            lengthUnits.Add(LengthUnit.kilometre);
            lengthUnits.Add(LengthUnit.decimetre);
            lengthUnits.Add(LengthUnit.centimetre);
            lengthUnits.Add(LengthUnit.millimetre);
            lengthUnits.Add(LengthUnit.micrometre);
            lengthUnits.Add(LengthUnit.nanometre);
            lengthUnits.Add(LengthUnit.angstrom);
            lengthUnits.Add(LengthUnit.mile);
            lengthUnits.Add(LengthUnit.furlong);
            lengthUnits.Add(LengthUnit.chain);
            lengthUnits.Add(LengthUnit.rod);
            lengthUnits.Add(LengthUnit.horseLength);
            lengthUnits.Add(LengthUnit.fathom);
            lengthUnits.Add(LengthUnit.yard);
            lengthUnits.Add(LengthUnit.foot);
            lengthUnits.Add(LengthUnit.inch);

            // UNIT TYPE 1 - Area
            areaUnits.Add(AreaUnit.squareMetre);
            areaUnits.Add(AreaUnit.squareKilometre);
            areaUnits.Add(AreaUnit.squareDecimetre);
            areaUnits.Add(AreaUnit.squareCentimetre);
            areaUnits.Add(AreaUnit.squareMillimetre);
            areaUnits.Add(AreaUnit.squareMicrometre);
            areaUnits.Add(AreaUnit.are);
            areaUnits.Add(AreaUnit.stremma);
            areaUnits.Add(AreaUnit.hectare);
            areaUnits.Add(AreaUnit.tetrad);
            areaUnits.Add(AreaUnit.hectad);
            areaUnits.Add(AreaUnit.myriad);
            areaUnits.Add(AreaUnit.squareMile);
            areaUnits.Add(AreaUnit.squareYard);
            areaUnits.Add(AreaUnit.squareFoot);
            areaUnits.Add(AreaUnit.squareInch);
            areaUnits.Add(AreaUnit.acre);
            areaUnits.Add(AreaUnit.rood);
            areaUnits.Add(AreaUnit.section);
            areaUnits.Add(AreaUnit.township);

            // UNIT TYPE 2 - Volume
            volumeUnits.Add(VolumeUnit.cubicMetre);
            volumeUnits.Add(VolumeUnit.cubicCentimetre);
            volumeUnits.Add(VolumeUnit.cubicMillimetre);
            volumeUnits.Add(VolumeUnit.cubicYard);
            volumeUnits.Add(VolumeUnit.cubicFoot);
            volumeUnits.Add(VolumeUnit.cubicInch);
            volumeUnits.Add(VolumeUnit.litre);
            volumeUnits.Add(VolumeUnit.millilitre);
            volumeUnits.Add(VolumeUnit.barrel);
            volumeUnits.Add(VolumeUnit.gallon);
            volumeUnits.Add(VolumeUnit.quart);
            volumeUnits.Add(VolumeUnit.pint);
            volumeUnits.Add(VolumeUnit.cup);
            volumeUnits.Add(VolumeUnit.tablespoon);
            volumeUnits.Add(VolumeUnit.teaspoon);

            // UNIT TYPE 3 - Time
            timeUnits.Add(TimeUnit.second);
            timeUnits.Add(TimeUnit.millisecond);
            timeUnits.Add(TimeUnit.microsecond);
            timeUnits.Add(TimeUnit.nanosecond);
            timeUnits.Add(TimeUnit.minute);
            timeUnits.Add(TimeUnit.hour);
            timeUnits.Add(TimeUnit.day);
            timeUnits.Add(TimeUnit.week);
            timeUnits.Add(TimeUnit.fortnight);
            timeUnits.Add(TimeUnit.year);
            timeUnits.Add(TimeUnit.yearLeap);

            // UNIT TYPE 4 - Speed
            speedUnits.Add(SpeedUnit.metrePerSecond);
            speedUnits.Add(SpeedUnit.metrePerMinute);
            speedUnits.Add(SpeedUnit.metrePerHour);
            speedUnits.Add(SpeedUnit.kilometrePerSecond);
            speedUnits.Add(SpeedUnit.kilometrePerMinute);
            speedUnits.Add(SpeedUnit.kilometrePerHour);
            speedUnits.Add(SpeedUnit.speedOfLight);
            speedUnits.Add(SpeedUnit.footPerSecond);
            speedUnits.Add(SpeedUnit.footPerMinute);
            speedUnits.Add(SpeedUnit.footPerHour);
            speedUnits.Add(SpeedUnit.milePerSecond);
            speedUnits.Add(SpeedUnit.milePerMinute);
            speedUnits.Add(SpeedUnit.milePerHour);
            speedUnits.Add(SpeedUnit.mach);
            speedUnits.Add(SpeedUnit.knot);

            // UNIT TYPE 5 - Flow Rate (Volume)

            // UNIT TYPE 6 - Flow Rate (Mass)

            // UNIT TYPE 7 - Mass
            massUnits.Add(MassUnit.kilogram);
            massUnits.Add(MassUnit.gram);
            massUnits.Add(MassUnit.carat);
            massUnits.Add(MassUnit.milligram);
            massUnits.Add(MassUnit.microgram);
            massUnits.Add(MassUnit.tonne);
            massUnits.Add(MassUnit.kilotonne);
            massUnits.Add(MassUnit.pound);
            massUnits.Add(MassUnit.ounce);
            massUnits.Add(MassUnit.stoneUK);
            massUnits.Add(MassUnit.tonShort);
            massUnits.Add(MassUnit.tonLong);
            massUnits.Add(MassUnit.kilotonShort);
            massUnits.Add(MassUnit.kilotonLong);

            // UNIT TYPE 8 - Energy
            energyUnits.Add(EnergyUnit.joule);
            energyUnits.Add(EnergyUnit.kilojoule);
            energyUnits.Add(EnergyUnit.megajoule);
            energyUnits.Add(EnergyUnit.wattHour);
            energyUnits.Add(EnergyUnit.kilowattHour);
            energyUnits.Add(EnergyUnit.megawattHour);
            energyUnits.Add(EnergyUnit.calorie);
            energyUnits.Add(EnergyUnit.kilocalorie);
            energyUnits.Add(EnergyUnit.btu);

            // UNIT TYPE 9 - Pressure
            pressureUnits.Add(PressureUnit.pascal);
            pressureUnits.Add(PressureUnit.hectopascal);
            pressureUnits.Add(PressureUnit.kilopascal);
            pressureUnits.Add(PressureUnit.atmosphere);
            pressureUnits.Add(PressureUnit.atmosphereTechnical);
            pressureUnits.Add(PressureUnit.bar);
            pressureUnits.Add(PressureUnit.kilobar);
            pressureUnits.Add(PressureUnit.megabar);
            pressureUnits.Add(PressureUnit.decibar);
            pressureUnits.Add(PressureUnit.centibar);
            pressureUnits.Add(PressureUnit.millibar);
            pressureUnits.Add(PressureUnit.millimetreOfMercury);
            pressureUnits.Add(PressureUnit.centimetreOfMercury);
            pressureUnits.Add(PressureUnit.inchOfMercury);
            pressureUnits.Add(PressureUnit.footOfMercury);
            pressureUnits.Add(PressureUnit.millimetreOfWater);
            pressureUnits.Add(PressureUnit.centimetreOfWater);
            pressureUnits.Add(PressureUnit.metreOfWater);
            pressureUnits.Add(PressureUnit.inchOfWater);
            pressureUnits.Add(PressureUnit.footOfWater);
            pressureUnits.Add(PressureUnit.psi);
            pressureUnits.Add(PressureUnit.torr);

            // UNIT TYPE 10 - Temperature
            temperatureUnits.Add(TemperatureUnit.kelvin);
            temperatureUnits.Add(TemperatureUnit.celsius);
            temperatureUnits.Add(TemperatureUnit.fahrenheit);

            // UNIT TYPE 11 - Luminance
            luminanceUnits.Add(LuminanceUnit.candelaPerSquareMetre);
            luminanceUnits.Add(LuminanceUnit.candelaPerSquareDecimetre);
            luminanceUnits.Add(LuminanceUnit.candelaPerSquareCentimetre);
            luminanceUnits.Add(LuminanceUnit.candelaPerSquareMillimetre);
            luminanceUnits.Add(LuminanceUnit.candelaPerSquareFoot);
            luminanceUnits.Add(LuminanceUnit.candelaPerSquareInch);
            luminanceUnits.Add(LuminanceUnit.kilocandelaPerSquareMetre);
            luminanceUnits.Add(LuminanceUnit.kilocandelaPerSquareFoot);
            luminanceUnits.Add(LuminanceUnit.lambert);
            luminanceUnits.Add(LuminanceUnit.footLambert);
            luminanceUnits.Add(LuminanceUnit.nit);
            luminanceUnits.Add(LuminanceUnit.stilb);
            luminanceUnits.Add(LuminanceUnit.apostilb);
            luminanceUnits.Add(LuminanceUnit.skot);
            luminanceUnits.Add(LuminanceUnit.bril);

            // UNIT TYPE 12 - Illuminance
            illuminanceUnits.Add(IlluminanceUnit.lux);
            illuminanceUnits.Add(IlluminanceUnit.kilolux);
            illuminanceUnits.Add(IlluminanceUnit.megalux);
            illuminanceUnits.Add(IlluminanceUnit.gigalux);
            illuminanceUnits.Add(IlluminanceUnit.millilux);
            illuminanceUnits.Add(IlluminanceUnit.microlux);
            illuminanceUnits.Add(IlluminanceUnit.nanolux);
            illuminanceUnits.Add(IlluminanceUnit.phot);
            illuminanceUnits.Add(IlluminanceUnit.milliphot);
            illuminanceUnits.Add(IlluminanceUnit.nox);
            illuminanceUnits.Add(IlluminanceUnit.lumensPerSquareMetre);
            illuminanceUnits.Add(IlluminanceUnit.lumensPerSquareDecimetre);
            illuminanceUnits.Add(IlluminanceUnit.lumensPerSquareCentimetre);
            illuminanceUnits.Add(IlluminanceUnit.lumensPerSquareMillimetre);
            illuminanceUnits.Add(IlluminanceUnit.footCandle);

            // UNIT TYPE 13 - Angle
            angleUnits.Add(AngleUnit.degree);
            angleUnits.Add(AngleUnit.radian);
            angleUnits.Add(AngleUnit.gradian);
            angleUnits.Add(AngleUnit.second);
            angleUnits.Add(AngleUnit.minute);
            angleUnits.Add(AngleUnit.octant);
            angleUnits.Add(AngleUnit.sextant);
            angleUnits.Add(AngleUnit.quadrant);
            angleUnits.Add(AngleUnit.semicircle);
            angleUnits.Add(AngleUnit.circle);

            // UNIT TYPE 14 - Data Size
            dataSizeUnits.Add(DataSizeUnit.sizeByte);
            dataSizeUnits.Add(DataSizeUnit.sizeKilobyte);
            dataSizeUnits.Add(DataSizeUnit.sizeMegabyte);
            dataSizeUnits.Add(DataSizeUnit.sizeGigabyte);
            dataSizeUnits.Add(DataSizeUnit.sizeTerabyte);
            dataSizeUnits.Add(DataSizeUnit.sizePetabyte);

            // Load initial units
            foreach (Unit element in lengthUnits)
            {
                fromUnitInput.Items.Add(element.GetName());
                toUnitOutput.Items.Add(element.GetName());
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
                case 10:
                    decimalPlacesToolStripMenuItem10.Checked = true;
                    break;
            }

            ExecuteCalculation();
            statusIndicator.Text = StatusMessage.roundOffValueSet;
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
                fromUnitInput.Items.Add(element.GetName());
                toUnitOutput.Items.Add(element.GetName());
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

            switch (unitSelectorTable.SelectedIndex)
            {
                case UnitTypeIndex.length:
                    AddComboBoxValues(lengthUnits);
                    break;
                case UnitTypeIndex.area:
                    AddComboBoxValues(areaUnits);
                    break;
                case UnitTypeIndex.volume:
                    AddComboBoxValues(volumeUnits);
                    break;
                case UnitTypeIndex.time:
                    AddComboBoxValues(timeUnits);
                    break;
                case UnitTypeIndex.speed:
                    AddComboBoxValues(speedUnits);
                    break;
                case UnitTypeIndex.flowVolume:
                    AddComboBoxValues(flowVolumeUnits);
                    break;
                case UnitTypeIndex.flowMass:
                    AddComboBoxValues(flowMassUnits);
                    break;
                case UnitTypeIndex.mass:
                    AddComboBoxValues(massUnits);
                    break;
                case UnitTypeIndex.energy:
                    AddComboBoxValues(energyUnits);
                    break;
                case UnitTypeIndex.pressure:
                    AddComboBoxValues(pressureUnits);
                    break;
                case UnitTypeIndex.temperature:
                    AddComboBoxValues(temperatureUnits);
                    break;
                case UnitTypeIndex.luminance:
                    AddComboBoxValues(luminanceUnits);
                    break;
                case UnitTypeIndex.illuminance:
                    AddComboBoxValues(illuminanceUnits);
                    break;
                case UnitTypeIndex.angle:
                    AddComboBoxValues(angleUnits);
                    break;
                case UnitTypeIndex.dataSize:
                    AddComboBoxValues(dataSizeUnits);
                    break;
                default:
                    changedComboBoxValues = false;
                    statusIndicator.Text = StatusMessage.unitTypeError;
                    break;
            }

            if (changedComboBoxValues)
                statusIndicator.Text = StatusMessage.ready;
        }

        // (4) CONTROLS - Helper function to set fromValueInput text properties
        // when it gains or loses focus
        private void SetFromValueInputTextToDefault(bool reset)
        {
            string currentStatusMessage = statusIndicator.Text;

            if (reset)
            {
                fromValueInput.Text = FromValueInputConstant.defaultString;
                fromValueInput.ForeColor = FromValueInputConstant.grey;
                fromValueInputEmpty = true;
            }
            else
            {
                fromValueInput.Text = FromValueInputConstant.emptyString;
                fromValueInput.ForeColor = FromValueInputConstant.black;
                fromValueInputEmpty = false;
            }

            statusIndicator.Text = currentStatusMessage;
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
            if (toUnitOutput.SelectedIndex > -1 && !fromValueInputEmpty)
                ExecuteCalculation();
        }

        // (4) CONTROLS - Attempt to calculate when fromUnitInput changed
        private void toUnitOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fromUnitInput.SelectedIndex > -1 && !fromValueInputEmpty)
                ExecuteCalculation();
        }

        // (4) CONTROLS - Automagically perform calculation when input text
        // is changed
        private void fromValueInput_TextChanged(object sender, EventArgs e)
        {
            if (fromUnitInput.SelectedIndex > -1 &&
                toUnitOutput.SelectedIndex > -1 &&
                !string.IsNullOrWhiteSpace(fromValueInput.Text) &&
                !fromValueInputEmpty)
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
                statusIndicator.Text = StatusMessage.swapped;
            }
            else
                statusIndicator.Text = StatusMessage.invalidSwap;
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
                    if ((string)fromUnitInput.SelectedItem == element.GetName())
                    {
                        unitValue = element.ConvertToSiValue(inputValue);
                        fromInputHasValue = true;
                        break;
                    }
                }

                foreach (Unit element in unitList)
                {
                    if ((string)toUnitOutput.SelectedItem == element.GetName())
                    {
                        resultUnitValue = element.ConvertFromSiValue(unitValue);
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
                    statusIndicator.Text = StatusMessage.done;
                }
                else
                    statusIndicator.Text = StatusMessage.unitError;
            }
            else
                statusIndicator.Text = StatusMessage.invalidInput;
        }

        // (6) CALCULATION - Execute the calculation process
        private void ExecuteCalculation()
        {
            switch (unitSelectorTable.SelectedIndex)
            {
                case UnitTypeIndex.length:
                    CalculateConversion(lengthUnits);
                    break;
                case UnitTypeIndex.area:
                    CalculateConversion(areaUnits);
                    break;
                case UnitTypeIndex.volume:
                    CalculateConversion(volumeUnits);
                    break;
                case UnitTypeIndex.time:
                    CalculateConversion(timeUnits);
                    break;
                case UnitTypeIndex.speed:
                    CalculateConversion(speedUnits);
                    break;
                case UnitTypeIndex.flowVolume:
                    CalculateConversion(flowVolumeUnits);
                    break;
                case UnitTypeIndex.flowMass:
                    CalculateConversion(flowMassUnits);
                    break;
                case UnitTypeIndex.mass:
                    CalculateConversion(massUnits);
                    break;
                case UnitTypeIndex.energy:
                    CalculateConversion(energyUnits);
                    break;
                case UnitTypeIndex.pressure:
                    CalculateConversion(pressureUnits);
                    break;
                case UnitTypeIndex.temperature:
                    CalculateConversion(temperatureUnits);
                    break;
                case UnitTypeIndex.luminance:
                    CalculateConversion(luminanceUnits);
                    break;
                case UnitTypeIndex.illuminance:
                    CalculateConversion(illuminanceUnits);
                    break;
                case UnitTypeIndex.angle:
                    CalculateConversion(angleUnits);
                    break;
                case UnitTypeIndex.dataSize:
                    CalculateConversion(dataSizeUnits);
                    break;
                default:
                    statusIndicator.Text = StatusMessage.unitTypeError;
                    break;
            }
        }
    }
}