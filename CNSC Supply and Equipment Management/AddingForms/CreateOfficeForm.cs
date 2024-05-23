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
    public partial class CreateOfficeForm : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();

        public CreateOfficeForm()
        {
            InitializeComponent();
        }

        private void buttonCreateDept_Click(object sender, EventArgs e)
        {
            string name = textBoxOffice.Text.Trim();
            string acronym = textBoxAcronym.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Office name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(acronym))
            {
                MessageBox.Show("Acronym cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = new Dictionary<string, object>
            {
                { "name", name },
                { "acronym", acronym }
            };

            try
            {
                databaseConnection.InsertData("Office", data);
                MessageBox.Show("Success", "Office Created");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the office: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
