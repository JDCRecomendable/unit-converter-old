namespace Unit_Converter
{
    /// <summary>
    /// Static class that defines the colour properties of all inputs
    /// when it is empty and when it is not
    /// </summary>
    public static class InputColour {
        public static System.Drawing.Color emptyColour = System.Drawing.Color.DarkGray;
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
        public const string customNameUnitInputEmptyString = "E.g. Metre";
        public const string gradientUnitInputEmptyString = "E.g. 1";
        public const string interceptUnitInputEmptyString = "E.g. 0";
    }
}