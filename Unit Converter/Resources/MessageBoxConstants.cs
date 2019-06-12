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
            "invalid inputs! \r\n\r\nPlease check that all mandatory " +
            "fields have been filled up and that any field with " +
            "information is filled up with appropriate values.");
        public static string caption = "Invalid Input(s)";
    }
}