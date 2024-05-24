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
    public partial class CreateSupplyForm : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        public CreateSupplyForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonAddNewSupply_Click(object sender, EventArgs e)
        {
            string supplyname = textBoxSupplyName.Text;
            string supplydescription = textBoxSupplyDescription.Text;
            string supplyquantity = textBoxSupplyQuantity.Text;

            if(comboBoxUnit.SelectedItem == null)
            {
                MessageBox.Show("Please select a unit.", "Input Error");
                return;
            }
            string supplyunit = comboBoxUnit.SelectedItem.ToString();

            string unitcost = textBoxunitCost.Text;

            string invent_no = textBoxInvenItemNo.Text;

            string useful = textBoxUsefulLife.Text;

            if (string.IsNullOrWhiteSpace(supplyname))
            {
                MessageBox.Show("Supply name cannot be empty.", "Input Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(supplyquantity) || !int.TryParse(supplyquantity, out int quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(supplyunit))
            {
                MessageBox.Show("Please select a unit.", "Input Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(unitcost) || !decimal.TryParse(unitcost, out decimal cost))
            {
                MessageBox.Show("Please enter a valid unit cost.", "Input Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(invent_no))
            {
                MessageBox.Show("Inventory item number cannot be empty.", "Input Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(useful) || !int.TryParse(useful, out int usefulLife))
            {
                MessageBox.Show("Please enter a valid useful life in years.", "Input Error");
                return;
            }

            var data = new Dictionary<string, object>
            {
                { "name", supplyname },
                { "quantity", supplyquantity },
                { "description", supplydescription },
                { "unit", supplyunit },
                { "unit_cost", unitcost },
                { "inventory_item_no", invent_no },
                { "estimated_useful_life", useful }
            };

            databaseConnection.InsertData("supply", data);

            MessageBox.Show("Success", "Supply Added");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CreateSupplyForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }
    }
}
