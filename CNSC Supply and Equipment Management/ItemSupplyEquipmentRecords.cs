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
    public partial class ItemSupplyEquipmentRecords : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        string itemType = "";

        public ItemSupplyEquipmentRecords()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void SetTypeOfItem(string type)
        {
            itemType = type;
        }
        private void ItemSupplyEquipmentRecords_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            LoadData();

            if (itemType == "supply")
            {
                buttonAddNew.Text = "Add New Supply";
            }
            else if (itemType == "equipment")
            {
                buttonAddNew.Text = "Add New Equipment";
            }
        }

        private void LoadData(string searchTerm = "")
        {
            labelMain.Text = itemType.ToUpper();

            string query = "";

            if (searchTerm == "")
            {
                query = "SELECT * FROM " + itemType;
            }
            else
            {
                if (itemType == "supply")
                {
                    query = $"SELECT * FROM {itemType} WHERE name LIKE '%{searchTerm}%'";
                }
                else if (itemType == "equipment")
                {
                    query = $"SELECT * FROM {itemType} WHERE description LIKE '%{searchTerm}%'";
                }
            }

            DataTable dataTable = databaseConnection.ExecuteQuery(query);

            dataGridView.Columns.Clear();
            dataGridView.DataSource = null;

            dataGridView.DataSource = dataTable;


            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.HeaderText = "Update";
            updateButtonColumn.Text = "Update";
            updateButtonColumn.Name = "Update";
            updateButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(updateButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(deleteButtonColumn);


            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;

            LoadData(searchTerm);
        }

        
        private void DeleteRecord(DataGridViewRow row)
        {
            string id = dataGridView[0, row.Index].Value.ToString();
            Console.WriteLine(id);

            string condition = "id = @id";

            var parameter = new Dictionary<string, object>
            {
                {"@id", id }
            };

            databaseConnection.DeleteData(itemType, condition, parameter);

            LoadData();

            databaseConnection.ExecuteNonQuery($"ALTER TABLE {itemType} AUTO_INCREMENT = 1");
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
        
            
            if (itemType == "supply")
            {
                using (CreateSupplyForm form = new CreateSupplyForm())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {

                        LoadData();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            else if (itemType == "equipment")
            {
                using (CreateEquipmentForm form = new CreateEquipmentForm())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {

                        LoadData();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }

           
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns["Update"].Index)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                if (itemType == "supply")
                {
                    using (CreateSupplyForm form = new CreateSupplyForm(id))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            LoadData();
                        }
                    }
                }
                else if (itemType == "equipment")
                {
                    using (CreateEquipmentForm form = new CreateEquipmentForm(id))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            LoadData();
                        }
                    }
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns["Delete"].Index)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                DeleteRecord(selectedRow);
            }
        }
    }
}
