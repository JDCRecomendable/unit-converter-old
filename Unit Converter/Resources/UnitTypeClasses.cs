using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    public class BaseUnit
    {
        protected string name;
        protected double siValue;

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

    public class LengthUnit : BaseUnit
    {
        public LengthUnit(string pName, double pSiValue)
        {
            name = pName;
            siValue = pSiValue;
        }
    }

    public class AreaUnit : BaseUnit
    {
        public AreaUnit(string pName, double pSiValue)
        {
            name = pName;
            siValue = pSiValue;
        }
    }

    public class VolumeUnit : BaseUnit
    {
        public VolumeUnit(string pName, double pSiValue)
        {
            name = pName;
            siValue = pSiValue;
        }
    }

    public class TimeUnit : BaseUnit
    {
        public TimeUnit(string pName, double pSiValue)
        {
            name = pName;
            siValue = pSiValue;
        }
    }

    public class SpeedUnit : BaseUnit
    {
        public SpeedUnit(string pName, double pSiValue)
        {
            name = pName;
            siValue = pSiValue;
        }
    }

    public class MassUnit : BaseUnit
    {
        public MassUnit(string pName, double pSiValue)
        {
            name = pName;
            siValue = pSiValue;
        }
    }

    public class EnergyUnit : BaseUnit
    {
        public EnergyUnit(string pName, double pSiValue)
        {
            name = pName;
            siValue = pSiValue;
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

    public class DataSizeUnit : BaseUnit
    {
        public DataSizeUnit(string pName, double pSiValue)
        {
            name = pName;
            siValue = pSiValue;
        }
    }
}
