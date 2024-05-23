using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNSC_Supply_and_Equipment_Management.Transactions.RequestForms
{
    public partial class RequestSupplyForm : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();

        public RequestSupplyForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RequestSupplyForm_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData(string searchTerm = "")
        {
            string query = $"SELECT * FROM supply WHERE name LIKE '%{searchTerm}%' AND quantity > 0 ";
            DataTable dataTable = databaseConnection.ExecuteQuery(query);
            dataGridViewSupplyList.Columns.Clear();
            dataGridViewSupplyList.DataSource = null;

            dataGridViewSupplyList.DataSource = dataTable;

            DataGridViewButtonColumn AddButton = new DataGridViewButtonColumn();
            AddButton.HeaderText = "Add";
            AddButton.Text = "Add";
            AddButton.Name = "Add";
            AddButton.UseColumnTextForButtonValue = true;
            dataGridViewSupplyList.Columns.Add(AddButton);
        }
        private void AddToCheckOut(DataGridViewRow row)
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
                qty = form.NumberInput.Value;
                if (result == DialogResult.OK)
                {
                    bool itemExists = false;
                    foreach (DataGridViewRow _row in dataGridViewToCheckOut.Rows)
                    {
                        if (_row.Cells["id"].Value != null && _row.Cells["id"].Value.ToString() == id)
                        {
                            itemExists = true;
                            int currentCheckOutQty = Convert.ToInt32(_row.Cells["quantity"].Value);
                            int availableQty = Convert.ToInt32(row.Cells["quantity"].Value);

                            if (currentCheckOutQty + qty > availableQty)
                            {
                                MessageBox.Show("The total quantity that you're requesting is higher than the remaining quantity in the supply. Try again.");
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
                            MessageBox.Show("The quantity that you're requesting is higher than the remaining quantity in the supply. Try again.");
                        }
                        else
                        {
                            dataGridViewToCheckOut.Rows.Add(id, name, desc, qty, unit);
                            MessageBox.Show("Successfully Added");
                        }
                    }
                    
                    LoadData();
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

            LoadData(searchTerm);
        }
        
        private void dataGridViewSupplyList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSupplyList.Columns["Add"].Index)
            {
                DataGridViewRow selectedRow = dataGridViewSupplyList.Rows[e.RowIndex];
                AddToCheckOut(selectedRow);
                
            }
        }

        private void dataGridViewToCheckOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewToCheckOut.Columns["remove"].Index)
            {
                DataGridViewRow selectedRow = dataGridViewToCheckOut.Rows[e.RowIndex];
                var result = MessageBox.Show("Are you sure you want to remove this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    dataGridViewToCheckOut.Rows.RemoveAt(e.RowIndex);
                    
                    MessageBox.Show("Successfully Removed");
                }
                

            }
        }

        

        private void buttonFinalize_Click(object sender, EventArgs e)
        {
            if(dataGridViewToCheckOut.RowCount == 0)
            {
                MessageBox.Show("You can not submit an empty request");
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
                else if (result == DialogResult.No)
                {

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
    }
}
