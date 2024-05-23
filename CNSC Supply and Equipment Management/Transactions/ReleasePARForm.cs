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
    public partial class ReleasePARForm : Form
    {
        string id;
        DataGridView data;
        public ReleasePARForm()
        {
            data = _data;

            InitializeComponent();
        }

        private void ReleasePARForm_Load(object sender, EventArgs e)
        {
            textBoxAdminName.Text = Main.currentUser.Name;
            LoadData();
        }
        public void SetRequestId(string _id)
        {
            id = _id;
        }
        public void SetData(DataGridView _data)
        {
            data = _data;
        }

        public void LoadData()
        {
            foreach (var item in data.Columns)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}
