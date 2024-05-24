
namespace CNSC_Supply_and_Equipment_Management
{
    partial class PARForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxIssuedDate = new System.Windows.Forms.TextBox();
            this.textBoxAdminName = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxOffice = new System.Windows.Forms.TextBox();
            this.textBoxCustodian = new System.Windows.Forms.TextBox();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridViewDetails);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 798);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxIssuedDate);
            this.groupBox2.Controls.Add(this.textBoxAdminName);
            this.groupBox2.Controls.Add(this.textBoxPosition);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(390, 656);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 127);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Issued By:";
            // 
            // textBoxIssuedDate
            // 
            this.textBoxIssuedDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIssuedDate.Location = new System.Drawing.Point(47, 94);
            this.textBoxIssuedDate.Name = "textBoxIssuedDate";
            this.textBoxIssuedDate.ReadOnly = true;
            this.textBoxIssuedDate.Size = new System.Drawing.Size(272, 26);
            this.textBoxIssuedDate.TabIndex = 5;
            this.textBoxIssuedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAdminName
            // 
            this.textBoxAdminName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdminName.Location = new System.Drawing.Point(47, 19);
            this.textBoxAdminName.Name = "textBoxAdminName";
            this.textBoxAdminName.ReadOnly = true;
            this.textBoxAdminName.Size = new System.Drawing.Size(272, 26);
            this.textBoxAdminName.TabIndex = 3;
            this.textBoxAdminName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPosition.Location = new System.Drawing.Point(47, 51);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.ReadOnly = true;
            this.textBoxPosition.Size = new System.Drawing.Size(272, 26);
            this.textBoxPosition.TabIndex = 4;
            this.textBoxPosition.Text = "Supply Officer III/ Admin. Officer V";
            this.textBoxPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxOffice);
            this.groupBox1.Controls.Add(this.textBoxCustodian);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 656);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Received By:";
            // 
            // textBoxOffice
            // 
            this.textBoxOffice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOffice.Location = new System.Drawing.Point(52, 51);
            this.textBoxOffice.Name = "textBoxOffice";
            this.textBoxOffice.ReadOnly = true;
            this.textBoxOffice.Size = new System.Drawing.Size(272, 26);
            this.textBoxOffice.TabIndex = 1;
            this.textBoxOffice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCustodian
            // 
            this.textBoxCustodian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustodian.Location = new System.Drawing.Point(52, 19);
            this.textBoxCustodian.Name = "textBoxCustodian";
            this.textBoxCustodian.ReadOnly = true;
            this.textBoxCustodian.Size = new System.Drawing.Size(272, 26);
            this.textBoxCustodian.TabIndex = 0;
            this.textBoxCustodian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.AllowUserToAddRows = false;
            this.dataGridViewDetails.AllowUserToDeleteRows = false;
            this.dataGridViewDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(26, 92);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.Size = new System.Drawing.Size(719, 558);
            this.dataGridViewDetails.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entity Name : CAMARINES NORTE STATE COLLEGE ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROPERTY ACKNOWLEDGMENT RECEIPT";
            // 
            // PARForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 824);
            this.Controls.Add(this.panel1);
            this.Name = "PARForm";
            this.Text = "PARForm";
            this.Load += new System.EventHandler(this.PARForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxIssuedDate;
        private System.Windows.Forms.TextBox textBoxAdminName;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxOffice;
        private System.Windows.Forms.TextBox textBoxCustodian;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}