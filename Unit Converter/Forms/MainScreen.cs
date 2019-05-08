using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            this.ActiveControl = lengthFromUnitInput;
            lengthFromUnitInput.Focus();

            // Detect if unit type changed (tab changed)
            unitSelector.SelectedIndexChanged += new EventHandler(unitSelector_SelectedIndexChanged);
        }

        // Open the About box to show the application credits
        private void aboutUnitConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        // Close the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainArea_Paint(object sender, PaintEventArgs e)
        {

        }

        // Initialise the MainScreen form
        private void MainScreen_Load(object sender, EventArgs e)
        {
            // Add items to LengthFromUnit combo box
            lengthFromUnitInput.Items.Add(LengthConversion.metre);
            lengthFromUnitInput.Items.Add(LengthConversion.kilometre);
            lengthFromUnitInput.Items.Add(LengthConversion.decimetre);
            lengthFromUnitInput.Items.Add(LengthConversion.centimetre);
            lengthFromUnitInput.Items.Add(LengthConversion.millimetre);
            lengthFromUnitInput.Items.Add(LengthConversion.mile);
            lengthFromUnitInput.Items.Add(LengthConversion.yard);
            lengthFromUnitInput.Items.Add(LengthConversion.foot);
            lengthFromUnitInput.Items.Add(LengthConversion.inch);

            // Add items to LengthToUnit combo box
            lengthToUnitOutput.Items.Add(LengthConversion.metre);
            lengthToUnitOutput.Items.Add(LengthConversion.kilometre);
            lengthToUnitOutput.Items.Add(LengthConversion.decimetre);
            lengthToUnitOutput.Items.Add(LengthConversion.centimetre);
            lengthToUnitOutput.Items.Add(LengthConversion.millimetre);
            lengthToUnitOutput.Items.Add(LengthConversion.mile);
            lengthToUnitOutput.Items.Add(LengthConversion.yard);
            lengthToUnitOutput.Items.Add(LengthConversion.foot);
            lengthToUnitOutput.Items.Add(LengthConversion.inch);


            // Add items to AreaFromUnit combo box
            areaFromUnitInput.Items.Add(AreaConversion.squareMetre);
            areaFromUnitInput.Items.Add(AreaConversion.squareKilometre);
            areaFromUnitInput.Items.Add(AreaConversion.squareDecimetre);
            areaFromUnitInput.Items.Add(AreaConversion.squareCentimetre);
            areaFromUnitInput.Items.Add(AreaConversion.squareMillimetre);
            areaFromUnitInput.Items.Add(AreaConversion.squareMile);
            areaFromUnitInput.Items.Add(AreaConversion.squareYard);
            areaFromUnitInput.Items.Add(AreaConversion.squareFoot);
            areaFromUnitInput.Items.Add(AreaConversion.squareInch);
            areaFromUnitInput.Items.Add(AreaConversion.acre);
            areaFromUnitInput.Items.Add(AreaConversion.are);
            areaFromUnitInput.Items.Add(AreaConversion.hectare);

            // Add items to AreaToUnit combo box
            areaToUnitOutput.Items.Add(AreaConversion.squareMetre);
            areaToUnitOutput.Items.Add(AreaConversion.squareKilometre);
            areaToUnitOutput.Items.Add(AreaConversion.squareDecimetre);
            areaToUnitOutput.Items.Add(AreaConversion.squareCentimetre);
            areaToUnitOutput.Items.Add(AreaConversion.squareMillimetre);
            areaToUnitOutput.Items.Add(AreaConversion.squareMile);
            areaToUnitOutput.Items.Add(AreaConversion.squareYard);
            areaToUnitOutput.Items.Add(AreaConversion.squareFoot);
            areaToUnitOutput.Items.Add(AreaConversion.squareInch);
            areaToUnitOutput.Items.Add(AreaConversion.acre);
            areaToUnitOutput.Items.Add(AreaConversion.are);
            areaToUnitOutput.Items.Add(AreaConversion.hectare);


            // Add items to VolumeFromUnit combo box
            volumeFromUnitInput.Items.Add(VolumeConversion.cubicMetre);
            volumeFromUnitInput.Items.Add(VolumeConversion.cubicCentimetre);
            volumeFromUnitInput.Items.Add(VolumeConversion.cubicMillimetre);
            volumeFromUnitInput.Items.Add(VolumeConversion.cubicYard);
            volumeFromUnitInput.Items.Add(VolumeConversion.cubicFoot);
            volumeFromUnitInput.Items.Add(VolumeConversion.cubicInch);
            volumeFromUnitInput.Items.Add(VolumeConversion.litre);
            volumeFromUnitInput.Items.Add(VolumeConversion.millilitre);
            volumeFromUnitInput.Items.Add(VolumeConversion.gallon);
            volumeFromUnitInput.Items.Add(VolumeConversion.quart);
            volumeFromUnitInput.Items.Add(VolumeConversion.pint);
            volumeFromUnitInput.Items.Add(VolumeConversion.cup);
            volumeFromUnitInput.Items.Add(VolumeConversion.tablespoon);
            volumeFromUnitInput.Items.Add(VolumeConversion.teaspoon);

            // Add items to VolumeToUnit combo box
            volumeToUnitOutput.Items.Add(VolumeConversion.cubicMetre);
            volumeToUnitOutput.Items.Add(VolumeConversion.cubicCentimetre);
            volumeToUnitOutput.Items.Add(VolumeConversion.cubicMillimetre);
            volumeToUnitOutput.Items.Add(VolumeConversion.cubicYard);
            volumeToUnitOutput.Items.Add(VolumeConversion.cubicFoot);
            volumeToUnitOutput.Items.Add(VolumeConversion.cubicInch);
            volumeToUnitOutput.Items.Add(VolumeConversion.litre);
            volumeToUnitOutput.Items.Add(VolumeConversion.millilitre);
            volumeToUnitOutput.Items.Add(VolumeConversion.gallon);
            volumeToUnitOutput.Items.Add(VolumeConversion.quart);
            volumeToUnitOutput.Items.Add(VolumeConversion.pint);
            volumeToUnitOutput.Items.Add(VolumeConversion.cup);
            volumeToUnitOutput.Items.Add(VolumeConversion.tablespoon);
            volumeToUnitOutput.Items.Add(VolumeConversion.teaspoon);


            // Add items to TimeFromUnit combo box
            timeFromUnitInput.Items.Add(TimeConversion.second);
            timeFromUnitInput.Items.Add(TimeConversion.millisecond);
            timeFromUnitInput.Items.Add(TimeConversion.microsecond);
            timeFromUnitInput.Items.Add(TimeConversion.nanosecond);
            timeFromUnitInput.Items.Add(TimeConversion.minute);
            timeFromUnitInput.Items.Add(TimeConversion.hour);
            timeFromUnitInput.Items.Add(TimeConversion.day);
            timeFromUnitInput.Items.Add(TimeConversion.week);
            timeFromUnitInput.Items.Add(TimeConversion.fortnight);
            timeFromUnitInput.Items.Add(TimeConversion.year);
            timeFromUnitInput.Items.Add(TimeConversion.yearLeap);

            // Add items to TimeToUnit combo box
            timeToUnitOutput.Items.Add(TimeConversion.second);
            timeToUnitOutput.Items.Add(TimeConversion.millisecond);
            timeToUnitOutput.Items.Add(TimeConversion.microsecond);
            timeToUnitOutput.Items.Add(TimeConversion.nanosecond);
            timeToUnitOutput.Items.Add(TimeConversion.minute);
            timeToUnitOutput.Items.Add(TimeConversion.hour);
            timeToUnitOutput.Items.Add(TimeConversion.day);
            timeToUnitOutput.Items.Add(TimeConversion.week);
            timeToUnitOutput.Items.Add(TimeConversion.fortnight);
            timeToUnitOutput.Items.Add(TimeConversion.year);
            timeToUnitOutput.Items.Add(TimeConversion.yearLeap);


            // Add items to SpeedFromUnit combo box
            speedFromUnitInput.Items.Add(SpeedConversion.metrePerSecond);
            speedFromUnitInput.Items.Add(SpeedConversion.metrePerHour);
            speedFromUnitInput.Items.Add(SpeedConversion.kilometrePerSecond);
            speedFromUnitInput.Items.Add(SpeedConversion.kilometrePerHour);
            speedFromUnitInput.Items.Add(SpeedConversion.footPerSecond);
            speedFromUnitInput.Items.Add(SpeedConversion.footPerHour);
            speedFromUnitInput.Items.Add(SpeedConversion.milePerSecond);
            speedFromUnitInput.Items.Add(SpeedConversion.milePerHour);

            // Add items to SpeedToUnit combo box
            speedToUnitOutput.Items.Add(SpeedConversion.metrePerSecond);
            speedToUnitOutput.Items.Add(SpeedConversion.metrePerHour);
            speedToUnitOutput.Items.Add(SpeedConversion.kilometrePerSecond);
            speedToUnitOutput.Items.Add(SpeedConversion.kilometrePerHour);
            speedToUnitOutput.Items.Add(SpeedConversion.footPerSecond);
            speedToUnitOutput.Items.Add(SpeedConversion.footPerHour);
            speedToUnitOutput.Items.Add(SpeedConversion.milePerSecond);
            speedToUnitOutput.Items.Add(SpeedConversion.milePerHour);


            // Add items to MassFromUnit combo box
            massFromUnitInput.Items.Add(MassConversion.kilogram);
            massFromUnitInput.Items.Add(MassConversion.gram);
            massFromUnitInput.Items.Add(MassConversion.milligram);
            massFromUnitInput.Items.Add(MassConversion.microgram);
            massFromUnitInput.Items.Add(MassConversion.tonne);
            massFromUnitInput.Items.Add(MassConversion.kilotonne);
            massFromUnitInput.Items.Add(MassConversion.pound);
            massFromUnitInput.Items.Add(MassConversion.ounce);
            massFromUnitInput.Items.Add(MassConversion.stoneUK);
            massFromUnitInput.Items.Add(MassConversion.tonShort);
            massFromUnitInput.Items.Add(MassConversion.tonLong);
            massFromUnitInput.Items.Add(MassConversion.kilotonShort);
            massFromUnitInput.Items.Add(MassConversion.kilotonLong);

            // Add items to MassToUnit combo box
            massToUnitOutput.Items.Add(MassConversion.kilogram);
            massToUnitOutput.Items.Add(MassConversion.gram);
            massToUnitOutput.Items.Add(MassConversion.milligram);
            massToUnitOutput.Items.Add(MassConversion.microgram);
            massToUnitOutput.Items.Add(MassConversion.tonne);
            massToUnitOutput.Items.Add(MassConversion.kilotonne);
            massToUnitOutput.Items.Add(MassConversion.pound);
            massToUnitOutput.Items.Add(MassConversion.ounce);
            massToUnitOutput.Items.Add(MassConversion.stoneUK);
            massToUnitOutput.Items.Add(MassConversion.tonShort);
            massToUnitOutput.Items.Add(MassConversion.tonLong);
            massToUnitOutput.Items.Add(MassConversion.kilotonShort);
            massToUnitOutput.Items.Add(MassConversion.kilotonLong);


            // Add items to EnergyFromUnit combo box
            energyFromUnitInput.Items.Add(EnergyConversion.joule);
            energyFromUnitInput.Items.Add(EnergyConversion.kilojoule);
            energyFromUnitInput.Items.Add(EnergyConversion.wattHour);
            energyFromUnitInput.Items.Add(EnergyConversion.kilowattHour);
            energyFromUnitInput.Items.Add(EnergyConversion.calorie);
            energyFromUnitInput.Items.Add(EnergyConversion.kilocalorie);
            energyFromUnitInput.Items.Add(EnergyConversion.btu);

            // Add items to EnergyToUnit combo box
            energyToUnitOutput.Items.Add(EnergyConversion.joule);
            energyToUnitOutput.Items.Add(EnergyConversion.kilojoule);
            energyToUnitOutput.Items.Add(EnergyConversion.wattHour);
            energyToUnitOutput.Items.Add(EnergyConversion.kilowattHour);
            energyToUnitOutput.Items.Add(EnergyConversion.calorie);
            energyToUnitOutput.Items.Add(EnergyConversion.kilocalorie);
            energyToUnitOutput.Items.Add(EnergyConversion.btu);


            // Add items to TemperatureFromUnit combo box
            temperatureFromUnitInput.Items.Add(TemperatureConversion.kelvin);
            temperatureFromUnitInput.Items.Add(TemperatureConversion.celsius);
            temperatureFromUnitInput.Items.Add(TemperatureConversion.fahrenheit);

            // Add items to TemperatureToUnit combo box
            temperatureToUnitOutput.Items.Add(TemperatureConversion.kelvin);
            temperatureToUnitOutput.Items.Add(TemperatureConversion.celsius);
            temperatureToUnitOutput.Items.Add(TemperatureConversion.fahrenheit);


            // Add items to DataSizeFromUnit combo box
            dataSizeFromUnitInput.Items.Add(DataSizeConversion.sizeByte);
            dataSizeFromUnitInput.Items.Add(DataSizeConversion.sizeKilobyte);
            dataSizeFromUnitInput.Items.Add(DataSizeConversion.sizeMegabyte);
            dataSizeFromUnitInput.Items.Add(DataSizeConversion.sizeGigabyte);
            dataSizeFromUnitInput.Items.Add(DataSizeConversion.sizeTerabyte);
            dataSizeFromUnitInput.Items.Add(DataSizeConversion.sizePetabyte);

            // Add items to DataSizeToUnit combo box
            dataSizeToUnitOutput.Items.Add(DataSizeConversion.sizeByte);
            dataSizeToUnitOutput.Items.Add(DataSizeConversion.sizeKilobyte);
            dataSizeToUnitOutput.Items.Add(DataSizeConversion.sizeMegabyte);
            dataSizeToUnitOutput.Items.Add(DataSizeConversion.sizeGigabyte);
            dataSizeToUnitOutput.Items.Add(DataSizeConversion.sizeTerabyte);
            dataSizeToUnitOutput.Items.Add(DataSizeConversion.sizePetabyte);
        }

        private void lengthCalculateButton_Click(object sender, EventArgs e)
        {
            ExecuteCalculation();
        }

        private void lengthFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void areaFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void volumeFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void timeFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void speedFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void massFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void energyFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void temperatureFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void dataSizeFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        // Execute the calculation process
        private void ExecuteCalculation()
        {
            string rawValue;         // raw data from the user-inputtable text box
            double inputValue;       // processed data from the user-inputtable text box
            bool canParse;           // shows whether raw user input data can be parsed to double
            bool unitError = false;  // shows if the user has not selected a unit for both from and or combo boxes

            // User wants to convert length
            if (unitSelector.SelectedIndex == 0)
            {
                double lengthValue = 0;
                double resultLengthValue = 0;

                rawValue = lengthFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.metre)
                        lengthValue = inputValue;
                    else if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.kilometre)
                        lengthValue = inputValue * LengthConversion.kilometreToMetreValue;
                    else if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.decimetre)
                        lengthValue = inputValue * LengthConversion.decimetreToMetreValue;
                    else if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.centimetre)
                        lengthValue = inputValue * LengthConversion.centimetreToMetreValue;
                    else if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.millimetre)
                        lengthValue = inputValue * LengthConversion.millimetreToMetreValue;
                    else if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.mile)
                        lengthValue = inputValue * LengthConversion.mileToMetreValue;
                    else if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.yard)
                        lengthValue = inputValue * LengthConversion.yardToMetreValue;
                    else if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.foot)
                        lengthValue = inputValue * LengthConversion.footToMetreValue;
                    else if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.inch)
                        lengthValue = inputValue * LengthConversion.inchToMetreValue;
                    else
                        unitError = true;

                    if ((unitError == false) && ((string)lengthToUnitOutput.SelectedItem == LengthConversion.metre))
                        resultLengthValue = lengthValue;
                    else if ((string)lengthToUnitOutput.SelectedItem == LengthConversion.kilometre)
                        resultLengthValue = lengthValue * LengthConversion.metreToKilometreValue;
                    else if ((string)lengthToUnitOutput.SelectedItem == LengthConversion.decimetre)
                        resultLengthValue = lengthValue * LengthConversion.metreToDecimetreValue;
                    else if ((string)lengthToUnitOutput.SelectedItem == LengthConversion.centimetre)
                        resultLengthValue = lengthValue * LengthConversion.metreToCentimetreValue;
                    else if ((string)lengthToUnitOutput.SelectedItem == LengthConversion.millimetre)
                        resultLengthValue = lengthValue * LengthConversion.metreToMillimetreValue;
                    else if ((string)lengthToUnitOutput.SelectedItem == LengthConversion.mile)
                        resultLengthValue = lengthValue * LengthConversion.metreToMileValue;
                    else if ((string)lengthToUnitOutput.SelectedItem == LengthConversion.yard)
                        resultLengthValue = lengthValue * LengthConversion.metreToYardValue;
                    else if ((string)lengthToUnitOutput.SelectedItem == LengthConversion.foot)
                        resultLengthValue = lengthValue * LengthConversion.metreToFootValue;
                    else if ((string)lengthToUnitOutput.SelectedItem == LengthConversion.inch)
                        resultLengthValue = lengthValue * LengthConversion.metreToInchValue;
                    else
                        unitError = true;

                    if (unitError == false)
                    {
                        lengthToValueOutput.Text = resultLengthValue.ToString();
                        statusIndicator.Text = StatusMessages.done;
                    }
                    else
                        statusIndicator.Text = StatusMessages.unitError;
                }
                else
                    statusIndicator.Text = StatusMessages.invalidInput;
            }

            // User wants to convert area
            else if (unitSelector.SelectedIndex == 1)
            {
                double areaValue = 0;
                double resultAreaValue = 0;

                rawValue = areaFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareMetre)
                        areaValue = inputValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareKilometre)
                        areaValue = inputValue * AreaConversion.squareKilometreToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareDecimetre)
                        areaValue = inputValue * AreaConversion.squareDecimetreToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareCentimetre)
                        areaValue = inputValue * AreaConversion.squareCentimetreToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareMillimetre)
                        areaValue = inputValue * AreaConversion.squareMillimetreToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareMile)
                        areaValue = inputValue * AreaConversion.squareMileToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareYard)
                        areaValue = inputValue * AreaConversion.squareYardToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareFoot)
                        areaValue = inputValue * AreaConversion.squareFootToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareInch)
                        areaValue = inputValue * AreaConversion.squareInchToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.acre)
                        areaValue = inputValue * AreaConversion.acreToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.are)
                        areaValue = inputValue * AreaConversion.areToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.hectare)
                        areaValue = inputValue * AreaConversion.hectareToSquareMetreValue;
                    else
                        unitError = true;

                    if ((unitError == false) && ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareMetre))
                        resultAreaValue = areaValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareKilometre)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToSquareKilometreValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareDecimetre)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToSquareDecimetreValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareCentimetre)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToSquareCentimetreValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareMillimetre)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToSquareMillimetreValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareMile)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToSquareMileValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareYard)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToSquareYardValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareFoot)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToSquareFootValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareInch)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToSquareInchValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.acre)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToAcreValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.are)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToAreValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.hectare)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToHectareValue;
                    else
                        unitError = true;

                    if (unitError == false)
                    {
                        areaToValueOutput.Text = resultAreaValue.ToString();
                        statusIndicator.Text = StatusMessages.done;
                    }
                    else
                        statusIndicator.Text = StatusMessages.unitError;
                }
                else
                    statusIndicator.Text = StatusMessages.invalidInput;
            }

            // User wants to convert volume
            else if (unitSelector.SelectedIndex == 2)
            {
                double volumeValue = 0;
                double resultVolumeValue = 0;

                rawValue = volumeFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.cubicMetre)
                        volumeValue = inputValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.cubicCentimetre)
                        volumeValue = inputValue * VolumeConversion.cubicCentimetreToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.cubicMillimetre)
                        volumeValue = inputValue * VolumeConversion.cubicMillimetreToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.cubicYard)
                        volumeValue = inputValue * VolumeConversion.cubicYardToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.cubicFoot)
                        volumeValue = inputValue * VolumeConversion.cubicFootToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.cubicInch)
                        volumeValue = inputValue * VolumeConversion.cubicInchToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.litre)
                        volumeValue = inputValue * VolumeConversion.litreToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.millilitre)
                        volumeValue = inputValue * VolumeConversion.millilitreToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.gallon)
                        volumeValue = inputValue * VolumeConversion.gallonToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.quart)
                        volumeValue = inputValue * VolumeConversion.quartToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.pint)
                        volumeValue = inputValue * VolumeConversion.pintToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.cup)
                        volumeValue = inputValue * VolumeConversion.cupToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.tablespoon)
                        volumeValue = inputValue * VolumeConversion.tablespoonToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.teaspoon)
                        volumeValue = inputValue * VolumeConversion.teaspoonToCubicMetreValue;
                    else
                        unitError = true;

                    if ((unitError == false) && ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.cubicMetre))
                        resultVolumeValue = volumeValue;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.cubicCentimetre)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToCubicCentimetreValue;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.cubicMillimetre)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToCubicMillimetreValue;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.cubicYard)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToCubicYardValue;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.cubicFoot)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToCubicFootValue;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.cubicInch)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToCubicInchValue;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.litre)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToLitreValue;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.millilitre)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToMillilitreValue;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.gallon)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToGallonValue;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.quart)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToQuartValue;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.pint)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToPintValue;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.cup)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToCupValue;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.tablespoon)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToTablespoonValue;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.teaspoon)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToTeaspoonValue;
                    else
                        unitError = true;

                    if (unitError == false)
                    {
                        volumeToValueOutput.Text = resultVolumeValue.ToString();
                        statusIndicator.Text = StatusMessages.done;
                    }
                    else
                        statusIndicator.Text = StatusMessages.unitError;
                }
                else
                    statusIndicator.Text = StatusMessages.invalidInput;
            }

            // User wants to convert time
            else if (unitSelector.SelectedIndex == 3)
            {
                double timeValue = 0;
                double resultTimeValue = 0;

                rawValue = timeFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    if ((string)timeFromUnitInput.SelectedItem == TimeConversion.second)
                        timeValue = inputValue;
                    else if ((string)timeFromUnitInput.SelectedItem == TimeConversion.millisecond)
                        timeValue = inputValue * TimeConversion.millisecondToSecondValue;
                    else if ((string)timeFromUnitInput.SelectedItem == TimeConversion.microsecond)
                        timeValue = inputValue * TimeConversion.microsecondToSecondValue;
                    else if ((string)timeFromUnitInput.SelectedItem == TimeConversion.nanosecond)
                        timeValue = inputValue * TimeConversion.nanosecondToSecondValue;
                    else if ((string)timeFromUnitInput.SelectedItem == TimeConversion.minute)
                        timeValue = inputValue * TimeConversion.minuteToSecondValue;
                    else if ((string)timeFromUnitInput.SelectedItem == TimeConversion.hour)
                        timeValue = inputValue * TimeConversion.hourToSecondValue;
                    else if ((string)timeFromUnitInput.SelectedItem == TimeConversion.day)
                        timeValue = inputValue * TimeConversion.dayToSecondValue;
                    else if ((string)timeFromUnitInput.SelectedItem == TimeConversion.week)
                        timeValue = inputValue * TimeConversion.weekToSecondValue;
                    else if ((string)timeFromUnitInput.SelectedItem == TimeConversion.fortnight)
                        timeValue = inputValue * TimeConversion.fortnightToSecondValue;
                    else if ((string)timeFromUnitInput.SelectedItem == TimeConversion.year)
                        timeValue = inputValue * TimeConversion.yearToSecondValue;
                    else if ((string)timeFromUnitInput.SelectedItem == TimeConversion.yearLeap)
                        timeValue = inputValue * TimeConversion.yearLeapToSecondValue;
                    else
                        unitError = true;

                    if ((unitError == false) && ((string)timeToUnitOutput.SelectedItem == TimeConversion.second))
                        resultTimeValue = timeValue;
                    else if ((string)timeToUnitOutput.SelectedItem == TimeConversion.millisecond)
                        resultTimeValue = timeValue * TimeConversion.secondToMillisecondValue;
                    else if ((string)timeToUnitOutput.SelectedItem == TimeConversion.microsecond)
                        resultTimeValue = timeValue * TimeConversion.secondToMicrosecondValue;
                    else if ((string)timeToUnitOutput.SelectedItem == TimeConversion.nanosecond)
                        resultTimeValue = timeValue * TimeConversion.secondToNanosecondValue;
                    else if ((string)timeToUnitOutput.SelectedItem == TimeConversion.minute)
                        resultTimeValue = timeValue * TimeConversion.secondToMinuteValue;
                    else if ((string)timeToUnitOutput.SelectedItem == TimeConversion.hour)
                        resultTimeValue = timeValue * TimeConversion.secondToHourValue;
                    else if ((string)timeToUnitOutput.SelectedItem == TimeConversion.day)
                        resultTimeValue = timeValue * TimeConversion.secondToDayValue;
                    else if ((string)timeToUnitOutput.SelectedItem == TimeConversion.week)
                        resultTimeValue = timeValue * TimeConversion.secondToWeekValue;
                    else if ((string)timeToUnitOutput.SelectedItem == TimeConversion.fortnight)
                        resultTimeValue = timeValue * TimeConversion.secondToFortnightValue;
                    else if ((string)timeToUnitOutput.SelectedItem == TimeConversion.year)
                        resultTimeValue = timeValue * TimeConversion.secondToYearValue;
                    else if ((string)timeToUnitOutput.SelectedItem == TimeConversion.yearLeap)
                        resultTimeValue = timeValue * TimeConversion.secondToYearLeapValue;
                    else
                        unitError = true;

                    if (unitError == false)
                    {
                        timeToValueOutput.Text = resultTimeValue.ToString();
                        statusIndicator.Text = StatusMessages.done;
                    }
                    else
                        statusIndicator.Text = StatusMessages.unitError;
                }
                else
                    statusIndicator.Text = StatusMessages.invalidInput;
            }

            // User wants to convert speed
            else if (unitSelector.SelectedIndex == 4)
            {
                double speedValue = 0;
                double resultSpeedValue = 0;

                rawValue = speedFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    if ((string)speedFromUnitInput.SelectedItem == SpeedConversion.metrePerSecond)
                        speedValue = inputValue;
                    else if ((string)speedFromUnitInput.SelectedItem == SpeedConversion.metrePerHour)
                        speedValue = inputValue * SpeedConversion.metrePerHourToMetrePerSecondValue;
                    else if ((string)speedFromUnitInput.SelectedItem == SpeedConversion.kilometrePerSecond)
                        speedValue = inputValue * SpeedConversion.kilometrePerSecondToMetrePerSecondValue;
                    else if ((string)speedFromUnitInput.SelectedItem == SpeedConversion.kilometrePerHour)
                        speedValue = inputValue * SpeedConversion.kilometrePerHourToMetrePerSecondValue;
                    else if ((string)speedFromUnitInput.SelectedItem == SpeedConversion.footPerSecond)
                        speedValue = inputValue * SpeedConversion.footPerSecondToMetrePerSecondValue;
                    else if ((string)speedFromUnitInput.SelectedItem == SpeedConversion.footPerHour)
                        speedValue = inputValue * SpeedConversion.footPerHourToMetrePerSecondValue;
                    else if ((string)speedFromUnitInput.SelectedItem == SpeedConversion.milePerSecond)
                        speedValue = inputValue * SpeedConversion.milePerSecondToMetrePerSecondValue;
                    else if ((string)speedFromUnitInput.SelectedItem == SpeedConversion.milePerHour)
                        speedValue = inputValue * SpeedConversion.milePerHourToMetrePerSecondValue;
                    else
                        unitError = true;

                    if ((unitError == false) && ((string)speedToUnitOutput.SelectedItem == SpeedConversion.metrePerSecond))
                        resultSpeedValue = speedValue;
                    else if ((string)speedToUnitOutput.SelectedItem == SpeedConversion.metrePerHour)
                        resultSpeedValue = speedValue * SpeedConversion.metrePerSecondToMetrePerHourValue;
                    else if ((string)speedToUnitOutput.SelectedItem == SpeedConversion.kilometrePerSecond)
                        resultSpeedValue = speedValue * SpeedConversion.metrePerSecondToKilometrePerSecondValue;
                    else if ((string)speedToUnitOutput.SelectedItem == SpeedConversion.kilometrePerHour)
                        resultSpeedValue = speedValue * SpeedConversion.metrePerSecondToKilometrePerHourValue;
                    else if ((string)speedToUnitOutput.SelectedItem == SpeedConversion.footPerSecond)
                        resultSpeedValue = speedValue * SpeedConversion.metrePerSecondToFootPerSecondValue;
                    else if ((string)speedToUnitOutput.SelectedItem == SpeedConversion.footPerHour)
                        resultSpeedValue = speedValue * SpeedConversion.metrePerSecondToFootPerHourValue;
                    else if ((string)speedToUnitOutput.SelectedItem == SpeedConversion.milePerSecond)
                        resultSpeedValue = speedValue * SpeedConversion.metrePerSecondToMilePerSecondValue;
                    else if ((string)speedToUnitOutput.SelectedItem == SpeedConversion.milePerHour)
                        resultSpeedValue = speedValue * SpeedConversion.metrePerSecondToMilePerHourValue;
                    else
                        unitError = true;

                    if (unitError == false)
                    {
                        speedToValueOutput.Text = resultSpeedValue.ToString();
                        statusIndicator.Text = StatusMessages.done;
                    }
                    else
                        statusIndicator.Text = StatusMessages.unitError;
                }
                else
                    statusIndicator.Text = StatusMessages.invalidInput;
            }

            // User wants to convert mass
            else if (unitSelector.SelectedIndex == 5)
            {
                double massValue = 0;
                double resultMassValue = 0;

                rawValue = massFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    if ((string)massFromUnitInput.SelectedItem == MassConversion.kilogram)
                        massValue = inputValue;
                    else if ((string)massFromUnitInput.SelectedItem == MassConversion.gram)
                        massValue = inputValue * MassConversion.gramToKilogramValue;
                    else if ((string)massFromUnitInput.SelectedItem == MassConversion.milligram)
                        massValue = inputValue * MassConversion.milligramToKilogramValue;
                    else if ((string)massFromUnitInput.SelectedItem == MassConversion.microgram)
                        massValue = inputValue * MassConversion.microgramToKilogramValue;
                    else if ((string)massFromUnitInput.SelectedItem == MassConversion.tonne)
                        massValue = inputValue * MassConversion.tonneToKilogramValue;
                    else if ((string)massFromUnitInput.SelectedItem == MassConversion.kilotonne)
                        massValue = inputValue * MassConversion.kilotonneToKilogramValue;
                    else if ((string)massFromUnitInput.SelectedItem == MassConversion.pound)
                        massValue = inputValue * MassConversion.poundToKilogramValue;
                    else if ((string)massFromUnitInput.SelectedItem == MassConversion.ounce)
                        massValue = inputValue * MassConversion.ounceToKilogramValue;
                    else if ((string)massFromUnitInput.SelectedItem == MassConversion.stoneUK)
                        massValue = inputValue * MassConversion.stoneUKToKilogramValue;
                    else if ((string)massFromUnitInput.SelectedItem == MassConversion.tonShort)
                        massValue = inputValue * MassConversion.tonShortToKilogramValue;
                    else if ((string)massFromUnitInput.SelectedItem == MassConversion.tonLong)
                        massValue = inputValue * MassConversion.tonLongToKilogramValue;
                    else if ((string)massFromUnitInput.SelectedItem == MassConversion.kilotonShort)
                        massValue = inputValue * MassConversion.kilotonShortToKilogramValue;
                    else if ((string)massFromUnitInput.SelectedItem == MassConversion.kilotonLong)
                        massValue = inputValue * MassConversion.kilotonLongToKilogramValue;
                    else
                        unitError = true;

                    if ((unitError == false) && ((string)massToUnitOutput.SelectedItem == MassConversion.kilogram))
                        resultMassValue = massValue;
                    else if ((string)massToUnitOutput.SelectedItem == MassConversion.gram)
                        resultMassValue = massValue * MassConversion.kilogramToGramValue;
                    else if ((string)massToUnitOutput.SelectedItem == MassConversion.milligram)
                        resultMassValue = massValue * MassConversion.kilogramToMilligramValue;
                    else if ((string)massToUnitOutput.SelectedItem == MassConversion.microgram)
                        resultMassValue = massValue * MassConversion.kilogramToMicrogramValue;
                    else if ((string)massToUnitOutput.SelectedItem == MassConversion.tonne)
                        resultMassValue = massValue * MassConversion.kilogramToTonneValue;
                    else if ((string)massToUnitOutput.SelectedItem == MassConversion.kilotonne)
                        resultMassValue = massValue * MassConversion.kilogramToKilotonneValue;
                    else if ((string)massToUnitOutput.SelectedItem == MassConversion.pound)
                        resultMassValue = massValue * MassConversion.kilogramToPoundValue;
                    else if ((string)massToUnitOutput.SelectedItem == MassConversion.ounce)
                        resultMassValue = massValue * MassConversion.kilogramToOunceValue;
                    else if ((string)massToUnitOutput.SelectedItem == MassConversion.stoneUK)
                        resultMassValue = massValue * MassConversion.kilogramToStoneUKValue;
                    else if ((string)massToUnitOutput.SelectedItem == MassConversion.tonShort)
                        resultMassValue = massValue * MassConversion.kilogramToTonShortValue;
                    else if ((string)massToUnitOutput.SelectedItem == MassConversion.tonLong)
                        resultMassValue = massValue * MassConversion.kilogramToTonLongValue;
                    else if ((string)massToUnitOutput.SelectedItem == MassConversion.kilotonShort)
                        resultMassValue = massValue * MassConversion.kilogramToKilotonShortValue;
                    else if ((string)massToUnitOutput.SelectedItem == MassConversion.kilotonLong)
                        resultMassValue = massValue * MassConversion.kilogramToKilotonLongValue;
                    else
                        unitError = true;

                    if (unitError == false)
                    {
                        massToValueOutput.Text = resultMassValue.ToString();
                        statusIndicator.Text = StatusMessages.done;
                    }
                    else
                        statusIndicator.Text = StatusMessages.unitError;
                }
                else
                    statusIndicator.Text = StatusMessages.invalidInput;
            }

            // User wants to convert energy
            else if (unitSelector.SelectedIndex == 6)
            {
                double energyValue = 0;
                double resultEnergyValue = 0;

                rawValue = energyFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    if ((string)energyFromUnitInput.SelectedItem == EnergyConversion.joule)
                        energyValue = inputValue;
                    else if ((string)energyFromUnitInput.SelectedItem == EnergyConversion.kilojoule)
                        energyValue = inputValue * EnergyConversion.kilojouleToJouleValue;
                    else if ((string)energyFromUnitInput.SelectedItem == EnergyConversion.wattHour)
                        energyValue = inputValue * EnergyConversion.wattHourToJouleValue;
                    else if ((string)energyFromUnitInput.SelectedItem == EnergyConversion.kilowattHour)
                        energyValue = inputValue * EnergyConversion.kilowattHourToJouleValue;
                    else if ((string)energyFromUnitInput.SelectedItem == EnergyConversion.calorie)
                        energyValue = inputValue * EnergyConversion.calorieToJouleValue;
                    else if ((string)energyFromUnitInput.SelectedItem == EnergyConversion.kilocalorie)
                        energyValue = inputValue * EnergyConversion.kilocalorieToJouleValue;
                    else if ((string)energyFromUnitInput.SelectedItem == EnergyConversion.btu)
                        energyValue = inputValue * EnergyConversion.btuToJouleValue;
                    else
                        unitError = true;

                    if ((unitError == false) && ((string)energyToUnitOutput.SelectedItem == EnergyConversion.joule))
                        resultEnergyValue = energyValue;
                    else if ((string)energyToUnitOutput.SelectedItem == EnergyConversion.kilojoule)
                        resultEnergyValue = energyValue * EnergyConversion.jouleToKilojouleValue;
                    else if ((string)energyToUnitOutput.SelectedItem == EnergyConversion.wattHour)
                        resultEnergyValue = energyValue * EnergyConversion.jouleToWattHourValue;
                    else if ((string)energyToUnitOutput.SelectedItem == EnergyConversion.kilowattHour)
                        resultEnergyValue = energyValue * EnergyConversion.jouleToKilowattHourValue;
                    else if ((string)energyToUnitOutput.SelectedItem == EnergyConversion.calorie)
                        resultEnergyValue = energyValue * EnergyConversion.jouleTocalorieValue;
                    else if ((string)energyToUnitOutput.SelectedItem == EnergyConversion.kilocalorie)
                        resultEnergyValue = energyValue * EnergyConversion.jouleToKilocalorieValue;
                    else if ((string)energyToUnitOutput.SelectedItem == EnergyConversion.btu)
                        resultEnergyValue = energyValue * EnergyConversion.jouleToBtuValue;
                    else
                        unitError = true;

                    if (unitError == false)
                    {
                        energyToValueOutput.Text = resultEnergyValue.ToString();
                        statusIndicator.Text = StatusMessages.done;
                    }
                    else
                        statusIndicator.Text = StatusMessages.unitError;
                }
                else
                    statusIndicator.Text = StatusMessages.invalidInput;
            }

            // User wants to convert temperature
            else if (unitSelector.SelectedIndex == 7)
            {
                double resultTemperatureValue = 0;

                rawValue = temperatureFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    if (((string)temperatureFromUnitInput.SelectedItem == TemperatureConversion.kelvin)
                        && (string)temperatureToUnitOutput.SelectedItem == TemperatureConversion.celsius)
                    {
                        resultTemperatureValue = inputValue - 273.15d;
                        temperatureToValueOutput.Text = resultTemperatureValue.ToString();
                    }
                    else if (((string)temperatureFromUnitInput.SelectedItem == TemperatureConversion.kelvin)
                        && (string)temperatureToUnitOutput.SelectedItem == TemperatureConversion.fahrenheit)
                    {
                        resultTemperatureValue = inputValue * 1.8d - 459.67d;
                        temperatureToValueOutput.Text = resultTemperatureValue.ToString();
                    }
                    else if (((string)temperatureFromUnitInput.SelectedItem == TemperatureConversion.celsius)
                        && (string)temperatureToUnitOutput.SelectedItem == TemperatureConversion.kelvin)
                    {
                        resultTemperatureValue = inputValue + 273.15d;
                        temperatureToValueOutput.Text = resultTemperatureValue.ToString();
                    }
                    else if (((string)temperatureFromUnitInput.SelectedItem == TemperatureConversion.celsius)
                        && (string)temperatureToUnitOutput.SelectedItem == TemperatureConversion.fahrenheit)
                    {
                        resultTemperatureValue = inputValue * 1.8d + 32d;
                        temperatureToValueOutput.Text = resultTemperatureValue.ToString();
                    }
                    else if (((string)temperatureFromUnitInput.SelectedItem == TemperatureConversion.fahrenheit)
                        && (string)temperatureToUnitOutput.SelectedItem == TemperatureConversion.kelvin)
                    {
                        resultTemperatureValue = (inputValue + 459.67d) / 1.8d;
                        temperatureToValueOutput.Text = resultTemperatureValue.ToString();
                    }
                    else if (((string)temperatureFromUnitInput.SelectedItem == TemperatureConversion.fahrenheit)
                        && (string)temperatureToUnitOutput.SelectedItem == TemperatureConversion.celsius)
                    {
                        resultTemperatureValue = (inputValue - 32d) / 1.8d;
                        temperatureToValueOutput.Text = resultTemperatureValue.ToString();
                    }
                    else
                        statusIndicator.Text = StatusMessages.unitError;

                    if (unitError == false)
                    {
                        speedToValueOutput.Text = resultTemperatureValue.ToString();
                        statusIndicator.Text = StatusMessages.done;
                    }
                    else
                        statusIndicator.Text = StatusMessages.unitError;
                }
                else
                    statusIndicator.Text = StatusMessages.invalidInput;
            }

            // User wants to convert data size
            else if (unitSelector.SelectedIndex == 8)
            {
                double dataSizeValue = 0;
                double resultDataSizeValue = 0;

                rawValue = dataSizeFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if ((canParse) && (inputValue >= 0))
                {
                    if ((string)dataSizeFromUnitInput.SelectedItem == DataSizeConversion.sizeByte)
                        dataSizeValue = inputValue;
                    else if ((string)dataSizeFromUnitInput.SelectedItem == DataSizeConversion.sizeKilobyte)
                        dataSizeValue = inputValue * DataSizeConversion.kilobyteToByteValue;
                    else if ((string)dataSizeFromUnitInput.SelectedItem == DataSizeConversion.sizeMegabyte)
                        dataSizeValue = inputValue * DataSizeConversion.megabyteToByteValue;
                    else if ((string)dataSizeFromUnitInput.SelectedItem == DataSizeConversion.sizeGigabyte)
                        dataSizeValue = inputValue * DataSizeConversion.gigabyteToByteValue;
                    else if ((string)dataSizeFromUnitInput.SelectedItem == DataSizeConversion.sizeTerabyte)
                        dataSizeValue = inputValue * DataSizeConversion.terabyteToByteValue;
                    else if ((string)dataSizeFromUnitInput.SelectedItem == DataSizeConversion.sizePetabyte)
                        dataSizeValue = inputValue * DataSizeConversion.petabyteToByteValue;
                    else
                        unitError = true;

                    if ((unitError == false) && ((string)dataSizeToUnitOutput.SelectedItem == DataSizeConversion.sizeByte))
                        resultDataSizeValue = dataSizeValue;
                    else if ((string)dataSizeToUnitOutput.SelectedItem == DataSizeConversion.sizeKilobyte)
                        resultDataSizeValue = dataSizeValue * DataSizeConversion.byteToKilobyteValue;
                    else if ((string)dataSizeToUnitOutput.SelectedItem == DataSizeConversion.sizeMegabyte)
                        resultDataSizeValue = dataSizeValue * DataSizeConversion.byteToMegabyteValue;
                    else if ((string)dataSizeToUnitOutput.SelectedItem == DataSizeConversion.sizeGigabyte)
                        resultDataSizeValue = dataSizeValue * DataSizeConversion.byteToGigabyteValue;
                    else if ((string)dataSizeToUnitOutput.SelectedItem == DataSizeConversion.sizeTerabyte)
                        resultDataSizeValue = dataSizeValue * DataSizeConversion.byteToTerabyteValue;
                    else if ((string)dataSizeToUnitOutput.SelectedItem == DataSizeConversion.sizePetabyte)
                        resultDataSizeValue = dataSizeValue * DataSizeConversion.byteToPetabyteValue;
                    else
                        unitError = true;

                    if (unitError == false)
                    {
                        dataSizeToValueOutput.Text = resultDataSizeValue.ToString();
                        statusIndicator.Text = StatusMessages.done;
                    }
                    else
                        statusIndicator.Text = StatusMessages.unitError;
                }
                else
                    statusIndicator.Text = StatusMessages.invalidInput;
            }

            // Somehow, the currently selected tab does not exist!
            else
                statusIndicator.Text = StatusMessages.unitTypeError;
        }

        // Indicate to user converter is ready when unit type is changed (tab is changed)
        private void unitSelector_SelectedIndexChanged(Object sender, EventArgs e)
        {
            statusIndicator.Text = StatusMessages.ready;
        }
    }

    public static class StatusMessages
    {
        public const string ready = "Ready";
        public const string done = "Done";
        public const string invalidInput = "Invalid input!";
        public const string unitTypeError = "Error: Invalid unit type! Restart application.";
        public const string unitError = "No unit(s) selected!";
    }

    public static class LengthConversion
    {
        // Strings
        public const string metre = "Metre [m] (S.I. Unit)";
        public const string kilometre = "Kilometre [km]";
        public const string decimetre = "Decimetre [dm]";
        public const string centimetre = "Centimetre [cm]";
        public const string millimetre = "Millimetre [mm]";
        public const string mile = "Mile [mi]";
        public const string yard = "Yard [yd]";
        public const string foot = "Foot [ft]";
        public const string inch = "Inch [in]";

        // To S.I. Unit (credits to https://www.rapidtables.com/convert/length/)
        public const double kilometreToMetreValue = 1000d;
        public const double decimetreToMetreValue = 0.1d;
        public const double centimetreToMetreValue = 0.01d;
        public const double millimetreToMetreValue = 0.001d;
        public const double mileToMetreValue = (1d / 3.280839895d) * 5280d;
        public const double yardToMetreValue = (1d / 3.280839895d) * 3d;
        public const double footToMetreValue = 1d / 3.280839895d;
        public const double inchToMetreValue = (1d / 3.280839895d) / 12d;

        // From S.I. Unit (credits to https://www.rapidtables.com/convert/length/)
        public const double metreToKilometreValue = 1d / kilometreToMetreValue;
        public const double metreToDecimetreValue = 1d / decimetreToMetreValue;
        public const double metreToCentimetreValue = 1d / centimetreToMetreValue;
        public const double metreToMillimetreValue = 1d / millimetreToMetreValue;
        public const double metreToMileValue = 1d / mileToMetreValue;
        public const double metreToYardValue = 1d / yardToMetreValue;
        public const double metreToFootValue = 1d / footToMetreValue;
        public const double metreToInchValue = 1d / inchToMetreValue;
    }

    public static class AreaConversion
    {
        // Strings
        public const string squareMetre = "Square Metre [m²] (S.I. Unit)";
        public const string squareKilometre = "Square Kilometre [km²]";
        public const string squareDecimetre = "Square Decimetre [dm²]";
        public const string squareCentimetre = "Square Centimetre [cm²]";
        public const string squareMillimetre = "Square Millimetre [mm²]";
        public const string squareMile = "Square Mile [mi²]";
        public const string squareYard = "Square Yard [yd²]";
        public const string squareFoot = "Square Foot [ft²]";
        public const string squareInch = "Square Inch [in²]";
        public const string acre = "Acre [ac]";
        public const string are = "Are [a]";
        public const string hectare = "Hectare [ha]";

        // To S.I. Unit
        public const double squareKilometreToSquareMetreValue = 1000000d;
        public const double squareDecimetreToSquareMetreValue = 0.01d;
        public const double squareCentimetreToSquareMetreValue = 0.0001d;
        public const double squareMillimetreToSquareMetreValue = 0.00000d;
        public const double squareMileToSquareMetreValue = (1d / 1.19599004630108d) * 3097600d;
        public const double squareYardToSquareMetreValue = 1d / 1.19599004630108d;
        public const double squareFootToSquareMetreValue = (1d / 1.19599004630108d) / 9d;
        public const double squareInchToSquareMetreValue = (1d / 1.19599004630108d) / 1296d;
        public const double acreToSquareMetreValue = (1d / 1.19599004630108d) * 4840d;
        public const double areToSquareMetreValue = 100d;
        public const double hectareToSquareMetreValue = 10000d;

        // From S.I. Unit
        public const double squareMetreToSquareKilometreValue = 1d / squareKilometreToSquareMetreValue;
        public const double squareMetreToSquareDecimetreValue = 1d / squareDecimetreToSquareMetreValue;
        public const double squareMetreToSquareCentimetreValue = 1d / squareCentimetreToSquareMetreValue;
        public const double squareMetreToSquareMillimetreValue = 1d / squareMillimetreToSquareMetreValue;
        public const double squareMetreToSquareMileValue = 1d / squareMileToSquareMetreValue;
        public const double squareMetreToSquareYardValue = 1d / squareYardToSquareMetreValue;
        public const double squareMetreToSquareFootValue = 1d / squareFootToSquareMetreValue;
        public const double squareMetreToSquareInchValue = 1d / squareInchToSquareMetreValue;
        public const double squareMetreToAcreValue = 1d / acreToSquareMetreValue;
        public const double squareMetreToAreValue = 1d / areToSquareMetreValue;
        public const double squareMetreToHectareValue = 1d / hectareToSquareMetreValue;
    }

    public static class VolumeConversion
    {
        // Strings
        public const string cubicMetre = "Cubic Metre [m³] (S.I. Unit)";
        public const string cubicCentimetre = "Cubic Centimetre [cm³]";
        public const string cubicMillimetre = "Cubic Millimetre [mm³]";
        public const string cubicYard = "Cubic Yard [yd³]";
        public const string cubicFoot = "Cubic Foot [ft³]";
        public const string cubicInch = "Cubic Inch [in³]";
        public const string litre = "Litre [L]";
        public const string millilitre = "Millilitre [mL]";
        public const string gallon = "Gallon (Imperial)";
        public const string quart = "Quart (Imperial)";
        public const string pint = "Pint (Imperial)";
        public const string cup = "Cup (US Customary)";
        public const string tablespoon = "Tablespoon (US Customary)";
        public const string teaspoon = "Teaspoon (US Customary)";

        // To S.I. Unit
        public const double cubicCentimetreToCubicMetreValue = 0.000001d;
        public const double cubicMillimetreToCubicMetreValue = 0.000000001d;
        public const double cubicYardToCubicMetreValue = 1d / 1.30795061931439d;
        public const double cubicFootToCubicMetreValue = (1d / 1.30795061931439d) / 27d;
        public const double cubicInchToCubicMetreValue = (1d / 1.30795061931439d) / 46656d;
        public const double litreToCubicMetreValue = 0.001d;
        public const double millilitreToCubicMetreValue = 0.000001d;
        public const double gallonToCubicMetreValue = 1d / 219.969248299088d;
        public const double quartToCubicMetreValue = (1d / 219.969248299088d) / 4d;
        public const double pintToCubicMetreValue = (1d / 219.969248299088d) / 8d;
        public const double cupToCubicMetreValue = 4226.75283773038d;
        public const double tablespoonToCubicMetreValue = 4226.75283773038d / 16d;
        public const double teaspoonToCubicMetreValue = 4226.75283773038d / 48d;

        // From S.I. Unit
        public const double cubicMetreToCubicCentimetreValue = 1d / cubicCentimetreToCubicMetreValue;
        public const double cubicMetreToCubicMillimetreValue = 1d / cubicMillimetreToCubicMetreValue;
        public const double cubicMetreToCubicYardValue = 1d / cubicYardToCubicMetreValue;
        public const double cubicMetreToCubicFootValue = 1d / cubicFootToCubicMetreValue;
        public const double cubicMetreToCubicInchValue = 1d / cubicInchToCubicMetreValue;
        public const double cubicMetreToLitreValue = 1d / litreToCubicMetreValue;
        public const double cubicMetreToMillilitreValue = 1d / millilitreToCubicMetreValue;
        public const double cubicMetreToGallonValue = 1d / gallonToCubicMetreValue;
        public const double cubicMetreToQuartValue = 1d / quartToCubicMetreValue;
        public const double cubicMetreToPintValue = 1d / pintToCubicMetreValue;
        public const double cubicMetreToCupValue = 1d / cupToCubicMetreValue;
        public const double cubicMetreToTablespoonValue = 1d / tablespoonToCubicMetreValue;
        public const double cubicMetreToTeaspoonValue = 1d / teaspoonToCubicMetreValue;
    }

    public static class TimeConversion
    {
        // Strings
        public const string second = "Second [s] (S.I. Unit)";
        public const string millisecond = "Millisecond [ms]";
        public const string microsecond = "Microsecond [μs]";
        public const string nanosecond = "Nanosecond [ns]";
        public const string minute = "Minute [min]";
        public const string hour = "Hour [h]";
        public const string day = "Day";
        public const string week = "Week";
        public const string fortnight = "Fortnight";
        public const string year = "Year";
        public const string yearLeap = "Year (Leap)";

        // To S.I. Unit
        public const double millisecondToSecondValue = 0.001d;
        public const double microsecondToSecondValue = 0.000001d;
        public const double nanosecondToSecondValue = 0.000000001d;
        public const double minuteToSecondValue = 60d;
        public const double hourToSecondValue = 3600d;
        public const double dayToSecondValue = 86400d;
        public const double weekToSecondValue = 604800d;
        public const double fortnightToSecondValue = 1209600d;
        public const double yearToSecondValue = 31536000d;
        public const double yearLeapToSecondValue = 31622400d;

        // From S.I. Unit
        public const double secondToMillisecondValue = 1d / millisecondToSecondValue;
        public const double secondToMicrosecondValue = 1d / microsecondToSecondValue;
        public const double secondToNanosecondValue = 1d / nanosecondToSecondValue;
        public const double secondToMinuteValue = 1d / minuteToSecondValue;
        public const double secondToHourValue = 1d / hourToSecondValue;
        public const double secondToDayValue = 1d / dayToSecondValue;
        public const double secondToWeekValue = 1d / weekToSecondValue;
        public const double secondToFortnightValue = 1d / fortnightToSecondValue;
        public const double secondToYearValue = 1d / yearToSecondValue;
        public const double secondToYearLeapValue = 1d / yearLeapToSecondValue;
    }

    public static class SpeedConversion
    {
        // Strings
        public const string metrePerSecond = "Metre per Second [m/s]";
        public const string metrePerHour = "Metre per Hour [m/h]";
        public const string kilometrePerSecond = "Kilometre per Second [km/s]";
        public const string kilometrePerHour = "Kilometre per Hour [km/h]";
        public const string footPerSecond = "Foot per Second [ft/s]";
        public const string footPerHour = "Foot per Hour [ft/h]";
        public const string milePerSecond = "Mile per Second [mi/s]";
        public const string milePerHour = "Mile per Hour [mi/h]";

        // To S.I. Unit
        public const double metrePerHourToMetrePerSecondValue = 1d / 3600d;
        public const double kilometrePerSecondToMetrePerSecondValue = 1000d;
        public const double kilometrePerHourToMetrePerSecondValue = 1d / 3.6d;
        public const double footPerSecondToMetrePerSecondValue = 1d / 3.280839895d;
        public const double footPerHourToMetrePerSecondValue = (1d / 3.280839895d) / 3600d;
        public const double milePerSecondToMetrePerSecondValue = (1d / 3.280839895d) * 5280d;
        public const double milePerHourToMetrePerSecondValue = (1d / 3.280839895d) * 5280d / 3600d;

        // From S.I. Unit
        public const double metrePerSecondToMetrePerHourValue = 1d / metrePerHourToMetrePerSecondValue;
        public const double metrePerSecondToKilometrePerSecondValue = 1d / kilometrePerSecondToMetrePerSecondValue;
        public const double metrePerSecondToKilometrePerHourValue = 1d / kilometrePerHourToMetrePerSecondValue;
        public const double metrePerSecondToFootPerSecondValue = 1d / footPerSecondToMetrePerSecondValue;
        public const double metrePerSecondToFootPerHourValue = 1d / footPerHourToMetrePerSecondValue;
        public const double metrePerSecondToMilePerSecondValue = 1d / milePerSecondToMetrePerSecondValue;
        public const double metrePerSecondToMilePerHourValue = 1d / milePerHourToMetrePerSecondValue;
    }

    public static class MassConversion
    {
        // Strings
        public const string kilogram = "Kilogram [kg] (S.I. Unit)";
        public const string gram = "Gram [g]";
        public const string milligram = "Milligram [mg]";
        public const string microgram = "Microgram [μg]";
        public const string tonne = "Tonne [t] (Metric)";
        public const string kilotonne = "Kilotonne [kt] (Metric)";
        public const string pound = "Pound [lb]";
        public const string ounce = "Ounce [oz]";
        public const string stoneUK = "Stone [st.] (UK)";
        public const string tonShort = "Ton (Short)";
        public const string tonLong = "Ton (Long)";
        public const string kilotonShort = "Kiloton (Short)";
        public const string kilotonLong = "Kiloton (Long)";

        // To S.I. Unit
        public const double gramToKilogramValue = 1d / 1000d;
        public const double milligramToKilogramValue = 1d / 1000000d;
        public const double microgramToKilogramValue = 1d / 1000000000d;
        public const double tonneToKilogramValue = 1000d;
        public const double kilotonneToKilogramValue = 1000000d;
        public const double poundToKilogramValue = 1d / 2.20462262184878d;
        public const double ounceToKilogramValue = (1d / 2.20462262184878d) / 16d;
        public const double stoneUKToKilogramValue = (1d / 2.20462262184878d) * 14d;
        public const double tonShortToKilogramValue = (1d / 2.20462262184878d) * 2000d;
        public const double tonLongToKilogramValue = (1d / 2.20462262184878d) * 2240d;
        public const double kilotonShortToKilogramValue = (1d / 2.20462262184878d) * 2000000d;
        public const double kilotonLongToKilogramValue = (1d / 2.20462262184878d) * 2240000d;

        // From S.I. Unit
        public const double kilogramToGramValue = 1d / gramToKilogramValue;
        public const double kilogramToMilligramValue = 1d / milligramToKilogramValue;
        public const double kilogramToMicrogramValue = 1d / microgramToKilogramValue;
        public const double kilogramToTonneValue = 1d / tonneToKilogramValue;
        public const double kilogramToKilotonneValue = 1d / kilotonneToKilogramValue;
        public const double kilogramToPoundValue = 1d / poundToKilogramValue;
        public const double kilogramToOunceValue = 1d / ounceToKilogramValue;
        public const double kilogramToStoneUKValue = 1d / stoneUKToKilogramValue;
        public const double kilogramToTonShortValue = 1d / tonShortToKilogramValue;
        public const double kilogramToTonLongValue = 1d / tonLongToKilogramValue;
        public const double kilogramToKilotonShortValue = 1d / kilotonShortToKilogramValue;
        public const double kilogramToKilotonLongValue = 1d / kilotonLongToKilogramValue;
    }

    public static class EnergyConversion
    {
        // Strings
        public const string joule = "Joule [J] (S.I. Unit)";
        public const string kilojoule = "Kilojoule [kj]";
        public const string wattHour = "Watt Hour [Wh]";
        public const string kilowattHour = "Kilowatt Hour [kWh]";
        public const string calorie = "calorie";
        public const string kilocalorie = "Kilocalorie";
        public const string btu = "British Thermal Unit (BTU)";

        // To S.I. Unit
        public const double kilojouleToJouleValue = 1000d;
        public const double wattHourToJouleValue = 3600d;
        public const double kilowattHourToJouleValue = 3600000d;
        public const double calorieToJouleValue = 4.184d;
        public const double kilocalorieToJouleValue = 4184d;
        public const double btuToJouleValue = 1055.05585262d;

        // From S.I. Unit
        public const double jouleToKilojouleValue = 1d / kilojouleToJouleValue;
        public const double jouleToWattHourValue = 1d / wattHourToJouleValue;
        public const double jouleToKilowattHourValue = 1d / kilowattHourToJouleValue;
        public const double jouleTocalorieValue = 1d / calorieToJouleValue;
        public const double jouleToKilocalorieValue = 1d / kilocalorieToJouleValue;
        public const double jouleToBtuValue = 1d / btuToJouleValue;
    }

    public static class TemperatureConversion
    {
        // Strings
        public const string kelvin = "Kelvin [K] (S.I. Unit)";
        public const string celsius = "Degrees Celsius [°C]";
        public const string fahrenheit = "Degrees Fahrenheit [°F]";
    }

    public static class DataSizeConversion
    {
        // Strings
        public const string sizeByte = "Byte [B]";
        public const string sizeKilobyte = "Kilobyte [kB]";
        public const string sizeMegabyte = "Megabyte [MB]";
        public const string sizeGigabyte = "Gigabyte [GB]";
        public const string sizeTerabyte = "Terabyte [TB]";
        public const string sizePetabyte = "Petabyte [PB]";

        // To S.I. Unit
        public const double kilobyteToByteValue = 1024d;
        public const double megabyteToByteValue = 1048576d;
        public const double gigabyteToByteValue = 1073741824d;
        public const double terabyteToByteValue = 1099511627776d;
        public const double petabyteToByteValue = 1125899906842624d;

        // From S.I. Unit
        public const double byteToKilobyteValue = 1d / kilobyteToByteValue;
        public const double byteToMegabyteValue = 1d / megabyteToByteValue;
        public const double byteToGigabyteValue = 1d / gigabyteToByteValue;
        public const double byteToTerabyteValue = 1d / terabyteToByteValue;
        public const double byteToPetabyteValue = 1d / petabyteToByteValue;
    }
}
