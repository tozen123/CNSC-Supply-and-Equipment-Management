using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace CNSC_Supply_and_Equipment_Management
{
    public partial class CreateAccountForm : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        public CreateAccountForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            groupBoxCusDept.Visible = false;

            LoadOfficesIntoComboBox();
        }

        private void LoadOfficesIntoComboBox()
        {
            DataTable officeTable = GetOffice();

            foreach (DataRow row in officeTable.Rows)
            {
                comboBoxOffice.Items.Add(row["name"].ToString());
            }
        }

        private DataTable GetOffice()
        {
            string query = "SELECT * FROM office";
            return databaseConnection.ExecuteQuery(query);
        }

        private bool isEmptyField(TextBox field)
        {
            if (string.IsNullOrWhiteSpace(field.Text))
            {
                MessageBox.Show("Empty Field at " + field.Name, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private bool isEmptyField(RichTextBox field)
        {
            if (string.IsNullOrWhiteSpace(field.Text))
            {
                MessageBox.Show("Empty Field at " + field.Name, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private bool isValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool isValidContact(string contact)
        {
            string contactPattern = @"^09\d{9}$";
            return Regex.IsMatch(contact, contactPattern);
        }
        private void buttonFinish_Click(object sender, EventArgs e)
        {
            string fname = textBoxFirstName.Text.Trim();
            string mname = textBoxMiddleName.Text.Trim();
            string lname = textBoxLastName.Text.Trim();

            if (isEmptyField(textBoxFirstName) || isEmptyField(textBoxMiddleName) || isEmptyField(textBoxLastName))
            {
                return;
            }

            if (comboBoxGender.SelectedItem == null)
            {
                MessageBox.Show("Please select gender", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string gender = comboBoxGender.SelectedItem.ToString();

            DateTime bdate = dateTimePickerBirthdate.Value;

            string contact = textBoxContact.Text.Trim();

            if (isEmptyField(textBoxContact))
            {
                return;
            }

            if (!isValidContact(contact))
            {
                MessageBox.Show("Please enter a valid contact number starting with '09' and having 11 digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = textBoxEmail.Text.Trim();

            if (isEmptyField(textBoxEmail))
            {
                return;
            }

            if (!isValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string address = richTextBoxAddress.Text.Trim();

            if (isEmptyField(richTextBoxAddress))
            {
                return;
            }

            string password = textBoxPassword.Text;
            string cpassword = textBoxConfirmPassword.Text;

            if (isEmptyField(textBoxPassword) || isEmptyField(textBoxConfirmPassword))
            {
                return;
            }

            if (!password.Equals(cpassword))
            {
                MessageBox.Show("Password did not match!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string user_type = "";

            var data = new Dictionary<string, object>
            {
                { "email", email },
                { "password", password },
                { "address", address },
                { "contact", contact },
                { "bdate", bdate },
                { "gender", gender },
                { "name", $"{fname} {mname} {lname}" }
            };

            if (checkBoxCustodian.Checked)
            {
                user_type = "custodian";
                if (comboBoxOffice.SelectedItem == null)
                {
                    MessageBox.Show("Please select an office", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string selectedOffice = comboBoxOffice.SelectedItem.ToString();
                string office_id = GetOfficeIdByName(selectedOffice);
                data.Add("office_id", office_id);
            }
            else if (checkBoxAdmin.Checked)
            {
                user_type = "admin";
            }

            try
            {
                databaseConnection.InsertData(user_type, data);
                MessageBox.Show("Success", "Account Created");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the account: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxCustodian_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCustodian.Checked)
            {
                groupBoxCusDept.Visible = true;
            }
            else
            {
                groupBoxCusDept.Visible = false;
            }
            
            if(checkBoxAdmin.Checked)
            {
                checkBoxAdmin.Checked = false;
            }
            else
            {
                checkBoxCustodian.Checked = true;
            }
        }
        private string GetOfficeIdByName(string officeName)
        {
            string query = "SELECT id FROM office WHERE name = @name";
            var parameters = new Dictionary<string, object>
            {
                { "@name", officeName }
            };

            DataTable result = databaseConnection.ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["id"].ToString();
            }

            throw new Exception("Office ID not found for the selected office name.");
        }

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCustodian.Checked)
            {
                checkBoxCustodian.Checked = false;
            }
            else
            {
                checkBoxAdmin.Checked = true;
            }
        }
    }
}
