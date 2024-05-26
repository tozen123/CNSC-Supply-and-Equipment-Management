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
        int supplyIdToUpdate = -1; 

        public CreateSupplyForm(int idToUpdate = -1)
        {
            InitializeComponent();
            supplyIdToUpdate = idToUpdate; 
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

            try
            {
                if (supplyIdToUpdate == -1)
                {
                    databaseConnection.InsertData("supply", data);
                    MessageBox.Show("Supply added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string setClause = string.Join(", ", data.Select(kv => $"{kv.Key}=@{kv.Key}"));
                    string condition = $"id = {supplyIdToUpdate}";
                    databaseConnection.UpdateData("supply", setClause, condition, data);
                    MessageBox.Show("Supply updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateSupplyForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            if (supplyIdToUpdate != -1)
            {
                LoadDataForUpdate();
            }
        }
        private void LoadDataForUpdate()
        {
            buttonAddNewSupply.Text = "Update Data";
            string query = $"SELECT * FROM supply WHERE id = {supplyIdToUpdate}";
            DataTable supplyData = databaseConnection.ExecuteQuery(query);
            if (supplyData.Rows.Count > 0)
            {
                textBoxSupplyName.Text = supplyData.Rows[0]["name"].ToString();
                textBoxSupplyDescription.Text = supplyData.Rows[0]["description"].ToString();
                textBoxSupplyQuantity.Text = supplyData.Rows[0]["quantity"].ToString();
                textBoxunitCost.Text = supplyData.Rows[0]["unit_cost"].ToString();
                textBoxInvenItemNo.Text = supplyData.Rows[0]["inventory_item_no"].ToString();
                textBoxUsefulLife.Text = supplyData.Rows[0]["estimated_useful_life"].ToString();
                comboBoxUnit.SelectedItem = supplyData.Rows[0]["unit"].ToString();
            }
        }
    }
}
