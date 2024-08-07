﻿using System;
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
    public partial class ReleaseICSForm : Form
    {
        string id;
        DataGridView data;
        DatabaseConnection databaseConnection = new DatabaseConnection();
        public ReleaseICSForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        public void SetRequestId(string _id)
        {
            id = _id;
        }
        public void SetData(DataGridView _data)
        {
            data = _data;
        }

        private void ReleaseICSForm_Load(object sender, EventArgs e)
        {

            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            textBoxAdminName.Text = Main.currentUser.Name;
            LoadData();
        }
        private void LoadData()
        {

            //item_id
            //unit
            //description
            //quantity
            //unit_cost
            //remarks
            //purpose
            //isUnique

            //Load Supply
            dataGridViewDetails.Rows.Clear();

            //for (var i = 0; i < data.ColumnCount; i++)
            //{
            //    var name = data.Columns[i].Name;
            //    Console.WriteLine(name);
            //}
                

            foreach (DataGridViewRow row in data.Rows)
            {
                if (row.IsNewRow) continue;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewDetails);

                newRow.Cells[0].Value = row.Cells["quantity"].Value;
                newRow.Cells[1].Value = row.Cells["unit"].Value;
                newRow.Cells[2].Value = row.Cells["description"].Value;

                string itemId = row.Cells["item_id"].Value.ToString();
                string description = row.Cells["description"].Value.ToString().Split('|')[1].Trim();
                string query = "SELECT inventory_item_no, unit_cost, estimated_useful_life FROM supply WHERE id = @item_id AND description = @description";
                var parameters = new Dictionary<string, object>
                {
                    {"@item_id", itemId },
                    {"@description", description }
                };
                DataTable result = databaseConnection.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    DataRow dataRow = result.Rows[0];
                    newRow.Cells[3].Value = dataRow["inventory_item_no"];
                    newRow.Cells[4].Value = dataRow["unit_cost"];
                    newRow.Cells[5].Value = dataRow["estimated_useful_life"];
                }
                else
                {
                    newRow.Cells[3].Value = "";
                    newRow.Cells[4].Value = 0;
                }

                dataGridViewDetails.Rows.Add(newRow);
            }


            textBoxIssuedDate.Text = DateTime.Now.ToString();
            string r_query = "SELECT * FROM request WHERE request_id = @RequestId";
            var r_parameters = new Dictionary<string, object> { { "@RequestId", id } };
            DataTable table = databaseConnection.ExecuteQuery(r_query, r_parameters);
            foreach (DataRow item in table.Rows)
            {

                int custodianId = Convert.ToInt32(item["custodian_id"]);

                string custodianQuery = "SELECT * FROM custodian WHERE id = @CustodianId";
                var custodianParameters = new Dictionary<string, object> { { "@CustodianId", custodianId } };
                DataTable custodianTable = databaseConnection.ExecuteQuery(custodianQuery, custodianParameters);

                if (custodianTable.Rows.Count == 0)
                {
                    MessageBox.Show("Custodian not found.");
                    return;
                }

                string custodianName = custodianTable.Rows[0]["name"].ToString();
                textBoxCustodian.Text = custodianName;


                int officeId = Convert.ToInt32(custodianTable.Rows[0]["office_id"]);

                string officeQuery = "SELECT * FROM office WHERE id = @OfficeId";
                var officeParameters = new Dictionary<string, object> { { "@OfficeId", officeId } };
                DataTable officeTable = databaseConnection.ExecuteQuery(officeQuery, officeParameters);

                if (officeTable.Rows.Count == 0)
                {
                    MessageBox.Show("Office not found.");
                    return;
                }

                string officeName = officeTable.Rows[0]["name"].ToString();
                textBoxOffice.Text = officeName;
            }

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }
    }
}
