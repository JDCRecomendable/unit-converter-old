namespace Unit_Converter
{
    /// <summary>
    /// Static class that contains all properties for use with the
    /// message box that shows up when the user inputs invalid
    /// input(s) in the AddCustomUnit box.
    /// </summary>
    public static class AddCustomUnitInvalidInputMessageBoxProperty
    {
        public static string message = ("You have entered one or more " +
            "invalid inputs! \r\n\r\nPlease check that all mandatory " +
            "fields have been filled up and that any field with " +
            "information is filled up with appropriate values.");
        public static string caption = "Invalid Input(s)";
    }

    public static class DeleteCustomUnitInvalidInputMessageBoxProperty
    {
        public static string message = ("You have entred an invalid " +
            "input!\r\n\r\nPlease check that the dropdown box has been " + 
            "filled up with the unit that you wish to delete.");
        public static string caption = "Invalid Input";
    }
}