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

        int equipmentIdToUpdate = -1; 

        public CreateEquipmentForm(int idToUpdate = -1)
        {
            InitializeComponent();
            equipmentIdToUpdate = idToUpdate;
        }

        //private void buttonAddNewSupply_Click(object sender, EventArgs e)
        //{
        //    string desc = textBoxEDescription.Text;

        //    string pnum = textBoxEPNumber.Text;
        //    string pquan = textBoxEQuantity.Text;

        //    if (comboBoxUnit.SelectedItem == null)
        //    {
        //        MessageBox.Show("Please select a unit.", "Input Error");
        //        return;
        //    }
        //    string qty = comboBoxUnit.SelectedItem.ToString();

        //    string name = textBoxName.Text;
        //    string unit = textBoxUnitCosts.Text;
        //    if (string.IsNullOrWhiteSpace(desc))
        //    {
        //        MessageBox.Show("Please put a description", "Input Error");
        //        return;
        //    }
        //    if (string.IsNullOrWhiteSpace(pnum))
        //    {
        //        MessageBox.Show("Please put a property number.", "Input Error");
        //        return;
        //    }
        //    if (string.IsNullOrWhiteSpace(name))
        //    {
        //        MessageBox.Show("Please put a name.", "Input Error");
        //        return;
        //    }

        //    if (string.IsNullOrWhiteSpace(unit))
        //    {
        //        MessageBox.Show("Please select a unit.", "Input Error");
        //        return;
        //    }

        //    if (string.IsNullOrWhiteSpace(pquan) || !int.TryParse(pquan, out int quantity))
        //    {
        //        MessageBox.Show("Please enter a valid quantity.", "Input Error");
        //        return;
        //    }

        //    var data = new Dictionary<string, object>
        //    {
        //        { "unit", qty },
        //        { "quantity", pquan },
        //        { "description", desc },
        //        { "property_number", pnum },
        //        { "unit_cost", unit },
        //        { "name", name }
        //    };

        //    databaseConnection.InsertData("equipment", data);

        //    MessageBox.Show("Success", "Equipment Added");
        //    this.DialogResult = DialogResult.OK;
        //    this.Close();
        //}
        private void buttonAddNewSupply_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string description = textBoxEDescription.Text.Trim();
            string propertyNumber = textBoxEPNumber.Text.Trim();
            string quantity = textBoxEQuantity.Text.Trim();
            string unitCost = textBoxUnitCosts.Text.Trim();
            string unit = comboBoxUnit.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(propertyNumber) || string.IsNullOrWhiteSpace(quantity) ||
                string.IsNullOrWhiteSpace(unitCost) || string.IsNullOrWhiteSpace(unit))
            {
                MessageBox.Show("Please fill all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(quantity, out int parsedQuantity) || parsedQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(unitCost, out decimal parsedUnitCost) || parsedUnitCost <= 0)
            {
                MessageBox.Show("Please enter a valid unit cost.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = new Dictionary<string, object>
            {
                { "name", name },
                { "description", description },
                { "property_number", propertyNumber },
                { "quantity", parsedQuantity },
                { "unit_cost", parsedUnitCost },
                { "unit", unit }
            };

            try
            {
                if (equipmentIdToUpdate == -1)
                {
                    databaseConnection.InsertData("equipment", data);
                    MessageBox.Show("Equipment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string setClause = string.Join(", ", data.Select(kv => $"{kv.Key}=@{kv.Key}"));
                    string condition = $"id = {equipmentIdToUpdate}";
                    databaseConnection.UpdateData("equipment", setClause, condition, data);
                    MessageBox.Show("Equipment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreateEquipmentForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            if (equipmentIdToUpdate != -1)
            {
                LoadDataForUpdate();
            }
        }
        private void LoadDataForUpdate()
        {
            buttonAddNewSupply.Text = "UpdateData";
            string query = $"SELECT * FROM equipment WHERE id = {equipmentIdToUpdate}";
            DataTable equipmentData = databaseConnection.ExecuteQuery(query);
            if (equipmentData.Rows.Count > 0)
            {
                textBoxName.Text = equipmentData.Rows[0]["name"].ToString();
                textBoxEDescription.Text = equipmentData.Rows[0]["description"].ToString();
                textBoxEPNumber.Text = equipmentData.Rows[0]["property_number"].ToString();
                textBoxEQuantity.Text = equipmentData.Rows[0]["quantity"].ToString();
                textBoxUnitCosts.Text = equipmentData.Rows[0]["unit_cost"].ToString();
                comboBoxUnit.SelectedItem = equipmentData.Rows[0]["unit"].ToString();
            }
        }
    }
}
