namespace Unit_Converter
{
    public class Unit
    {
        private readonly string name;
        private readonly double gradient;
        private readonly double intercept;

        public Unit(string pName, double pGradient, double pIntercept)
        {
            name = pName;
            gradient = pGradient;
            intercept = pIntercept;
        }

        public string getName()
        {
            return name;
        }

        public double convertToSiValue(double value)
        {
            return (value * gradient + intercept);
        }

        public double convertFromSiValue(double value)
        {
            return ((value - intercept) / gradient);
        }
    }
}
