using System.Collections.Generic;

namespace Unit_Converter
{
    /// <summary>
    /// Class definition that is the basis for units used in the converter.
    /// <para>
    /// The user should define the gradient and the y-intercept of a unit
    /// relative to the S.I. unit for the unit type of the unit to be defined.
    /// </para>
    /// <para>
    /// S.I. Value = Gradient * User Input + Intercept
    /// </para>
    /// </summary>
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

        public string GetName()
        {
            return name;
        }

        public double GetGradient()
        {
            return gradient;
        }

        public double GetIntercept()
        {
            return intercept;
        }

        public double ConvertToSiValue(double value)
        {
            return (value * gradient + intercept);
        }

        public double ConvertFromSiValue(double value)
        {
            return ((value - intercept) / gradient);
        }
    }

    // CUSTOM UNITS
    /// <summary>
    /// Base class for all custom units
    /// </summary>
    public class CustomBaseUnits
    {
        private List<Unit> unitList = new List<Unit>();

        /// <summary>
        /// Add the input custom unit to the object.
        /// </summary>
        public void AddUnit(Unit unit)
        {
            unitList.Add(unit);
        }

        /// <summary>
        /// Remove the input custom unit from the object.
        /// </summary>
        public void RemoveUnit(Unit unit)
        {
            unitList.Remove(unit);
        }

        /// <summary>
        /// Modify the input custom unit in the object.
        /// <para>
        /// Takes three parameters: the unit object, the new gradient and
        /// the new intercept.
        /// </para>
        /// </summary>
        public void UpdateUnit(Unit unit, double newGradient, double newIntercept)
        {
            string name = unit.GetName();
            RemoveUnit(unit);
            Unit newUnit = new Unit(name, newGradient, newIntercept);
            AddUnit(newUnit);
        }

        /// <summary>
        /// Remove a list of all units contained in the object.
        /// </summary>
        public List<Unit> ListUnits()
        {
            return unitList;
        }
    }
}
