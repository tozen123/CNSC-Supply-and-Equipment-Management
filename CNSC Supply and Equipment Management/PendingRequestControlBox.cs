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

        string request_id;

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
            labelReqId.Text = request_id;

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
        public void SetRequestId(string _req_id)
        {
            request_id = _req_id;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {

        }
    }
}
