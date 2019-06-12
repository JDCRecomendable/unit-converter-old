namespace Unit_Converter
{
    // DEFAULT UNITS
    /// <summary>
    /// Contains 22 length units
    /// </summary>
    public static class LengthUnit
    {
        public static Unit metre = new Unit("Metre [m] (S.I. Unit)", 1d, 0d);
        public static Unit nauticalMile = new Unit("Nautical Mile [nmi]", 1852d, 0d);
        public static Unit hectometre = new Unit("Hectometre [hm]", 100d, 0d);
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
        public static Unit astronomicalUnit = new Unit("Astronomical Unit", 149597900000d, 0d);
        public static Unit lightYear = new Unit("Light-Year", 9460730000000000d, 0d);
        public static Unit parsec = new Unit("Parsec", 30856782064650000d, 0d);
    }

    /// <summary>
    /// Contains 20 area units
    /// </summary>
    public static class AreaUnit
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

    /// <summary>
    /// Contains 15 volume units
    /// </summary>
    public static class VolumeUnit
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

    /// <summary>
    /// Contains 11 time units
    /// </summary>
    public static class TimeUnit
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

    /// <summary>
    /// Contains 15 speed units
    /// </summary>
    public static class SpeedUnit
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

    /// <summary>
    /// Contains 80 flow rate (area) units
    /// </summary>
    public static class FlowAreaUnit
    {
        // Per Second
        public static Unit squareMetrePerSecond = new Unit("Square Metre per Second", 1d, 0d);
        public static Unit squareKilometrePerSecond = new Unit("Square Kilometre per Second", 1000000d, 0d);
        public static Unit squareDecimetrePerSecond = new Unit("Square Decimetre per Second", 0.01d, 0d);
        public static Unit squareCentimetrePerSecond = new Unit("Square Centimetre per Second", 0.0001d, 0d);
        public static Unit squareMillimetrePerSecond = new Unit("Square Millimetre per Second", 0.000001d, 0d);
        public static Unit squareMicrometrePerSecond = new Unit("Square Micrometre per Second", 0.000000000001d, 0d);
        public static Unit arePerSecond = new Unit("Are per Second", 100d, 0d);
        public static Unit stremmaPerSecond = new Unit("Stremma per Second", 1000d, 0d);
        public static Unit hectarePerSecond = new Unit("Hectare per Second", 10000d, 0d);
        public static Unit tetradPerSecond = new Unit("Tetrad per Second", 4000000d, 0d);
        public static Unit hectadPerSecond = new Unit("Hectad per Second", 100000000d, 0d);
        public static Unit myriadPerSecond = new Unit("Myriad per Second", 10000000000d, 0d);
        public static Unit squareMilePerSecond = new Unit("Square Mile per Second", ((1d / 1.19599004630108d) * 3097600d), 0d);
        public static Unit squareYardPerSecond = new Unit("Square Yard per Second", (1d / 1.19599004630108d), 0d);
        public static Unit squareFootPerSecond = new Unit("Square Foot per Second", ((1d / 1.19599004630108d) / 9d), 0d);
        public static Unit squareInchPerSecond = new Unit("Square Inch per Second", ((1d / 1.19599004630108d) / 1296d), 0d);
        public static Unit acrePerSecond = new Unit("Acre per Second", ((1d / 1.19599004630108d) * 4840d), 0d);
        public static Unit roodPerSecond = new Unit("Rood per Second", ((1d / 1.19599004630108d) * 1210d), 0d);
        public static Unit sectionPerSecond = new Unit("Section per Second", ((1d / 1.19599004630108d) * 3097600d), 0d);
        public static Unit townshipPerSecond = new Unit("Survey Township per Second", ((1d / 1.19599004630108d) * 111513600d), 0d);

        // Per Minute
        public static Unit squareMetrePerMinute = new Unit("Square Metre per Minute", 1d * 60d, 0d);
        public static Unit squareKilometrePerMinute = new Unit("Square Kilometre per Minute", 1000000d * 60d, 0d);
        public static Unit squareDecimetrePerMinute = new Unit("Square Decimetre per Minute", 0.01d * 60d, 0d);
        public static Unit squareCentimetrePerMinute = new Unit("Square Centimetre per Minute", 0.0001d * 60d, 0d);
        public static Unit squareMillimetrePerMinute = new Unit("Square Millimetre per Minute", 0.000001d * 60d, 0d);
        public static Unit squareMicrometrePerMinute = new Unit("Square Micrometre per Minute", 0.000000000001d * 60d, 0d);
        public static Unit arePerMinute = new Unit("Are per Minute", 100d * 60d, 0d);
        public static Unit stremmaPerMinute = new Unit("Stremma per Minute", 1000d * 60d, 0d);
        public static Unit hectarePerMinute = new Unit("Hectare per Minute", 10000d * 60d, 0d);
        public static Unit tetradPerMinute = new Unit("Tetrad per Minute", 4000000d * 60d, 0d);
        public static Unit hectadPerMinute = new Unit("Hectad per Minute", 100000000d * 60d, 0d);
        public static Unit myriadPerMinute = new Unit("Myriad per Minute", 10000000000d * 60d, 0d);
        public static Unit squareMilePerMinute = new Unit("Square Mile per Minute", ((1d / 1.19599004630108d) * 3097600d) * 60d, 0d);
        public static Unit squareYardPerMinute = new Unit("Square Yard per Minute", (1d / 1.19599004630108d) * 60d, 0d);
        public static Unit squareFootPerMinute = new Unit("Square Foot per Minute", ((1d / 1.19599004630108d) / 9d) * 60d, 0d);
        public static Unit squareInchPerMinute = new Unit("Square Inch per Minute", ((1d / 1.19599004630108d) / 1296d) * 60d, 0d);
        public static Unit acrePerMinute = new Unit("Acre per Minute", ((1d / 1.19599004630108d) * 4840d) * 60d, 0d);
        public static Unit roodPerMinute = new Unit("Rood per Minute", ((1d / 1.19599004630108d) * 1210d) * 60d, 0d);
        public static Unit sectionPerMinute = new Unit("Section per Minute", ((1d / 1.19599004630108d) * 3097600d) * 60d, 0d);
        public static Unit townshipPerMinute = new Unit("Survey Township per Minute", ((1d / 1.19599004630108d) * 111513600d) * 60d, 0d);

        // Per Hour
        public static Unit squareMetrePerHour = new Unit("Square Metre per Hour", 1d * 3600d, 0d);
        public static Unit squareKilometrePerHour = new Unit("Square Kilometre per Hour", 1000000d * 3600d, 0d);
        public static Unit squareDecimetrePerHour = new Unit("Square Decimetre per Hour", 0.01d * 3600d, 0d);
        public static Unit squareCentimetrePerHour = new Unit("Square Centimetre per Hour", 0.0001d * 3600d, 0d);
        public static Unit squareMillimetrePerHour = new Unit("Square Millimetre per Hour", 0.000001d * 3600d, 0d);
        public static Unit squareMicrometrePerHour = new Unit("Square Micrometre per Hour", 0.000000000001d * 3600d, 0d);
        public static Unit arePerHour = new Unit("Are per Hour", 100d * 3600d, 0d);
        public static Unit stremmaPerHour = new Unit("Stremma per Hour", 1000d * 3600d, 0d);
        public static Unit hectarePerHour = new Unit("Hectare per Hour", 10000d * 3600d, 0d);
        public static Unit tetradPerHour = new Unit("Tetrad per Hour", 4000000d * 3600d, 0d);
        public static Unit hectadPerHour = new Unit("Hectad per Hour", 100000000d * 3600d, 0d);
        public static Unit myriadPerHour = new Unit("Myriad per Hour", 10000000000d * 3600d, 0d);
        public static Unit squareMilePerHour = new Unit("Square Mile per Hour", ((1d / 1.19599004630108d) * 3097600d) * 3600d, 0d);
        public static Unit squareYardPerHour = new Unit("Square Yard per Hour", (1d / 1.19599004630108d) * 3600d, 0d);
        public static Unit squareFootPerHour = new Unit("Square Foot per Hour", ((1d / 1.19599004630108d) / 9d) * 3600d, 0d);
        public static Unit squareInchPerHour = new Unit("Square Inch per Hour", ((1d / 1.19599004630108d) / 1296d) * 3600d, 0d);
        public static Unit acrePerHour = new Unit("Acre per Hour", ((1d / 1.19599004630108d) * 4840d) * 3600d, 0d);
        public static Unit roodPerHour = new Unit("Rood per Hour", ((1d / 1.19599004630108d) * 1210d) * 3600d, 0d);
        public static Unit sectionPerHour = new Unit("Section per Hour", ((1d / 1.19599004630108d) * 3097600d) * 3600d, 0d);
        public static Unit townshipPerHour = new Unit("Survey Township per Hour", ((1d / 1.19599004630108d) * 111513600d) * 3600d, 0d);

        // Per Day
        public static Unit squareMetrePerDay = new Unit("Square Metre per Day", 1d * 86400d, 0d);
        public static Unit squareKilometrePerDay = new Unit("Square Kilometre per Day", 1000000d * 86400d, 0d);
        public static Unit squareDecimetrePerDay = new Unit("Square Decimetre per Day", 0.01d * 86400d, 0d);
        public static Unit squareCentimetrePerDay = new Unit("Square Centimetre per Day", 0.0001d * 86400d, 0d);
        public static Unit squareMillimetrePerDay = new Unit("Square Millimetre per Day", 0.000001d * 86400d, 0d);
        public static Unit squareMicrometrePerDay = new Unit("Square Micrometre per Day", 0.000000000001d * 86400d, 0d);
        public static Unit arePerDay = new Unit("Are per Day", 100d * 86400d, 0d);
        public static Unit stremmaPerDay = new Unit("Stremma per Day", 1000d * 86400d, 0d);
        public static Unit hectarePerDay = new Unit("Hectare per Day", 10000d * 86400d, 0d);
        public static Unit tetradPerDay = new Unit("Tetrad per Day", 4000000d * 86400d, 0d);
        public static Unit hectadPerDay = new Unit("Hectad per Day", 100000000d * 86400d, 0d);
        public static Unit myriadPerDay = new Unit("Myriad per Day", 10000000000d * 86400d, 0d);
        public static Unit squareMilePerDay = new Unit("Square Mile per Day", ((1d / 1.19599004630108d) * 3097600d) * 86400d, 0d);
        public static Unit squareYardPerDay = new Unit("Square Yard per Day", (1d / 1.19599004630108d) * 86400d, 0d);
        public static Unit squareFootPerDay = new Unit("Square Foot per Day", ((1d / 1.19599004630108d) / 9d) * 86400d, 0d);
        public static Unit squareInchPerDay = new Unit("Square Inch per Day", ((1d / 1.19599004630108d) / 1296d) * 86400d, 0d);
        public static Unit acrePerDay = new Unit("Acre per Day", ((1d / 1.19599004630108d) * 4840d) * 86400d, 0d);
        public static Unit roodPerDay = new Unit("Rood per Day", ((1d / 1.19599004630108d) * 1210d) * 86400d, 0d);
        public static Unit sectionPerDay = new Unit("Section per Day", ((1d / 1.19599004630108d) * 3097600d) * 86400d, 0d);
        public static Unit townshipPerDay = new Unit("Survey Township per Day", ((1d / 1.19599004630108d) * 111513600d) * 86400d, 0d);
    }

    /// <summary>
    /// Contains 60 flow rate (volume) units
    /// </summary>
    public static class FlowVolumeUnit
    {
        // Per Second
        public static Unit cubicMetrePerSecond = new Unit("Cubic Metre per Second", 1d, 0d);
        public static Unit cubicCentimetrePerSecond = new Unit("Cubic Centimetre per Second", 0.000001d, 0d);
        public static Unit cubicMillimetrePerSecond = new Unit("Cubic Millimetre per Second", 0.000000001d, 0d);
        public static Unit cubicYardPerSecond = new Unit("Cubic Yard per Second", (1d / 1.30795061931439d), 0d);
        public static Unit cubicFootPerSecond = new Unit("Cubic Foot per Second", ((1d / 1.30795061931439d) / 27d), 0d);
        public static Unit cubicInchPerSecond = new Unit("Cubic Inch per Second", ((1d / 1.30795061931439d) / 46656d), 0d);
        public static Unit litrePerSecond = new Unit("Litre per Second", 0.001d, 0d);
        public static Unit millilitrePerSecond = new Unit("Millilitre per Second", 0.000001d, 0d);
        public static Unit barrelPerSecond = new Unit("Barrel per Second", (((1d / 1.30795061931439d) / 46656d) * 9702d), 0d);
        public static Unit gallonPerSecond = new Unit("Gallon (Imperial) per Second", (1d / 219.969248299088d), 0d);
        public static Unit quartPerSecond = new Unit("Quart (Imperial) per Second", ((1d / 219.969248299088d) / 4d), 0d);
        public static Unit pintPerSecond = new Unit("Pint (Imperial) per Second", ((1d / 219.969248299088d) / 8d), 0d);
        public static Unit cupPerSecond = new Unit("Cup (US Customary) per Second", 4226.75283773038d, 0d);
        public static Unit tablespoonPerSecond = new Unit("Tablespoon (US Customary) per Second", (4226.75283773038d / 16d), 0d);
        public static Unit teaspoonPerSecond = new Unit("Teaspoon (US Customary) per Second", (4226.75283773038d / 48d), 0d);
        
        // Per Minute
        public static Unit cubicMetrePerMinute = new Unit("Cubic Metre per Minute", 1d * 60d, 0d);
        public static Unit cubicCentimetrePerMinute = new Unit("Cubic Centimetre per Minute", 0.000001d * 60d, 0d);
        public static Unit cubicMillimetrePerMinute = new Unit("Cubic Millimetre per Minute", 0.000000001d * 60d, 0d);
        public static Unit cubicYardPerMinute = new Unit("Cubic Yard per Minute", (1d / 1.30795061931439d) * 60d, 0d);
        public static Unit cubicFootPerMinute = new Unit("Cubic Foot per Minute", ((1d / 1.30795061931439d) / 27d) * 60d, 0d);
        public static Unit cubicInchPerMinute = new Unit("Cubic Inch per Minute", ((1d / 1.30795061931439d) / 46656d) * 60d, 0d);
        public static Unit litrePerMinute = new Unit("Litre per Minute", 0.001d * 60d, 0d);
        public static Unit millilitrePerMinute = new Unit("Millilitre per Minute", 0.000001d * 60d, 0d);
        public static Unit barrelPerMinute = new Unit("Barrel per Minute", (((1d / 1.30795061931439d) / 46656d) * 9702d) * 60d, 0d);
        public static Unit gallonPerMinute = new Unit("Gallon (Imperial) per Minute", (1d / 219.969248299088d) * 60d, 0d);
        public static Unit quartPerMinute = new Unit("Quart (Imperial) per Minute", ((1d / 219.969248299088d) / 4d) * 60d, 0d);
        public static Unit pintPerMinute = new Unit("Pint (Imperial) per Minute", ((1d / 219.969248299088d) / 8d) * 60d, 0d);
        public static Unit cupPerMinute = new Unit("Cup (US Customary) per Minute", 4226.75283773038d * 60d, 0d);
        public static Unit tablespoonPerMinute = new Unit("Tablespoon (US Customary) per Minute", (4226.75283773038d / 16d) * 60d, 0d);
        public static Unit teaspoonPerMinute = new Unit("Teaspoon (US Customary) per Minute", (4226.75283773038d / 48d) * 60d, 0d);
        
        // Per Hour
        public static Unit cubicMetrePerHour = new Unit("Cubic Metre per Hour", 1d * 3600d, 0d);
        public static Unit cubicCentimetrePerHour = new Unit("Cubic Centimetre per Hour", 0.000001d * 3600d, 0d);
        public static Unit cubicMillimetrePerHour = new Unit("Cubic Millimetre per Hour", 0.000000001d * 3600d, 0d);
        public static Unit cubicYardPerHour = new Unit("Cubic Yard per Hour", (1d / 1.30795061931439d) * 3600d, 0d);
        public static Unit cubicFootPerHour = new Unit("Cubic Foot per Hour", ((1d / 1.30795061931439d) / 27d) * 3600d, 0d);
        public static Unit cubicInchPerHour = new Unit("Cubic Inch per Hour", ((1d / 1.30795061931439d) / 46656d) * 3600d, 0d);
        public static Unit litrePerHour = new Unit("Litre per Hour", 0.001d * 3600d, 0d);
        public static Unit millilitrePerHour = new Unit("Millilitre per Hour", 0.000001d * 3600d, 0d);
        public static Unit barrelPerHour = new Unit("Barrel per Hour", (((1d / 1.30795061931439d) / 46656d) * 9702d) * 3600d, 0d);
        public static Unit gallonPerHour = new Unit("Gallon (Imperial) per Hour", (1d / 219.969248299088d) * 3600d, 0d);
        public static Unit quartPerHour = new Unit("Quart (Imperial) per Hour", ((1d / 219.969248299088d) / 4d) * 3600d, 0d);
        public static Unit pintPerHour = new Unit("Pint (Imperial) per Hour", ((1d / 219.969248299088d) / 8d) * 3600d, 0d);
        public static Unit cupPerHour = new Unit("Cup (US Customary) per Hour", 4226.75283773038d * 3600d, 0d);
        public static Unit tablespoonPerHour = new Unit("Tablespoon (US Customary) per Hour", (4226.75283773038d / 16d) * 3600d, 0d);
        public static Unit teaspoonPerHour = new Unit("Teaspoon (US Customary) per Hour", (4226.75283773038d / 48d) * 3600d, 0d);
        
        // Per Day
        public static Unit cubicMetrePerDay = new Unit("Cubic Metre per Day", 1d * 86400d, 0d);
        public static Unit cubicCentimetrePerDay = new Unit("Cubic Centimetre per Day", 0.000001d * 86400d, 0d);
        public static Unit cubicMillimetrePerDay = new Unit("Cubic Millimetre per Day", 0.000000001d * 86400d, 0d);
        public static Unit cubicYardPerDay = new Unit("Cubic Yard per Day", (1d / 1.30795061931439d) * 86400d, 0d);
        public static Unit cubicFootPerDay = new Unit("Cubic Foot per Day", ((1d / 1.30795061931439d) / 27d) * 86400d, 0d);
        public static Unit cubicInchPerDay = new Unit("Cubic Inch per Day", ((1d / 1.30795061931439d) / 46656d) * 86400d, 0d);
        public static Unit litrePerDay = new Unit("Litre per Day", 0.001d * 86400d, 0d);
        public static Unit millilitrePerDay = new Unit("Millilitre per Day", 0.000001d * 86400d, 0d);
        public static Unit barrelPerDay = new Unit("Barrel per Day", (((1d / 1.30795061931439d) / 46656d) * 9702d) * 86400d, 0d);
        public static Unit gallonPerDay = new Unit("Gallon (Imperial) per Day", (1d / 219.969248299088d) * 86400d, 0d);
        public static Unit quartPerDay = new Unit("Quart (Imperial) per Day", ((1d / 219.969248299088d) / 4d) * 86400d, 0d);
        public static Unit pintPerDay = new Unit("Pint (Imperial) per Day", ((1d / 219.969248299088d) / 8d) * 86400d, 0d);
        public static Unit cupPerDay = new Unit("Cup (US Customary) per Day", 4226.75283773038d * 86400d, 0d);
        public static Unit tablespoonPerDay = new Unit("Tablespoon (US Customary) per Day", (4226.75283773038d / 16d) * 86400d, 0d);
        public static Unit teaspoonPerDay = new Unit("Teaspoon (US Customary) per Day", (4226.75283773038d / 48d) * 86400d, 0d);
    }

    /// <summary>
    /// Contains 56 flow rate (mass) units
    /// </summary>
    public static class FlowMassUnit
    {
        // Per Second
        public static Unit kilogramPerSecond = new Unit("Kilogram per Second", 1d, 0d);
        public static Unit gramPerSecond = new Unit("Gram per Second", (1d / 1000d), 0d);
        public static Unit caratPerSecond = new Unit("Carat per Second", 0.0002d, 0d);
        public static Unit milligramPerSecond = new Unit("Milligram per Second", (1d / 1000000d), 0d);
        public static Unit microgramPerSecond = new Unit("Microgram per Second", (1d / 1000000000d), 0d);
        public static Unit tonnePerSecond = new Unit("Tonne per Second", 1000d, 0d);
        public static Unit kilotonnePerSecond = new Unit("Kilotonne per Second", 1000000d, 0d);
        public static Unit poundPerSecond = new Unit("Pound per Second", (1d / 2.20462262184878d), 0d);
        public static Unit ouncePerSecond = new Unit("Ounce per Second", ((1d / 2.20462262184878d) / 16d), 0d);
        public static Unit stoneUKPerSecond = new Unit("Stone per Second", ((1d / 2.20462262184878d) * 14d), 0d);
        public static Unit tonShortPerSecond = new Unit("Ton (Short) per Second", ((1d / 2.20462262184878d) * 2000d), 0d);
        public static Unit tonLongPerSecond = new Unit("Ton (Long) per Second", ((1d / 2.20462262184878d) * 2240d), 0d);
        public static Unit kilotonShortPerSecond = new Unit("Kiloton (Short) per Second", ((1d / 2.20462262184878d) * 2000000d), 0d);
        public static Unit kilotonLongPerSecond = new Unit("Kiloton (Long) per Second", ((1d / 2.20462262184878d) * 2240000d), 0d);

        // Per Minute
        public static Unit kilogramPerMinute = new Unit("Kilogram per Minute", 1d * 60d, 0d);
        public static Unit gramPerMinute = new Unit("Gram per Minute", (1d / 1000d) * 60d, 0d);
        public static Unit caratPerMinute = new Unit("Carat per Minute", 0.0002d * 60d, 0d);
        public static Unit milligramPerMinute = new Unit("Milligram per Minute", (1d / 1000000d) * 60d, 0d);
        public static Unit microgramPerMinute = new Unit("Microgram per Minute", (1d / 1000000000d) * 60d, 0d);
        public static Unit tonnePerMinute = new Unit("Tonne per Minute", 1000d * 60d, 0d);
        public static Unit kilotonnePerMinute = new Unit("Kilotonne per Minute", 1000000d * 60d, 0d);
        public static Unit poundPerMinute = new Unit("Pound per Minute", (1d / 2.20462262184878d) * 60d, 0d);
        public static Unit ouncePerMinute = new Unit("Ounce per Minute", ((1d / 2.20462262184878d) / 16d) * 60d, 0d);
        public static Unit stoneUKPerMinute = new Unit("Stone per Minute", ((1d / 2.20462262184878d) * 14d) * 60d, 0d);
        public static Unit tonShortPerMinute = new Unit("Ton (Short) per Minute", ((1d / 2.20462262184878d) * 2000d) * 60d, 0d);
        public static Unit tonLongPerMinute = new Unit("Ton (Long) per Minute", ((1d / 2.20462262184878d) * 2240d) * 60d, 0d);
        public static Unit kilotonShortPerMinute = new Unit("Kiloton (Short) per Minute", ((1d / 2.20462262184878d) * 2000000d) * 60d, 0d);
        public static Unit kilotonLongPerMinute = new Unit("Kiloton (Long) per Minute", ((1d / 2.20462262184878d) * 2240000d) * 60d, 0d);

        // Per Hour
        public static Unit kilogramPerHour = new Unit("Kilogram per Hour", 1d * 3600d, 0d);
        public static Unit gramPerHour = new Unit("Gram per Hour", (1d / 1000d) * 3600d, 0d);
        public static Unit caratPerHour = new Unit("Carat per Hour", 0.0002d * 3600d, 0d);
        public static Unit milligramPerHour = new Unit("Milligram per Hour", (1d / 1000000d) * 3600d, 0d);
        public static Unit microgramPerHour = new Unit("Microgram per Hour", (1d / 1000000000d) * 3600d, 0d);
        public static Unit tonnePerHour = new Unit("Tonne per Hour", 1000d * 3600d, 0d);
        public static Unit kilotonnePerHour = new Unit("Kilotonne per Hour", 1000000d * 3600d, 0d);
        public static Unit poundPerHour = new Unit("Pound per Hour", (1d / 2.20462262184878d) * 3600d, 0d);
        public static Unit ouncePerHour = new Unit("Ounce per Hour", ((1d / 2.20462262184878d) / 16d) * 3600d, 0d);
        public static Unit stoneUKPerHour = new Unit("Stone per Hour", ((1d / 2.20462262184878d) * 14d) * 3600d, 0d);
        public static Unit tonShortPerHour = new Unit("Ton (Short) per Hour", ((1d / 2.20462262184878d) * 2000d) * 3600d, 0d);
        public static Unit tonLongPerHour = new Unit("Ton (Long) per Hour", ((1d / 2.20462262184878d) * 2240d) * 3600d, 0d);
        public static Unit kilotonShortPerHour = new Unit("Kiloton (Short) per Hour", ((1d / 2.20462262184878d) * 2000000d) * 3600d, 0d);
        public static Unit kilotonLongPerHour = new Unit("Kiloton (Long) per Hour", ((1d / 2.20462262184878d) * 2240000d) * 3600d, 0d);

        // Per Day
        public static Unit kilogramPerDay = new Unit("Kilogram per Day", 1d * 86400d, 0d);
        public static Unit gramPerDay = new Unit("Gram per Day", (1d / 1000d) * 86400d, 0d);
        public static Unit caratPerDay = new Unit("Carat per Day", 0.0002d * 86400d, 0d);
        public static Unit milligramPerDay = new Unit("Milligram per Day", (1d / 1000000d) * 86400d, 0d);
        public static Unit microgramPerDay = new Unit("Microgram per Day", (1d / 1000000000d) * 86400d, 0d);
        public static Unit tonnePerDay = new Unit("Tonne per Day", 1000d * 86400d, 0d);
        public static Unit kilotonnePerDay = new Unit("Kilotonne per Day", 1000000d * 86400d, 0d);
        public static Unit poundPerDay = new Unit("Pound per Day", (1d / 2.20462262184878d) * 86400d, 0d);
        public static Unit ouncePerDay = new Unit("Ounce per Day", ((1d / 2.20462262184878d) / 16d) * 86400d, 0d);
        public static Unit stoneUKPerDay = new Unit("Stone per Day", ((1d / 2.20462262184878d) * 14d) * 86400d, 0d);
        public static Unit tonShortPerDay = new Unit("Ton (Short) per Day", ((1d / 2.20462262184878d) * 2000d) * 86400d, 0d);
        public static Unit tonLongPerDay = new Unit("Ton (Long) per Day", ((1d / 2.20462262184878d) * 2240d) * 86400d, 0d);
        public static Unit kilotonShortPerDay = new Unit("Kiloton (Short) per Day", ((1d / 2.20462262184878d) * 2000000d) * 86400d, 0d);
        public static Unit kilotonLongPerDay = new Unit("Kiloton (Long) per Day", ((1d / 2.20462262184878d) * 2240000d) * 86400d, 0d);
    }

    /// <summary>
    /// Contains 14 mass units
    /// </summary>
    public static class MassUnit
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

    /// <summary>
    /// Contains 9 energy units
    /// </summary>
    public static class EnergyUnit
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

    /// <summary>
    /// Contains 22 pressure units
    /// </summary>
    public static class PressureUnit
    {
        public static Unit pascal = new Unit("Pascal [Pa] (S.I. Unit)", 1d, 0d);
        public static Unit hectopascal = new Unit("Hectopascal [hPa]", 100d, 0d);
        public static Unit kilopascal = new Unit("Kilopascal [kPa]", 1000d, 0d);
        public static Unit atmosphere = new Unit("Standard Atmosphere [atm]", 101325d, 0d);
        public static Unit atmosphereTechnical = new Unit("Technical Atmosphere [at]", 98066.5d, 0d);
        public static Unit bar = new Unit("Bar", 100000d, 0d);
        public static Unit kilobar = new Unit("Kilobar [kBar]", 100000000d, 0d);
        public static Unit megabar = new Unit("Megabar [MBar]", 100000000000d, 0d);
        public static Unit decibar = new Unit("Decibar [dBar]", 10000d, 0d);
        public static Unit centibar = new Unit("Centibar", 1000d, 0d);
        public static Unit millibar = new Unit("Millibar", 100d, 0d);
        public static Unit millimetreOfMercury = new Unit("Millimetre of Mercury [mmHg]", 133.322387415d, 0d);
        public static Unit centimetreOfMercury = new Unit("Centimetre of Mercury [cmHg]", 1333.22387415d, 0d);
        public static Unit inchOfMercury = new Unit("Inch of Mercury [inHg]", (133322.387415d * ((1d / 3.280839895d) / 12d)), 0d);
        public static Unit footOfMercury = new Unit("Foot of Mercury [ftHg]", (133322.387415d * (1d / 3.280839895d)), 0d);
        public static Unit millimetreOfWater = new Unit("Millimetre of Water [mmH₂O]", 9.80664857d, 0d);
        public static Unit centimetreOfWater = new Unit("Centimetre of Water [cmH₂O]", 98.0664857d, 0d);
        public static Unit metreOfWater = new Unit("Metre of Water [mH₂O]", 9806.64857d, 0d);
        public static Unit inchOfWater = new Unit("Inch of Water [inH₂O]", (9806.64857d * ((1d / 3.280839895d) / 12d)), 0d);
        public static Unit footOfWater = new Unit("Foot of Water [ftH₂O]", (9806.64857d * (1d / 3.280839895d)), 0d);
        public static Unit psi = new Unit("Pound per Square Inch [PSI]", 6894.75729d, 0d);
        public static Unit torr = new Unit("Torr", (101325d / 760d), 0d);
    }

    /// <summary>
    /// Contains 3 temperature units
    /// </summary>
    public static class TemperatureUnit
    {
        public static Unit kelvin = new Unit("Kelvin [K] (S.I. Unit)", 1d, 0d);
        public static Unit celsius = new Unit("Celsius [°C]", 1d, 273.15d);
        public static Unit fahrenheit = new Unit("Fahrenheit [°F]", (5d / 9d), (459.67d * (5d / 9d)));
    }

    /// <summary>
    /// Contains 15 luminance units
    /// </summary>
    public static class LuminanceUnit
    {
        public static Unit candelaPerSquareMetre = new Unit("Candela per Square Metre [cd/m²] (S.I. Unit)", 1d, 0d);
        public static Unit candelaPerSquareDecimetre = new Unit("Candela per Square Decimetre [cd/dm²]", 100d, 0d);
        public static Unit candelaPerSquareCentimetre = new Unit("Candela per Square Centimetre [cd/cm²]", 10000d, 0d);
        public static Unit candelaPerSquareMillimetre = new Unit("Candela per Square Millimetre [cd/mm²]", 1000000d, 0d);
        public static Unit candelaPerSquareFoot = new Unit("Candela per Square Foot [cd/ft²]", (1d / ((1d / 1.19599004630108d) / 9d)), 0d);
        public static Unit candelaPerSquareInch = new Unit("Candela per Square Inch [cd/in²]", (1d / ((1d / 1.19599004630108d) / 1296d)), 0d);
        public static Unit kilocandelaPerSquareMetre = new Unit("Kilocandela per Square Metre [kcd/m²]", 1000d, 0d);
        public static Unit kilocandelaPerSquareFoot = new Unit("Candela per Square Foot [cd/ft²]", ((1d / ((1d / 1.19599004630108d) / 9d)) * 1000d), 0d);
        public static Unit lambert = new Unit("Lambert [L]", (10000d / 3.1415926535897932384626433832795d), 0d);
        public static Unit footLambert = new Unit("Foot Lambert [fL]", 3.4262590996323d, 0d);
        public static Unit nit = new Unit("Nit", 1d, 0d);
        public static Unit stilb = new Unit("Stilb", 10000d, 0d);
        public static Unit apostilb = new Unit("Apostilb [asb]", (1d / 3.1415926535897932384626433832795d), 0d);
        public static Unit skot = new Unit("Skot [sk]", ((0.001d / 3.1415926535897932384626433832795d)), 0d);
        public static Unit bril = new Unit("Bril", ((0.0000001d / 3.1415926535897932384626433832795d)), 0d);
    }

    /// <summary>
    /// Contains 15 illuminance units
    /// </summary>
    public static class IlluminanceUnit
    {
        public static Unit lux = new Unit("Lux [lx] (S.I. Unit)", 1d, 0d);
        public static Unit kilolux = new Unit("Kilolux [klx]", 1000d, 0d);
        public static Unit megalux = new Unit("Megalux [Mlx]", 1000000d, 0d);
        public static Unit gigalux = new Unit("Gigalux [Glx]", 1000000d, 0d);
        public static Unit millilux = new Unit("Millilux [mlx]", 0.001d, 0d);
        public static Unit microlux = new Unit("Microlux [μlx]", 0.000001d, 0d);
        public static Unit nanolux = new Unit("Nanolux [nlx]", 0.000000001d, 0d);
        public static Unit phot = new Unit("Phot [ph]", 10000d, 0d);
        public static Unit milliphot = new Unit("Milliphot [mph]", 10d, 0d);
        public static Unit nox = new Unit("Nox [nx]", 0.001d, 0d);
        public static Unit lumensPerSquareMetre = new Unit("Lumen per Square Metre [lm/m²]", 1d, 0d);
        public static Unit lumensPerSquareDecimetre = new Unit("Lumen per Square Decimetre [lm/dm²]", 100d, 0d);
        public static Unit lumensPerSquareCentimetre = new Unit("Lumen per Square Centimetre [lm/cm²]", 10000d, 0d);
        public static Unit lumensPerSquareMillimetre = new Unit("Lumen per Square Millimetre [lm/mm²]", 1000000d, 0d);
        public static Unit footCandle = new Unit("Foot-Candle [fc]", (1d / 0.092903043596611d), 0d);
    }

    /// <summary>
    /// Contains 10 angle units
    /// </summary>
    public static class AngleUnit
    {
        public static Unit degree = new Unit("Degree [°]", 1d, 0d);
        public static Unit radian = new Unit("Radian [rad]", ((1d / 3.1415926535897932384626433832795d) * 180d), 0d);
        public static Unit gradian = new Unit("Gradian [ᵍ]", 0.9d, 0d);
        public static Unit second = new Unit("Second", (1d / 3600d), 0d);
        public static Unit minute = new Unit("Minute", (1d / 60d), 0d);
        public static Unit octant = new Unit("Octant", 45d, 0d);
        public static Unit sextant = new Unit("Sextant", 60d, 0d);
        public static Unit quadrant = new Unit("Quadrant", 90d, 0d);
        public static Unit semicircle = new Unit("Semicircle", 180d, 0d);
        public static Unit circle = new Unit("Circle", 360d, 0d);
    }

    /// <summary>
    /// Contains 6 data size units
    /// </summary>
    public static class DataSizeUnit
    {
        public static Unit sizeByte = new Unit("Byte [B]", 1d, 0d);
        public static Unit sizeKilobyte = new Unit("Kilobyte [kb]", 1024d, 0d);
        public static Unit sizeMegabyte = new Unit("Megabyte [MB]", 1048576d, 0d);
        public static Unit sizeGigabyte = new Unit("Gigabyte [GB]", 1073741824d, 0d);
        public static Unit sizeTerabyte = new Unit("Terabyte [TB]", 1099511627776d, 0d);
        public static Unit sizePetabyte = new Unit("Petabyte [PB]", 1125899906842624d, 0d);
    }
}