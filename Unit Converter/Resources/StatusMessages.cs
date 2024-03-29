﻿namespace Unit_Converter
{
    /// <summary>
    /// Static class that contains all strings for use with the status
    /// indicator at the bottom of the main form.
    /// </summary>
    public static class StatusMessage
    {
        // Calculation messages
        public const string ready = "Ready";
        public const string done = "Done";
        public const string invalidInput = "Invalid input!";
        public const string unitTypeError = "Error: Invalid unit type! Restart application.";
        public const string unitError = "No or invalid unit(s) selected!";

        // Unit swap messages
        public const string swapped = "Swapped";
        public const string invalidSwap = "Invalid swap!";

        // Round-off value messages
        public const string roundOffValueSet = "Round-off value set";

        // Custo units messages
        public const string customUnitAdded = "Custom unit added";
        public const string customUnitDeleted = "Custom unit deleted";

        // Colours
        public static System.Drawing.Color errorColour = System.Drawing.Color.FromArgb(192, 0, 0);
        public static System.Drawing.Color standardColour = System.Drawing.Color.FromArgb(210, 90, 0);
        public static System.Drawing.Color positiveColour = System.Drawing.Color.FromArgb(0, 128, 0);
    }
}
