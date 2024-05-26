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
    public partial class ViewRequest : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        string id;



        public ViewRequest()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        public void SetRequestId(string _id)
        {
            id = _id;
        }
        private void ViewRequest_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            Console.WriteLine(id);


            dataGridViewListOfRequest.Columns.Add("unit", "Unit");
            dataGridViewListOfRequest.Columns.Add("description", "Description");
            dataGridViewListOfRequest.Columns.Add("quantity", "Quantity");
            dataGridViewListOfRequest.Columns.Add("unit_cost", "Unit Cost");
            dataGridViewListOfRequest.Columns.Add("remarks", "Remarks");
            dataGridViewListOfRequest.Columns.Add("purpose", "Purpose");
            dataGridViewListOfRequest.Columns.Add("isUnique", "Is Unique");

            dataGridViewListOfRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            LoadRequestData();
        }

        private void LoadRequestData()
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Error Occured while opening the request. Please contact the developer");
                return;
            }

            string query = "SELECT * FROM request WHERE request_id = @RequestId";
            var parameters = new Dictionary<string, object> { { "@RequestId", id } };
            DataTable table = databaseConnection.ExecuteQuery(query, parameters);

            double totalCost = 0;

            foreach (DataRow item in table.Rows)
            {

                Console.WriteLine(string.Join(", ", item.ItemArray));
                textBoxDate.Text = item["submitted_date"].ToString();

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
                textBoxPrintedName.Text = custodianName;

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
                string officeAcronym = officeTable.Rows[0]["acronym"].ToString();
                labelOfficeNameAcronym.Text = officeName + " (" + officeAcronym + ")";
                textBoxOffice.Text = officeName;

                double unitCost = 0;
                int itemId = Convert.ToInt32(item["item_id"]);
                string itemName = item["description"].ToString().Split('|')[1].Trim();
                Console.WriteLine(itemName);
                string unitCostQuery;

                unitCostQuery = "SELECT unit_cost FROM supply WHERE id = @ItemId AND description = @ItemName";
                var unitCostParameters = new Dictionary<string, object>
                {
                    { "@ItemId", itemId },
                    { "@ItemName", itemName }
                };
                DataTable unitCostTable = databaseConnection.ExecuteQuery(unitCostQuery, unitCostParameters);

                if (unitCostTable.Rows.Count > 0)
                {
                    unitCost = Convert.ToDouble(unitCostTable.Rows[0]["unit_cost"]);
                }
                else
                {
                    unitCostQuery = "SELECT unit_cost FROM equipment WHERE id = @ItemId AND description = @ItemName";
                    unitCostTable = databaseConnection.ExecuteQuery(unitCostQuery, unitCostParameters);

                    if (unitCostTable.Rows.Count > 0)
                    {
                        unitCost = Convert.ToDouble(unitCostTable.Rows[0]["unit_cost"]);
                    }
                }

                int quantity = Convert.ToInt32(item["quantity"]);
                double itemTotalCost = unitCost * quantity;
                totalCost += itemTotalCost;

                dataGridViewListOfRequest.Rows.Add(
                    item["item_id"],
                    item["unit"],
                    item["description"],
                    quantity,
                    unitCost,
                    item["remarks"],
                    item["purpose"],
                    item["isUnique"]
                );
            }

            textBoxTotalCost.Text = totalCost.ToString();
        }


        private void dataGridViewListOfRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            using (ChoosingReleasingForm form = new ChoosingReleasingForm())
            {
                form.SetRequestId(id);
                form.SetData(dataGridViewListOfRequest);
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string type = form.ChosenType();

                    //Return Check of the ReleasingForm that is chosen by the ADMIN
                    Console.WriteLine("Returned With = " + type);

                    if (type == "PAR")
                    {
                        ReleasePAR();
                        // When there is unique, create new item from that to EQUIPMENT
                    }
                    else if (type == "ICS")
                    {
                        ReleaseICS();
                        // When there is unique, create new item from that to SUPPLY
                    }

                    SetStatusRequest(1, type);
                    
                    UpdateItemQuantity();

                    MessageBox.Show("Request Approved Sucessfully");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Request Approving Transaction Cancelled.");
                    this.Close();
                }
            }

        }
        private int GetUserOffice()
        {
            //GetUserOffice


            int office_id = -1;

            string query = "SELECT * FROM request WHERE request_id = @RequestId";
            var parameters = new Dictionary<string, object> { { "@RequestId", id } };
            DataTable table = databaseConnection.ExecuteQuery(query, parameters);
            foreach (DataRow item in table.Rows)
            {
                int custodianId = Convert.ToInt32(item["custodian_id"]);
                string custodianQuery = "SELECT * FROM custodian WHERE id = @CustodianId";
                var custodianParameters = new Dictionary<string, object> { { "@CustodianId", custodianId } };
                DataTable custodianTable = databaseConnection.ExecuteQuery(custodianQuery, custodianParameters);
                int officeId = Convert.ToInt32(custodianTable.Rows[0]["office_id"]);

                office_id = officeId;
            }
            return office_id;
        }
        private void OfficeAddItem(string itemType)
        {
            // Add the unique to the records of offices
           
            Console.WriteLine(itemType);
            string num_label = "";
            string targetType = "";
            string idColumnName = "";
            if(itemType == "supply")
            {
                num_label = "inventory_item_no";
                targetType = "office_supply_records";
                idColumnName = "supply_id";
            }
            else if (itemType == "equipment")
            {
                num_label = "property_number";
                targetType = "office_equipment_records";
                idColumnName = "equipment_id";
            }

            int officeId = GetUserOffice();


            foreach (DataGridViewRow Datarow in dataGridViewListOfRequest.Rows)
            {
                if (Datarow.Cells["isUnique"].Value.ToString() == "1")
                {
                    var data = new Dictionary<string, object>
                    {
                        { "quantity",   0},// Datarow.Cells["quantity"].Value
                        { "unit", Datarow.Cells["unit"].Value },
                        { "unit_cost",  Datarow.Cells["unit_cost"].Value },
                        { "name", Datarow.Cells["description"].Value.ToString().Split('|')[0].Trim() },
                        { "description", Datarow.Cells["description"].Value.ToString().Split('|')[1].Trim() },
                        { num_label, "" }
                    };

                    int generatedId = databaseConnection.InsertDataAndGetID(itemType, data);



                    //Add to OfficeRecords
                    var data2 = new Dictionary<string, object>
                    {
                        { "quantity",   Datarow.Cells["quantity"].Value},
                        { idColumnName, generatedId },
                        { "office_id",  officeId }
                        
                    };

                    databaseConnection.InsertData(targetType, data2);

                    Console.WriteLine($"Inserted ID: {generatedId}");
                }
                else
                {
                    if (Datarow.Cells["isUnique"].Value.ToString() == "0")
                    {
                        var data = new Dictionary<string, object>
                    {
                        { "quantity",   Datarow.Cells["quantity"].Value},
                        { "equipment_id", Datarow.Cells["item_id"].Value },
                        { "office_id",  officeId }

                    };

                        databaseConnection.InsertData(targetType, data);

                    }
                }
            } 
            



        }
       

        private void ReleaseICS()
        {
            OfficeAddItem("supply");

            string query = "SELECT custodian_id FROM request WHERE request_id = @RequestId";
            var parameters = new Dictionary<string, object> { { "@RequestId", id } };
            DataTable table = databaseConnection.ExecuteQuery(query, parameters);

            int cur_id = Convert.ToInt32(Main.currentUser.Id);
            int custodian_id = Convert.ToInt32(table.Rows[0]["custodian_id"]);

            var data = new Dictionary<string, object>
            {
                { "request_id",  id},
                { "admin_id", cur_id },
                { "custodian_id", custodian_id }
            };

            databaseConnection.InsertData("ics", data);

        }

        private void ReleasePAR()
        {
            OfficeAddItem("equipment");

            string query = "SELECT custodian_id FROM request WHERE request_id = @RequestId";
            var parameters = new Dictionary<string, object> { { "@RequestId", id } };
            DataTable table = databaseConnection.ExecuteQuery(query, parameters);

            int cur_id = Convert.ToInt32(Main.currentUser.Id);
            int custodian_id = Convert.ToInt32(table.Rows[0]["custodian_id"]);

            var data = new Dictionary<string, object>
            {
                { "request_id",  id},
                { "admin_id", cur_id },
                { "custodian_id", custodian_id }
            };

            databaseConnection.InsertData("par", data);
        }

        private void buttonDisapprove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Disapproved Sucessfully");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void SetStatusRequest(int isApprove, string type = "Did Not Release")
        {
            string rmrk = richTextBox1.Text;
            var data = new Dictionary<string, object>
            {
                { "request_id", id },
                { "isApprove", 1 },
                { "remarks", rmrk },
                { "releasedType", type }
            };
            databaseConnection.InsertData("request_status", data);



        }

        private void UpdateItemQuantity()
        {
            foreach (DataGridViewRow row in dataGridViewListOfRequest.Rows)
            {

                int itemId = Convert.ToInt32(row.Cells["item_id"].Value);
                string itemName = row.Cells["description"].Value.ToString().Split('|')[1].Trim();
                int quantity = Convert.ToInt32(row.Cells["quantity"].Value);

                ///

                //Console.WriteLine("UpdateItemQuantity(id): " + row.Cells["item_id"].Value);
                //Console.WriteLine("UpdateItemQuantity(quantity): " + row.Cells["quantity"].Value);
                //Console.WriteLine("UpdateItemQuantity(description): " + row.Cells["description"].Value.ToString());



                // Check for supply first

                string query = "SELECT quantity FROM supply WHERE id = @ItemId AND description = @ItemName";
                var parameters = new Dictionary<string, object>
                {
                    { "@ItemId", itemId },
                    { "@ItemName", itemName }
                };
                DataTable table = databaseConnection.ExecuteQuery(query, parameters);

                if (table.Rows.Count > 0)
                {
                    int currentQuantity = Convert.ToInt32(table.Rows[0]["quantity"]);
                    int newQuantity = currentQuantity - quantity;

                    string setClause = "quantity = @Quantity";
                    string condition = "id = @ItemId AND description = @ItemName";
                    var _parameters = new Dictionary<string, object>
                    {
                        { "@Quantity", newQuantity },
                        { "@ItemId", itemId },
                        { "@ItemName", itemName }
                    };

                    databaseConnection.UpdateData("supply", setClause, condition, _parameters);

                } 
                else
                {
                    string e_query = "SELECT quantity FROM equipment WHERE id = @ItemId AND description = @ItemName";
                    var e_parameters = new Dictionary<string, object>
                    {
                        { "@ItemId", itemId },
                        { "@ItemName", itemName }
                    };
                    DataTable e_table = databaseConnection.ExecuteQuery(e_query, e_parameters);

                    if (e_table.Rows.Count > 0)
                    {
                        int currentQuantity = Convert.ToInt32(e_table.Rows[0]["quantity"]);
                        int newQuantity = currentQuantity - quantity;

                        string setClause = "quantity = @Quantity";
                        string condition = "id = @ItemId AND description = @ItemName";

                        var _parameters = new Dictionary<string, object>
                        {
                            { "@Quantity", newQuantity },
                            { "@ItemId", itemId },
                            { "@ItemName", itemName }
                        };

                        databaseConnection.UpdateData("equipment", setClause, condition, _parameters);

                    }

                }



            }
        }


    }
}
