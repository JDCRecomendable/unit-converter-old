namespace Unit_Converter
{
    public class BaseUnit
    {
        private readonly string name;
        private readonly double siValue;

        public BaseUnit(string pName, double pSiValue)
        {
            name = pName;
            siValue = pSiValue;
        }

        public string getName()
        {
            return name;
        }

        public double convertToSiValue(double value)
        {
            return (value * siValue);
        }

        public double convertFromSiValue(double value)
        {
            return (value / siValue);
        }
    }

    public class TemperatureUnit
    {
        private readonly string name;

        public TemperatureUnit(string pName)
        {
            name = pName;
        }

        public string getName()
        {
            return name;
        }
    }
}
