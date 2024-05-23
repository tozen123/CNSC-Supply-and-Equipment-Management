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
    public partial class CreateTransactionRequest : Form
    {
        public CreateTransactionRequest()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateTransactionRequest_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxSupply_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEquipment.Checked)
            {
                checkBoxEquipment.Checked = false;
            }
            else
            {
                checkBoxSupply.Checked = true;
            }
        }

        private void checkBoxEquipment_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSupply.Checked)
            {
                checkBoxSupply.Checked = false;
            }
            else
            {
                checkBoxEquipment.Checked = true;
            }
        }

        private void buttonRequestNext_Click(object sender, EventArgs e)
        {
            if (checkBoxSupply.Checked)
            {
                using (Transactions.RequestForms.RequestSupplyEquipmentForm form = new Transactions.RequestForms.RequestSupplyEquipmentForm())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {


                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
            //if (checkBoxEquipment.Checked)
            //{
            //    using (Transactions.RequestForms.RequestEquipmentForm form = new Transactions.RequestForms.RequestEquipmentForm())
            //    {
            //        var result = form.ShowDialog();
            //        if (result == DialogResult.OK)
            //        {


            //        }
            //        else
            //        {
            //            this.Close();
            //        }
            //    }
            //}
          

        }
    }
}
