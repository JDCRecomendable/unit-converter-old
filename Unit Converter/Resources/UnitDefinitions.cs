namespace Unit_Converter
{
    /// <summary>
    /// Define the 18 length units
    /// </summary>
    public static class LengthUnits
    {
        public static Unit metre = new Unit("Metre [m] (S.I. Unit)", 1d, 0d);
        public static Unit nauticalMile = new Unit("Nautical Mile [nmi]", 1852d, 0d);
        public static Unit kilometre = new Unit("Kilometre [km]", 1000d, 0d);
        public static Unit decimetre = new Unit("Decimetre [dm]", 0.1d, 0d);
        public static Unit centimetre = new Unit("Centimetre [cm]", 0.01d, 0d);
        public static Unit millimetre = new Unit("Millimetre [mm]", 0.001d, 0d);
        public static Unit micrometre = new Unit("Micrometre [μm]", 0.000001d, 0d);
        public static Unit nanometre = new Unit("Nanometre [nm]", 0.000000001d, 0d);
        public static Unit angstrom = new Unit("Ångström [Å]", 0.0000000001d, 0d);
        public static Unit mile = new Unit("Mile [mi]", ((1d / 3.280839895d) * 5280d), 0d);
        public static Unit furlong = new Unit("Furlong", ((1d / 3.280839895d) * 660d), 0d);
        public static Unit chain = new Unit("Chain", ((1d / 3.280839895d) * 66d), 0d);
        public static Unit rod = new Unit("Rod", ((1d / 3.280839895d) * 16.5d), 0d);
        public static Unit horseLength = new Unit("Horse Length", ((1d / 3.280839895d) * 8d), 0d);
        public static Unit fathom = new Unit("Fathom", ((1d / 3.280839895d) * 6d), 0d);
        public static Unit yard = new Unit("Yard [yd]", ((1d / 3.280839895d) * 3d), 0d);
        public static Unit foot = new Unit("Foot [ft]", (1d / 3.280839895d), 0d);
        public static Unit inch = new Unit("Inch [in]", ((1d / 3.280839895d) / 12d), 0d);
    }

    /// <summary>
    /// Define the 20 area units
    /// </summary>
    public static class AreaUnits
    {
        public static Unit squareMetre = new Unit("Square Metre [m²] (S.I. Unit)", 1d, 0d);
        public static Unit squareKilometre = new Unit("Square Kilometre [km²]", 1000000d, 0d);
        public static Unit squareDecimetre = new Unit("Square Decimetre [dm²]", 0.01d, 0d);
        public static Unit squareCentimetre = new Unit("Square Centimetre [cm²]", 0.0001d, 0d);
        public static Unit squareMillimetre = new Unit("Square Millimetre [mm²]", 0.000001d, 0d);
        public static Unit squareMicrometre = new Unit("Square Micrometre [μm²]", 0.000000000001d, 0d);
        public static Unit are = new Unit("Are [a]", 100d, 0d);
        public static Unit stremma = new Unit("Stremma", 1000d, 0d);
        public static Unit hectare = new Unit("Hectare [ha]", 10000d, 0d);
        public static Unit tetrad = new Unit("Tetrad", 4000000d, 0d);
        public static Unit hectad = new Unit("Hectad", 100000000d, 0d);
        public static Unit myriad = new Unit("Myriad", 10000000000d, 0d);
        public static Unit squareMile = new Unit("Square Mile [mi²]", ((1d / 1.19599004630108d) * 3097600d), 0d);
        public static Unit squareYard = new Unit("Square Yard [yd²]", (1d / 1.19599004630108d), 0d);
        public static Unit squareFoot = new Unit("Square Foot [ft²]", ((1d / 1.19599004630108d) / 9d), 0d);
        public static Unit squareInch = new Unit("Square Inch [in²]", ((1d / 1.19599004630108d) / 1296d), 0d);
        public static Unit acre = new Unit("Acre [ac]", ((1d / 1.19599004630108d) * 4840d), 0d);
        public static Unit rood = new Unit("Rood", ((1d / 1.19599004630108d) * 1210d), 0d);
        public static Unit section = new Unit("Section", ((1d / 1.19599004630108d) * 3097600d), 0d);
        public static Unit township = new Unit("Survey Township", ((1d / 1.19599004630108d) * 111513600d), 0d);
    }

    public static class VolumeUnits
    {
        public static Unit cubicMetre = new Unit("Cubic Metre [m³] (S.I. Unit)", 1d, 0d);
        public static Unit cubicCentimetre = new Unit("Cubic Centimetre [cm³]", 0.000001d, 0d);
        public static Unit cubicMillimetre = new Unit("Cubic Millimetre [mm³]", 0.000000001d, 0d);
        public static Unit cubicYard = new Unit("Cubic Yard [yd³]", (1d / 1.30795061931439d), 0d);
        public static Unit cubicFoot = new Unit("Cubic Foot [ft³]", ((1d / 1.30795061931439d) / 27d), 0d);
        public static Unit cubicInch = new Unit("Cubic Inch [in³]", ((1d / 1.30795061931439d) / 46656d), 0d);
        public static Unit litre = new Unit("Litre [L]", 0.001d, 0d);
        public static Unit millilitre = new Unit("Millilitre [mL]", 0.000001d, 0d);
        public static Unit barrel = new Unit("Barrel", (((1d / 1.30795061931439d) / 46656d) * 9702d), 0d);
        public static Unit gallon = new Unit("Gallon (Imperial)", (1d / 219.969248299088d), 0d);
        public static Unit quart = new Unit("Quart (Imperial)", ((1d / 219.969248299088d) / 4d), 0d);
        public static Unit pint = new Unit("Pint (Imperial)", ((1d / 219.969248299088d) / 8d), 0d);
        public static Unit cup = new Unit("Cup (US Customary)", 4226.75283773038d, 0d);
        public static Unit tablespoon = new Unit("Tablespoon (US Customary)", (4226.75283773038d / 16d), 0d);
        public static Unit teaspoon = new Unit("Teaspoon (US Customary)", (4226.75283773038d / 48d), 0d);
    }

    public static class TimeUnits
    {
        public static Unit second = new Unit("Second [s] (S.I. Unit)", 1d, 0d);
        public static Unit millisecond = new Unit("Millisecond [ms]", 0.001d, 0d);
        public static Unit microsecond = new Unit("Microsecond [μs]", 0.000001d, 0d);
        public static Unit nanosecond = new Unit("Nanosecond [ns]", 000000001d, 0d);
        public static Unit minute = new Unit("Minute [min]", 60d, 0d);
        public static Unit hour = new Unit("Hour [h]", 3600d, 0d);
        public static Unit day = new Unit("Day", 86400d, 0d);
        public static Unit week = new Unit("Week", 604800d, 0d);
        public static Unit fortnight = new Unit("Fortnight", 1209600d, 0d);
        public static Unit year = new Unit("Year", 31536000d, 0d);
        public static Unit yearLeap = new Unit("Year (Leap)", 31622400d, 0d);
    }

    public static class SpeedUnits
    {
        public static Unit metrePerSecond = new Unit("Metre per Second [m/s] (S.I. Unit)", 1d, 0d);
        public static Unit metrePerMinute = new Unit("Metre per Minute [m/min]", (1d / 60d), 0d);
        public static Unit metrePerHour = new Unit("Metre per Hour [m/h]", (1d / 3600d), 0d);
        public static Unit kilometrePerSecond = new Unit("Kilometre per Second [km/s]", 1000d, 0d);
        public static Unit kilometrePerMinute = new Unit("Kilometre per Minute [km/min]", (1000d / 60d), 0d);
        public static Unit kilometrePerHour = new Unit("Kilometre per Hour [km/h]", (1d / 3.6d), 0d);
        public static Unit speedOfLight = new Unit("Speed of Light (c)", 299792458d, 0d);
        public static Unit footPerSecond = new Unit("Foot per Second [ft/s]", (1d / 3.280839895d), 0d);
        public static Unit footPerMinute = new Unit("Foot per Minute [ft/min]", ((1d / 3.280839895d) / 60d), 0d);
        public static Unit footPerHour = new Unit("Foot per Hour [ft/h]", ((1d / 3.280839895d) / 3600d), 0d);
        public static Unit milePerSecond = new Unit("Mile per Second [mi/s]", ((1d / 3.280839895d) * 5280d), 0d);
        public static Unit milePerMinute = new Unit("Mile per Minute [mi/min]", ((1d / 3.280839895d) * 5280d / 60d), 0d);
        public static Unit milePerHour = new Unit("Mile per Hour [mi/h]", ((1d / 3.280839895d) * 5280d / 3600d), 0d);
        public static Unit mach = new Unit("Mach [Ma]", 340d, 0d);
        public static Unit knot = new Unit("Knot [kn]", 1852d / 3600d, 0d);
    }

    public static class FlowUnits
    {
        // empty
    }

    public static class MassUnits
    {
        public static Unit kilogram = new Unit("Kilogram [kg] (S.I. Unit)", 1d, 0d);
        public static Unit gram = new Unit("Gram [g]", (1d / 1000d), 0d);
        public static Unit carat = new Unit("Carat [ct]", 0.0002d, 0d);
        public static Unit milligram = new Unit("Milligram [mg]", (1d / 1000000d), 0d);
        public static Unit microgram = new Unit("Microgram [μg]", (1d / 1000000000d), 0d);
        public static Unit tonne = new Unit("Tonne [t] (Metric)", 1000d, 0d);
        public static Unit kilotonne = new Unit("Kilotonne [kt] (Metric)", 1000000d, 0d);
        public static Unit pound = new Unit("Pound [lb]", (1d / 2.20462262184878d), 0d);
        public static Unit ounce = new Unit("Ounce [oz]", ((1d / 2.20462262184878d) / 16d), 0d);
        public static Unit stoneUK = new Unit("Stone [st.] (UK)", ((1d / 2.20462262184878d) * 14d), 0d);
        public static Unit tonShort = new Unit("Ton (Short)", ((1d / 2.20462262184878d) * 2000d), 0d);
        public static Unit tonLong = new Unit("Ton (Long)", ((1d / 2.20462262184878d) * 2240d), 0d);
        public static Unit kilotonShort = new Unit("Kiloton (Short)", ((1d / 2.20462262184878d) * 2000000d), 0d);
        public static Unit kilotonLong = new Unit("Kiloton (Long)", ((1d / 2.20462262184878d) * 2240000d), 0d);
    }

    public static class EnergyUnits
    {
        public static Unit joule = new Unit("Joule [J] (S.I. Unit)", 1d, 0d);
        public static Unit kilojoule = new Unit("Kilojoule [kJ]", 1000d, 0d);
        public static Unit megajoule = new Unit("Megajoule [MJ]", 1000000d, 0d);
        public static Unit wattHour = new Unit("Watt Hour [Wh]", 3600d, 0d);
        public static Unit kilowattHour = new Unit("Kilowatt Hour [kWh]", 3600000d, 0d);
        public static Unit megawattHour = new Unit("Megawatt Hour [MWh]", 3600000000d, 0d);
        public static Unit calorie = new Unit("calorie", 4.184d, 0d);
        public static Unit kilocalorie = new Unit("Kilocalorie", 4184d, 0d);
        public static Unit btu = new Unit("British Thermal Unit (BTU)", 1055.05585262d, 0d);
    }

    public static class PressureUnits
    {
        // empty
    }

    public static class TemperatureUnits
    {
        public static Unit kelvin = new Unit("Kelvin [K] (S.I. Unit)", 1d, 0d);
        public static Unit celsius = new Unit("Celsius [°C]", 1d, 273.15d);
        public static Unit fahrenheit = new Unit("Fahrenheit [°F]", (5d / 9d), (459.67d * (5d / 9d)));
    }

    public static class LuminosityUnits
    {
        // empty
    }

    public static class DataSizeUnits
    {
        public static Unit sizeByte = new Unit("Byte [B]", 1d, 0d);
        public static Unit sizeKilobyte = new Unit("Kilobyte [kb]", 1024d, 0d);
        public static Unit sizeMegabyte = new Unit("Megabyte [MB]", 1048576d, 0d);
        public static Unit sizeGigabyte = new Unit("Gigabyte [GB]", 1073741824d, 0d);
        public static Unit sizeTerabyte = new Unit("Terabyte [TB]", 1099511627776d, 0d);
        public static Unit sizePetabyte = new Unit("Petabyte [PB]", 1125899906842624d, 0d);
    }
}