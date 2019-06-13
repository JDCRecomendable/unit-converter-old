using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class AddCustomUnitsBox : Form
    {
        private MainScreen mainScreen;

        public AddCustomUnitsBox(MainScreen pMainScreen)
        {
            InitializeComponent();

            // To enable this form to call public functions
            // from the main screen
            mainScreen = pMainScreen;

            // Set initially active control of the form
            ResetFocus();

            // Reset the input boxes during initialisation
            SetInputBoxToDefault(customUnitNameInput, true);
            SetInputBoxToDefault(gradientUnitInput, true);
            SetInputBoxToDefault(interceptUnitInput, true);
        }

        // INITIALISATION - Reset focus of the controls
        private void ResetFocus()
        {
            this.ActiveControl = unitSelectorCustomUnitTable;
            unitSelectorCustomUnitTable.Focus();
            unitSelectorCustomUnitTable.SelectedIndex = 0;
        }

        // INITIALISATION - Define indicator when any of the input boxes
        // is empty
        bool customUnitNameIsEmpty = true;
        bool gradientUnitInputIsEmpty = true;
        bool interceptUnitInputIsEmpty = true;

        // INITIALISATION - Define the list that contains the user controls
        List<TextBox> textBoxes = new List<TextBox>();

        // INITIALISATION - Load elements to main screen controls
        private void AddCustomUnitsScreen_Load(object sender, EventArgs e)
        {
            // Text Boxes
            textBoxes.Add(customUnitNameInput);
            textBoxes.Add(gradientUnitInput);
            textBoxes.Add(interceptUnitInput);
        }

        // CONTROLS - Helper function to set input box text properties when it
        // gains or loses focus
        private void SetInputBoxToDefault(TextBox textBox, bool reset)
        {
            if (reset)
            {
                if (textBox == customUnitNameInput)
                {
                    textBox.Text = InputText.customNameUnitInputEmptyString;
                    customUnitNameIsEmpty = true;
                }
                else if (textBox == gradientUnitInput)
                {
                    textBox.Text = InputText.gradientUnitInputEmptyString;
                    gradientUnitInputIsEmpty = true;
                }
                else if (textBox == interceptUnitInput)
                {
                    textBox.Text = InputText.interceptUnitInputEmptyString;
                    interceptUnitInputIsEmpty = true;
                }
                textBox.ForeColor = InputColour.emptyColour;
            }
            else
            {
                textBox.Text = InputText.standardString;
                textBox.ForeColor = InputColour.standardColour;
                if (textBox == customUnitNameInput)
                    customUnitNameIsEmpty = false;
                else if (textBox == gradientUnitInput)
                    gradientUnitInputIsEmpty = false;
                else if (textBox == interceptUnitInput)
                    interceptUnitInputIsEmpty = false;
            }
        }

        // CONTROLS - Do when customUnitNameInput gains focus
        private void customUnitNameInput_Enter(object sender, EventArgs e)
        {
            if (customUnitNameIsEmpty)
                SetInputBoxToDefault(customUnitNameInput, false);
        }

        // CONTROLS - Do when customUnitNameInput loses focus
        private void customUnitNameInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customUnitNameInput.Text))
                SetInputBoxToDefault(customUnitNameInput, true);
        }

        // CONTROLS - Do when gradientUnitInput gains focus
        private void gradientUnitInput_Enter(object sender, EventArgs e)
        {
            if (gradientUnitInputIsEmpty)
                SetInputBoxToDefault(gradientUnitInput, false);
        }

        // CONTROLS - Do when gradientUnitInput loses focus
        private void gradientUnitInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(gradientUnitInput.Text))
                SetInputBoxToDefault(gradientUnitInput, true);
        }

        // CONTROLS - Do when interceptUnitInput gains focus
        private void interceptUnitInput_Enter(object sender, EventArgs e)
        {
            if (interceptUnitInputIsEmpty)
                SetInputBoxToDefault(interceptUnitInput, false);
        }

        // CONTROLS - Do when interceptUnitInput loses focus
        private void interceptUnitInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(interceptUnitInput.Text))
                SetInputBoxToDefault(interceptUnitInput, true);
        }

        // UNIT TYPE EVENTS - Helper function to add units in the combo box
        private void AddComboBoxValues(List<Unit> unitList)
        {
            foreach (Unit element in unitList)
                compareUnitInput.Items.Add(element.GetName());
        }

        // UNIT TYPE EVENTS - Helper function to clear all text boxes (except
        // custom unit name)
        private void ResetTextBoxes()
        {
            foreach (TextBox textBox in textBoxes)
            {
                SetInputBoxToDefault(textBox, true);
            }
        }

        // UNIT TYPE EVENTS - Helper function to update local combo box
        private void UpdateComboBox()
        {
            List<Unit> unitList = new List<Unit>();

            compareUnitInput.Items.Clear();

            unitList.AddRange(mainScreen.GetAllUnits((short)unitSelectorCustomUnitTable.SelectedIndex));
            AddComboBoxValues(unitList);
        }

        // UNIT TYPE EVENTS - Do when unit type is changed
        private void unitSelectorCustomUnitTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBox();
            ResetTextBoxes();
        }

        // MAIN EVENTS - Close the form when user clicks cancel
        private void cancelAddCustomUnitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // MAIN EVENTS - Helper function to add custom unit
        private bool AddCustomUnit()
        {
            bool isError = false;
            bool gradientIsValid = double.TryParse(gradientUnitInput.Text, result: out double gradient);
            bool interceptIsValid = double.TryParse(interceptUnitInput.Text, result: out double intercept);

            if (customUnitNameIsEmpty ||
                compareUnitInput.SelectedIndex == -1 ||
                !gradientIsValid ||
                (!interceptUnitInputIsEmpty &&
                !interceptIsValid))
            {
                MessageBox.Show(AddCustomUnitInvalidInputMessageBoxProperty.message,
                    AddCustomUnitInvalidInputMessageBoxProperty.caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                isError = true;
            }
            else
            {
                List<Unit> units = new List<Unit>();
                double rGradient = 0;
                double rIntercept = 0;

                short unitTypeIndex = (short)unitSelectorCustomUnitTable.SelectedIndex;
                units.AddRange(mainScreen.GetAllUnits(unitTypeIndex));

                foreach (Unit unit in units)
                {
                    if (unit.GetName() == (string)compareUnitInput.SelectedItem)
                    {
                        rGradient = unit.GetGradient();
                        rIntercept = unit.GetIntercept();
                    }
                }

                Unit newUnit = new Unit(customUnitNameInput.Text,
                    gradient * rGradient,
                    intercept * rGradient + rIntercept);

                mainScreen.AddCustomUnit(unitTypeIndex, newUnit);
                mainScreen.UpdateComboBoxes();
                mainScreen.SetStatusBarCustomUnit(0);
            }

            return isError;
        }

        // MAIN EVENTS - Add the custom unit
        private void createCustomUnitButton_Click(object sender, EventArgs e)
        {
            bool isError = AddCustomUnit();
            if (!isError)
            {
                UpdateComboBox();
                ResetTextBoxes();
            }
            ResetFocus();
        }

        // MAIN EVENTS - Add the custom unit and close window
        private void createCustomUnitButtonAndClose_Click(object sender, EventArgs e)
        {
            bool isError = AddCustomUnit();
            if (!isError)
                this.Close();
            else
                ResetFocus();
        }
    }
}