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
            this.ActiveControl = lengthFromUnitInput;
            //this.AcceptButton = calculateButton;
            lengthFromUnitInput.Focus();

            // Detect if unit type changed (tab changed)
            unitSelector.SelectedIndexChanged += new EventHandler(unitSelector_SelectedIndexChanged);
        }

        // (1) INITIALISATION - Define all units
        // UNIT TYPE 0 - Length (12 Units)
        BaseUnit metre = new BaseUnit("Metre [m] (S.I. Unit)", 1d);
        BaseUnit kilometre = new BaseUnit("Kilometre [km]", 1000d);
        BaseUnit decimetre = new BaseUnit("Decimetre [dm]", 0.1d);
        BaseUnit centimetre = new BaseUnit("Centimetre [cm]", 0.01d);
        BaseUnit millimetre = new BaseUnit("Millimetre [mm]", 0.001d);
        BaseUnit micrometre = new BaseUnit("Micrometre [μm]", 0.000001d);
        BaseUnit nanometre = new BaseUnit("Nanometre [nm]", 0.000000001d);
        BaseUnit angstrom = new BaseUnit("Ångström [Å]", 0.0000000001d);
        BaseUnit mile = new BaseUnit("Mile [mi]", ((1d / 3.280839895d) * 5280d));
        BaseUnit yard = new BaseUnit("Yard [yd]", ((1d / 3.280839895d) * 3d));
        BaseUnit foot = new BaseUnit("Foot [ft]", (1d / 3.280839895d));
        BaseUnit inch = new BaseUnit("Inch [in]", ((1d / 3.280839895d) / 12d));

        // UNIT TYPE 1 - Area (13 Units)
        BaseUnit squareMetre = new BaseUnit("Square Metre [m²] (S.I. Unit)", 1d);
        BaseUnit squareKilometre = new BaseUnit("Square Kilometre [km²]", 1000000d);
        BaseUnit squareDecimetre = new BaseUnit("Square Decimetre [dm²]", 0.01d);
        BaseUnit squareCentimetre = new BaseUnit("Square Centimetre [cm²]", 0.0001d);
        BaseUnit squareMillimetre = new BaseUnit("Square Millimetre [mm²]", 0.000001d);
        BaseUnit squareMicrometre = new BaseUnit("Square Micrometre [μm²]", 0.000000000001d);
        BaseUnit squareMile = new BaseUnit("Square Mile [mi²]", ((1d / 1.19599004630108d) * 3097600d));
        BaseUnit squareYard = new BaseUnit("Square Yard [yd²]", (1d / 1.19599004630108d));
        BaseUnit squareFoot = new BaseUnit("Square Foot [ft²]", ((1d / 1.19599004630108d) / 9d));
        BaseUnit squareInch = new BaseUnit("Square Inch [in²]", ((1d / 1.19599004630108d) / 1296d));
        BaseUnit acre = new BaseUnit("Acre [ac]", ((1d / 1.19599004630108d) * 4840d));
        BaseUnit are = new BaseUnit("Are [a]", 100d);
        BaseUnit hectare = new BaseUnit("Hectare [ha]", 10000d);

        // UNIT TYPE 2 - Volume (14 Units)
        BaseUnit cubicMetre = new BaseUnit("Cubic Metre [m³] (S.I. Unit)", 1d);
        BaseUnit cubicCentimetre = new BaseUnit("Cubic Centimetre [cm³]", 0.000001d);
        BaseUnit cubicMillimetre = new BaseUnit("Cubic Millimetre [mm³]", 0.000000001d);
        BaseUnit cubicYard = new BaseUnit("Cubic Yard [yd³]", (1d / 1.30795061931439d));
        BaseUnit cubicFoot = new BaseUnit("Cubic Foot [ft³]", ((1d / 1.30795061931439d) / 27d));
        BaseUnit cubicInch = new BaseUnit("Cubic Inch [in³]", ((1d / 1.30795061931439d) / 46656d));
        BaseUnit litre = new BaseUnit("Litre [L]", 0.001d);
        BaseUnit millilitre = new BaseUnit("Millilitre [mL]", 0.000001d);
        BaseUnit gallon = new BaseUnit("Gallon (Imperial)", (1d / 219.969248299088d));
        BaseUnit quart = new BaseUnit("Quart (Imperial)", ((1d / 219.969248299088d) / 4d));
        BaseUnit pint = new BaseUnit("Pint (Imperial)", ((1d / 219.969248299088d) / 8d));
        BaseUnit cup = new BaseUnit("Cup (US Customary)", 4226.75283773038d);
        BaseUnit tablespoon = new BaseUnit("Tablespoon (US Customary)", (4226.75283773038d / 16d));
        BaseUnit teaspoon = new BaseUnit("Teaspoon (US Customary)", (4226.75283773038d / 48d));

        // UNIT TYPE 3 - Time (11 Units)
        BaseUnit second = new BaseUnit("Second [s] (S.I. Unit)", 1d);
        BaseUnit millisecond = new BaseUnit("Millisecond [ms]", 0.001d);
        BaseUnit microsecond = new BaseUnit("Microsecond [μs]", 0.000001d);
        BaseUnit nanosecond = new BaseUnit("Nanosecond [ns]", 000000001d);
        BaseUnit minute = new BaseUnit("Minute [min]", 60d);
        BaseUnit hour = new BaseUnit("Hour [h]", 3600d);
        BaseUnit day = new BaseUnit("Day", 86400d);
        BaseUnit week = new BaseUnit("Week", 604800d);
        BaseUnit fortnight = new BaseUnit("Fortnight", 1209600d);
        BaseUnit year = new BaseUnit("Year", 31536000d);
        BaseUnit yearLeap = new BaseUnit("Year (Leap)", 31622400d);

        // UNIT TYPE 4 - Speed (10 Units)
        BaseUnit metrePerSecond = new BaseUnit("Metre per Second [m/s] (S.I. Unit)", 1d);
        BaseUnit metrePerHour = new BaseUnit("Metre per Hour [m/h]", (1d / 3600d));
        BaseUnit kilometrePerSecond = new BaseUnit("Kilometre per Second [km/s]", 1000d);
        BaseUnit kilometrePerHour = new BaseUnit("Kilometre per Hour [km/h]", (1d / 3.6d));
        BaseUnit footPerSecond = new BaseUnit("Foot per Second [ft/s]", (1d / 3.280839895d));
        BaseUnit footPerHour = new BaseUnit("Foot per Hour [ft/h]", ((1d / 3.280839895d) / 3600d));
        BaseUnit milePerSecond = new BaseUnit("Mile per Second [mi/s]", ((1d / 3.280839895d) * 5280d));
        BaseUnit milePerHour = new BaseUnit("Mile per Hour [mi/h]", ((1d / 3.280839895d) * 5280d / 3600d));
        BaseUnit mach = new BaseUnit("Mach [Ma]", 340d);
        BaseUnit knot = new BaseUnit("Knot [kn]", 1852d);

        // UNIT TYPE 5 - Mass (13 Units)
        BaseUnit kilogram = new BaseUnit("Kilogram [kg] (S.I. Unit)", 1d);
        BaseUnit gram = new BaseUnit("Gram [g]", (1d / 1000d));
        BaseUnit milligram = new BaseUnit("Milligram [mg]", (1d / 1000000d));
        BaseUnit microgram = new BaseUnit("Microgram [μg]", (1d / 1000000000d));
        BaseUnit tonne = new BaseUnit("Tonne [t] (Metric)", 1000d);
        BaseUnit kilotonne = new BaseUnit("Kilotonne [kt] (Metric)", 1000000d);
        BaseUnit pound = new BaseUnit("Pound [lb]", (1d / 2.20462262184878d));
        BaseUnit ounce = new BaseUnit("Ounce [oz]", ((1d / 2.20462262184878d) / 16d));
        BaseUnit stoneUK = new BaseUnit("Stone [st.] (UK)", ((1d / 2.20462262184878d) * 14d));
        BaseUnit tonShort = new BaseUnit("Ton (Short)", ((1d / 2.20462262184878d) * 2000d));
        BaseUnit tonLong = new BaseUnit("Ton (Long)", ((1d / 2.20462262184878d) * 2240d));
        BaseUnit kilotonShort = new BaseUnit("Kiloton (Short)", ((1d / 2.20462262184878d) * 2000000d));
        BaseUnit kilotonLong = new BaseUnit("Kiloton (Long)", ((1d / 2.20462262184878d) * 2240000d));

        // UNIT TYPE 6 - Energy (7 Units)
        BaseUnit joule = new BaseUnit("Joule [J] (S.I. Unit)", 1d);
        BaseUnit kilojoule = new BaseUnit("Kilojoule [kj]", 1000d);
        BaseUnit wattHour = new BaseUnit("Watt Hour [Wh]", 3600d);
        BaseUnit kilowattHour = new BaseUnit("Kilowatt Hour [kWh]", 3600000d);
        BaseUnit calorie = new BaseUnit("calorie", 4.184d);
        BaseUnit kilocalorie = new BaseUnit("Kilocalorie", 4184d);
        BaseUnit btu = new BaseUnit("British Thermal Unit (BTU)", 1055.05585262d);

        // UNIT TYPE 7 - Temperature (3 Units, not a multiplicative unit type)
        TemperatureUnit kelvin = new TemperatureUnit("Kelvin [K] (S.I. Unit)");
        TemperatureUnit celsius = new TemperatureUnit("Celsius [°C]");
        TemperatureUnit fahrenheit = new TemperatureUnit("Fahrenheit [°F]");

        // UNIT TYPE 8 - Data Size (6 Units)
        BaseUnit sizeByte = new BaseUnit("Byte [B]", 1d);
        BaseUnit sizeKilobyte = new BaseUnit("Kilobyte [kb]", 1024d);
        BaseUnit sizeMegabyte = new BaseUnit("Megabyte [MB]", 1048576d);
        BaseUnit sizeGigabyte = new BaseUnit("Gigabyte [GB]", 1073741824d);
        BaseUnit sizeTerabyte = new BaseUnit("Terabyte [TB]", 1099511627776d);
        BaseUnit sizePetabyte = new BaseUnit("Petabyte [PB]", 1125899906842624d);

        // (1) INITIALISATION - Define lists to contain units
        List<BaseUnit> lengthUnits = new List<BaseUnit>();
        List<BaseUnit> areaUnits = new List<BaseUnit>();
        List<BaseUnit> volumeUnits = new List<BaseUnit>();
        List<BaseUnit> timeUnits = new List<BaseUnit>();
        List<BaseUnit> speedUnits = new List<BaseUnit>();
        List<BaseUnit> massUnits = new List<BaseUnit>();
        List<BaseUnit> energyUnits = new List<BaseUnit>();
        List<TemperatureUnit> temperatureUnits = new List<TemperatureUnit>();
        List<BaseUnit> dataSizeUnits = new List<BaseUnit>();

        // (1) INITIALISATION - Load elements to main screen controls
        private void MainScreen_Load(object sender, EventArgs e)
        {
            // UNIT TYPE 0 - Length
            lengthUnits.Add(metre);
            lengthUnits.Add(kilometre);
            lengthUnits.Add(decimetre);
            lengthUnits.Add(centimetre);
            lengthUnits.Add(millimetre);
            lengthUnits.Add(micrometre);
            lengthUnits.Add(nanometre);
            lengthUnits.Add(angstrom);
            lengthUnits.Add(mile);
            lengthUnits.Add(yard);
            lengthUnits.Add(foot);
            lengthUnits.Add(inch);

            foreach (BaseUnit element in lengthUnits)
            {
                lengthFromUnitInput.Items.Add(element.getName());
                lengthToUnitOutput.Items.Add(element.getName());
            }


            // UNIT TYPE 1 - Area
            areaUnits.Add(squareMetre);
            areaUnits.Add(squareKilometre);
            areaUnits.Add(squareDecimetre);
            areaUnits.Add(squareCentimetre);
            areaUnits.Add(squareMillimetre);
            areaUnits.Add(squareMicrometre);
            areaUnits.Add(squareMile);
            areaUnits.Add(squareYard);
            areaUnits.Add(squareFoot);
            areaUnits.Add(squareInch);
            areaUnits.Add(acre);
            areaUnits.Add(are);
            areaUnits.Add(hectare);

            foreach (BaseUnit element in areaUnits)
            {
                areaFromUnitInput.Items.Add(element.getName());
                areaToUnitOutput.Items.Add(element.getName());
            }

            // UNIT TYPE 2 - Volume
            volumeUnits.Add(cubicMetre);
            volumeUnits.Add(cubicCentimetre);
            volumeUnits.Add(cubicMillimetre);
            volumeUnits.Add(cubicYard);
            volumeUnits.Add(cubicFoot);
            volumeUnits.Add(cubicInch);
            volumeUnits.Add(litre);
            volumeUnits.Add(millilitre);
            volumeUnits.Add(gallon);
            volumeUnits.Add(quart);
            volumeUnits.Add(pint);
            volumeUnits.Add(cup);
            volumeUnits.Add(tablespoon);
            volumeUnits.Add(teaspoon);

            foreach (BaseUnit element in volumeUnits)
            {
                volumeFromUnitInput.Items.Add(element.getName());
                volumeToUnitOutput.Items.Add(element.getName());
            }

            // UNIT TYPE 3 - Time
            timeUnits.Add(second);
            timeUnits.Add(millisecond);
            timeUnits.Add(microsecond);
            timeUnits.Add(nanosecond);
            timeUnits.Add(minute);
            timeUnits.Add(hour);
            timeUnits.Add(day);
            timeUnits.Add(week);
            timeUnits.Add(fortnight);
            timeUnits.Add(year);
            timeUnits.Add(yearLeap);

            foreach (BaseUnit element in timeUnits)
            {
                timeFromUnitInput.Items.Add(element.getName());
                timeToUnitOutput.Items.Add(element.getName());
            }

            // UNIT TYPE 4 - Speed
            speedUnits.Add(metrePerSecond);
            speedUnits.Add(metrePerHour);
            speedUnits.Add(kilometrePerSecond);
            speedUnits.Add(kilometrePerHour);
            speedUnits.Add(footPerSecond);
            speedUnits.Add(footPerHour);
            speedUnits.Add(milePerSecond);
            speedUnits.Add(milePerHour);
            speedUnits.Add(mach);
            speedUnits.Add(knot);

            foreach (BaseUnit element in speedUnits)
            {
                speedFromUnitInput.Items.Add(element.getName());
                speedToUnitOutput.Items.Add(element.getName());
            }

            // UNIT TYPE 5 - Mass
            massUnits.Add(kilogram);
            massUnits.Add(gram);
            massUnits.Add(milligram);
            massUnits.Add(microgram);
            massUnits.Add(tonne);
            massUnits.Add(kilotonne);
            massUnits.Add(pound);
            massUnits.Add(ounce);
            massUnits.Add(stoneUK);
            massUnits.Add(tonShort);
            massUnits.Add(tonLong);
            massUnits.Add(kilotonShort);
            massUnits.Add(kilotonLong);

            foreach (BaseUnit element in massUnits)
            {
                massFromUnitInput.Items.Add(element.getName());
                massToUnitOutput.Items.Add(element.getName());
            }

            // UNIT TYPE 6 - Energy
            energyUnits.Add(joule);
            energyUnits.Add(kilojoule);
            energyUnits.Add(wattHour);
            energyUnits.Add(kilowattHour);
            energyUnits.Add(calorie);
            energyUnits.Add(kilocalorie);
            energyUnits.Add(btu);

            foreach (BaseUnit element in energyUnits)
            {
                energyFromUnitInput.Items.Add(element.getName());
                energyToUnitOutput.Items.Add(element.getName());
            }

            // UNIT TYPE 7 - Temperature
            temperatureUnits.Add(kelvin);
            temperatureUnits.Add(celsius);
            temperatureUnits.Add(fahrenheit);

            foreach (TemperatureUnit element in temperatureUnits)
            {
                temperatureFromUnitInput.Items.Add(element.getName());
                temperatureToUnitOutput.Items.Add(element.getName());
            }

            // UNIT TYPE 8 - Data Size
            dataSizeUnits.Add(sizeByte);
            dataSizeUnits.Add(sizeKilobyte);
            dataSizeUnits.Add(sizeMegabyte);
            dataSizeUnits.Add(sizeGigabyte);
            dataSizeUnits.Add(sizeTerabyte);
            dataSizeUnits.Add(sizePetabyte);

            foreach (BaseUnit element in dataSizeUnits)
            {
                dataSizeFromUnitInput.Items.Add(element.getName());
                dataSizeToUnitOutput.Items.Add(element.getName());
            }
        }

        // (2) MENU BAR EVENTS - Open the About box to show the application
        // credits
        private void aboutUnitConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        // (2) MENU BAR EVENTS - Close the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // (3) STATUS BAR EVENTS - Indicate to user converter is ready when unit
        // type is changed (tab is changed)
        private void unitSelector_SelectedIndexChanged(Object sender, EventArgs e)
        {
            statusIndicator.Text = StatusMessages.ready;
        }

        // (4) CONTROLS - Calculate when button clicked
        private void calculateButton_Click(object sender, EventArgs e)
        {
            ExecuteCalculation();
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void lengthFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteCalculation();
                e.SuppressKeyPress = true;
            }
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void areaFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteCalculation();
                e.SuppressKeyPress = true;
            }
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void volumeFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteCalculation();
                e.SuppressKeyPress = true;
            }
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void timeFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteCalculation();
                e.SuppressKeyPress = true;
            }
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void speedFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteCalculation();
                e.SuppressKeyPress = true;
            }
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void massFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteCalculation();
                e.SuppressKeyPress = true;
            }
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void energyFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteCalculation();
                e.SuppressKeyPress = true;
            }
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void temperatureFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteCalculation();
                e.SuppressKeyPress = true;
            }
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void dataSizeFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteCalculation();
                e.SuppressKeyPress = true;
            }
        }

        // (5) CALCULATION - Execute the calculation process
        private void ExecuteCalculation()
        {
            string rawValue;                 // raw data from the user-inputtable text box
            double inputValue;               // processed data from the user-inputtable text box
            bool canParse;                   // shows whether raw user input data can be parsed to double
            bool fromInputHasValue = false;  // shows if the user has not selected a unit for fromUnitInput combo box
            bool toOutputHasValue = false;   // shows if the user has not selected a unit for toUnitOutput combo box

            // UNIT TYPE 0 - User wants to convert length
            if (unitSelector.SelectedIndex == 0)
            {
                double lengthValue = 0;
                double resultLengthValue = 0;

                rawValue = lengthFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    foreach (BaseUnit element in lengthUnits)
                    {
                        if ((string)lengthFromUnitInput.SelectedItem == element.getName())
                        {
                            lengthValue = element.convertToSiValue(inputValue);
                            fromInputHasValue = true;
                            break;
                        }
                    }

                    foreach (BaseUnit element in lengthUnits)
                    {
                        if ((string)lengthToUnitOutput.SelectedItem == element.getName())
                        {
                            resultLengthValue = element.convertFromSiValue(lengthValue);
                            toOutputHasValue = true;
                            break;
                        }
                    }

                    if (fromInputHasValue && toOutputHasValue)
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

            // UNIT TYPE 1 - User wants to convert area
            else if (unitSelector.SelectedIndex == 1)
            {
                double areaValue = 0;
                double resultAreaValue = 0;

                rawValue = areaFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    foreach (BaseUnit element in areaUnits)
                    {
                        if ((string)areaFromUnitInput.SelectedItem == element.getName())
                        {
                            areaValue = element.convertToSiValue(inputValue);
                            fromInputHasValue = true;
                            break;
                        }
                    }

                    foreach (BaseUnit element in areaUnits)
                    {
                        if ((string)areaToUnitOutput.SelectedItem == element.getName())
                        {
                            resultAreaValue = element.convertFromSiValue(areaValue);
                            toOutputHasValue = true;
                            break;
                        }
                    }

                    if (fromInputHasValue && toOutputHasValue)
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

            // UNIT TYPE 2 - User wants to convert volume
            else if (unitSelector.SelectedIndex == 2)
            {
                double volumeValue = 0;
                double resultVolumeValue = 0;

                rawValue = volumeFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    foreach (BaseUnit element in volumeUnits)
                    {
                        if ((string)volumeFromUnitInput.SelectedItem == element.getName())
                        {
                            volumeValue = element.convertToSiValue(inputValue);
                            fromInputHasValue = true;
                            break;
                        }
                    }

                    foreach (BaseUnit element in volumeUnits)
                    {
                        if ((string)volumeToUnitOutput.SelectedItem == element.getName())
                        {
                            resultVolumeValue = element.convertFromSiValue(volumeValue);
                            toOutputHasValue = true;
                            break;
                        }
                    }

                    if (fromInputHasValue && toOutputHasValue)
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

            // UNIT TYPE 3 - User wants to convert time
            else if (unitSelector.SelectedIndex == 3)
            {
                double timeValue = 0;
                double resultTimeValue = 0;

                rawValue = timeFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    foreach (BaseUnit element in timeUnits)
                    {
                        if ((string)timeFromUnitInput.SelectedItem == element.getName())
                        {
                            timeValue = element.convertToSiValue(inputValue);
                            fromInputHasValue = true;
                            break;
                        }
                    }

                    foreach (BaseUnit element in timeUnits)
                    {
                        if ((string)timeToUnitOutput.SelectedItem == element.getName())
                        {
                            resultTimeValue = element.convertFromSiValue(timeValue);
                            toOutputHasValue = true;
                            break;
                        }
                    }

                    if (fromInputHasValue && toOutputHasValue)
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

            // UNIT TYPE 4 - User wants to convert speed
            else if (unitSelector.SelectedIndex == 4)
            {
                double speedValue = 0;
                double resultSpeedValue = 0;

                rawValue = speedFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    foreach (BaseUnit element in speedUnits)
                    {
                        if ((string)speedFromUnitInput.SelectedItem == element.getName())
                        {
                            speedValue = element.convertToSiValue(inputValue);
                            fromInputHasValue = true;
                            break;
                        }
                    }

                    foreach (BaseUnit element in speedUnits)
                    {
                        if ((string)speedToUnitOutput.SelectedItem == element.getName())
                        {
                            resultSpeedValue = element.convertFromSiValue(speedValue);
                            toOutputHasValue = true;
                            break;
                        }
                    }

                    if (fromInputHasValue && toOutputHasValue)
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

            // UNIT TYPE 5 - User wants to convert mass
            else if (unitSelector.SelectedIndex == 5)
            {
                double massValue = 0;
                double resultMassValue = 0;

                rawValue = massFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    foreach (BaseUnit element in massUnits)
                    {
                        if ((string)massFromUnitInput.SelectedItem == element.getName())
                        {
                            massValue = element.convertToSiValue(inputValue);
                            fromInputHasValue = true;
                            break;
                        }
                    }

                    foreach (BaseUnit element in massUnits)
                    {
                        if ((string)massToUnitOutput.SelectedItem == element.getName())
                        {
                            resultMassValue = element.convertFromSiValue(massValue);
                            toOutputHasValue = true;
                            break;
                        }
                    }

                    if (fromInputHasValue && toOutputHasValue)
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

            // UNIT TYPE 6 - User wants to convert energy
            else if (unitSelector.SelectedIndex == 6)
            {
                double energyValue = 0;
                double resultEnergyValue = 0;

                rawValue = energyFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    foreach (BaseUnit element in energyUnits)
                    {
                        if ((string)energyFromUnitInput.SelectedItem == element.getName())
                        {
                            energyValue = element.convertToSiValue(inputValue);
                            fromInputHasValue = true;
                            break;
                        }
                    }

                    foreach (BaseUnit element in energyUnits)
                    {
                        if ((string)energyToUnitOutput.SelectedItem == element.getName())
                        {
                            resultEnergyValue = element.convertFromSiValue(energyValue);
                            toOutputHasValue = true;
                            break;
                        }
                    }

                    if (fromInputHasValue && toOutputHasValue)
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

            // UNIT TYPE 7 - User wants to convert temperature
            else if (unitSelector.SelectedIndex == 7)
            {
                double resultTemperatureValue = 0;

                rawValue = temperatureFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    fromInputHasValue = true;
                    toOutputHasValue = true;

                    if ((string)temperatureFromUnitInput.SelectedItem ==
                        (string)temperatureToUnitOutput.SelectedItem)
                        resultTemperatureValue = inputValue;
                    else if (((string)temperatureFromUnitInput.SelectedItem == kelvin.getName())
                        && (string)temperatureToUnitOutput.SelectedItem == celsius.getName())
                        resultTemperatureValue = inputValue - 273.15d;
                    else if (((string)temperatureFromUnitInput.SelectedItem == kelvin.getName())
                        && (string)temperatureToUnitOutput.SelectedItem == fahrenheit.getName())
                        resultTemperatureValue = inputValue * 1.8d - 459.67d;
                    else if (((string)temperatureFromUnitInput.SelectedItem == celsius.getName())
                        && (string)temperatureToUnitOutput.SelectedItem == kelvin.getName())
                        resultTemperatureValue = inputValue + 273.15d;
                    else if (((string)temperatureFromUnitInput.SelectedItem == celsius.getName())
                        && (string)temperatureToUnitOutput.SelectedItem == fahrenheit.getName())
                        resultTemperatureValue = inputValue * 1.8d + 32d;
                    else if (((string)temperatureFromUnitInput.SelectedItem == fahrenheit.getName())
                        && (string)temperatureToUnitOutput.SelectedItem == kelvin.getName())
                        resultTemperatureValue = (inputValue + 459.67d) / 1.8d;
                    else if (((string)temperatureFromUnitInput.SelectedItem == fahrenheit.getName())
                        && (string)temperatureToUnitOutput.SelectedItem == celsius.getName())
                        resultTemperatureValue = (inputValue - 32d) / 1.8d;
                    else
                        fromInputHasValue = false;

                    if (fromInputHasValue && toOutputHasValue)
                    {
                        temperatureToValueOutput.Text = resultTemperatureValue.ToString();
                        statusIndicator.Text = StatusMessages.done;
                    }
                    else
                        statusIndicator.Text = StatusMessages.unitError;
                }
                else
                    statusIndicator.Text = StatusMessages.invalidInput;
            }

            // UNIT TYPE 8 - User wants to convert data size
            else if (unitSelector.SelectedIndex == 8)
            {
                double dataSizeValue = 0;
                double resultDataSizeValue = 0;

                rawValue = dataSizeFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if ((canParse) && (inputValue >= 0))
                {
                    foreach (BaseUnit element in dataSizeUnits)
                    {
                        if ((string)dataSizeFromUnitInput.SelectedItem == element.getName())
                        {
                            dataSizeValue = element.convertToSiValue(inputValue);
                            fromInputHasValue = true;
                            break;
                        }
                    }

                    foreach (BaseUnit element in dataSizeUnits)
                    {
                        if ((string)dataSizeToUnitOutput.SelectedItem == element.getName())
                        {
                            resultDataSizeValue = element.convertFromSiValue(dataSizeValue);
                            toOutputHasValue = true;
                            break;
                        }
                    }

                    if (fromInputHasValue && toOutputHasValue)
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
    }
}