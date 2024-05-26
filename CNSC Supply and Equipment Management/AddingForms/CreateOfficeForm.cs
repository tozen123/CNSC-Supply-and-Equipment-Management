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
        string actiontype = "";
        DataGridViewRow reference_row;
        public CreateOfficeForm()
        {
            InitializeComponent();
        }

        public void SetTypeOfAction(string type)
        {
            actiontype = type;
        }

        public void SetDataReference(DataGridViewRow row)
        {
            reference_row = row;
        }

        private void buttonCreateDept_Click(object sender, EventArgs e)
        {
            if(actiontype == "Create")
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
            else if (actiontype == "Update")
            {
                if (reference_row != null)
                {
                    int id = Convert.ToInt32(reference_row.Cells["id"].Value);

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
                        databaseConnection.UpdateData("office", "name = @Name, acronym = @Acronym", "id = @Id", new Dictionary<string, object>
                        {
                            { "@Name", name },
                            { "@Acronym", acronym },
                            { "@Id", id }
                        });

                        MessageBox.Show("Success", "Office Updated");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating the office: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void CreateOfficeForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            this.StartPosition = FormStartPosition.CenterScreen;

            if (actiontype == "Create")
            {
            }
            else if (actiontype == "Update")
            {
                int id = Convert.ToInt32(reference_row.Cells["id"].Value);
                string query = "SELECT name, acronym FROM office WHERE id = @OfficeId";
                var parameters = new Dictionary<string, object> { { "@OfficeId", id } };
                DataTable table = databaseConnection.ExecuteQuery(query, parameters);

                if (table.Rows.Count > 0)
                {
                    string name = table.Rows[0]["name"].ToString();
                    string acronym = table.Rows[0]["acronym"].ToString();

                    textBoxOffice.Text = name;
                    textBoxAcronym.Text = acronym;

                    buttonCreateDept.Text = "Update Office";
                }
                else
                {
                    MessageBox.Show("Office data not found!");
                }
            }
        }
    }
}
