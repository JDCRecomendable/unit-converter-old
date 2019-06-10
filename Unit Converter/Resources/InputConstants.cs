namespace Unit_Converter
{
    /// <summary>
    /// Static class that defines the colour properties of all inputs
    /// when it is empty and when it is not
    /// </summary>
    public static class InputColour {
        public static System.Drawing.Color emptyColour = System.Drawing.Color.LightGray;
        public static System.Drawing.Color standardColour = System.Drawing.Color.White;
    }

    /// <summary>
    /// Static class that defines the text properties of all inputs
    /// when it is empty and when it is not
    /// </summary>
    public static class InputText
    {
        public const string standardString = "";

        public const string fromValueInputEmptyString = "Type your input here...";
        public const string nameCustomUnitInputEmptyString = "Metre";
        public const string gradientUnitInputEmptyString = "1";
        public const string interceptUnitInputEmptyString = "0";
    }
}