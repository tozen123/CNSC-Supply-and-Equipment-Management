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
    public partial class ChoosingReleasingForm : Form
    {
        DataGridView data;
        string id;
        string type;
        public ChoosingReleasingForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void SetData(DataGridView datagrid)
        {
            data = datagrid;
        }

        private void buttonICS_Click(object sender, EventArgs e)
        {
            type = "ICS";
            using (ReleaseICSForm form = new ReleaseICSForm())
            {
                form.SetData(data);
                form.SetRequestId(id);

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }
        public void SetRequestId(string _id)
        {
            id = _id;
        }
        private void buttonPAR_Click(object sender, EventArgs e)
        {
            type = "PAR";
            using (ReleasePARForm form = new ReleasePARForm())
            {
                form.SetData(data);
                form.SetRequestId(id);

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        public string ChosenType()
        {
            return type;
        }

        private void ChoosingReleasingForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }
    }
}
