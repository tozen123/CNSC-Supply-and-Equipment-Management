using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNSC_Supply_and_Equipment_Management
{
    public partial class CreateEquipmentForm : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();

        public CreateEquipmentForm()
        {
            InitializeComponent();
        }

        private void buttonAddNewSupply_Click(object sender, EventArgs e)
        {
            string desc = textBoxEDescription.Text;
            string pnum = textBoxEPNumber.Text;
            string pquan = textBoxEQuantity.Text;

            string qty = comboBoxUnit.SelectedItem.ToString();

            var data = new Dictionary<string, object>
            {
                { "unit", qty },
                { "quantity", pquan },
                { "description", desc },
                { "property_number", pnum }
            };

            databaseConnection.InsertData("equipment", data);

            MessageBox.Show("Success", "Equipment Added");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
