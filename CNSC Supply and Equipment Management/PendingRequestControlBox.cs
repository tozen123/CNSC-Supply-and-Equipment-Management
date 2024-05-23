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
    public partial class PendingRequestControlBox : UserControl
    {
        string officename;
        string officeacronym;
        string name;
        DateTime reqsubmittedate;

        public PendingRequestControlBox()
        {
            InitializeComponent();
        }

        private void PendingRequestControlBox_Load(object sender, EventArgs e)
        {
            labelCustodianName.Text = name;
            labelOfficeAcronym.Text = officeacronym;
            labelOffice.Text = officename;
            labelRequestSubmittedDate.Text = reqsubmittedate.ToString();

            this.Dock = DockStyle.Right;
        }

        public void SetCustodianName(string _name)
        {
            name = _name;
        }
        public void SetOfficeName(string _officename)
        {
            officename = _officename;
        }
        public void SetOfficeAcronymName(string _officeacronym)
        {
            officeacronym = _officeacronym;
        }

        public void SetSubmittedDate(DateTime _date)
        {
            reqsubmittedate = _date;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {

        }
    }
}
