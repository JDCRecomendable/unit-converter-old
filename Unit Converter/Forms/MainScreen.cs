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

            // Modify the colours of selected items
            menuBar.Renderer = new SelectorColourRenderer();
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
        List<Unit> flowAreaUnits = new List<Unit>();
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

        // (1) INITIALISATION - Define custom unit objects
        CustomBaseUnits customLengthUnits = new CustomBaseUnits();
        CustomBaseUnits customAreaUnits = new CustomBaseUnits();
        CustomBaseUnits customVolumeUnits = new CustomBaseUnits();
        CustomBaseUnits customTimeUnits = new CustomBaseUnits();
        CustomBaseUnits customSpeedUnits = new CustomBaseUnits();
        CustomBaseUnits customFlowAreaUnits = new CustomBaseUnits();
        CustomBaseUnits customFlowVolumeUnits = new CustomBaseUnits();
        CustomBaseUnits customFlowMassUnits = new CustomBaseUnits();
        CustomBaseUnits customMassUnits = new CustomBaseUnits();
        CustomBaseUnits customEnergyUnits = new CustomBaseUnits();
        CustomBaseUnits customPressureUnits = new CustomBaseUnits();
        CustomBaseUnits customTemperatureUnits = new CustomBaseUnits();
        CustomBaseUnits customLuminanceUnits = new CustomBaseUnits();
        CustomBaseUnits customIlluminanceUnits = new CustomBaseUnits();
        CustomBaseUnits customAngleUnits = new CustomBaseUnits();
        CustomBaseUnits customDataSizeUnits = new CustomBaseUnits();


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

            // UNIT TYPE 5 - Flow Rate (Area)
            // Per Second
            flowAreaUnits.Add(FlowAreaUnit.squareMetrePerSecond);
            flowAreaUnits.Add(FlowAreaUnit.squareKilometrePerSecond);
            flowAreaUnits.Add(FlowAreaUnit.squareDecimetrePerSecond);
            flowAreaUnits.Add(FlowAreaUnit.squareCentimetrePerSecond);
            flowAreaUnits.Add(FlowAreaUnit.squareMillimetrePerSecond);
            flowAreaUnits.Add(FlowAreaUnit.squareMicrometrePerSecond);
            flowAreaUnits.Add(FlowAreaUnit.arePerSecond);
            flowAreaUnits.Add(FlowAreaUnit.stremmaPerSecond);
            flowAreaUnits.Add(FlowAreaUnit.hectarePerSecond);
            flowAreaUnits.Add(FlowAreaUnit.tetradPerSecond);
            flowAreaUnits.Add(FlowAreaUnit.hectadPerSecond);
            flowAreaUnits.Add(FlowAreaUnit.myriadPerSecond);
            flowAreaUnits.Add(FlowAreaUnit.squareMilePerSecond);
            flowAreaUnits.Add(FlowAreaUnit.squareYardPerSecond);
            flowAreaUnits.Add(FlowAreaUnit.squareFootPerSecond);
            flowAreaUnits.Add(FlowAreaUnit.squareInchPerSecond);
            flowAreaUnits.Add(FlowAreaUnit.acrePerSecond);
            flowAreaUnits.Add(FlowAreaUnit.roodPerSecond);
            flowAreaUnits.Add(FlowAreaUnit.sectionPerSecond);
            flowAreaUnits.Add(FlowAreaUnit.townshipPerSecond);
            // Per Minute
            flowAreaUnits.Add(FlowAreaUnit.squareMetrePerMinute);
            flowAreaUnits.Add(FlowAreaUnit.squareKilometrePerMinute);
            flowAreaUnits.Add(FlowAreaUnit.squareDecimetrePerMinute);
            flowAreaUnits.Add(FlowAreaUnit.squareCentimetrePerMinute);
            flowAreaUnits.Add(FlowAreaUnit.squareMillimetrePerMinute);
            flowAreaUnits.Add(FlowAreaUnit.squareMicrometrePerMinute);
            flowAreaUnits.Add(FlowAreaUnit.arePerMinute);
            flowAreaUnits.Add(FlowAreaUnit.stremmaPerMinute);
            flowAreaUnits.Add(FlowAreaUnit.hectarePerMinute);
            flowAreaUnits.Add(FlowAreaUnit.tetradPerMinute);
            flowAreaUnits.Add(FlowAreaUnit.hectadPerMinute);
            flowAreaUnits.Add(FlowAreaUnit.myriadPerMinute);
            flowAreaUnits.Add(FlowAreaUnit.squareMilePerMinute);
            flowAreaUnits.Add(FlowAreaUnit.squareYardPerMinute);
            flowAreaUnits.Add(FlowAreaUnit.squareFootPerMinute);
            flowAreaUnits.Add(FlowAreaUnit.squareInchPerMinute);
            flowAreaUnits.Add(FlowAreaUnit.acrePerMinute);
            flowAreaUnits.Add(FlowAreaUnit.roodPerMinute);
            flowAreaUnits.Add(FlowAreaUnit.sectionPerMinute);
            flowAreaUnits.Add(FlowAreaUnit.townshipPerMinute);
            // Per Hour
            flowAreaUnits.Add(FlowAreaUnit.squareMetrePerHour);
            flowAreaUnits.Add(FlowAreaUnit.squareKilometrePerHour);
            flowAreaUnits.Add(FlowAreaUnit.squareDecimetrePerHour);
            flowAreaUnits.Add(FlowAreaUnit.squareCentimetrePerHour);
            flowAreaUnits.Add(FlowAreaUnit.squareMillimetrePerHour);
            flowAreaUnits.Add(FlowAreaUnit.squareMicrometrePerHour);
            flowAreaUnits.Add(FlowAreaUnit.arePerHour);
            flowAreaUnits.Add(FlowAreaUnit.stremmaPerHour);
            flowAreaUnits.Add(FlowAreaUnit.hectarePerHour);
            flowAreaUnits.Add(FlowAreaUnit.tetradPerHour);
            flowAreaUnits.Add(FlowAreaUnit.hectadPerHour);
            flowAreaUnits.Add(FlowAreaUnit.myriadPerHour);
            flowAreaUnits.Add(FlowAreaUnit.squareMilePerHour);
            flowAreaUnits.Add(FlowAreaUnit.squareYardPerHour);
            flowAreaUnits.Add(FlowAreaUnit.squareFootPerHour);
            flowAreaUnits.Add(FlowAreaUnit.squareInchPerHour);
            flowAreaUnits.Add(FlowAreaUnit.acrePerHour);
            flowAreaUnits.Add(FlowAreaUnit.roodPerHour);
            flowAreaUnits.Add(FlowAreaUnit.sectionPerHour);
            flowAreaUnits.Add(FlowAreaUnit.townshipPerHour);
            // Per Day
            flowAreaUnits.Add(FlowAreaUnit.squareMetrePerDay);
            flowAreaUnits.Add(FlowAreaUnit.squareKilometrePerDay);
            flowAreaUnits.Add(FlowAreaUnit.squareDecimetrePerDay);
            flowAreaUnits.Add(FlowAreaUnit.squareCentimetrePerDay);
            flowAreaUnits.Add(FlowAreaUnit.squareMillimetrePerDay);
            flowAreaUnits.Add(FlowAreaUnit.squareMicrometrePerDay);
            flowAreaUnits.Add(FlowAreaUnit.arePerDay);
            flowAreaUnits.Add(FlowAreaUnit.stremmaPerDay);
            flowAreaUnits.Add(FlowAreaUnit.hectarePerDay);
            flowAreaUnits.Add(FlowAreaUnit.tetradPerDay);
            flowAreaUnits.Add(FlowAreaUnit.hectadPerDay);
            flowAreaUnits.Add(FlowAreaUnit.myriadPerDay);
            flowAreaUnits.Add(FlowAreaUnit.squareMilePerDay);
            flowAreaUnits.Add(FlowAreaUnit.squareYardPerDay);
            flowAreaUnits.Add(FlowAreaUnit.squareFootPerDay);
            flowAreaUnits.Add(FlowAreaUnit.squareInchPerDay);
            flowAreaUnits.Add(FlowAreaUnit.acrePerDay);
            flowAreaUnits.Add(FlowAreaUnit.roodPerDay);
            flowAreaUnits.Add(FlowAreaUnit.sectionPerDay);
            flowAreaUnits.Add(FlowAreaUnit.townshipPerDay);

            // UNIT TYPE 6 - Flow Rate (Volume)
            // Per Second
            flowVolumeUnits.Add(FlowVolumeUnit.cubicMetrePerSecond);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicCentimetrePerSecond);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicMillimetrePerSecond);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicYardPerSecond);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicFootPerSecond);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicInchPerSecond);
            flowVolumeUnits.Add(FlowVolumeUnit.litrePerSecond);
            flowVolumeUnits.Add(FlowVolumeUnit.millilitrePerSecond);
            flowVolumeUnits.Add(FlowVolumeUnit.barrelPerSecond);
            flowVolumeUnits.Add(FlowVolumeUnit.gallonPerSecond);
            flowVolumeUnits.Add(FlowVolumeUnit.quartPerSecond);
            flowVolumeUnits.Add(FlowVolumeUnit.pintPerSecond);
            flowVolumeUnits.Add(FlowVolumeUnit.cupPerSecond);
            flowVolumeUnits.Add(FlowVolumeUnit.tablespoonPerSecond);
            flowVolumeUnits.Add(FlowVolumeUnit.teaspoonPerSecond);
            // Per Minute
            flowVolumeUnits.Add(FlowVolumeUnit.cubicMetrePerMinute);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicCentimetrePerMinute);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicMillimetrePerMinute);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicYardPerMinute);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicFootPerMinute);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicInchPerMinute);
            flowVolumeUnits.Add(FlowVolumeUnit.litrePerMinute);
            flowVolumeUnits.Add(FlowVolumeUnit.millilitrePerMinute);
            flowVolumeUnits.Add(FlowVolumeUnit.barrelPerMinute);
            flowVolumeUnits.Add(FlowVolumeUnit.gallonPerMinute);
            flowVolumeUnits.Add(FlowVolumeUnit.quartPerMinute);
            flowVolumeUnits.Add(FlowVolumeUnit.pintPerMinute);
            flowVolumeUnits.Add(FlowVolumeUnit.cupPerMinute);
            flowVolumeUnits.Add(FlowVolumeUnit.tablespoonPerMinute);
            flowVolumeUnits.Add(FlowVolumeUnit.teaspoonPerMinute);
            // Per Hour
            flowVolumeUnits.Add(FlowVolumeUnit.cubicMetrePerHour);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicCentimetrePerHour);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicMillimetrePerHour);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicYardPerHour);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicFootPerHour);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicInchPerHour);
            flowVolumeUnits.Add(FlowVolumeUnit.litrePerHour);
            flowVolumeUnits.Add(FlowVolumeUnit.millilitrePerHour);
            flowVolumeUnits.Add(FlowVolumeUnit.barrelPerHour);
            flowVolumeUnits.Add(FlowVolumeUnit.gallonPerHour);
            flowVolumeUnits.Add(FlowVolumeUnit.quartPerHour);
            flowVolumeUnits.Add(FlowVolumeUnit.pintPerHour);
            flowVolumeUnits.Add(FlowVolumeUnit.cupPerHour);
            flowVolumeUnits.Add(FlowVolumeUnit.tablespoonPerHour);
            flowVolumeUnits.Add(FlowVolumeUnit.teaspoonPerHour);
            // Per Day
            flowVolumeUnits.Add(FlowVolumeUnit.cubicMetrePerDay);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicCentimetrePerDay);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicMillimetrePerDay);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicYardPerDay);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicFootPerDay);
            flowVolumeUnits.Add(FlowVolumeUnit.cubicInchPerDay);
            flowVolumeUnits.Add(FlowVolumeUnit.litrePerDay);
            flowVolumeUnits.Add(FlowVolumeUnit.millilitrePerDay);
            flowVolumeUnits.Add(FlowVolumeUnit.barrelPerDay);
            flowVolumeUnits.Add(FlowVolumeUnit.gallonPerDay);
            flowVolumeUnits.Add(FlowVolumeUnit.quartPerDay);
            flowVolumeUnits.Add(FlowVolumeUnit.pintPerDay);
            flowVolumeUnits.Add(FlowVolumeUnit.cupPerDay);
            flowVolumeUnits.Add(FlowVolumeUnit.tablespoonPerDay);
            flowVolumeUnits.Add(FlowVolumeUnit.teaspoonPerDay);

            // UNIT TYPE 7 - Flow Rate (Mass)
            // Per Second
            flowMassUnits.Add(FlowMassUnit.kilogramPerSecond);
            flowMassUnits.Add(FlowMassUnit.gramPerSecond);
            flowMassUnits.Add(FlowMassUnit.caratPerSecond);
            flowMassUnits.Add(FlowMassUnit.milligramPerSecond);
            flowMassUnits.Add(FlowMassUnit.microgramPerSecond);
            flowMassUnits.Add(FlowMassUnit.tonnePerSecond);
            flowMassUnits.Add(FlowMassUnit.kilotonnePerSecond);
            flowMassUnits.Add(FlowMassUnit.poundPerSecond);
            flowMassUnits.Add(FlowMassUnit.ouncePerSecond);
            flowMassUnits.Add(FlowMassUnit.stoneUKPerSecond);
            flowMassUnits.Add(FlowMassUnit.tonShortPerSecond);
            flowMassUnits.Add(FlowMassUnit.tonLongPerSecond);
            flowMassUnits.Add(FlowMassUnit.kilotonShortPerSecond);
            flowMassUnits.Add(FlowMassUnit.kilotonLongPerSecond);
            // Per Minute
            flowMassUnits.Add(FlowMassUnit.kilogramPerMinute);
            flowMassUnits.Add(FlowMassUnit.gramPerMinute);
            flowMassUnits.Add(FlowMassUnit.caratPerMinute);
            flowMassUnits.Add(FlowMassUnit.milligramPerMinute);
            flowMassUnits.Add(FlowMassUnit.microgramPerMinute);
            flowMassUnits.Add(FlowMassUnit.tonnePerMinute);
            flowMassUnits.Add(FlowMassUnit.kilotonnePerMinute);
            flowMassUnits.Add(FlowMassUnit.poundPerMinute);
            flowMassUnits.Add(FlowMassUnit.ouncePerMinute);
            flowMassUnits.Add(FlowMassUnit.stoneUKPerMinute);
            flowMassUnits.Add(FlowMassUnit.tonShortPerMinute);
            flowMassUnits.Add(FlowMassUnit.tonLongPerMinute);
            flowMassUnits.Add(FlowMassUnit.kilotonShortPerMinute);
            flowMassUnits.Add(FlowMassUnit.kilotonLongPerMinute);
            // Per Hour
            flowMassUnits.Add(FlowMassUnit.kilogramPerHour);
            flowMassUnits.Add(FlowMassUnit.gramPerHour);
            flowMassUnits.Add(FlowMassUnit.caratPerHour);
            flowMassUnits.Add(FlowMassUnit.milligramPerHour);
            flowMassUnits.Add(FlowMassUnit.microgramPerHour);
            flowMassUnits.Add(FlowMassUnit.tonnePerHour);
            flowMassUnits.Add(FlowMassUnit.kilotonnePerHour);
            flowMassUnits.Add(FlowMassUnit.poundPerHour);
            flowMassUnits.Add(FlowMassUnit.ouncePerHour);
            flowMassUnits.Add(FlowMassUnit.stoneUKPerHour);
            flowMassUnits.Add(FlowMassUnit.tonShortPerHour);
            flowMassUnits.Add(FlowMassUnit.tonLongPerHour);
            flowMassUnits.Add(FlowMassUnit.kilotonShortPerHour);
            flowMassUnits.Add(FlowMassUnit.kilotonLongPerHour);
            // Per Day
            flowMassUnits.Add(FlowMassUnit.kilogramPerDay);
            flowMassUnits.Add(FlowMassUnit.gramPerDay);
            flowMassUnits.Add(FlowMassUnit.caratPerDay);
            flowMassUnits.Add(FlowMassUnit.milligramPerDay);
            flowMassUnits.Add(FlowMassUnit.microgramPerDay);
            flowMassUnits.Add(FlowMassUnit.tonnePerDay);
            flowMassUnits.Add(FlowMassUnit.kilotonnePerDay);
            flowMassUnits.Add(FlowMassUnit.poundPerDay);
            flowMassUnits.Add(FlowMassUnit.ouncePerDay);
            flowMassUnits.Add(FlowMassUnit.stoneUKPerDay);
            flowMassUnits.Add(FlowMassUnit.tonShortPerDay);
            flowMassUnits.Add(FlowMassUnit.tonLongPerDay);
            flowMassUnits.Add(FlowMassUnit.kilotonShortPerDay);
            flowMassUnits.Add(FlowMassUnit.kilotonLongPerDay);

            // UNIT TYPE 8 - Mass
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

            // UNIT TYPE 9 - Energy
            energyUnits.Add(EnergyUnit.joule);
            energyUnits.Add(EnergyUnit.kilojoule);
            energyUnits.Add(EnergyUnit.megajoule);
            energyUnits.Add(EnergyUnit.wattHour);
            energyUnits.Add(EnergyUnit.kilowattHour);
            energyUnits.Add(EnergyUnit.megawattHour);
            energyUnits.Add(EnergyUnit.calorie);
            energyUnits.Add(EnergyUnit.kilocalorie);
            energyUnits.Add(EnergyUnit.btu);

            // UNIT TYPE 10 - Pressure
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

            // UNIT TYPE 11 - Temperature
            temperatureUnits.Add(TemperatureUnit.kelvin);
            temperatureUnits.Add(TemperatureUnit.celsius);
            temperatureUnits.Add(TemperatureUnit.fahrenheit);

            // UNIT TYPE 12 - Luminance
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

            // UNIT TYPE 13 - Illuminance
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

            // UNIT TYPE 14 - Angle
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

            // UNIT TYPE 15 - Data Size
            dataSizeUnits.Add(DataSizeUnit.sizeByte);
            dataSizeUnits.Add(DataSizeUnit.sizeKilobyte);
            dataSizeUnits.Add(DataSizeUnit.sizeMegabyte);
            dataSizeUnits.Add(DataSizeUnit.sizeGigabyte);
            dataSizeUnits.Add(DataSizeUnit.sizeTerabyte);
            dataSizeUnits.Add(DataSizeUnit.sizePetabyte);

            // Load initial units
            AddComboBoxValues(lengthUnits);

            // Reset fromValueInput
            SetFromValueInputTextToDefault(true);
        }

        // Enable custom unit forms to add custom units from this form
        public void AddCustomUnit(short unitTypeIndex, Unit unit)
        {
            switch (unitTypeIndex)
            {
                case UnitTypeIndex.length:
                    customLengthUnits.AddUnit(unit);
                    break;
                case UnitTypeIndex.area:
                    customAreaUnits.AddUnit(unit);
                    break;
                case UnitTypeIndex.volume:
                    customVolumeUnits.AddUnit(unit);
                    break;
                case UnitTypeIndex.time:
                    customTimeUnits.AddUnit(unit);
                    break;
                case UnitTypeIndex.speed:
                    customSpeedUnits.AddUnit(unit);
                    break;
                case UnitTypeIndex.flowArea:
                    customFlowAreaUnits.AddUnit(unit);
                    break;
                case UnitTypeIndex.flowVolume:
                    customFlowVolumeUnits.AddUnit(unit);
                    break;
                case UnitTypeIndex.flowMass:
                    customFlowMassUnits.AddUnit(unit);
                    break;
                case UnitTypeIndex.mass:
                    customMassUnits.AddUnit(unit);
                    break;
                case UnitTypeIndex.energy:
                    customEnergyUnits.AddUnit(unit);
                    break;
                case UnitTypeIndex.pressure:
                    customPressureUnits.AddUnit(unit);
                    break;
                case UnitTypeIndex.temperature:
                    customTemperatureUnits.AddUnit(unit);
                    break;
                case UnitTypeIndex.luminance:
                    customLuminanceUnits.AddUnit(unit);
                    break;
                case UnitTypeIndex.illuminance:
                    customIlluminanceUnits.AddUnit(unit);
                    break;
                case UnitTypeIndex.angle:
                    customAngleUnits.AddUnit(unit);
                    break;
                case UnitTypeIndex.dataSize:
                    customDataSizeUnits.AddUnit(unit);
                    break;
            }
        }

        // Enable custom unit forms to read units from this form
        public List<Unit> GetCustomUnitListings(short unitTypeIndex)
        {
            List<Unit> resultUnitList = new List<Unit>();

            switch (unitTypeIndex)
            {
                case UnitTypeIndex.length:
                    resultUnitList.AddRange(customLengthUnits.ListUnits());
                    break;
                case UnitTypeIndex.area:
                    resultUnitList.AddRange(customAreaUnits.ListUnits());
                    break;
                case UnitTypeIndex.volume:
                    resultUnitList.AddRange(customVolumeUnits.ListUnits());
                    break;
                case UnitTypeIndex.time:
                    resultUnitList.AddRange(customTimeUnits.ListUnits());
                    break;
                case UnitTypeIndex.speed:
                    resultUnitList.AddRange(customSpeedUnits.ListUnits());
                    break;
                case UnitTypeIndex.flowArea:
                    resultUnitList.AddRange(customFlowAreaUnits.ListUnits());
                    break;
                case UnitTypeIndex.flowVolume:
                    resultUnitList.AddRange(customFlowVolumeUnits.ListUnits());
                    break;
                case UnitTypeIndex.flowMass:
                    resultUnitList.AddRange(customFlowMassUnits.ListUnits());
                    break;
                case UnitTypeIndex.mass:
                    resultUnitList.AddRange(customMassUnits.ListUnits());
                    break;
                case UnitTypeIndex.energy:
                    resultUnitList.AddRange(customEnergyUnits.ListUnits());
                    break;
                case UnitTypeIndex.pressure:
                    resultUnitList.AddRange(customPressureUnits.ListUnits());
                    break;
                case UnitTypeIndex.temperature:
                    resultUnitList.AddRange(customTemperatureUnits.ListUnits());
                    break;
                case UnitTypeIndex.luminance:
                    resultUnitList.AddRange(customLuminanceUnits.ListUnits());
                    break;
                case UnitTypeIndex.illuminance:
                    resultUnitList.AddRange(customIlluminanceUnits.ListUnits());
                    break;
                case UnitTypeIndex.angle:
                    resultUnitList.AddRange(customAngleUnits.ListUnits());
                    break;
                case UnitTypeIndex.dataSize:
                    resultUnitList.AddRange(customDataSizeUnits.ListUnits());
                    break;
            }

            return resultUnitList;
        }

        // Enable custom unit forms to delete a custom unit from this form
        public void DeleteCustomUnit(short unitTypeIndex, Unit unit)
        {
            switch (unitTypeIndex)
            {
                case UnitTypeIndex.length:
                    customLengthUnits.RemoveUnit(unit);
                    break;
                case UnitTypeIndex.area:
                    customAreaUnits.RemoveUnit(unit);
                    break;
                case UnitTypeIndex.volume:
                    customVolumeUnits.RemoveUnit(unit);
                    break;
                case UnitTypeIndex.time:
                    customTimeUnits.RemoveUnit(unit);
                    break;
                case UnitTypeIndex.speed:
                    customSpeedUnits.RemoveUnit(unit);
                    break;
                case UnitTypeIndex.flowArea:
                    customFlowAreaUnits.RemoveUnit(unit);
                    break;
                case UnitTypeIndex.flowVolume:
                    customFlowVolumeUnits.RemoveUnit(unit);
                    break;
                case UnitTypeIndex.flowMass:
                    customFlowMassUnits.RemoveUnit(unit);
                    break;
                case UnitTypeIndex.mass:
                    customMassUnits.RemoveUnit(unit);
                    break;
                case UnitTypeIndex.energy:
                    customEnergyUnits.RemoveUnit(unit);
                    break;
                case UnitTypeIndex.pressure:
                    customPressureUnits.RemoveUnit(unit);
                    break;
                case UnitTypeIndex.temperature:
                    customTemperatureUnits.RemoveUnit(unit);
                    break;
                case UnitTypeIndex.luminance:
                    customLuminanceUnits.RemoveUnit(unit);
                    break;
                case UnitTypeIndex.illuminance:
                    customIlluminanceUnits.RemoveUnit(unit);
                    break;
                case UnitTypeIndex.angle:
                    customAngleUnits.RemoveUnit(unit);
                    break;
                case UnitTypeIndex.dataSize:
                    customDataSizeUnits.RemoveUnit(unit);
                    break;
            }
        }

        // (2) MENU BAR EVENTS - Open the About box to show the application
        // credits
            private void aboutUnitConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            if (this.TopMost)
                aboutBox.TopMost = true;
            aboutBox.Show();
        }

        // (2) MENU BAR EVENTS - Open the Add Custom Units Box
        private void addCustomUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomUnitsBox addCustomUnitsBox = new AddCustomUnitsBox(this);
            if (this.TopMost)
                addCustomUnitsBox.TopMost = true;
            addCustomUnitsBox.Show();
        }

        // (2) MENU BAR EVENTS - Open the Delete Custom Units Box
        private void deleteCustomUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCustomUnitsBox deleteCustomUnitsBox = new DeleteCustomUnitsBox(this);
            if (this.TopMost)
                deleteCustomUnitsBox.TopMost = true;
            deleteCustomUnitsBox.Show();
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
            statusBar.BackColor = StatusMessage.positiveColour;
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

        // (3) UNIT TYPE EVENTS - Helper function to add custom units in the
        // combo box for multiplicative units that use the Unit class
        private void AddCustomComboBoxValues(CustomBaseUnits customBaseUnits)
        {
            foreach (Unit element in customBaseUnits.ListUnits())
            {
                fromUnitInput.Items.Add(element.GetName());
                toUnitOutput.Items.Add(element.GetName());
            }
        }

        // (3) UNIT TYPE EVENTS - Helper function to combo box contents
        public void UpdateComboBoxes()
        {
            List<Unit> unitList = new List<Unit>();

            fromUnitInput.Items.Clear();
            toUnitOutput.Items.Clear();
            SetFromValueInputTextToDefault(true);
            toValueOutput.Clear();

            unitList.AddRange(GetAllUnits((short)unitSelectorTable.SelectedIndex));
            AddComboBoxValues(unitList);

            statusIndicator.Text = StatusMessage.ready;
            statusBar.BackColor = StatusMessage.standardColour;
        }

        // (3) UNIT TYPE EVENTS - Do when unit type is changed
        private void unitSelectorTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBoxes();
        }

        // (4) CONTROLS - Helper function to set fromValueInput text properties
        // when it gains or loses focus
        private void SetFromValueInputTextToDefault(bool reset)
        {
            string currentStatusMessage = statusIndicator.Text;
            System.Drawing.Color currentStatusColour = statusBar.BackColor;

            if (reset)
            {
                fromValueInput.Text = InputText.fromValueInputEmptyString;
                fromValueInput.ForeColor = InputColour.emptyColour;
                fromValueInputEmpty = true;
            }
            else
            {
                fromValueInput.Text = InputText.standardString;
                fromValueInput.ForeColor = InputColour.standardColour;
                fromValueInputEmpty = false;
            }

            statusIndicator.Text = currentStatusMessage;
            statusBar.BackColor = currentStatusColour;
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

        // (4) CONTROLS - Do when text in toValueOutput changes
        private void toValueOutput_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(toValueOutput.Text))
                toValueOutput.Cursor = Cursors.No;
            else
                toValueOutput.Cursor = Cursors.IBeam;
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
            else if (!fromValueInputEmpty &&
                string.IsNullOrWhiteSpace(fromValueInput.Text))
                toValueOutput.Text = "";
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
                statusBar.BackColor = StatusMessage.positiveColour;
            }
            else
            {
                statusIndicator.Text = StatusMessage.invalidSwap;
                statusBar.BackColor = StatusMessage.errorColour;
            }
        }

        // (6) CLEAR- Clear all inputs and the value output
        private void clearButton_Click(object sender, EventArgs e)
        {
            fromUnitInput.SelectedIndex = -1;
            toUnitOutput.SelectedIndex = -1;
            SetFromValueInputTextToDefault(true);
            toValueOutput.Text = "";
            statusIndicator.Text = StatusMessage.ready;
            statusBar.BackColor = StatusMessage.standardColour;
        }

        // (7) CALCULATION - Helper function that calculates the result value
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
                    statusBar.BackColor = StatusMessage.positiveColour;
                }
                else
                {
                    statusIndicator.Text = StatusMessage.unitError;
                    statusBar.BackColor = StatusMessage.errorColour;
                }
            }
            else
            {
                statusIndicator.Text = StatusMessage.invalidInput;
                statusBar.BackColor = StatusMessage.errorColour;
            }
        }

        // (7) CALCULATION - Execute the calculation process
        private void ExecuteCalculation()
        {
            List<Unit> unitList = new List<Unit>();
            unitList.AddRange(GetAllUnits((short)unitSelectorTable.SelectedIndex));
            CalculateConversion(unitList);
        }

        // COMMON - Helper function to combine all units from main and custom
        // unit lists
        public List<Unit> GetAllUnits(short unitTypeIndex)
        {
            List<Unit> resultUnitList = new List<Unit>();

            switch (unitTypeIndex)
            {
                case UnitTypeIndex.length:
                    resultUnitList.AddRange(lengthUnits);
                    resultUnitList.AddRange(customLengthUnits.ListUnits());
                    break;
                case UnitTypeIndex.area:
                    resultUnitList.AddRange(areaUnits);
                    resultUnitList.AddRange(customAreaUnits.ListUnits());
                    break;
                case UnitTypeIndex.volume:
                    resultUnitList.AddRange(volumeUnits);
                    resultUnitList.AddRange(customVolumeUnits.ListUnits());
                    break;
                case UnitTypeIndex.time:
                    resultUnitList.AddRange(timeUnits);
                    resultUnitList.AddRange(customTimeUnits.ListUnits());
                    break;
                case UnitTypeIndex.speed:
                    resultUnitList.AddRange(speedUnits);
                    resultUnitList.AddRange(customSpeedUnits.ListUnits());
                    break;
                case UnitTypeIndex.flowArea:
                    resultUnitList.AddRange(flowAreaUnits);
                    resultUnitList.AddRange(customFlowAreaUnits.ListUnits());
                    break;
                case UnitTypeIndex.flowVolume:
                    resultUnitList.AddRange(flowVolumeUnits);
                    resultUnitList.AddRange(customFlowVolumeUnits.ListUnits());
                    break;
                case UnitTypeIndex.flowMass:
                    resultUnitList.AddRange(flowMassUnits);
                    resultUnitList.AddRange(customFlowMassUnits.ListUnits());
                    break;
                case UnitTypeIndex.mass:
                    resultUnitList.AddRange(massUnits);
                    resultUnitList.AddRange(customMassUnits.ListUnits());
                    break;
                case UnitTypeIndex.energy:
                    resultUnitList.AddRange(energyUnits);
                    resultUnitList.AddRange(customEnergyUnits.ListUnits());
                    break;
                case UnitTypeIndex.pressure:
                    resultUnitList.AddRange(pressureUnits);
                    resultUnitList.AddRange(customPressureUnits.ListUnits());
                    break;
                case UnitTypeIndex.temperature:
                    resultUnitList.AddRange(temperatureUnits);
                    resultUnitList.AddRange(customTemperatureUnits.ListUnits());
                    break;
                case UnitTypeIndex.luminance:
                    resultUnitList.AddRange(luminanceUnits);
                    resultUnitList.AddRange(customLuminanceUnits.ListUnits());
                    break;
                case UnitTypeIndex.illuminance:
                    resultUnitList.AddRange(illuminanceUnits);
                    resultUnitList.AddRange(customIlluminanceUnits.ListUnits());
                    break;
                case UnitTypeIndex.angle:
                    resultUnitList.AddRange(angleUnits);
                    resultUnitList.AddRange(customAngleUnits.ListUnits());
                    break;
                case UnitTypeIndex.dataSize:
                    resultUnitList.AddRange(dataSizeUnits);
                    resultUnitList.AddRange(customDataSizeUnits.ListUnits());
                    break;
            }
            return resultUnitList;
        }

        // MISC - For menu bar rendering
        private class SelectorColourRenderer : ToolStripProfessionalRenderer
        {
            public SelectorColourRenderer() : base(new SelectorColours()) { }
        }

        // MISC - For menu bar rendering
        private class SelectorColours : ProfessionalColorTable
        {
            public override System.Drawing.Color MenuItemSelected
            {
                get
                {
                    return System.Drawing.Color.Gray;
                }
            }

            public override System.Drawing.Color MenuItemBorder
            {
                get
                {
                    return System.Drawing.Color.Gray;
                }
            }

            public override System.Drawing.Color MenuBorder
            {
                get
                {
                    return System.Drawing.Color.Gray;
                }
            }

            public override System.Drawing.Color SeparatorDark
            {
                get
                {
                    return System.Drawing.Color.White;
                }
            }

            public override System.Drawing.Color CheckBackground
            {
                get
                {
                    return System.Drawing.Color.White;
                }
            }

            public override System.Drawing.Color CheckSelectedBackground
            {
                get
                {
                    return System.Drawing.Color.White;
                }
            }
        }
    }
}