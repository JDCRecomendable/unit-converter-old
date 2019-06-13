using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class DeleteCustomUnitsBox : Form
    {
        private MainScreen mainScreen;

        public DeleteCustomUnitsBox(MainScreen pMainScreen)
        {
            InitializeComponent();

            // To enable this form to call public functions
            // from the main screen
            mainScreen = pMainScreen;

            // Set initially active control of the form
            this.ActiveControl = unitSelectorCustomUnitTable;
            unitSelectorCustomUnitTable.Focus();
            unitSelectorCustomUnitTable.SelectedIndex = 0;
        }

        // UNIT TYPE EVENTS - Helper function to update combo box contents
        private void UpdateComboBox()
        {
            List<Unit> unitList = new List<Unit>();

            unitToDeleteCheckBox.Items.Clear();
            unitList = mainScreen.GetCustomUnits((short)unitSelectorCustomUnitTable.SelectedIndex);

            foreach (Unit element in unitList)
                unitToDeleteCheckBox.Items.Add(element.GetName());
        }

        // UNIT TYPE EVENTS - Do when unit type is changed
        private void unitSelectorCustomUnitTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBox();
        }

        // MAIN EVENTS - Close the form when user clicks cancel
        private void cancelAddCustomUnitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // MAIN EVENTS - Helper function to delete custom unit
        private bool DeleteCustomUnit()
        {
            bool isError = false;
            List<string> unitsChecked = new List<string>();

            foreach (string selected in unitToDeleteCheckBox.CheckedItems)
                unitsChecked.Add(selected);

            if (unitsChecked.Count > 0)
            {
                List<Unit> unitList = new List<Unit>();
                short unitTypeIndex = (short)unitSelectorCustomUnitTable.SelectedIndex;
                unitList = mainScreen.GetCustomUnits(unitTypeIndex);

                foreach (string selected in unitToDeleteCheckBox.CheckedItems)
                {
                    foreach (Unit element in unitList)
                    {
                        if (selected == element.GetName())
                        {
                            mainScreen.DeleteCustomUnit(unitTypeIndex, element);
                            mainScreen.UpdateComboBoxes();
                            break;
                        }
                    }
                }

                mainScreen.SetStatusBarCustomUnit(1);
            }
            else
            {
                MessageBox.Show(DeleteCustomUnitInvalidInputMessageBoxProperty.message,
                    DeleteCustomUnitInvalidInputMessageBoxProperty.caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                isError = true;
            }

            return isError;
        }

        // MAIN EVENTS - Carry out deletion of the unit
        private void deleteCustomUnitButton_Click(object sender, EventArgs e)
        {
            DeleteCustomUnit();
            UpdateComboBox();
        }

        // MAIN EVENTS - Carry out deletion of the unit
        private void deleteCustomUnitButtonAndClose_Click(object sender, EventArgs e)
        {
            bool isError = DeleteCustomUnit();
            if (!isError)
                this.Close();
        }
    }
}
