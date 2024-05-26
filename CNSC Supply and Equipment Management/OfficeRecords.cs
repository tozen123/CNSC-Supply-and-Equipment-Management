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
    public partial class OfficeRecords : Form
    {

        DatabaseConnection databaseConnection = new DatabaseConnection();
        public OfficeRecords()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void DepartmentRecords_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            LoadOfficeData();
        }

       
        private void LoadOfficeData(string searchTerm = "")
        {
          
            string query;

            if (searchTerm == "")
            {
                query = "SELECT * FROM office" ;
            }
            else
            {
                query = $"SELECT * FROM office WHERE acronym LIKE '%{searchTerm}%'";
            }
            DataTable dataTable = databaseConnection.ExecuteQuery(query);

            dataGridViewOffices.Columns.Clear();
            dataGridViewOffices.DataSource = null;

            dataGridViewOffices.DataSource = dataTable;

            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.HeaderText = "Update";
            updateButtonColumn.Text = "Update";
            updateButtonColumn.Name = "Update";
            updateButtonColumn.UseColumnTextForButtonValue = true;
            dataGridViewOffices.Columns.Add(updateButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridViewOffices.Columns.Add(deleteButtonColumn);

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;

            LoadOfficeData(searchTerm);
        }

        private void buttonNewOffice_Click(object sender, EventArgs e)
        {
            using (CreateOfficeForm form = new CreateOfficeForm())
            {
                form.SetTypeOfAction("Create");
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadOfficeData();
                }
                else
                {
                    this.Close();
                }
            }
            
        }

        private void UpdateEntry(DataGridViewRow row)
        {
            using (CreateOfficeForm form = new CreateOfficeForm())
            {
                form.SetTypeOfAction("Update");
                form.SetDataReference(row);

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadOfficeData();
                }
                else
                {
                    this.Close();
                }
            }
        }
        private void dataGridViewOffices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewOffices.Columns["Update"].Index)
            {
                DataGridViewRow selectedRow = dataGridViewOffices.Rows[e.RowIndex];
                UpdateEntry(selectedRow);

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewOffices.Columns["Delete"].Index)
            {
                DataGridViewRow selectedRow = dataGridViewOffices.Rows[e.RowIndex];
                DeleteRecord(selectedRow);
            }
        }
        private void DeleteRecord(DataGridViewRow row)
        {
            string id = dataGridViewOffices[0, row.Index].Value.ToString();
            Console.WriteLine(id);

            string condition = "id = @id";

            var parameter = new Dictionary<string, object>
            {
                {"@id", id }
            };

            databaseConnection.DeleteData("office", condition, parameter);

            LoadOfficeData();

            databaseConnection.ExecuteNonQuery("ALTER TABLE office AUTO_INCREMENT = 1");
        }
    }
}
