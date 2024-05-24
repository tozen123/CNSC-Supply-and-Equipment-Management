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
    public partial class RequestMasterTableForm : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        public RequestMasterTableForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RequestMasterTableForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            string query = @"
                    SELECT 
                        r.request_id, 
                        c.name AS custodian_name, 
                        r.unit, 
                        r.description, 
                        r.quantity, 
                        r.remarks, 
                        r.purpose, 
                        r.submitted_date,
                        CASE 
                            WHEN rs.isApprove = 1 THEN 'APPROVED'
                            ELSE 'NOT APPROVED'
                        END AS approval_status
                    FROM 
                        request r
                    INNER JOIN 
                        custodian c ON r.custodian_id = c.id
                    LEFT JOIN
                        request_status rs ON r.request_id = rs.request_id";

            DataTable dataTable = databaseConnection.ExecuteQuery(query);

            dataGridViewAllRequest.DataSource = dataTable;

            dataGridViewAllRequest.Columns["request_id"].Visible = false;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewAllRequest.DataSource = null;
            string searchTerm = textBoxSearch.Text.Trim();

            string query = @"
                            SELECT 
                                r.request_id, 
                                c.name AS custodian_name, 
                                r.unit, 
                                r.description, 
                                r.quantity, 
                                r.remarks, 
                                r.purpose, 
                                r.submitted_date
                            FROM 
                                request r
                            INNER JOIN 
                                custodian c ON r.custodian_id = c.id
                            WHERE 
                                c.name LIKE @searchTerm";

            var parameters = new Dictionary<string, object>
            {
                {"@searchTerm", $"%{searchTerm}%" }
            };

            DataTable dataTable = databaseConnection.ExecuteQuery(query, parameters);

            dataGridViewAllRequest.DataSource = dataTable;

            dataGridViewAllRequest.Columns["request_id"].Visible = false;
        }
    }
}
