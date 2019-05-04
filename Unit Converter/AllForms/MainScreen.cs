using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            this.ActiveControl = lengthFromUnitInput;
            lengthFromUnitInput.Focus();

            // Detect if unit type changed (tab changed)
            unitSelector.SelectedIndexChanged += new EventHandler(unitSelector_SelectedIndexChanged);
        }

        // Open the About box to show the application credits
        private void aboutUnitConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        // Close the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainArea_Paint(object sender, PaintEventArgs e)
        {

        }

        // Initialise the MainScreen form
        private void MainScreen_Load(object sender, EventArgs e)
        {
            // Add items to LengthFromUnit combo box
            lengthFromUnitInput.Items.Add(LengthConversion.metre);
            lengthFromUnitInput.Items.Add(LengthConversion.kilometre);
            lengthFromUnitInput.Items.Add(LengthConversion.decimetre);
            lengthFromUnitInput.Items.Add(LengthConversion.centimetre);
            lengthFromUnitInput.Items.Add(LengthConversion.millimetre);
            lengthFromUnitInput.Items.Add(LengthConversion.yard);
            lengthFromUnitInput.Items.Add(LengthConversion.foot);
            lengthFromUnitInput.Items.Add(LengthConversion.inch);

            // Add items to LengthToUnit combo box
            lengthToUnitOutput.Items.Add(LengthConversion.metre);
            lengthToUnitOutput.Items.Add(LengthConversion.kilometre);
            lengthToUnitOutput.Items.Add(LengthConversion.decimetre);
            lengthToUnitOutput.Items.Add(LengthConversion.centimetre);
            lengthToUnitOutput.Items.Add(LengthConversion.millimetre);
            lengthToUnitOutput.Items.Add(LengthConversion.yard);
            lengthToUnitOutput.Items.Add(LengthConversion.foot);
            lengthToUnitOutput.Items.Add(LengthConversion.inch);


            // Add items to AreaFromUnit combo box
            areaFromUnitInput.Items.Add(AreaConversion.squareMetre);
            areaFromUnitInput.Items.Add(AreaConversion.squareKilometre);
            areaFromUnitInput.Items.Add(AreaConversion.squareDecimetre);
            areaFromUnitInput.Items.Add(AreaConversion.squareCentimetre);
            areaFromUnitInput.Items.Add(AreaConversion.squareMillimetre);
            areaFromUnitInput.Items.Add(AreaConversion.squareYard);
            areaFromUnitInput.Items.Add(AreaConversion.squareFoot);
            areaFromUnitInput.Items.Add(AreaConversion.squareInch);
            areaFromUnitInput.Items.Add(AreaConversion.acre);
            areaFromUnitInput.Items.Add(AreaConversion.are);
            areaFromUnitInput.Items.Add(AreaConversion.hectare);

            // Add items to AreaToUnit combo box
            areaToUnitOutput.Items.Add(AreaConversion.squareMetre);
            areaToUnitOutput.Items.Add(AreaConversion.squareKilometre);
            areaToUnitOutput.Items.Add(AreaConversion.squareDecimetre);
            areaToUnitOutput.Items.Add(AreaConversion.squareCentimetre);
            areaToUnitOutput.Items.Add(AreaConversion.squareMillimetre);
            areaToUnitOutput.Items.Add(AreaConversion.squareYard);
            areaToUnitOutput.Items.Add(AreaConversion.squareFoot);
            areaToUnitOutput.Items.Add(AreaConversion.squareInch);
            areaToUnitOutput.Items.Add(AreaConversion.acre);
            areaToUnitOutput.Items.Add(AreaConversion.are);
            areaToUnitOutput.Items.Add(AreaConversion.hectare);


            // Add items to VolumeFromUnit combo box
            volumeFromUnitInput.Items.Add(VolumeConversion.cubicMetre);
            volumeFromUnitInput.Items.Add(VolumeConversion.cubicCentimetre);
            volumeFromUnitInput.Items.Add(VolumeConversion.cubicMillimetre);
            volumeFromUnitInput.Items.Add(VolumeConversion.cubicYard);
            volumeFromUnitInput.Items.Add(VolumeConversion.cubicFoot);
            volumeFromUnitInput.Items.Add(VolumeConversion.cubicInch);
            volumeFromUnitInput.Items.Add(VolumeConversion.litre);
            volumeFromUnitInput.Items.Add(VolumeConversion.millilitre);
            volumeFromUnitInput.Items.Add(VolumeConversion.gallon);
            volumeFromUnitInput.Items.Add(VolumeConversion.quart);
            volumeFromUnitInput.Items.Add(VolumeConversion.pint);
            volumeFromUnitInput.Items.Add(VolumeConversion.cup);
            volumeFromUnitInput.Items.Add(VolumeConversion.tablespoon);
            volumeFromUnitInput.Items.Add(VolumeConversion.teaspoon);

            // Add items to VolumeToUnit combo box
            volumeToUnitOutput.Items.Add(VolumeConversion.cubicMetre);
            volumeToUnitOutput.Items.Add(VolumeConversion.cubicCentimetre);
            volumeToUnitOutput.Items.Add(VolumeConversion.cubicMillimetre);
            volumeToUnitOutput.Items.Add(VolumeConversion.cubicYard);
            volumeToUnitOutput.Items.Add(VolumeConversion.cubicFoot);
            volumeToUnitOutput.Items.Add(VolumeConversion.cubicInch);
            volumeToUnitOutput.Items.Add(VolumeConversion.litre);
            volumeToUnitOutput.Items.Add(VolumeConversion.millilitre);
            volumeToUnitOutput.Items.Add(VolumeConversion.gallon);
            volumeToUnitOutput.Items.Add(VolumeConversion.quart);
            volumeToUnitOutput.Items.Add(VolumeConversion.pint);
            volumeToUnitOutput.Items.Add(VolumeConversion.cup);
            volumeToUnitOutput.Items.Add(VolumeConversion.tablespoon);
            volumeToUnitOutput.Items.Add(VolumeConversion.teaspoon);
        }

        private void lengthCalculateButton_Click(object sender, EventArgs e)
        {
            ExecuteCalculation();
        }

        private void lengthFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void areaFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void volumeFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void timeFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void speedFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void massFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void energyFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void powerFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        private void dataSizeFromValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteCalculation();
        }

        // Execute the calculation process
        private void ExecuteCalculation()
        {
            string rawValue;         // raw data from the user-inputtable text box
            double inputValue;       // processed data from the user-inputtable text box
            bool canParse;           // shows whether raw user input data can be parsed to double
            bool unitError = false;  // shows if the user has not selected a unit for both from and or combo boxes

            // User wants to convert length
            if (unitSelector.SelectedIndex == 0)
            {
                double lengthValue = 0;
                double resultLengthValue = 0;

                rawValue = lengthFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.metre)
                        lengthValue = inputValue;
                    else if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.kilometre)
                        lengthValue = inputValue * LengthConversion.kilometreToMetreValue;
                    else if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.decimetre)
                        lengthValue = inputValue * LengthConversion.decimetreToMetreValue;
                    else if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.centimetre)
                        lengthValue = inputValue * LengthConversion.centimetreToMetreValue;
                    else if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.millimetre)
                        lengthValue = inputValue * LengthConversion.millimetreToMetreValue;
                    else if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.yard)
                        lengthValue = inputValue * LengthConversion.yardToMetreValue;
                    else if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.foot)
                        lengthValue = inputValue * LengthConversion.footToMetreValue;
                    else if ((string)lengthFromUnitInput.SelectedItem == LengthConversion.inch)
                        lengthValue = inputValue * LengthConversion.inchToMetreValue;
                    else
                        unitError = true;

                    if (((string)lengthToUnitOutput.SelectedItem == LengthConversion.metre) && (unitError == false))
                        resultLengthValue = lengthValue;
                    else if ((string)lengthToUnitOutput.SelectedItem == LengthConversion.kilometre)
                        resultLengthValue = lengthValue * LengthConversion.metreToKilometreValue;
                    else if ((string)lengthToUnitOutput.SelectedItem == LengthConversion.decimetre)
                        resultLengthValue = lengthValue * LengthConversion.metreToDecimetreValue;
                    else if ((string)lengthToUnitOutput.SelectedItem == LengthConversion.centimetre)
                        resultLengthValue = lengthValue * LengthConversion.metreToCentimetreValue;
                    else if ((string)lengthToUnitOutput.SelectedItem == LengthConversion.millimetre)
                        resultLengthValue = lengthValue * LengthConversion.metreToMillimetreValue;
                    else if ((string)lengthToUnitOutput.SelectedItem == LengthConversion.yard)
                        resultLengthValue = lengthValue * LengthConversion.metreToYardValue;
                    else if ((string)lengthToUnitOutput.SelectedItem == LengthConversion.foot)
                        resultLengthValue = lengthValue * LengthConversion.metreToFootValue;
                    else if ((string)lengthToUnitOutput.SelectedItem == LengthConversion.inch)
                        resultLengthValue = lengthValue * LengthConversion.metreToInchValue;
                    else
                        unitError = true;

                    if (unitError == false)
                    {
                        lengthToValueOutput.Text = resultLengthValue.ToString();
                        statusIndicator.Text = StatusMessages.done;
                    }
                    else
                        statusIndicator.Text = StatusMessages.unitError;
                }
                else
                    statusIndicator.Text = StatusMessages.invalidInput;
            }

            // User wants to convert area
            else if (unitSelector.SelectedIndex == 1)
            {
                double areaValue = 0;
                double resultAreaValue = 0;

                rawValue = areaFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareMetre)
                        areaValue = inputValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareKilometre)
                        areaValue = inputValue * AreaConversion.squareKilometreToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareDecimetre)
                        areaValue = inputValue * AreaConversion.squareDecimetreToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareCentimetre)
                        areaValue = inputValue * AreaConversion.squareCentimetreToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareMillimetre)
                        areaValue = inputValue * AreaConversion.squareMillimetreToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareYard)
                        areaValue = inputValue * AreaConversion.squareYardToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareFoot)
                        areaValue = inputValue * AreaConversion.squareFootToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.squareInch)
                        areaValue = inputValue * AreaConversion.squareInchToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.acre)
                        areaValue = inputValue * AreaConversion.acreToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.are)
                        areaValue = inputValue * AreaConversion.areToSquareMetreValue;
                    else if ((string)areaFromUnitInput.SelectedItem == AreaConversion.hectare)
                        areaValue = inputValue * AreaConversion.hectareToSquareMetreValue;
                    else
                        unitError = true;

                    if (((string)areaToUnitOutput.SelectedItem == AreaConversion.squareMetre) && (unitError == false))
                        resultAreaValue = areaValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareKilometre)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToSquareKilometreValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareDecimetre)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToSquareDecimetreValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareCentimetre)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToSquareCentimetreValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareMillimetre)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToSquareMillimetreValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareYard)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToSquareYardValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareFoot)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToSquareFootValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.squareInch)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToSquareInchValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.acre)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToAcreValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.are)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToAreValue;
                    else if ((string)areaToUnitOutput.SelectedItem == AreaConversion.hectare)
                        resultAreaValue = areaValue * AreaConversion.squareMetreToHectareValue;
                    else
                        unitError = true;

                    if (unitError == false)
                    {
                        areaToValueOutput.Text = resultAreaValue.ToString();
                        statusIndicator.Text = StatusMessages.done;
                    }
                    else
                        statusIndicator.Text = StatusMessages.unitError;
                }
                else
                    statusIndicator.Text = StatusMessages.invalidInput;
            }

            // User wants to convert volume
            else if (unitSelector.SelectedIndex == 2)
            {
                double volumeValue = 0;
                double resultVolumeValue = 0;

                rawValue = volumeFromValueInput.Text;
                canParse = double.TryParse(rawValue, result: out inputValue);

                if (canParse)
                {
                    if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.cubicMetre)
                        volumeValue = inputValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.cubicCentimetre)
                        volumeValue = inputValue * VolumeConversion.cubicCentimetreToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.cubicMillimetre)
                        volumeValue = inputValue * VolumeConversion.cubicMillimetreToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.cubicYard)
                        volumeValue = inputValue * VolumeConversion.cubicYardToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.cubicFoot)
                        volumeValue = inputValue * VolumeConversion.cubicFootToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.cubicInch)
                        volumeValue = inputValue * VolumeConversion.cubicInchToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.litre)
                        volumeValue = inputValue * VolumeConversion.litreToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.millilitre)
                        volumeValue = inputValue * VolumeConversion.millilitreToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.gallon)
                        volumeValue = inputValue * VolumeConversion.gallonToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.quart)
                        volumeValue = inputValue * VolumeConversion.quartToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.pint)
                        volumeValue = inputValue * VolumeConversion.pintToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.cup)
                        volumeValue = inputValue * VolumeConversion.cupToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.tablespoon)
                        volumeValue = inputValue * VolumeConversion.tablespoonToCubicMetreValue;
                    else if ((string)volumeFromUnitInput.SelectedItem == VolumeConversion.teaspoon)
                        volumeValue = inputValue * VolumeConversion.teaspoonToCubicMetreValue;
                    else
                        unitError = true;

                    if (((string)volumeToUnitOutput.SelectedItem == VolumeConversion.cubicMetre) && (unitError == false))
                        resultVolumeValue = volumeValue;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.cubicCentimetre)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToCubicCentimetre;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.cubicMillimetre)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToCubicMillimetre;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.cubicYard)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToCubicYard;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.cubicFoot)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToCubicFoot;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.cubicInch)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToCubicInch;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.litre)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToLitre;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.millilitre)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToMillilitre;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.gallon)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToGallon;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.quart)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToQuart;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.pint)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToPint;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.cup)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToCup;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.tablespoon)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToTablespoon;
                    else if ((string)volumeToUnitOutput.SelectedItem == VolumeConversion.teaspoon)
                        resultVolumeValue = volumeValue * VolumeConversion.cubicMetreToTeaspoon;
                    else
                        unitError = true;

                    if (unitError == false)
                    {
                        volumeToValueOutput.Text = resultVolumeValue.ToString();
                        statusIndicator.Text = StatusMessages.done;
                    }
                    else
                        statusIndicator.Text = StatusMessages.unitError;
                }
                else
                    statusIndicator.Text = StatusMessages.invalidInput;
            }

            // Somehow, the currently selected tab does not exist!
            else
                statusIndicator.Text = StatusMessages.unitTypeError;
        }

        // Indicate to user converter is ready when unit type is changed (tab is changed)
        private void unitSelector_SelectedIndexChanged(Object sender, EventArgs e)
        {
            statusIndicator.Text = StatusMessages.ready;
        }
    }

    public static class StatusMessages
    {
        public const string ready = "Ready";
        public const string done = "Done";
        public const string invalidInput = "Invalid input!";
        public const string unitTypeError = "Error: Invalid unit type! Restart application.";
        public const string unitError = "No unit(s) selected!";
    }

    public static class LengthConversion
    {
        // Strings
        public const string metre = "Metre [m] (S.I. Unit)";
        public const string kilometre = "Kilometre [km]";
        public const string decimetre = "Decimetre [dm]";
        public const string centimetre = "Centimetre [cm]";
        public const string millimetre = "Millimetre [mm]";
        public const string yard = "Yard [yd]";
        public const string foot = "Foot [ft]";
        public const string inch = "Inch [in]";

        // To S.I. Unit (credits to https://www.rapidtables.com/convert/length/)
        public const double kilometreToMetreValue = 1000d;
        public const double decimetreToMetreValue = 0.1d;
        public const double centimetreToMetreValue = 0.01d;
        public const double millimetreToMetreValue = 0.001d;
        public const double yardToMetreValue = (1d / 3.280839895d) * 3d;
        public const double footToMetreValue = 1d / 3.280839895d;
        public const double inchToMetreValue = (1d / 3.280839895d) / 12d;

        // From S.I. Unit (credits to https://www.rapidtables.com/convert/length/)
        public const double metreToKilometreValue = 0.001d;
        public const double metreToDecimetreValue = 10d;
        public const double metreToCentimetreValue = 100d;
        public const double metreToMillimetreValue = 1000d;
        public const double metreToYardValue = 3.280839895d / 3d;
        public const double metreToFootValue = 3.280839895d;
        public const double metreToInchValue = 3.280839895d * 12d;
    }

    public static class AreaConversion
    {
        // Strings
        public const string squareMetre = "Square Metre [m²] (S.I. Unit)";
        public const string squareKilometre = "Square Kilometre [km²]";
        public const string squareDecimetre = "Square Decimetre [dm²]";
        public const string squareCentimetre = "Square Centimetre [cm²]";
        public const string squareMillimetre = "Square Millimetre [mm²]";
        public const string squareYard = "Square Yard [yd²]";
        public const string squareFoot = "Square Foot [ft²]";
        public const string squareInch = "Square Inch [in²]";
        public const string acre = "Acre [ac]";
        public const string are = "Are [a]";
        public const string hectare = "Hectare [ha]";

        // To S.I. Unit
        public const double squareKilometreToSquareMetreValue = 1000000d;
        public const double squareDecimetreToSquareMetreValue = 0.01d;
        public const double squareCentimetreToSquareMetreValue = 0.0001d;
        public const double squareMillimetreToSquareMetreValue = 0.00000d;
        public const double squareYardToSquareMetreValue = 1d / 1.19599004630108d;
        public const double squareFootToSquareMetreValue = (1d / 1.19599004630108d) / 9d;
        public const double squareInchToSquareMetreValue = (1d / 1.19599004630108d) / 1296d;
        public const double acreToSquareMetreValue = 0.8361273574d * 4840d;
        public const double areToSquareMetreValue = 100d;
        public const double hectareToSquareMetreValue = 10000d;

        // From S.I. Unit
        public const double squareMetreToSquareKilometreValue = 1d / 1000000d;
        public const double squareMetreToSquareDecimetreValue = 1d / 0.01d;
        public const double squareMetreToSquareCentimetreValue = 1d / 0.0001d;
        public const double squareMetreToSquareMillimetreValue = 1d / 0.00000d;
        public const double squareMetreToSquareYardValue = 1.19599004630108d;
        public const double squareMetreToSquareFootValue = 1.19599004630108d * 9d;
        public const double squareMetreToSquareInchValue = 1.19599004630108d * 1296d;
        public const double squareMetreToAcreValue = 1d / (0.8361273574d * 4840d);
        public const double squareMetreToAreValue = 1d / 100d;
        public const double squareMetreToHectareValue = 1d / 10000d;
    }

    public static class VolumeConversion
    {
        // Strings
        public const string cubicMetre = "Cubic Metre [m³] (S.I. Unit)";
        public const string cubicCentimetre = "Cubic Centimetre [cm³]";
        public const string cubicMillimetre = "Cubic Millimetre [mm³]";
        public const string cubicYard = "Cubic Yard [yd³]";
        public const string cubicFoot = "Cubic Foot [ft³]";
        public const string cubicInch = "Cubic Inch [in³]";
        public const string litre = "Litre [L]";
        public const string millilitre = "Millilitre [mL]";
        public const string gallon = "Gallon (Imperial)";
        public const string quart = "Quart (Imperial)";
        public const string pint = "Pint (Imperial)";
        public const string cup = "Cup (US Customary)";
        public const string tablespoon = "Tablespoon (US Customary)";
        public const string teaspoon = "Teaspoon (US Customary)";

        // To S.I. Unit
        public const double cubicCentimetreToCubicMetreValue = 0.000001d;
        public const double cubicMillimetreToCubicMetreValue = 0.000000001d;
        public const double cubicYardToCubicMetreValue = 1d / 1.30795061931439d;
        public const double cubicFootToCubicMetreValue = (1d / 1.30795061931439d) / 27d;
        public const double cubicInchToCubicMetreValue = (1d / 1.30795061931439d) / 46656d;
        public const double litreToCubicMetreValue = 0.001d;
        public const double millilitreToCubicMetreValue = 0.000001d;
        public const double gallonToCubicMetreValue = 1d / 219.969248299088d;
        public const double quartToCubicMetreValue = (1d / 219.969248299088d) / 4d;
        public const double pintToCubicMetreValue = (1d / 219.969248299088d) / 8d;
        public const double cupToCubicMetreValue = 4226.75283773038d;
        public const double tablespoonToCubicMetreValue = 4226.75283773038d / 16d;
        public const double teaspoonToCubicMetreValue = 4226.75283773038d / 48d;

        // From S.I. Unit
        public const double cubicMetreToCubicCentimetre = 1000000d;
        public const double cubicMetreToCubicMillimetre = 1000000000d;
        public const double cubicMetreToCubicYard = 1.30795061931439d;
        public const double cubicMetreToCubicFoot = 1.30795061931439d * 27d;
        public const double cubicMetreToCubicInch = 1.30795061931439d * 46656d;
        public const double cubicMetreToLitre = 1000d;
        public const double cubicMetreToMillilitre = 1000000d;
        public const double cubicMetreToGallon = 219.969248299088d;
        public const double cubicMetreToQuart = 219.969248299088d * 4d;
        public const double cubicMetreToPint = 219.969248299088d * 8d;
        public const double cubicMetreToCup = 1d / 4226.75283773038d;
        public const double cubicMetreToTablespoon = (1d / 4226.75283773038d) * 16d;
        public const double cubicMetreToTeaspoon = (1d / 4226.75283773038d) * 48d;
    }
}
