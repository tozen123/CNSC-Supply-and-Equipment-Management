using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CNSC_Supply_and_Equipment_Management
{
    public partial class LoginForm : Form
    {

        User loggedInUser;

        DatabaseConnection databaseConnection = new DatabaseConnection();
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            Login(email, password);
        }

        private void Login(string email, string password)
        {

            string query = @"
                            SELECT id, email, password, address, contact, bdate, gender, name, 'admin' AS userType
                            FROM admin
                            WHERE email = @Email AND password = @Password
                            UNION
                            SELECT id, email, password, address, contact, bdate, gender, name, 'custodian' AS userType
                            FROM custodian
                            WHERE email = @Email AND password = @Password";

            var parameters = new Dictionary<string, object>
            {
                { "@Email", email },
                { "@Password", password }
            };

            DataTable result = databaseConnection.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];

                string id = row["id"].ToString();
                string userEmail = row["email"].ToString();
                string userPassword = row["password"].ToString();
                string userAddress = row["address"].ToString();
                string userContact = row["contact"].ToString();
                DateTime userBDate = DateTime.Parse(row["bdate"].ToString());
                string userGender = row["gender"].ToString();
                string userName = row["name"].ToString();
                string userType = row["userType"].ToString();

                loggedInUser = new User(id, userEmail, userPassword, userAddress, userContact, userBDate, userGender, userName, userType);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            new CreateAccountForm().Show();
        }

        public User LoggedInUser()
        {

            return loggedInUser;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = "jake@gmail.com";
            string password = "123";
            Login(email, password);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = "icscustodian@gmail.com";
            string password = "123";
            Login(email, password);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string email = "ifms@gmail.com";
            string password = "123";
            Login(email, password);
        }
    }
}
