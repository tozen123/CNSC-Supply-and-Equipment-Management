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
    public partial class Main : Form
    {
        public static User currentUser;
        string userType;

        DatabaseConnection databaseConnection = new DatabaseConnection();
        public Main()
        {
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            using (LoginForm loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {     
                    currentUser = loginForm.LoggedInUser();
                }
                else
                {      
                    this.Close();
                }
            }

            if(currentUser == null)
            {
                Application.Exit();
                return;
            }

            userType = currentUser.UserType.ToUpper();
            labelMain.Text = "CNSC Supply and Equipment Management System";
            labelTypeUser.Text = currentUser.UserType.ToUpper();
            labelName.Text = "Hello,  " + currentUser.Name;

            if (userType == "ADMIN")
            {
                transactionsToolStripMenuItem.DropDownItems[0].Visible = false; //Disable Request
                menuStrip1.Items[3].Visible = false; //Disable Office Records
            } 
            else if (userType == "CUSTODIAN")
            {
                transactionsToolStripMenuItem.DropDownItems[1].Visible = false; //Disable Pending Request
                buttonRefresh.Visible = false; //Disable Pending Request
                
                menuStrip1.Items[2].Visible = false; //Disable Records
                recordsToolStripMenuItem.DropDownItems[2].Visible = false; //Disable Offices

                labelTypeUser.Text = currentUser.UserType.ToUpper() + " | " + GetUserOffice();
                tabControlOfficesRecord.Visible = false;
            }

            HandleMainBoard();
        }

        public void HandleMainBoard()
        {
            string query = "SELECT id, acronym FROM office";
            int adder = 380;
            DataTable result = databaseConnection.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    int officeId = Convert.ToInt32(row["id"]);
                    string acronym = row["acronym"].ToString();
                    TabPage tabPage = new TabPage(acronym);

                    int margin = 10;
                    int gridWidth = (tabPage.Width - (3 * margin)) / 2;
                    int gridHeight = tabPage.Height - (2 * margin);

                    Label labelSupply = new Label
                    {
                        Text = "Supply",
                        Location = new Point(margin, margin),
                        AutoSize = true
                    };

                    Label labelEquipment = new Label
                    {
                        Text = "Equipment",
                        Location = new Point(gridWidth + (2 * margin) + adder, margin),
                        AutoSize = true
                    };

                    DataGridView dataGridView1 = new DataGridView
                    {
                        Name = "dataGridViewSupply",
                        Location = new Point(margin, margin + labelSupply.Height + 5),
                        Size = new Size(gridWidth + adder, gridHeight + adder),
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                        ReadOnly = true,
                        AllowUserToAddRows = false,
                        AllowUserToDeleteRows = false,
                        AllowUserToOrderColumns = false
                    };

                    DataGridView dataGridView2 = new DataGridView
                    {
                        Name = "dataGridViewEquipment",
                        Location = new Point(gridWidth + (2 * margin) + adder, margin + labelEquipment.Height + 5),
                        Size = new Size(gridWidth + adder, gridHeight + adder),
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                        ReadOnly = true,
                        AllowUserToAddRows = false,
                        AllowUserToDeleteRows = false,
                        AllowUserToOrderColumns = false
                    };

                    // Fetch and bind data for Supply
                    string supplyQuery = @"
                SELECT s.id, s.name, osr.quantity, s.unit, s.description, s.unit_cost, s.inventory_item_no, s.estimated_useful_life
                FROM office_supply_records osr
                JOIN supply s ON osr.supply_id = s.id
                WHERE osr.office_id = @OfficeId";
                    var supplyParameters = new Dictionary<string, object> { { "@OfficeId", officeId } };
                    DataTable supplyData = databaseConnection.ExecuteQuery(supplyQuery, supplyParameters);
                    dataGridView1.DataSource = supplyData;

                    // Fetch and bind data for Equipment
                    string equipmentQuery = @"
                SELECT e.id, e.name, oer.quantity, e.unit, e.unit_cost, e.description, e.property_number
                FROM office_equipment_records oer
                JOIN equipment e ON oer.equipment_id = e.id
                WHERE oer.office_id = @OfficeId";
                    var equipmentParameters = new Dictionary<string, object> { { "@OfficeId", officeId } };
                    DataTable equipmentData = databaseConnection.ExecuteQuery(equipmentQuery, equipmentParameters);
                    dataGridView2.DataSource = equipmentData;

                    tabPage.Controls.Add(labelSupply);
                    tabPage.Controls.Add(dataGridView1);
                    tabPage.Controls.Add(labelEquipment);
                    tabPage.Controls.Add(dataGridView2);

                    tabControlOfficesRecord.TabPages.Add(tabPage);
                }
            }
        }







        private string GetUserOffice()
        {
            string query = "SELECT name FROM office WHERE id = (SELECT office_id FROM custodian WHERE id = @userId)";

            var parameters = new Dictionary<string, object>
            {
                { "@userId", currentUser.Id } 
            };

            DataTable result = databaseConnection.ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["name"].ToString();
            }

            return "Unknown";
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreateOfficeForm().Show();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Office Records
            new OfficeRecords().Show();
        }

        private void supplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreateSupplyForm().Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void supplyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            ItemSupplyEquipmentRecords itemSupplyEquipmentRecords = new ItemSupplyEquipmentRecords();
            itemSupplyEquipmentRecords.SetTypeOfItem("supply");
            itemSupplyEquipmentRecords.Show();

        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreateEquipmentForm().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void equipmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Equipment Records
            ItemSupplyEquipmentRecords itemSupplyEquipmentRecords = new ItemSupplyEquipmentRecords();
            itemSupplyEquipmentRecords.SetTypeOfItem("equipment");
            itemSupplyEquipmentRecords.Show();
        }

        private void requestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new CreateTransactionRequest().Show();
            new Transactions.RequestForms.RequestSupplyEquipmentForm().Show();
        }

        private void pendingRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Transactions.ViewPendingRequestsTransactionForm().Show();
        }

        private void requestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RequestMasterTableForm().Show();
        }

        private void pendingRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PendingRequestRecord().Show();
        }

        private void approvedRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewRequestRecord("Approved").Show();
        }

        private void disapprovedRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewRequestRecord("Disapproved").Show();
        }

        private void recordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CustodianItemSupplyEquipmentRecordsForm("Supply").Show();
        }

        private void equipmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CustodianItemSupplyEquipmentRecordsForm("Equipment").Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            tabControlOfficesRecord.TabPages.Clear();

            HandleMainBoard();
        }
    }
}
