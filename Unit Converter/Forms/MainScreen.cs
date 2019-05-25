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
            this.ActiveControl = fromUnitInput;
            fromUnitInput.Focus();

            // Detect if unit type changed (tab changed)
            unitSelector.SelectedIndexChanged += new EventHandler(unitSelector_SelectedIndexChanged);
        }

        // (1) INITIALISATION - Define all units
        // UNIT TYPE 0 - Length (18 Units)
        BaseUnit metre = new BaseUnit("Metre [m] (S.I. Unit)", 1d);
        BaseUnit nauticalMile = new BaseUnit("Nautical Mile [nmi]", 1852d);
        BaseUnit kilometre = new BaseUnit("Kilometre [km]", 1000d);
        BaseUnit decimetre = new BaseUnit("Decimetre [dm]", 0.1d);
        BaseUnit centimetre = new BaseUnit("Centimetre [cm]", 0.01d);
        BaseUnit millimetre = new BaseUnit("Millimetre [mm]", 0.001d);
        BaseUnit micrometre = new BaseUnit("Micrometre [μm]", 0.000001d);
        BaseUnit nanometre = new BaseUnit("Nanometre [nm]", 0.000000001d);
        BaseUnit angstrom = new BaseUnit("Ångström [Å]", 0.0000000001d);
        BaseUnit mile = new BaseUnit("Mile [mi]", ((1d / 3.280839895d) * 5280d));
        BaseUnit furlong = new BaseUnit("Furlong", ((1d / 3.280839895d) * 660d));
        BaseUnit chain = new BaseUnit("Chain", ((1d / 3.280839895d) * 66d));
        BaseUnit rod = new BaseUnit("Rod", ((1d / 3.280839895d) * 16.5d));
        BaseUnit horseLength = new BaseUnit("Horse Length", ((1d / 3.280839895d) * 8d));
        BaseUnit fathom = new BaseUnit("Fathom", ((1d / 3.280839895d) * 6d));
        BaseUnit yard = new BaseUnit("Yard [yd]", ((1d / 3.280839895d) * 3d));
        BaseUnit foot = new BaseUnit("Foot [ft]", (1d / 3.280839895d));
        BaseUnit inch = new BaseUnit("Inch [in]", ((1d / 3.280839895d) / 12d));

        // UNIT TYPE 1 - Area (20 Units)
        BaseUnit squareMetre = new BaseUnit("Square Metre [m²] (S.I. Unit)", 1d);
        BaseUnit squareKilometre = new BaseUnit("Square Kilometre [km²]", 1000000d);
        BaseUnit squareDecimetre = new BaseUnit("Square Decimetre [dm²]", 0.01d);
        BaseUnit squareCentimetre = new BaseUnit("Square Centimetre [cm²]", 0.0001d);
        BaseUnit squareMillimetre = new BaseUnit("Square Millimetre [mm²]", 0.000001d);
        BaseUnit squareMicrometre = new BaseUnit("Square Micrometre [μm²]", 0.000000000001d);
        BaseUnit are = new BaseUnit("Are [a]", 100d);
        BaseUnit stremma = new BaseUnit("Stremma", 1000d);
        BaseUnit hectare = new BaseUnit("Hectare [ha]", 10000d);
        BaseUnit tetrad = new BaseUnit("Tetrad", 4000000d);
        BaseUnit hectad = new BaseUnit("Hectad", 100000000d);
        BaseUnit myriad = new BaseUnit("Myriad", 10000000000d);
        BaseUnit squareMile = new BaseUnit("Square Mile [mi²]", ((1d / 1.19599004630108d) * 3097600d));
        BaseUnit squareYard = new BaseUnit("Square Yard [yd²]", (1d / 1.19599004630108d));
        BaseUnit squareFoot = new BaseUnit("Square Foot [ft²]", ((1d / 1.19599004630108d) / 9d));
        BaseUnit squareInch = new BaseUnit("Square Inch [in²]", ((1d / 1.19599004630108d) / 1296d));
        BaseUnit acre = new BaseUnit("Acre [ac]", ((1d / 1.19599004630108d) * 4840d));
        BaseUnit rood = new BaseUnit("Rood", ((1d / 1.19599004630108d) * 1210d));
        BaseUnit section = new BaseUnit("Section", ((1d / 1.19599004630108d) * 3097600d));
        BaseUnit township = new BaseUnit("Survey Township", ((1d / 1.19599004630108d) * 111513600d));

        // UNIT TYPE 2 - Volume (15 Units)
        BaseUnit cubicMetre = new BaseUnit("Cubic Metre [m³] (S.I. Unit)", 1d);
        BaseUnit cubicCentimetre = new BaseUnit("Cubic Centimetre [cm³]", 0.000001d);
        BaseUnit cubicMillimetre = new BaseUnit("Cubic Millimetre [mm³]", 0.000000001d);
        BaseUnit cubicYard = new BaseUnit("Cubic Yard [yd³]", (1d / 1.30795061931439d));
        BaseUnit cubicFoot = new BaseUnit("Cubic Foot [ft³]", ((1d / 1.30795061931439d) / 27d));
        BaseUnit cubicInch = new BaseUnit("Cubic Inch [in³]", ((1d / 1.30795061931439d) / 46656d));
        BaseUnit litre = new BaseUnit("Litre [L]", 0.001d);
        BaseUnit millilitre = new BaseUnit("Millilitre [mL]", 0.000001d);
        BaseUnit barrel = new BaseUnit("Barrel", (((1d / 1.30795061931439d) / 46656d) * 9702d));
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

        // UNIT TYPE 4 - Speed (15 Units)
        BaseUnit metrePerSecond = new BaseUnit("Metre per Second [m/s] (S.I. Unit)", 1d);
        BaseUnit metrePerMinute = new BaseUnit("Metre per Minute [m/min]", (1d / 60d));
        BaseUnit metrePerHour = new BaseUnit("Metre per Hour [m/h]", (1d / 3600d));
        BaseUnit kilometrePerSecond = new BaseUnit("Kilometre per Second [km/s]", 1000d);
        BaseUnit kilometrePerMinute = new BaseUnit("Kilometre per Minute [km/min]", (1000d / 60d));
        BaseUnit kilometrePerHour = new BaseUnit("Kilometre per Hour [km/h]", (1d / 3.6d));
        BaseUnit speedOfLight = new BaseUnit("Speed of Light (c)", 299792458d);
        BaseUnit footPerSecond = new BaseUnit("Foot per Second [ft/s]", (1d / 3.280839895d));
        BaseUnit footPerMinute = new BaseUnit("Foot per Minute [ft/min]", ((1d / 3.280839895d) / 60d));
        BaseUnit footPerHour = new BaseUnit("Foot per Hour [ft/h]", ((1d / 3.280839895d) / 3600d));
        BaseUnit milePerSecond = new BaseUnit("Mile per Second [mi/s]", ((1d / 3.280839895d) * 5280d));
        BaseUnit milePerMinute = new BaseUnit("Mile per Minute [mi/min]", ((1d / 3.280839895d) * 5280d / 60d));
        BaseUnit milePerHour = new BaseUnit("Mile per Hour [mi/h]", ((1d / 3.280839895d) * 5280d / 3600d));
        BaseUnit mach = new BaseUnit("Mach [Ma]", 340d);
        BaseUnit knot = new BaseUnit("Knot [kn]", 1852d / 3600d);

        // UNIT TYPE 5 - Mass (14 Units)
        BaseUnit kilogram = new BaseUnit("Kilogram [kg] (S.I. Unit)", 1d);
        BaseUnit gram = new BaseUnit("Gram [g]", (1d / 1000d));
        BaseUnit carat = new BaseUnit("Carat [ct]", 0.0002d);
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

        // UNIT TYPE 6 - Energy (9 Units)
        BaseUnit joule = new BaseUnit("Joule [J] (S.I. Unit)", 1d);
        BaseUnit kilojoule = new BaseUnit("Kilojoule [kJ]", 1000d);
        BaseUnit megajoule = new BaseUnit("Megajoule [MJ]", 1000000d);
        BaseUnit wattHour = new BaseUnit("Watt Hour [Wh]", 3600d);
        BaseUnit kilowattHour = new BaseUnit("Kilowatt Hour [kWh]", 3600000d);
        BaseUnit megawattHour = new BaseUnit("Megawatt Hour [MWh]", 3600000000d);
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
            lengthUnits.Add(nauticalMile);
            lengthUnits.Add(kilometre);
            lengthUnits.Add(decimetre);
            lengthUnits.Add(centimetre);
            lengthUnits.Add(millimetre);
            lengthUnits.Add(micrometre);
            lengthUnits.Add(nanometre);
            lengthUnits.Add(angstrom);
            lengthUnits.Add(mile);
            lengthUnits.Add(furlong);
            lengthUnits.Add(chain);
            lengthUnits.Add(rod);
            lengthUnits.Add(horseLength);
            lengthUnits.Add(fathom);
            lengthUnits.Add(yard);
            lengthUnits.Add(foot);
            lengthUnits.Add(inch);

            // UNIT TYPE 1 - Area
            areaUnits.Add(squareMetre);
            areaUnits.Add(squareKilometre);
            areaUnits.Add(squareDecimetre);
            areaUnits.Add(squareCentimetre);
            areaUnits.Add(squareMillimetre);
            areaUnits.Add(squareMicrometre);
            areaUnits.Add(are);
            areaUnits.Add(stremma);
            areaUnits.Add(hectare);
            areaUnits.Add(tetrad);
            areaUnits.Add(hectad);
            areaUnits.Add(myriad);
            areaUnits.Add(squareMile);
            areaUnits.Add(squareYard);
            areaUnits.Add(squareFoot);
            areaUnits.Add(squareInch);
            areaUnits.Add(acre);
            areaUnits.Add(rood);
            areaUnits.Add(section);
            areaUnits.Add(township);

            // UNIT TYPE 2 - Volume
            volumeUnits.Add(cubicMetre);
            volumeUnits.Add(cubicCentimetre);
            volumeUnits.Add(cubicMillimetre);
            volumeUnits.Add(cubicYard);
            volumeUnits.Add(cubicFoot);
            volumeUnits.Add(cubicInch);
            volumeUnits.Add(litre);
            volumeUnits.Add(millilitre);
            volumeUnits.Add(barrel);
            volumeUnits.Add(gallon);
            volumeUnits.Add(quart);
            volumeUnits.Add(pint);
            volumeUnits.Add(cup);
            volumeUnits.Add(tablespoon);
            volumeUnits.Add(teaspoon);

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

            // UNIT TYPE 4 - Speed
            speedUnits.Add(metrePerSecond);
            speedUnits.Add(metrePerMinute);
            speedUnits.Add(metrePerHour);
            speedUnits.Add(kilometrePerSecond);
            speedUnits.Add(kilometrePerMinute);
            speedUnits.Add(kilometrePerHour);
            speedUnits.Add(speedOfLight);
            speedUnits.Add(footPerSecond);
            speedUnits.Add(footPerMinute);
            speedUnits.Add(footPerHour);
            speedUnits.Add(milePerSecond);
            speedUnits.Add(milePerMinute);
            speedUnits.Add(milePerHour);
            speedUnits.Add(mach);
            speedUnits.Add(knot);

            // UNIT TYPE 5 - Mass
            massUnits.Add(kilogram);
            massUnits.Add(gram);
            massUnits.Add(carat);
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

            // UNIT TYPE 6 - Energy
            energyUnits.Add(joule);
            energyUnits.Add(kilojoule);
            energyUnits.Add(megajoule);
            energyUnits.Add(wattHour);
            energyUnits.Add(kilowattHour);
            energyUnits.Add(megawattHour);
            energyUnits.Add(calorie);
            energyUnits.Add(kilocalorie);
            energyUnits.Add(btu);

            // UNIT TYPE 7 - Temperature
            temperatureUnits.Add(kelvin);
            temperatureUnits.Add(celsius);
            temperatureUnits.Add(fahrenheit);

            // UNIT TYPE 8 - Data Size
            dataSizeUnits.Add(sizeByte);
            dataSizeUnits.Add(sizeKilobyte);
            dataSizeUnits.Add(sizeMegabyte);
            dataSizeUnits.Add(sizeGigabyte);
            dataSizeUnits.Add(sizeTerabyte);
            dataSizeUnits.Add(sizePetabyte);

            foreach (BaseUnit element in lengthUnits)
            {
                fromUnitInput.Items.Add(element.getName());
                toUnitOutput.Items.Add(element.getName());
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

        // (3) UNIT TYPE EVENTS - Helper function to add units in the combo box
        // for multiplicative units that use the BaseUnit class
        private void AddComboBoxValues(List<BaseUnit> unitList)
        {
            foreach (BaseUnit element in unitList)
            {
                fromUnitInput.Items.Add(element.getName());
                toUnitOutput.Items.Add(element.getName());
            }
        }

        // (3) UNIT TYPE EVENTS - Do when unit type is changed (tab is changed)
        private void unitSelector_SelectedIndexChanged(Object sender, EventArgs e)
        {
            bool changedComboBoxValues = true;

            fromUnitInput.Items.Clear();
            toUnitOutput.Items.Clear();
            fromValueInput.Clear();
            toValueOutput.Clear();

            if (unitSelector.SelectedIndex == 0)
                AddComboBoxValues(lengthUnits);
            else if (unitSelector.SelectedIndex == 1)
                AddComboBoxValues(areaUnits);
            else if (unitSelector.SelectedIndex == 2)
                AddComboBoxValues(volumeUnits);
            else if (unitSelector.SelectedIndex == 3)
                AddComboBoxValues(timeUnits);
            else if (unitSelector.SelectedIndex == 4)
                AddComboBoxValues(speedUnits);
            else if (unitSelector.SelectedIndex == 5)
                AddComboBoxValues(massUnits);
            else if (unitSelector.SelectedIndex == 6)
                AddComboBoxValues(energyUnits);
            else if (unitSelector.SelectedIndex == 7)
            {
                foreach (TemperatureUnit element in temperatureUnits)
                {
                    fromUnitInput.Items.Add(element.getName());
                    toUnitOutput.Items.Add(element.getName());
                }
            }
            else if (unitSelector.SelectedIndex == 8)
                AddComboBoxValues(dataSizeUnits);
            else
            {
                changedComboBoxValues = false;
                statusIndicator.Text = StatusMessages.unitTypeError;
            }

            if (changedComboBoxValues)
                statusIndicator.Text = StatusMessages.ready;
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
                statusIndicator.Text = StatusMessages.swapped;
            }
            else
                statusIndicator.Text = StatusMessages.invalidSwap;
        }

        // (6) CALCULATION - Helper function that calculates the result value
        // for multiplicative units that use BaseUnit class and modifies status
        private void CalculateConversion(List<BaseUnit> unitList)
        {
            string rawValue;                 // raw data from the user-inputtable text box
            bool canParse;                   // shows whether raw user input data can be parsed to double
            bool fromInputHasValue = false;  // shows if the user has not selected a unit for fromUnitInput combo box
            bool toOutputHasValue = false;   // shows if the user has not selected a unit for toUnitOutput combo box
            double inputValue;               // processed data from the user-inputtable text box
            double unitValue = 0;
            double resultUnitValue = 0;

            rawValue = fromValueInput.Text;
            canParse = double.TryParse(rawValue, result: out inputValue);

            if (canParse)
            {
                foreach (BaseUnit element in unitList)
                {
                    if ((string)fromUnitInput.SelectedItem == element.getName())
                    {
                        unitValue = element.convertToSiValue(inputValue);
                        fromInputHasValue = true;
                        break;
                    }
                }

                foreach (BaseUnit element in unitList)
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
            // UNIT TYPE 0 - User wants to convert length
            if (unitSelector.SelectedIndex == 0)
                CalculateConversion(lengthUnits);

            // UNIT TYPE 1 - User wants to convert area
            else if (unitSelector.SelectedIndex == 1)
                CalculateConversion(areaUnits);

            // UNIT TYPE 2 - User wants to convert volume
            else if (unitSelector.SelectedIndex == 2)
                CalculateConversion(volumeUnits);

            // UNIT TYPE 3 - User wants to convert time
            else if (unitSelector.SelectedIndex == 3)
                CalculateConversion(timeUnits);

            // UNIT TYPE 4 - User wants to convert speed
            else if (unitSelector.SelectedIndex == 4)
                CalculateConversion(speedUnits);

            // UNIT TYPE 5 - User wants to convert mass
            else if (unitSelector.SelectedIndex == 5)
                CalculateConversion(massUnits);

            // UNIT TYPE 6 - User wants to convert energy
            else if (unitSelector.SelectedIndex == 6)
                CalculateConversion(energyUnits);

            // UNIT TYPE 7 - User wants to convert temperature
            else if (unitSelector.SelectedIndex == 7)
            {
                string rawValue;                 // raw data from the user-inputtable text box
                double inputValue;               // processed data from the user-inputtable text box
                bool canParse;                   // shows whether raw user input data can be parsed to double
                bool fromInputHasValue = false;  // shows if the user has not selected a unit for fromUnitInput combo box
                bool toOutputHasValue = false;   // shows if the user has not selected a unit for toUnitOutput combo box
                double resultTemperatureValue = 0;

                rawValue = fromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    fromInputHasValue = true;
                    toOutputHasValue = true;

                    if ((string)fromUnitInput.SelectedItem ==
                        (string)toUnitOutput.SelectedItem)
                        resultTemperatureValue = inputValue;
                    else if (((string)fromUnitInput.SelectedItem == kelvin.getName())
                        && (string)toUnitOutput.SelectedItem == celsius.getName())
                        resultTemperatureValue = inputValue - 273.15d;
                    else if (((string)fromUnitInput.SelectedItem == kelvin.getName())
                        && (string)toUnitOutput.SelectedItem == fahrenheit.getName())
                        resultTemperatureValue = inputValue * 1.8d - 459.67d;
                    else if (((string)fromUnitInput.SelectedItem == celsius.getName())
                        && (string)toUnitOutput.SelectedItem == kelvin.getName())
                        resultTemperatureValue = inputValue + 273.15d;
                    else if (((string)fromUnitInput.SelectedItem == celsius.getName())
                        && (string)toUnitOutput.SelectedItem == fahrenheit.getName())
                        resultTemperatureValue = inputValue * 1.8d + 32d;
                    else if (((string)fromUnitInput.SelectedItem == fahrenheit.getName())
                        && (string)toUnitOutput.SelectedItem == kelvin.getName())
                        resultTemperatureValue = (inputValue + 459.67d) / 1.8d;
                    else if (((string)fromUnitInput.SelectedItem == fahrenheit.getName())
                        && (string)toUnitOutput.SelectedItem == celsius.getName())
                        resultTemperatureValue = (inputValue - 32d) / 1.8d;
                    else
                        fromInputHasValue = false;

                    if (fromInputHasValue && toOutputHasValue)
                    {
                        toValueOutput.Text = resultTemperatureValue.ToString();
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
                CalculateConversion(dataSizeUnits);

            // Somehow, the currently selected tab does not exist!
            else
                statusIndicator.Text = StatusMessages.unitTypeError;
        }
    }
}