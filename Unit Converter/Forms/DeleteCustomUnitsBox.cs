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

            unitToDeleteInput.Items.Clear();
            unitList = mainScreen.GetCustomUnitListings((short)unitSelectorCustomUnitTable.SelectedIndex);

            foreach (Unit element in unitList)
                unitToDeleteInput.Items.Add(element.GetName());
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

        // MAIN EVENTS - Carry out deletion of the unit
        private void deleteCustomUnitButton_Click(object sender, EventArgs e)
        {
            List<Unit> unitList = new List<Unit>();
            short unitTypeIndex = (short)unitSelectorCustomUnitTable.SelectedIndex;
            unitList = mainScreen.GetCustomUnitListings(unitTypeIndex);

            foreach (Unit element in unitList)
            {
                if (element.GetName() == (string)unitToDeleteInput.SelectedItem)
                {
                    mainScreen.DeleteCustomUnit(unitTypeIndex, element);
                    mainScreen.UpdateComboBoxes();
                    break;
                }
            }

            this.Close();
        }
    }
}
