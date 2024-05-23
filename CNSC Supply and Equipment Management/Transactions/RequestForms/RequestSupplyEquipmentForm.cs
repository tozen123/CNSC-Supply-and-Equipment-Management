using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CNSC_Supply_and_Equipment_Management.Transactions.RequestForms
{
    public partial class RequestSupplyEquipmentForm : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        string firstToAdd;

        public RequestSupplyEquipmentForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RequestSupplyForm_Load(object sender, EventArgs e)
        {
            LoadSupplyData();
            LoadEquipmentData();
        }

        private void LoadSupplyData(string searchTerm = "")
        {
            string query = $"SELECT * FROM supply WHERE name LIKE '%{searchTerm}%' AND quantity > 0";
            DataTable dataTable = databaseConnection.ExecuteQuery(query);
            dataGridViewSupplyList.Columns.Clear();
            dataGridViewSupplyList.DataSource = null;

            dataGridViewSupplyList.DataSource = dataTable;

            DataGridViewButtonColumn addButton = new DataGridViewButtonColumn();
            addButton.HeaderText = "Add";
            addButton.Text = "Add";
            addButton.Name = "Add";
            addButton.UseColumnTextForButtonValue = true;
            dataGridViewSupplyList.Columns.Add(addButton);
        }

        private void LoadEquipmentData(string searchTerm = "")
        {
            string query = $"SELECT * FROM equipment WHERE name LIKE '%{searchTerm}%' AND quantity > 0";
            DataTable dataTable = databaseConnection.ExecuteQuery(query);
            dataGridViewEquipmentList.Columns.Clear();
            dataGridViewEquipmentList.DataSource = null;

            dataGridViewEquipmentList.DataSource = dataTable;

            DataGridViewButtonColumn addButton = new DataGridViewButtonColumn();
            addButton.HeaderText = "Add";
            addButton.Text = "Add";
            addButton.Name = "Add";
            addButton.UseColumnTextForButtonValue = true;
            dataGridViewEquipmentList.Columns.Add(addButton);
        }

        private void AddToCheckOut(DataGridViewRow row, bool isEquipment)
        {
            string id = row.Cells["id"].Value.ToString();
            string name = row.Cells["name"].Value.ToString();
            string unit = row.Cells["unit"].Value.ToString();
            string desc = row.Cells["description"].Value.ToString();

            int qty;

            using (Tools.InputNumberForm form = new Tools.InputNumberForm("Quantity"))
            {
                var result = form.ShowDialog();

                if (form.NumberInput.HasValue)
                {
                    qty = form.NumberInput.Value;
                }
                else
                {
                    MessageBox.Show("Quantity not specified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (result == DialogResult.OK)
                {
                    bool itemExists = false;
                    foreach (DataGridViewRow _row in dataGridViewToCheckOut.Rows)
                    {
                        if (_row.Cells["name"].Value != null && _row.Cells["name"].Value.ToString() == name)
                        {
                            itemExists = true;
                            int currentCheckOutQty = Convert.ToInt32(_row.Cells["quantity"].Value);
                            int availableQty = Convert.ToInt32(row.Cells["quantity"].Value);

                            if (currentCheckOutQty + qty > availableQty)
                            {
                                MessageBox.Show("The total quantity that you're requesting is higher than the remaining quantity. Try again.");
                            }
                            else
                            {
                                _row.Cells["quantity"].Value = currentCheckOutQty + qty;
                                MessageBox.Show("Successfully Updated");
                            }
                            break;
                        }
                    }

                    if (!itemExists)
                    {
                        int availableQty = Convert.ToInt32(row.Cells["quantity"].Value);
                        if (qty > availableQty)
                        {
                            MessageBox.Show("The quantity that you're requesting is higher than the remaining quantity. Try again.");
                        }
                        else
                        {
                            dataGridViewToCheckOut.Rows.Add(id, name, desc, qty, unit);
                            MessageBox.Show("Successfully Added");
                        }
                    }

                    if (isEquipment)
                    {
                        LoadEquipmentData();
                        
                    }
                    else
                    {
                        LoadSupplyData();
                        
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;
            LoadSupplyData(searchTerm);
        }

        private void textBoxSearchEquipment_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearchEquipment.Text;
            LoadEquipmentData(searchTerm);
        }

        private void dataGridViewSupplyList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSupplyList.Columns["Add"].Index)
            {
                if (string.IsNullOrEmpty(firstToAdd))
                {
                    firstToAdd = "supply";
                }

                if (firstToAdd != "supply")
                {
                    MessageBox.Show("The system does not want you to mix the request with Supply and Equipment. Please separate those requests.");
                    return;
                }

                DataGridViewRow selectedRow = dataGridViewSupplyList.Rows[e.RowIndex];
                AddToCheckOut(selectedRow, false);
            }
        }

        private void dataGridViewEquipmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewEquipmentList.Columns["Add"].Index)
            {
                if (string.IsNullOrEmpty(firstToAdd))
                {
                    firstToAdd = "equipment";
                }

                if (firstToAdd != "equipment")
                {
                    MessageBox.Show("The system does not want you to mix the request with Supply and Equipment. Please separate those requests.");
                    return;
                }

                DataGridViewRow selectedRow = dataGridViewEquipmentList.Rows[e.RowIndex];
                string itemName = selectedRow.Cells["name"].Value.ToString();

                bool itemExists = false;
                foreach (DataGridViewRow _row in dataGridViewToCheckOut.Rows)
                {
                    if (_row.Cells["name"].Value != null && _row.Cells["name"].Value.ToString() == itemName)
                    {
                        itemExists = true;
                        break;
                    }
                }

                if (!itemExists)
                {
                    AddToCheckOut(selectedRow, true);
                }
                else
                {
                    MessageBox.Show("Item already exists in the checkout list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewToCheckOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewToCheckOut.Columns["remove"].Index)
            {
                var result = MessageBox.Show("Are you sure you want to remove this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dataGridViewToCheckOut.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Successfully Removed");
                }
            }
        }

        private void buttonFinalize_Click(object sender, EventArgs e)
        {
            if (dataGridViewToCheckOut.RowCount == 0)
            {
                MessageBox.Show("You cannot submit an empty request.");
                return;
            }

            List<Dictionary<string, object>> checkoutData = new List<Dictionary<string, object>>();

            foreach (DataGridViewRow row in dataGridViewToCheckOut.Rows)
            {
                if (row.Cells["id"].Value != null)
                {
                    var rowData = new Dictionary<string, object>
                    {
                        { "id", row.Cells["id"].Value },
                        { "name", row.Cells["name"].Value },
                        { "description", row.Cells["description"].Value },
                        { "quantity", row.Cells["quantity"].Value },
                        { "unit", row.Cells["unit"].Value }
                    };
                    checkoutData.Add(rowData);
                }
            }

            using (FinalRequestProcessSlipForm finalForm = new FinalRequestProcessSlipForm())
            {
                finalForm.LoadCheckoutData(checkoutData);
                var result = finalForm.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void buttonUniqueRequestSupply_Click(object sender, EventArgs e)
        {
            using (Tools.AddUniqueSupplyItemRequest form = new Tools.AddUniqueSupplyItemRequest())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    string name = form.ItemName;
                    string description = form.Description;
                    int quantity = form.Quantity;
                    string unit = form.Unit;

                    if (quantity > 0 && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(unit))
                    {
                        dataGridViewToCheckOut.Rows.Add("", name, description, quantity, unit);
                        MessageBox.Show("Successfully Added");
                    }
                    else
                    {
                        MessageBox.Show("Invalid input. Please check your entries.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
