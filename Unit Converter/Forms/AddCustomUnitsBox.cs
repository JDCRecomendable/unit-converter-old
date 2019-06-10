using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class AddCustomUnitsBox : Form
    {
        public AddCustomUnitsBox()
        {
            InitializeComponent();
            this.ActiveControl = unitSelectorCustomUnitTable;
            unitSelectorCustomUnitTable.Focus();
            unitSelectorCustomUnitTable.SelectedIndex = 0;
        }

        // INITIALISATION - Define the list that contains the user controls
        List<TextBox> textBoxes = new List<TextBox>();

        // INITIALISATION - Define lists to contain units
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

        // INITIALISATION - Load elements to main screen controls
        private void AddCustomUnitsScreen_Load(object sender, EventArgs e)
        {
            // Text Boxes
            textBoxes.Add(customUnitNameInput);
            textBoxes.Add(gradientUnitInput);
            textBoxes.Add(interceptUnitInput);

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

            // Load textboxes onto list that contains them
            textBoxes.Add(customUnitNameInput);
            textBoxes.Add(customUnitNameInput);
        }

        // UNIT TYPE EVENTS - Helper function to add units in the combo box
        private void AddComboBoxValues(List<Unit> unitList)
        {
            foreach (Unit element in unitList)
                compareUnitInput.Items.Add(element.GetName());
        }

        // UNIT TYPE EVENTS - Helper function to clear all text boxes (except
        // custom unit name)
        private void ClearTextBoxes()
        {
            foreach (TextBox textbox in textBoxes)
            {
                textbox.Text = InputText.standardString;
            }
        }

        // UNIT TYPE EVENTS - Do when unit type is changed
        private void unitSelectorCustomUnitTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            compareUnitInput.Items.Clear();
            ClearTextBoxes();

            switch (unitSelectorCustomUnitTable.SelectedIndex)
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
                case UnitTypeIndex.flowArea:
                    AddComboBoxValues(flowAreaUnits);
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
            }
        }

        // MAIN EVENTS - Close the form when user clicks cancel
        private void cancelAddCustomUnitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // MAIN EVENTS - Attempt to add the custom unit
        private void createCustomUnitButton_Click(object sender, EventArgs e)
        {
            bool gradientIsValid = double.TryParse(gradientUnitInput.Text, result: out double gradient);
            bool interceptIsValid = double.TryParse(interceptUnitInput.Text, result: out double intercept);

            if (string.IsNullOrWhiteSpace(customUnitNameInput.Text) ||
                compareUnitInput.SelectedIndex == -1 ||
                !gradientIsValid ||
                (!string.IsNullOrWhiteSpace(interceptUnitInput.Text) &&
                !interceptIsValid))
            {
                MessageBox.Show(InvalidInputMessageBoxProperty.message,
                    InvalidInputMessageBoxProperty.caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                //
            }
        }
    }
}
