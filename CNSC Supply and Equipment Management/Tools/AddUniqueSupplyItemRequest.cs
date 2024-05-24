using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNSC_Supply_and_Equipment_Management.Tools
{
    public partial class AddUniqueSupplyItemRequest : Form
    {
        public AddUniqueSupplyItemRequest()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddUniqueSupplyItemRequest_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }
        public string ItemName => textBoxName.Text;
        public string Description => richTextBoxDescription.Text;
        public int Quantity => int.TryParse(textBoxQuantity.Text, out int qty) ? qty : 0;
        public string Unit => comboBoxUnit.SelectedItem?.ToString();

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxQuantity.Text) ||
                comboBoxUnit.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantity;
            if (!int.TryParse(textBoxQuantity.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid number for quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
