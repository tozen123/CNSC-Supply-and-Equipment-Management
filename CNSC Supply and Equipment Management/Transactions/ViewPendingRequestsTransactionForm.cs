using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNSC_Supply_and_Equipment_Management.Transactions
{
    public partial class ViewPendingRequestsTransactionForm : Form
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();

        public ViewPendingRequestsTransactionForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            flowLayoutPanelRequests.WrapContents = false;
        }

        private void ViewPendingRequestsTransactionForm_Load(object sender, EventArgs e)
        {
            LoadOfficesIntoComboBox();
            LoadPendingRequests();
        }
        public void Reload()
        {
            flowLayoutPanelRequests.Controls.Clear();
            LoadPendingRequests();
        }
        private void LoadPendingRequests()
        {
            string selectedOffice = comboBoxOffices.SelectedItem?.ToString();
            string selectedDate = comboBoxDate.SelectedItem?.ToString();

            string query = @"
                    SELECT r.request_id, r.custodian_id, r.submitted_date
                    FROM request r
                    LEFT JOIN request_status rs ON r.request_id = rs.request_id
                    WHERE rs.request_id IS NULL
                    GROUP BY r.request_id";

            if (!string.IsNullOrEmpty(selectedOffice))
            {
                if (selectedOffice == "All")
                {
                    query = @"
                SELECT r.request_id, r.custodian_id, r.submitted_date
                FROM request r
                LEFT JOIN request_status rs ON r.request_id = rs.request_id
                WHERE rs.request_id IS NULL
                GROUP BY r.request_id";
                }
                else
                {
                    query = $@"
                SELECT r.request_id, r.custodian_id, r.submitted_date
                FROM request r
                JOIN custodian c ON r.custodian_id = c.id
                JOIN office o ON c.office_id = o.id
                LEFT JOIN request_status rs ON r.request_id = rs.request_id
                WHERE o.name = '{selectedOffice}' AND rs.request_id IS NULL
                GROUP BY r.request_id";
                }
            }

            else if (!string.IsNullOrEmpty(selectedDate))
            {
                if (selectedDate == "Oldest")
                {
                    query += " ORDER BY submitted_date ASC";
                }
                else if (selectedDate == "Latest")
                {
                    query += " ORDER BY submitted_date DESC";
                }
            }

            DataTable requestsTable = databaseConnection.ExecuteQuery(query);

            foreach (DataRow requestRow in requestsTable.Rows)
            {
                LoadPendingRequestControl(requestRow);
            }
        }
       
        private void LoadPendingRequestControl(DataRow requestRow)
        {
            

            int custodianId = Convert.ToInt32(requestRow["custodian_id"]);

            string custodianQuery = $"SELECT * FROM custodian WHERE id = {custodianId}";
            DataTable custodianTable = databaseConnection.ExecuteQuery(custodianQuery);

            int officeId = Convert.ToInt32(custodianTable.Rows[0]["office_id"]);

            string officeQuery = $"SELECT * FROM office WHERE id = {officeId}";
            DataTable officeTable = databaseConnection.ExecuteQuery(officeQuery);

            string officeName = officeTable.Rows[0]["name"].ToString();
            Console.WriteLine(officeName);
            string officeAcronym = officeTable.Rows[0]["acronym"].ToString();

            string custodianName = custodianTable.Rows[0]["name"].ToString();

            DateTime submittedDate = Convert.ToDateTime(requestRow["submitted_date"]);

            PendingRequestControlBox custodianControl = new PendingRequestControlBox(this);
            custodianControl.SetCustodianName(custodianName);
            custodianControl.SetOfficeName(officeName);
            custodianControl.SetOfficeAcronymName(officeAcronym);
            custodianControl.SetSubmittedDate(submittedDate);

            string r = requestRow["request_id"].ToString();

            custodianControl.SetRequestId(r);

            flowLayoutPanelRequests.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelRequests.Controls.Add(custodianControl);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string query = $@"
                        SELECT r.request_id, r.custodian_id, r.submitted_date, c.name AS custodian_name, o.name AS office_name, o.acronym AS office_acronym
                        FROM request r
                        JOIN custodian c ON r.custodian_id = c.id
                        JOIN office o ON c.office_id = o.id
                        WHERE o.name LIKE '%{searchTerm}%' OR o.acronym LIKE '%{searchTerm}%'
                        GROUP BY r.request_id";
                DataTable filteredRequestsTable = databaseConnection.ExecuteQuery(query);

                flowLayoutPanelRequests.Controls.Clear();

                foreach (DataRow requestRow in filteredRequestsTable.Rows)
                {
                    LoadPendingRequestControl(requestRow);
                }
            }
            else
            {
                LoadPendingRequests();
            }
        }
        private void LoadOfficesIntoComboBox()
        {
            DataTable officeTable = GetOffice();

            foreach (DataRow row in officeTable.Rows)
            {
                comboBoxOffices.Items.Add(row["name"].ToString());
            }
        }

        private DataTable GetOffice()
        {
            string query = "SELECT * FROM office";
            return databaseConnection.ExecuteQuery(query);
        }

        private void comboBoxOffices_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanelRequests.Controls.Clear();
            LoadPendingRequests();

        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanelRequests.Controls.Clear();
            LoadPendingRequests();
        }

       
    }
}
