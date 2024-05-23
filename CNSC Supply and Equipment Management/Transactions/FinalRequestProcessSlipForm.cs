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
    public partial class FinalRequestProcessSlipForm : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();

        public FinalRequestProcessSlipForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeDataGridViewColumns();
        }

        private void InitializeDataGridViewColumns()
        {

            DataGridViewButtonColumn addRemarksButtonColumn = new DataGridViewButtonColumn
            {
                Name = "add_remarks_button",
                HeaderText = "Add Remark",
                Text = "Add Remark",
                UseColumnTextForButtonValue = true
            };
            dataGridViewCheckOutFinal.Columns.Add(addRemarksButtonColumn);
        }

        private void FinalRequestProcessSlipForm_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadCheckoutData(List<Dictionary<string, object>> data)
        {
            dataGridViewCheckOutFinal.Rows.Clear();

            foreach (var row in data)
            {
                int rowIndex = dataGridViewCheckOutFinal.Rows.Add();
                foreach (var kvp in row)
                {
                    dataGridViewCheckOutFinal.Rows[rowIndex].Cells[kvp.Key].Value = kvp.Value;
                }
            }
        }

        private void dataGridViewCheckOutFinal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewCheckOutFinal.Columns["add_remarks_button"].Index)
            {
                DataGridViewRow selectedRow = dataGridViewCheckOutFinal.Rows[e.RowIndex];
                string currentRemark = selectedRow.Cells["remarks"].Value?.ToString();

                using (Form remarkForm = new Form())
                {
                    remarkForm.Text = "Add Remark";
                    remarkForm.Size = new Size(300, 200);

                    TextBox textBox = new TextBox() { Text = currentRemark, Multiline = true, Dock = DockStyle.Fill, Margin = new Padding(20) };
                    remarkForm.Controls.Add(textBox);

                    Button okButton = new Button() { Text = "OK", DialogResult = DialogResult.OK, Dock = DockStyle.Bottom, Margin = new Padding(20) };
                    remarkForm.Controls.Add(okButton);

                    if (remarkForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedRow.Cells["remarks"].Value = textBox.Text;
                    }
                }
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string purpose = richTextBoxPurpose.Text;

            if (purpose == "")
            {
                MessageBox.Show("Please fill the purpose", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Main.currentUser == null)
            {
                MessageBox.Show("User not logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int custodianId = Convert.ToInt32(Main.currentUser.Id);

            // Generate a unique request ID
            string requestId = GenerateUniqueRequestId();

            List<Dictionary<string, object>> requestData = new List<Dictionary<string, object>>();

            int stockNo = 1;

            foreach (DataGridViewRow row in dataGridViewCheckOutFinal.Rows)
            {
                int isunique = 0;

                if (row.IsNewRow) continue;

                if (row.Cells["id"].Value.ToString() == "")
                {
                    isunique = 1; 
                }
                else
                {
                    isunique = 0; 
                }

                var data = new Dictionary<string, object>
                {
                    { "request_id", requestId }, 
                    { "custodian_id", custodianId },
                    { "item_id", row.Cells["id"].Value },
                    { "stock_no", stockNo.ToString() },
                    { "unit", row.Cells["unit"].Value },
                    { "description", row.Cells["name"].Value + " | " +row.Cells["description"].Value },
                    { "quantity", row.Cells["quantity"].Value },
                    { "remarks", row.Cells["remarks"].Value },
                    { "purpose", purpose },
                    { "isUnique", isunique }
                };

                requestData.Add(data);
                stockNo++;
            }

            foreach (var data in requestData)
            {
                databaseConnection.InsertData("request", data);
            }

            MessageBox.Show("Request submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.Yes;
            this.Close();


        }
        private string GenerateUniqueRequestId()
        {
            return Guid.NewGuid().ToString();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
