using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNSC_Supply_and_Equipment_Management
{
    public partial class PARForm : Form
    {
        string request_id;
        DatabaseConnection databaseConnection = new DatabaseConnection(); // Initialize the database connection

        public PARForm()
        {
            InitializeComponent();
        }

        public void SetReferenceId(string reference_id)
        {
            request_id = reference_id;
        }

        private void PARForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = @"
                SELECT 
                    r.quantity, 
                    r.unit, 
                    r.description, 
                    e.property_number, 
                    e.unit_cost ,
                    r.custodian_id
                FROM 
                    request r
                LEFT JOIN 
                    equipment e ON r.item_id = e.id
                WHERE 
                    r.request_id = @request_id";

            var parameters = new Dictionary<string, object>
            {
                {"@request_id", request_id }
            };

            DataTable requestsTable = databaseConnection.ExecuteQuery(query, parameters);
            int custodian_id = Convert.ToInt32(requestsTable.Rows[0]["custodian_id"]);

            string forApproveDateQuery = "SELECT approved_date FROM request_status WHERE request_id = @RequestId";
            var forApproveDateParameters = new Dictionary<string, object> { { "@RequestId", request_id } };
            DataTable forApproveDateTable = databaseConnection.ExecuteQuery(forApproveDateQuery, forApproveDateParameters);

            if (forApproveDateTable.Rows.Count > 0)
            {
                textBoxIssuedDate.Text = forApproveDateTable.Rows[0]["approved_date"].ToString();
            }
            else
            {
                textBoxIssuedDate.Text = "No approved date available";
            }

            string forAdminNameQuery = @"
                                        SELECT a.name
                                        FROM par p
                                        INNER JOIN admin a ON p.admin_id = a.id
                                        WHERE p.request_id = @RequestId";

            var forAdminNameParameters = new Dictionary<string, object> { { "@RequestId", request_id } };
            DataTable forAdminNameTable = databaseConnection.ExecuteQuery(forAdminNameQuery, forAdminNameParameters);

            if (forAdminNameTable.Rows.Count > 0)
            {
                textBoxAdminName.Text = forAdminNameTable.Rows[0]["name"].ToString();
            }
            else
            {
                textBoxAdminName.Text = "No admin name available";
            }

            string forCustodianNameQuery = @"
                                            SELECT c.name
                                            FROM request r
                                            INNER JOIN custodian c ON r.custodian_id = c.id
                                            WHERE r.request_id = @RequestId";

            var forCustodianNameParameters = new Dictionary<string, object> { { "@RequestId", request_id } };
            DataTable forCustodianNameTable = databaseConnection.ExecuteQuery(forCustodianNameQuery, forCustodianNameParameters);

            if (forCustodianNameTable.Rows.Count > 0)
            {
                textBoxCustodian.Text = forCustodianNameTable.Rows[0]["name"].ToString();
            }
            else
            {
                textBoxCustodian.Text = "No custodian name available";
            }

            string forOfficeNameQuery = @"
                                    SELECT o.name
                                    FROM custodian c
                                    INNER JOIN office o ON c.office_id = o.id
                                    WHERE c.id = @CustodianId";

            var forOfficeNameParameters = new Dictionary<string, object> { { "@CustodianId", custodian_id } };
            DataTable forOfficeNameTable = databaseConnection.ExecuteQuery(forOfficeNameQuery, forOfficeNameParameters);

            if (forOfficeNameTable.Rows.Count > 0)
            {
                textBoxOffice.Text = forOfficeNameTable.Rows[0]["name"].ToString();
            }
            else
            {
                textBoxOffice.Text = "No office name available";
            }

            InitializeDataGridView();
            PopulateDataGridView(requestsTable);
        }

        private void InitializeDataGridView()
        {
            dataGridViewDetails.AutoGenerateColumns = false;

            dataGridViewDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                DataPropertyName = "quantity",
                Name = "quantity"
            });

            dataGridViewDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Unit",
                DataPropertyName = "unit",
                Name = "unit"
            });

            dataGridViewDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Description",
                DataPropertyName = "description",
                Name = "description"
            });

            dataGridViewDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Property Number",
                DataPropertyName = "property_number",
                Name = "property_number"
            });

            dataGridViewDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Amount",
                DataPropertyName = "unit_cost",
                Name = "unit_cost"
            });
        }

        private void PopulateDataGridView(DataTable dataTable)
        {
            dataGridViewDetails.DataSource = dataTable;
        }
    }
}
