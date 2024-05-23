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
    public partial class InputNumberForm : Form
    {
        public int? NumberInput { get; private set; }
        public InputNumberForm(string title)
        {
            InitializeComponent();
            labelMainInput.Text = "Input " + title + " Form";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
      
        private void InputNumberForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            if(int.TryParse(textBoxInputBox.Text, out int number))
            {
                NumberInput = number;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No input found.");
            }
           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
