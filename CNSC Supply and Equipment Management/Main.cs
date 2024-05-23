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
                
                menuStrip1.Items[2].Visible = false; //Disable Records
                recordsToolStripMenuItem.DropDownItems[2].Visible = false; //Disable Offices

                labelTypeUser.Text = currentUser.UserType.ToUpper() + " | " + GetUserOffice();
                tabControlOfficesRecord.Visible = false;
            }

            HandleMainBoard();
        }

        public void HandleMainBoard()
        {
            string query = "SELECT acronym FROM office";

            DataTable result = databaseConnection.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                string acr;
                for (int i = 0; i < result.Rows.Count; i++)
                {
                    acr = result.Rows[i]["acronym"].ToString();
                    tabControlOfficesRecord.TabPages.Add(acr);
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
    }
}
