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
    public partial class ReleaseICSForm : Form
    {
        string id;
        DataGridView data;
        public ReleaseICSForm()
        {
            InitializeComponent();
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
        }
    }
}
