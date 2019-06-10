namespace Unit_Converter
{
    /// <summary>
    /// Static class that contains all properties for use with the
    /// message box that shows up when the user inputs invalid
    /// input(s) in the AddCustomUnit box.
    /// </summary>
    public static class InvalidInputMessageBoxProperty
    {
        public static string message = ("You have entered one or more " +
            "invalid inputs! \r\n\r\nPlease check that the mandatory input " +
            "boxes have been filled up with the appropriate values.");
        public static string caption = "Invalid Input(s)";
    }
}