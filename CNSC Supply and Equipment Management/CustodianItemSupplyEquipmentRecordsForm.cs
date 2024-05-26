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
    public partial class CustodianItemSupplyEquipmentRecordsForm : Form
    {
        string typeofitem;
        DatabaseConnection databaseConnection = new DatabaseConnection();
        public CustodianItemSupplyEquipmentRecordsForm(string type)
        {
            typeofitem = type;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CustodianItemSupplyEquipmentRecordsForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            labelMain.Text = "Office Records for " + typeofitem;
            LoadData();
        }

        private void LoadData(string term = "")
        {
            string query = "";

            if (typeofitem == "Supply")
            {
                query = @"
            SELECT s.id, s.name, osr.quantity, s.unit, s.description, s.unit_cost, s.inventory_item_no, s.estimated_useful_life
            FROM office_supply_records osr
            JOIN supply s ON osr.supply_id = s.id
            WHERE osr.office_id = @OfficeId";

                if (!string.IsNullOrEmpty(term))
                {
                    query += " AND s.name LIKE @SearchTerm";
                }
            }
            else if (typeofitem == "Equipment")
            {
                query = @"
            SELECT e.id, e.name, oer.quantity, e.unit, e.unit_cost, e.description, e.property_number
            FROM office_equipment_records oer
            JOIN equipment e ON oer.equipment_id = e.id
            WHERE oer.office_id = @OfficeId";

                if (!string.IsNullOrEmpty(term))
                {
                    query += " AND e.name LIKE @SearchTerm";
                }
            }

            var parameters = new Dictionary<string, object> { { "@OfficeId", GetUserOffice() } };

            if (!string.IsNullOrEmpty(term))
            {
                parameters.Add("@SearchTerm", "%" + term + "%");
            }

            DataTable equipmentData = databaseConnection.ExecuteQuery(query, parameters);
            dataGridViewitem.DataSource = equipmentData;
        }

        private int GetUserOffice()
        {
            string query = "SELECT id FROM office WHERE id = (SELECT office_id FROM custodian WHERE id = @userId)";

            var parameters = new Dictionary<string, object>
            {
                { "@userId", Main.currentUser.Id }
            };

            DataTable result = databaseConnection.ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["id"]);
            }
            return -1;
         
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();

            LoadData(searchTerm);

        }
    }
}
