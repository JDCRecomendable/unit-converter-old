using System;
using System.Collections.Generic;
// using System.ComponentModel;
// using System.Data;
// using System.Drawing;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
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
            lengthFromUnitInput.Focus();

            // Detect if unit type changed (tab changed)
            unitSelector.SelectedIndexChanged += new EventHandler(unitSelector_SelectedIndexChanged);
        }

        // (1) INITIALISATION - Define all units
        // UNIT TYPE 0 - Length (9 Units)
        LengthUnit metre = new LengthUnit("Metre [m] (S.I. Unit)", 1d);
        LengthUnit kilometre = new LengthUnit("Kilometre [km]", 1000d);
        LengthUnit decimetre = new LengthUnit("Decimetre [dm]", 0.1d);
        LengthUnit centimetre = new LengthUnit("Centimetre [cm]", 0.01d);
        LengthUnit millimetre = new LengthUnit("Millimetre [mm]", 0.001d);
        LengthUnit mile = new LengthUnit("Mile [mi]", ((1d / 3.280839895d) * 5280d));
        LengthUnit yard = new LengthUnit("Yard [yd]", ((1d / 3.280839895d) * 3d));
        LengthUnit foot = new LengthUnit("Foot [ft]", (1d / 3.280839895d));
        LengthUnit inch = new LengthUnit("Inch [in]", ((1d / 3.280839895d) / 12d));

        // UNIT TYPE 1 - Area (12 Units)
        AreaUnit squareMetre = new AreaUnit("Square Metre [m²] (S.I. Unit)", 1d);
        AreaUnit squareKilometre = new AreaUnit("Square Kilometre [km²]", 1000000d);
        AreaUnit squareDecimetre = new AreaUnit("Square Decimetre [dm²]", 0.01d);
        AreaUnit squareCentimetre = new AreaUnit("Square Centimetre [cm²]", 0.0001d);
        AreaUnit squareMillimetre = new AreaUnit("Square Millimetre [mm²]", 0.000001);
        AreaUnit squareMile = new AreaUnit("Square Mile [mi²]", ((1d / 1.19599004630108d) * 3097600d));
        AreaUnit squareYard = new AreaUnit("Square Yard [yd²]", (1d / 1.19599004630108d));
        AreaUnit squareFoot = new AreaUnit("Square Foot [ft²]", ((1d / 1.19599004630108d) / 9d));
        AreaUnit squareInch = new AreaUnit("Square Inch [in²]", ((1d / 1.19599004630108d) / 1296d));
        AreaUnit acre = new AreaUnit("Acre [ac]", ((1d / 1.19599004630108d) * 4840d));
        AreaUnit are = new AreaUnit("Are [a]", 100d);
        AreaUnit hectare = new AreaUnit("Hectare [ha]", 10000d);

        // UNIT TYPE 2 - Volume (14 Units)
        VolumeUnit cubicMetre = new VolumeUnit("Cubic Metre [m³] (S.I. Unit)", 1d);
        VolumeUnit cubicCentimetre = new VolumeUnit("Cubic Centimetre [cm³]", 0.000001d);
        VolumeUnit cubicMillimetre = new VolumeUnit("Cubic Millimetre [mm³]", 0.000000001d);
        VolumeUnit cubicYard = new VolumeUnit("Cubic Yard [yd³]", (1d / 1.30795061931439d));
        VolumeUnit cubicFoot = new VolumeUnit("Cubic Foot [ft³]", ((1d / 1.30795061931439d) / 27d));
        VolumeUnit cubicInch = new VolumeUnit("Cubic Inch [in³]", ((1d / 1.30795061931439d) / 46656d));
        VolumeUnit litre = new VolumeUnit("Litre [L]", 0.001d);
        VolumeUnit millilitre = new VolumeUnit("Millilitre [mL]", 0.000001d);
        VolumeUnit gallon = new VolumeUnit("Gallon (Imperial)", (1d / 219.969248299088d));
        VolumeUnit quart = new VolumeUnit("Quart (Imperial)", ((1d / 219.969248299088d) / 4d));
        VolumeUnit pint = new VolumeUnit("Pint (Imperial)", ((1d / 219.969248299088d) / 8d));
        VolumeUnit cup = new VolumeUnit("Cup (US Customary)", 4226.75283773038d);
        VolumeUnit tablespoon = new VolumeUnit("Tablespoon (US Customary)", (4226.75283773038d / 16d));
        VolumeUnit teaspoon = new VolumeUnit("Teaspoon (US Customary)", (4226.75283773038d / 48d));

        // UNIT TYPE 3 - Time (11 Units)
        TimeUnit second = new TimeUnit("Second [s] (S.I. Unit)", 1d);
        TimeUnit millisecond = new TimeUnit("Millisecond [ms]", 0.001d);
        TimeUnit microsecond = new TimeUnit("Microsecond [μs]", 0.000001d);
        TimeUnit nanosecond = new TimeUnit("Nanosecond [ns]", 000000001d);
        TimeUnit minute = new TimeUnit("Minute [min]", 60d);
        TimeUnit hour = new TimeUnit("Hour [h]", 3600d);
        TimeUnit day = new TimeUnit("Day", 86400d);
        TimeUnit week = new TimeUnit("Week", 604800d);
        TimeUnit fortnight = new TimeUnit("Fortnight", 1209600d);
        TimeUnit year = new TimeUnit("Year", 31536000d);
        TimeUnit yearLeap = new TimeUnit("Year (Leap)", 31622400d);

        // UNIT TYPE 4 - Speed (8 Units)
        SpeedUnit metrePerSecond = new SpeedUnit("Metre per Second [m/s] (S.I. Unit)", 1d);
        SpeedUnit metrePerHour = new SpeedUnit("Metre per Hour [m/h]", (1d / 3600d));
        SpeedUnit kilometrePerSecond = new SpeedUnit("Kilometre per Second [km/s]", 1000d);
        SpeedUnit kilometrePerHour = new SpeedUnit("Kilometre per Hour [km/h]", (1d / 3.6d));
        SpeedUnit footPerSecond = new SpeedUnit("Foot per Second [ft/s]", (1d / 3.280839895d));
        SpeedUnit footPerHour = new SpeedUnit("Foot per Hour [ft/h]", ((1d / 3.280839895d) / 3600d));
        SpeedUnit milePerSecond = new SpeedUnit("Mile per Second [mi/s]", ((1d / 3.280839895d) * 5280d));
        SpeedUnit milePerHour = new SpeedUnit("Mile per Hour [mi/h]", ((1d / 3.280839895d) * 5280d / 3600d));

        // UNIT TYPE 5 - Mass (13 Units)
        MassUnit kilogram = new MassUnit("Kilogram [kg] (S.I. Unit)", 1d);
        MassUnit gram = new MassUnit("Gram [g]", (1d / 1000d));
        MassUnit milligram = new MassUnit("Milligram [mg]", (1d / 1000000d));
        MassUnit microgram = new MassUnit("Microgram [μg]", (1d / 1000000000d));
        MassUnit tonne = new MassUnit("Tonne [t] (Metric)", 1000d);
        MassUnit kilotonne = new MassUnit("Kilotonne [kt] (Metric)", 1000000d);
        MassUnit pound = new MassUnit("Pound [lb]", (1d / 2.20462262184878d));
        MassUnit ounce = new MassUnit("Ounce [oz]", ((1d / 2.20462262184878d) / 16d));
        MassUnit stoneUK = new MassUnit("Stone [st.] (UK)", ((1d / 2.20462262184878d) * 14d));
        MassUnit tonShort = new MassUnit("Ton (Short)", ((1d / 2.20462262184878d) * 2000d));
        MassUnit tonLong = new MassUnit("Ton (Long)", ((1d / 2.20462262184878d) * 2240d));
        MassUnit kilotonShort = new MassUnit("Kiloton (Short)", ((1d / 2.20462262184878d) * 2000000d));
        MassUnit kilotonLong = new MassUnit("Kiloton (Long)", ((1d / 2.20462262184878d) * 2240000d));

        // UNIT TYPE 6 - Energy (7 Units)
        EnergyUnit joule = new EnergyUnit("Joule [J] (S.I. Unit)", 1d);
        EnergyUnit kilojoule = new EnergyUnit("Kilojoule [kj]", 1000d);
        EnergyUnit wattHour = new EnergyUnit("Watt Hour [Wh]", 3600d);
        EnergyUnit kilowattHour = new EnergyUnit("Kilowatt Hour [kWh]", 3600000d);
        EnergyUnit calorie = new EnergyUnit("calorie", 4.184d);
        EnergyUnit kilocalorie = new EnergyUnit("Kilocalorie", 4184d);
        EnergyUnit btu = new EnergyUnit("British Thermal Unit (BTU)", 1055.05585262d);

        // UNIT TYPE 7 - Temperature (3 Units, not a multiplicative unit type)
        TemperatureUnit kelvin = new TemperatureUnit("Kelvin [K] (S.I. Unit)");
        TemperatureUnit celsius = new TemperatureUnit("Celsius [°C]");
        TemperatureUnit fahrenheit = new TemperatureUnit("Fahrenheit [°F]");

        // UNIT TYPE 8 - Data Size (6 Units)
        DataSizeUnit sizeByte = new DataSizeUnit("Byte [B]", 1d);
        DataSizeUnit sizeKilobyte = new DataSizeUnit("Kilobyte [kb]", 1024d);
        DataSizeUnit sizeMegabyte = new DataSizeUnit("Megabyte [MB]", 1048576d);
        DataSizeUnit sizeGigabyte = new DataSizeUnit("Gigabyte [GB]", 1073741824d);
        DataSizeUnit sizeTerabyte = new DataSizeUnit("Terabyte [TB]", 1099511627776d);
        DataSizeUnit sizePetabyte = new DataSizeUnit("Petabyte [PB]", 1125899906842624d);

        // (1) INITIALISATION - Define lists to contain units
        List<LengthUnit> lengthUnits = new List<LengthUnit>();
        List<AreaUnit> areaUnits = new List<AreaUnit>();
        List<VolumeUnit> volumeUnits = new List<VolumeUnit>();
        List<TimeUnit> timeUnits = new List<TimeUnit>();
        List<SpeedUnit> speedUnits = new List<SpeedUnit>();
        List<MassUnit> massUnits = new List<MassUnit>();
        List<EnergyUnit> energyUnits = new List<EnergyUnit>();
        List<TemperatureUnit> temperatureUnits = new List<TemperatureUnit>();
        List<DataSizeUnit> dataSizeUnits = new List<DataSizeUnit>();

        // (1) INITIALISATION - Load elements to main screen controls
        private void MainScreen_Load(object sender, EventArgs e)
        {
            // UNIT TYPE 0 - Length
            lengthUnits.Add(metre);
            lengthUnits.Add(kilometre);
            lengthUnits.Add(decimetre);
            lengthUnits.Add(centimetre);
            lengthUnits.Add(millimetre);
            lengthUnits.Add(mile);
            lengthUnits.Add(yard);
            lengthUnits.Add(foot);
            lengthUnits.Add(inch);

            foreach (LengthUnit element in lengthUnits)
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
            areaUnits.Add(squareMile);
            areaUnits.Add(squareYard);
            areaUnits.Add(squareFoot);
            areaUnits.Add(squareInch);
            areaUnits.Add(acre);
            areaUnits.Add(are);
            areaUnits.Add(hectare);

            foreach (AreaUnit element in areaUnits)
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

            foreach (VolumeUnit element in volumeUnits)
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

            foreach (TimeUnit element in timeUnits)
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

            foreach (SpeedUnit element in speedUnits)
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

            foreach (MassUnit element in massUnits)
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

            foreach (EnergyUnit element in energyUnits)
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

            foreach (DataSizeUnit element in dataSizeUnits)
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
        private void lengthCalculateButton_Click(object sender, EventArgs e)
        {
            ExecuteCalculation();
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void lengthFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void areaFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void volumeFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void timeFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void speedFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void massFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void energyFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void temperatureFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        // (4) CONTROLS - Calculate when [Enter] pressed in the input box
        private void dataSizeFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        // (5) CALCULATION - Execute the calculation process
        private void ExecuteCalculation()
        {
            string rawValue;         // raw data from the user-inputtable text box
            double inputValue;       // processed data from the user-inputtable text box
            bool canParse;           // shows whether raw user input data can be parsed to double
            bool unitError = false;  // shows if the user has not selected a unit for both from and or combo boxes

            // UNIT TYPE 0 - User wants to convert length
            if (unitSelector.SelectedIndex == 0)
            {
                double lengthValue = 0;
                double resultLengthValue = 0;

                rawValue = lengthFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    foreach (LengthUnit element in lengthUnits)
                    {
                        if ((string)lengthFromUnitInput.SelectedItem == element.getName())
                        {
                            lengthValue = element.convertToSiValue(inputValue);
                            break;
                        }
                    }

                    foreach (LengthUnit element in lengthUnits)
                    {
                        if ((string)lengthToUnitOutput.SelectedItem == element.getName())
                        {
                            resultLengthValue = element.convertFromSiValue(lengthValue);
                            break;
                        }
                    }

                    lengthToValueOutput.Text = resultLengthValue.ToString();
                    statusIndicator.Text = StatusMessages.done;
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
                    foreach (AreaUnit element in areaUnits)
                    {
                        if ((string)areaFromUnitInput.SelectedItem == element.getName())
                        {
                            areaValue = element.convertToSiValue(inputValue);
                            break;
                        }
                    }

                    foreach (AreaUnit element in areaUnits)
                    {
                        if ((string)areaToUnitOutput.SelectedItem == element.getName())
                        {
                            resultAreaValue = element.convertFromSiValue(areaValue);
                            break;
                        }
                    }

                    areaToValueOutput.Text = resultAreaValue.ToString();
                    statusIndicator.Text = StatusMessages.done;
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
                    foreach (VolumeUnit element in volumeUnits)
                    {
                        if ((string)volumeFromUnitInput.SelectedItem == element.getName())
                        {
                            volumeValue = element.convertToSiValue(inputValue);
                            break;
                        }
                    }

                    foreach (VolumeUnit element in volumeUnits)
                    {
                        if ((string)volumeToUnitOutput.SelectedItem == element.getName())
                        {
                            resultVolumeValue = element.convertFromSiValue(volumeValue);
                            break;
                        }
                    }

                    volumeToValueOutput.Text = resultVolumeValue.ToString();
                    statusIndicator.Text = StatusMessages.done;
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
                    foreach (TimeUnit element in timeUnits)
                    {
                        if ((string)timeFromUnitInput.SelectedItem == element.getName())
                        {
                            timeValue = element.convertToSiValue(inputValue);
                            break;
                        }
                    }

                    foreach (TimeUnit element in timeUnits)
                    {
                        if ((string)timeToUnitOutput.SelectedItem == element.getName())
                        {
                            resultTimeValue = element.convertFromSiValue(timeValue);
                            break;
                        }
                    }

                    timeToValueOutput.Text = resultTimeValue.ToString();
                    statusIndicator.Text = StatusMessages.done;
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
                    foreach (SpeedUnit element in speedUnits)
                    {
                        if ((string)speedFromUnitInput.SelectedItem == element.getName())
                        {
                            speedValue = element.convertToSiValue(inputValue);
                            break;
                        }
                    }

                    foreach (SpeedUnit element in speedUnits)
                    {
                        if ((string)speedToUnitOutput.SelectedItem == element.getName())
                        {
                            resultSpeedValue = element.convertFromSiValue(speedValue);
                            break;
                        }
                    }

                    speedToValueOutput.Text = resultSpeedValue.ToString();
                    statusIndicator.Text = StatusMessages.done;
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
                    foreach (MassUnit element in massUnits)
                    {
                        if ((string)massFromUnitInput.SelectedItem == element.getName())
                        {
                            massValue = element.convertToSiValue(inputValue);
                            break;
                        }
                    }

                    foreach (MassUnit element in massUnits)
                    {
                        if ((string)massToUnitOutput.SelectedItem == element.getName())
                        {
                            resultMassValue = element.convertFromSiValue(massValue);
                            break;
                        }
                    }

                    massToValueOutput.Text = resultMassValue.ToString();
                    statusIndicator.Text = StatusMessages.done;
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
                    foreach (EnergyUnit element in energyUnits)
                    {
                        if ((string)energyFromUnitInput.SelectedItem == element.getName())
                        {
                            energyValue = element.convertToSiValue(inputValue);
                            break;
                        }
                    }

                    foreach (EnergyUnit element in energyUnits)
                    {
                        if ((string)energyToUnitOutput.SelectedItem == element.getName())
                        {
                            resultEnergyValue = element.convertFromSiValue(energyValue);
                            break;
                        }
                    }

                    energyToValueOutput.Text = resultEnergyValue.ToString();
                    statusIndicator.Text = StatusMessages.done;
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
                    if (((string)temperatureFromUnitInput.SelectedItem == kelvin.getName())
                        && (string)temperatureToUnitOutput.SelectedItem == celsius.getName())
                    {
                        resultTemperatureValue = inputValue - 273.15d;
                        temperatureToValueOutput.Text = resultTemperatureValue.ToString();
                    }
                    else if (((string)temperatureFromUnitInput.SelectedItem == kelvin.getName())
                        && (string)temperatureToUnitOutput.SelectedItem == fahrenheit.getName())
                    {
                        resultTemperatureValue = inputValue * 1.8d - 459.67d;
                        temperatureToValueOutput.Text = resultTemperatureValue.ToString();
                    }
                    else if (((string)temperatureFromUnitInput.SelectedItem == celsius.getName())
                        && (string)temperatureToUnitOutput.SelectedItem == kelvin.getName())
                    {
                        resultTemperatureValue = inputValue + 273.15d;
                        temperatureToValueOutput.Text = resultTemperatureValue.ToString();
                    }
                    else if (((string)temperatureFromUnitInput.SelectedItem == celsius.getName())
                        && (string)temperatureToUnitOutput.SelectedItem == fahrenheit.getName())
                    {
                        resultTemperatureValue = inputValue * 1.8d + 32d;
                        temperatureToValueOutput.Text = resultTemperatureValue.ToString();
                    }
                    else if (((string)temperatureFromUnitInput.SelectedItem == fahrenheit.getName())
                        && (string)temperatureToUnitOutput.SelectedItem == kelvin.getName())
                    {
                        resultTemperatureValue = (inputValue + 459.67d) / 1.8d;
                        temperatureToValueOutput.Text = resultTemperatureValue.ToString();
                    }
                    else if (((string)temperatureFromUnitInput.SelectedItem == fahrenheit.getName())
                        && (string)temperatureToUnitOutput.SelectedItem == celsius.getName())
                    {
                        resultTemperatureValue = (inputValue - 32d) / 1.8d;
                        temperatureToValueOutput.Text = resultTemperatureValue.ToString();
                    }
                    else
                        statusIndicator.Text = StatusMessages.unitError;

                    if (unitError == false)
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
                    foreach (DataSizeUnit element in dataSizeUnits)
                    {
                        if ((string)dataSizeFromUnitInput.SelectedItem == element.getName())
                        {
                            dataSizeValue = element.convertToSiValue(inputValue);
                            break;
                        }
                    }

                    foreach (DataSizeUnit element in dataSizeUnits)
                    {
                        if ((string)dataSizeToUnitOutput.SelectedItem == element.getName())
                        {
                            resultDataSizeValue = element.convertFromSiValue(dataSizeValue);
                            break;
                        }
                    }

                    dataSizeToValueOutput.Text = resultDataSizeValue.ToString();
                    statusIndicator.Text = StatusMessages.done;
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