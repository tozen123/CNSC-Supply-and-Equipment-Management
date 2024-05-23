using CNSC_Supply_and_Equipment_Management.Transactions;
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
    public partial class ViewRequestRecord : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();

        public ViewRequestRecord()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ViewRequestRecord_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            LoadData();
        }

        private void InitializeDataGridView()
        {
            dataGridViewApproved.AutoGenerateColumns = false;

            dataGridViewApproved.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                DataPropertyName = "quantity",
                Name = "quantity"
            });

            dataGridViewApproved.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Unit",
                DataPropertyName = "unit",
                Name = "unit"
            });

            dataGridViewApproved.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Description",
                DataPropertyName = "description",
                Name = "description"
            });

            dataGridViewApproved.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Remarks",
                DataPropertyName = "remarks",
                Name = "remarks"
            });
            dataGridViewApproved.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "FORM TYPE",
                DataPropertyName = "releasedType",
                Name = "releasedType"
            });
            dataGridViewApproved.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Purpose",
                DataPropertyName = "purpose",
                Name = "purpose"
            });

            dataGridViewApproved.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Submitted Date",
                DataPropertyName = "submitted_date",
                Name = "submitted_date"
            });

            dataGridViewApproved.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "request_id",
                Name = "request_id",
                Visible = false
            });

            DataGridViewButtonColumn viewForm = new DataGridViewButtonColumn
            {
                HeaderText = "View Form",
                Text = "View Form",
                Name = "View Form",
                UseColumnTextForButtonValue = true
            };
            dataGridViewApproved.Columns.Add(viewForm);

        }

        private void LoadData(string searchTerm = "")
        {
            string currentUserId = Main.currentUser.Id;
            string query;
            if (searchTerm == "")
            {
                query = @"
                            SELECT r.request_id, rs.releasedType, r.quantity, r.unit, r.description, r.remarks, r.purpose, r.submitted_date
                            FROM request r
                            INNER JOIN request_status rs ON r.request_id = rs.request_id
                            WHERE r.custodian_id = @custodianId AND rs.isApprove = 1";
            }
            else
            {
                query = $@"
                        SELECT r.request_id, rs.releasedType, r.quantity, r.unit, r.description, r.remarks, r.purpose, r.submitted_date
                        FROM request r
                        INNER JOIN request_status rs ON r.request_id = rs.request_id
                        WHERE r.custodian_id = @custodianId AND rs.isApprove = 1 AND r.description LIKE '%{searchTerm}%'";
            }


            var parameters = new Dictionary<string, object>
            {
                {"@custodianId", currentUserId }
            };

            DataTable requestsTable = databaseConnection.ExecuteQuery(query, parameters);

            dataGridViewApproved.DataSource = requestsTable;
        }

        private void dataGridViewApproved_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewApproved.Columns["View Form"].Index)
            {
                DataGridViewRow selectedRow = dataGridViewApproved.Rows[e.RowIndex];
                string requestId = selectedRow.Cells["request_id"].Value.ToString();
                string formtype = selectedRow.Cells["releasedType"].Value.ToString();

                if(formtype == "PAR")
                {
                    PARForm form = new PARForm();
                    form.SetReferenceId(requestId);
                    form.Show();
                }
              
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;

            LoadData(searchTerm);
        }
    }
}
