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
    public partial class PendingRequestRecord : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        public PendingRequestRecord()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void PendingRequestRecord_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            LoadData();
        }

        private void LoadData()
        {
            string current_custodian_id = Main.currentUser.Id;

            string query = @"
                SELECT 
                    r.unit, 
                    r.description, 
                    r.quantity, 
                    r.remarks, 
                    r.purpose, 
                    r.submitted_date
                FROM 
                    request r
                LEFT JOIN 
                    request_status rs ON r.request_id = rs.request_id
                WHERE 
                    r.custodian_id = @custodianId
                    AND rs.request_id IS NULL";

            var parameters = new Dictionary<string, object>
            {
                {"@custodianId", current_custodian_id }
            };

            DataTable dataTable = databaseConnection.ExecuteQuery(query, parameters);

            dataGridViewPending.DataSource = dataTable;

            string officeQuery = @"
                                SELECT 
                                    o.name AS office_name
                                FROM 
                                    custodian c
                                INNER JOIN 
                                    office o ON c.office_id = o.id
                                WHERE 
                                    c.id = @custodianId";

            DataTable officeTable = databaseConnection.ExecuteQuery(officeQuery, parameters);

            // Check if the officeTable contains any rows
            if (officeTable.Rows.Count > 0)
            {
                // Get the office name from the first row
                string officeName = officeTable.Rows[0]["office_name"].ToString();
                labelOfficeName.Text = officeName;
            }
            else
            {
                labelOfficeName.Text = "Office name not found";
            }
        }
    }
}
