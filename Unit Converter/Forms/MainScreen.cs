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
            this.ActiveControl = unitSelector;
            unitSelector.Focus();

            // Detect if unit type changed (tab changed)
            unitSelector.SelectedIndexChanged += new EventHandler(unitSelector_SelectedIndexChanged);
        }

        // (1) INITIALISATION - Define round-off value variable
        // (-1 if not to round off)
        short roundOffValue = -1;

        // (1) INITIALISATION - Define all units
        // UNIT TYPE 0 - Length (18 Units)
        Unit metre = new Unit("Metre [m] (S.I. Unit)", 1d, 0d);
        Unit nauticalMile = new Unit("Nautical Mile [nmi]", 1852d, 0d);
        Unit kilometre = new Unit("Kilometre [km]", 1000d, 0d);
        Unit decimetre = new Unit("Decimetre [dm]", 0.1d, 0d);
        Unit centimetre = new Unit("Centimetre [cm]", 0.01d, 0d);
        Unit millimetre = new Unit("Millimetre [mm]", 0.001d, 0d);
        Unit micrometre = new Unit("Micrometre [μm]", 0.000001d, 0d);
        Unit nanometre = new Unit("Nanometre [nm]", 0.000000001d, 0d);
        Unit angstrom = new Unit("Ångström [Å]", 0.0000000001d, 0d);
        Unit mile = new Unit("Mile [mi]", ((1d / 3.280839895d) * 5280d), 0d);
        Unit furlong = new Unit("Furlong", ((1d / 3.280839895d) * 660d), 0d);
        Unit chain = new Unit("Chain", ((1d / 3.280839895d) * 66d), 0d);
        Unit rod = new Unit("Rod", ((1d / 3.280839895d) * 16.5d), 0d);
        Unit horseLength = new Unit("Horse Length", ((1d / 3.280839895d) * 8d), 0d);
        Unit fathom = new Unit("Fathom", ((1d / 3.280839895d) * 6d), 0d);
        Unit yard = new Unit("Yard [yd]", ((1d / 3.280839895d) * 3d), 0d);
        Unit foot = new Unit("Foot [ft]", (1d / 3.280839895d), 0d);
        Unit inch = new Unit("Inch [in]", ((1d / 3.280839895d) / 12d), 0d);

        // UNIT TYPE 1 - Area (20 Units)
        Unit squareMetre = new Unit("Square Metre [m²] (S.I. Unit)", 1d, 0d);
        Unit squareKilometre = new Unit("Square Kilometre [km²]", 1000000d, 0d);
        Unit squareDecimetre = new Unit("Square Decimetre [dm²]", 0.01d, 0d);
        Unit squareCentimetre = new Unit("Square Centimetre [cm²]", 0.0001d, 0d);
        Unit squareMillimetre = new Unit("Square Millimetre [mm²]", 0.000001d, 0d);
        Unit squareMicrometre = new Unit("Square Micrometre [μm²]", 0.000000000001d, 0d);
        Unit are = new Unit("Are [a]", 100d, 0d);
        Unit stremma = new Unit("Stremma", 1000d, 0d);
        Unit hectare = new Unit("Hectare [ha]", 10000d, 0d);
        Unit tetrad = new Unit("Tetrad", 4000000d, 0d);
        Unit hectad = new Unit("Hectad", 100000000d, 0d);
        Unit myriad = new Unit("Myriad", 10000000000d, 0d);
        Unit squareMile = new Unit("Square Mile [mi²]", ((1d / 1.19599004630108d) * 3097600d), 0d);
        Unit squareYard = new Unit("Square Yard [yd²]", (1d / 1.19599004630108d), 0d);
        Unit squareFoot = new Unit("Square Foot [ft²]", ((1d / 1.19599004630108d) / 9d), 0d);
        Unit squareInch = new Unit("Square Inch [in²]", ((1d / 1.19599004630108d) / 1296d), 0d);
        Unit acre = new Unit("Acre [ac]", ((1d / 1.19599004630108d) * 4840d), 0d);
        Unit rood = new Unit("Rood", ((1d / 1.19599004630108d) * 1210d), 0d);
        Unit section = new Unit("Section", ((1d / 1.19599004630108d) * 3097600d), 0d);
        Unit township = new Unit("Survey Township", ((1d / 1.19599004630108d) * 111513600d), 0d);

        // UNIT TYPE 2 - Volume (15 Units)
        Unit cubicMetre = new Unit("Cubic Metre [m³] (S.I. Unit)", 1d, 0d);
        Unit cubicCentimetre = new Unit("Cubic Centimetre [cm³]", 0.000001d, 0d);
        Unit cubicMillimetre = new Unit("Cubic Millimetre [mm³]", 0.000000001d, 0d);
        Unit cubicYard = new Unit("Cubic Yard [yd³]", (1d / 1.30795061931439d), 0d);
        Unit cubicFoot = new Unit("Cubic Foot [ft³]", ((1d / 1.30795061931439d) / 27d), 0d);
        Unit cubicInch = new Unit("Cubic Inch [in³]", ((1d / 1.30795061931439d) / 46656d), 0d);
        Unit litre = new Unit("Litre [L]", 0.001d, 0d);
        Unit millilitre = new Unit("Millilitre [mL]", 0.000001d, 0d);
        Unit barrel = new Unit("Barrel", (((1d / 1.30795061931439d) / 46656d) * 9702d), 0d);
        Unit gallon = new Unit("Gallon (Imperial)", (1d / 219.969248299088d), 0d);
        Unit quart = new Unit("Quart (Imperial)", ((1d / 219.969248299088d) / 4d), 0d);
        Unit pint = new Unit("Pint (Imperial)", ((1d / 219.969248299088d) / 8d), 0d);
        Unit cup = new Unit("Cup (US Customary)", 4226.75283773038d, 0d);
        Unit tablespoon = new Unit("Tablespoon (US Customary)", (4226.75283773038d / 16d), 0d);
        Unit teaspoon = new Unit("Teaspoon (US Customary)", (4226.75283773038d / 48d), 0d);

        // UNIT TYPE 3 - Time (11 Units)
        Unit second = new Unit("Second [s] (S.I. Unit)", 1d, 0d);
        Unit millisecond = new Unit("Millisecond [ms]", 0.001d, 0d);
        Unit microsecond = new Unit("Microsecond [μs]", 0.000001d, 0d);
        Unit nanosecond = new Unit("Nanosecond [ns]", 000000001d, 0d);
        Unit minute = new Unit("Minute [min]", 60d, 0d);
        Unit hour = new Unit("Hour [h]", 3600d, 0d);
        Unit day = new Unit("Day", 86400d, 0d);
        Unit week = new Unit("Week", 604800d, 0d);
        Unit fortnight = new Unit("Fortnight", 1209600d, 0d);
        Unit year = new Unit("Year", 31536000d, 0d);
        Unit yearLeap = new Unit("Year (Leap)", 31622400d, 0d);

        // UNIT TYPE 4 - Speed (15 Units)
        Unit metrePerSecond = new Unit("Metre per Second [m/s] (S.I. Unit)", 1d, 0d);
        Unit metrePerMinute = new Unit("Metre per Minute [m/min]", (1d / 60d), 0d);
        Unit metrePerHour = new Unit("Metre per Hour [m/h]", (1d / 3600d), 0d);
        Unit kilometrePerSecond = new Unit("Kilometre per Second [km/s]", 1000d, 0d);
        Unit kilometrePerMinute = new Unit("Kilometre per Minute [km/min]", (1000d / 60d), 0d);
        Unit kilometrePerHour = new Unit("Kilometre per Hour [km/h]", (1d / 3.6d), 0d);
        Unit speedOfLight = new Unit("Speed of Light (c)", 299792458d, 0d);
        Unit footPerSecond = new Unit("Foot per Second [ft/s]", (1d / 3.280839895d), 0d);
        Unit footPerMinute = new Unit("Foot per Minute [ft/min]", ((1d / 3.280839895d) / 60d), 0d);
        Unit footPerHour = new Unit("Foot per Hour [ft/h]", ((1d / 3.280839895d) / 3600d), 0d);
        Unit milePerSecond = new Unit("Mile per Second [mi/s]", ((1d / 3.280839895d) * 5280d), 0d);
        Unit milePerMinute = new Unit("Mile per Minute [mi/min]", ((1d / 3.280839895d) * 5280d / 60d), 0d);
        Unit milePerHour = new Unit("Mile per Hour [mi/h]", ((1d / 3.280839895d) * 5280d / 3600d), 0d);
        Unit mach = new Unit("Mach [Ma]", 340d, 0d);
        Unit knot = new Unit("Knot [kn]", 1852d / 3600d, 0d);

        // UNIT TYPE 5 - Mass (14 Units)
        Unit kilogram = new Unit("Kilogram [kg] (S.I. Unit)", 1d, 0d);
        Unit gram = new Unit("Gram [g]", (1d / 1000d), 0d);
        Unit carat = new Unit("Carat [ct]", 0.0002d, 0d);
        Unit milligram = new Unit("Milligram [mg]", (1d / 1000000d), 0d);
        Unit microgram = new Unit("Microgram [μg]", (1d / 1000000000d), 0d);
        Unit tonne = new Unit("Tonne [t] (Metric)", 1000d, 0d);
        Unit kilotonne = new Unit("Kilotonne [kt] (Metric)", 1000000d, 0d);
        Unit pound = new Unit("Pound [lb]", (1d / 2.20462262184878d), 0d);
        Unit ounce = new Unit("Ounce [oz]", ((1d / 2.20462262184878d) / 16d), 0d);
        Unit stoneUK = new Unit("Stone [st.] (UK)", ((1d / 2.20462262184878d) * 14d), 0d);
        Unit tonShort = new Unit("Ton (Short)", ((1d / 2.20462262184878d) * 2000d), 0d);
        Unit tonLong = new Unit("Ton (Long)", ((1d / 2.20462262184878d) * 2240d), 0d);
        Unit kilotonShort = new Unit("Kiloton (Short)", ((1d / 2.20462262184878d) * 2000000d), 0d);
        Unit kilotonLong = new Unit("Kiloton (Long)", ((1d / 2.20462262184878d) * 2240000d), 0d);

        // UNIT TYPE 6 - Energy (9 Units)
        Unit joule = new Unit("Joule [J] (S.I. Unit)", 1d, 0d);
        Unit kilojoule = new Unit("Kilojoule [kJ]", 1000d, 0d);
        Unit megajoule = new Unit("Megajoule [MJ]", 1000000d, 0d);
        Unit wattHour = new Unit("Watt Hour [Wh]", 3600d, 0d);
        Unit kilowattHour = new Unit("Kilowatt Hour [kWh]", 3600000d, 0d);
        Unit megawattHour = new Unit("Megawatt Hour [MWh]", 3600000000d, 0d);
        Unit calorie = new Unit("calorie", 4.184d, 0d);
        Unit kilocalorie = new Unit("Kilocalorie", 4184d, 0d);
        Unit btu = new Unit("British Thermal Unit (BTU)", 1055.05585262d, 0d);

        // UNIT TYPE 7 - Temperature (3 Units)
        Unit kelvin = new Unit("Kelvin [K] (S.I. Unit)", 1d, 0d);
        Unit celsius = new Unit("Celsius [°C]", 1d, 273.15d);
        Unit fahrenheit = new Unit("Fahrenheit [°F]", (5d / 9d), (459.67d * (5d / 9d)));

        // UNIT TYPE 8 - Data Size (6 Units)
        Unit sizeByte = new Unit("Byte [B]", 1d, 0d);
        Unit sizeKilobyte = new Unit("Kilobyte [kb]", 1024d, 0d);
        Unit sizeMegabyte = new Unit("Megabyte [MB]", 1048576d, 0d);
        Unit sizeGigabyte = new Unit("Gigabyte [GB]", 1073741824d, 0d);
        Unit sizeTerabyte = new Unit("Terabyte [TB]", 1099511627776d, 0d);
        Unit sizePetabyte = new Unit("Petabyte [PB]", 1125899906842624d, 0d);

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

            foreach (Unit element in lengthUnits)
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
        private void uncheckAllRoundOffMenuItems()
        {
            foreach (ToolStripMenuItem element in roundOffMenuItems)
            {
                element.Checked = false;
            }
        }

        // (2) MENU BAR EVENTS - Set to not round off
        private void doNotRoundOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uncheckAllRoundOffMenuItems();
            roundOffValue = -1;
            doNotRoundOffToolStripMenuItem.Checked = true;
            ExecuteCalculation();
            statusIndicator.Text = StatusMessages.roundOffValueSet;
        }

        // (2) MENU BAR EVENTS - Set round-off value to 0
        private void wholeNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uncheckAllRoundOffMenuItems();
            roundOffValue = 0;
            wholeNumberToolStripMenuItem.Checked = true;
            ExecuteCalculation();
            statusIndicator.Text = StatusMessages.roundOffValueSet;
        }

        // (2) MENU BAR EVENTS - Set round-off value to 1
        private void decimalPlacesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            uncheckAllRoundOffMenuItems();
            roundOffValue = 1;
            decimalPlacesToolStripMenuItem1.Checked = true;
            ExecuteCalculation();
            statusIndicator.Text = StatusMessages.roundOffValueSet;
        }

        // (2) MENU BAR EVENTS - Set round-off value to 2
        private void decimalPlacesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            uncheckAllRoundOffMenuItems();
            roundOffValue = 2;
            decimalPlacesToolStripMenuItem2.Checked = true;
            ExecuteCalculation();
            statusIndicator.Text = StatusMessages.roundOffValueSet;
        }

        // (2) MENU BAR EVENTS - Set round-off value to 3
        private void decimalPlacesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            uncheckAllRoundOffMenuItems();
            roundOffValue = 3;
            decimalPlacesToolStripMenuItem3.Checked = true;
            ExecuteCalculation();
            statusIndicator.Text = StatusMessages.roundOffValueSet;
        }

        // (2) MENU BAR EVENTS - Set round-off value to 4
        private void decimalPlacesToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            uncheckAllRoundOffMenuItems();
            roundOffValue = 4;
            decimalPlacesToolStripMenuItem4.Checked = true;
            ExecuteCalculation();
            statusIndicator.Text = StatusMessages.roundOffValueSet;
        }

        // (2) MENU BAR EVENTS - Set round-off value to 5
        private void decimalPlacesToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            uncheckAllRoundOffMenuItems();
            roundOffValue = 5;
            decimalPlacesToolStripMenuItem5.Checked = true;
            ExecuteCalculation();
            statusIndicator.Text = StatusMessages.roundOffValueSet;
        }

        // (2) MENU BAR EVENTS - Set round-off value to 6
        private void decimalPlacesToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            uncheckAllRoundOffMenuItems();
            roundOffValue = 6;
            decimalPlacesToolStripMenuItem6.Checked = true;
            ExecuteCalculation();
            statusIndicator.Text = StatusMessages.roundOffValueSet;
        }

        // (2) MENU BAR EVENTS - Set round-off value to 7
        private void decimalPlacesToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            uncheckAllRoundOffMenuItems();
            roundOffValue = 7;
            decimalPlacesToolStripMenuItem7.Checked = true;
            ExecuteCalculation();
            statusIndicator.Text = StatusMessages.roundOffValueSet;
        }

        // (2) MENU BAR EVENTS - Set round-off value to 8
        private void decimalPlacesToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            uncheckAllRoundOffMenuItems();
            roundOffValue = 8;
            decimalPlacesToolStripMenuItem8.Checked = true;
            ExecuteCalculation();
            statusIndicator.Text = StatusMessages.roundOffValueSet;
        }

        // (2) MENU BAR EVENTS - Set round-off value to 9
        private void decimalPlacesToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            uncheckAllRoundOffMenuItems();
            roundOffValue = 9;
            decimalPlacesToolStripMenuItem9.Checked = true;
            ExecuteCalculation();
            statusIndicator.Text = StatusMessages.roundOffValueSet;
        }

        // (2) MENU BAR EVENTS - Set round-off value to 10
        private void decimalPlacesToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            uncheckAllRoundOffMenuItems();
            roundOffValue = 10;
            decimalPlacesToolStripMenuItem10.Checked = true;
            ExecuteCalculation();
            statusIndicator.Text = StatusMessages.roundOffValueSet;
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
                AddComboBoxValues(temperatureUnits);
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

        // (4) CONTROLS - Attempt to calculate when fromUnitInput changed
        private void fromUnitInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toUnitOutput.SelectedIndex > -1 && !(string.IsNullOrWhiteSpace(fromValueInput.Text)))
                ExecuteCalculation();
        }

        // (4) CONTROLS - Attempt to calculate when fromUnitInput changed
        private void toUnitOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fromUnitInput.SelectedIndex > -1 && !(string.IsNullOrWhiteSpace(fromValueInput.Text)))
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
                CalculateConversion(temperatureUnits);

            // UNIT TYPE 8 - User wants to convert data size
            else if (unitSelector.SelectedIndex == 8)
                CalculateConversion(dataSizeUnits);

            // Somehow, the currently selected tab does not exist!
            else
                statusIndicator.Text = StatusMessages.unitTypeError;
        }
    }
}
