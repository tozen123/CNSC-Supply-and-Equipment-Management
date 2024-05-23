
namespace CNSC_Supply_and_Equipment_Management
{
    partial class PendingRequestControlBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelOffice = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.labelCustodianName = new System.Windows.Forms.Label();
            this.labelOfficeAcronym = new System.Windows.Forms.Label();
            this.labelRequestSubmittedDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOffice
            // 
            this.labelOffice.AutoSize = true;
            this.labelOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOffice.Location = new System.Drawing.Point(23, 25);
            this.labelOffice.Name = "labelOffice";
            this.labelOffice.Size = new System.Drawing.Size(66, 24);
            this.labelOffice.TabIndex = 0;
            this.labelOffice.Text = "label1";
            // 
            // buttonView
            // 
            this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonView.Location = new System.Drawing.Point(534, 91);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(311, 38);
            this.buttonView.TabIndex = 1;
            this.buttonView.Text = "View Request";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // labelCustodianName
            // 
            this.labelCustodianName.AutoSize = true;
            this.labelCustodianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustodianName.Location = new System.Drawing.Point(24, 69);
            this.labelCustodianName.Name = "labelCustodianName";
            this.labelCustodianName.Size = new System.Drawing.Size(41, 15);
            this.labelCustodianName.TabIndex = 2;
            this.labelCustodianName.Text = "label1";
            // 
            // labelOfficeAcronym
            // 
            this.labelOfficeAcronym.AutoSize = true;
            this.labelOfficeAcronym.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfficeAcronym.Location = new System.Drawing.Point(23, 49);
            this.labelOfficeAcronym.Name = "labelOfficeAcronym";
            this.labelOfficeAcronym.Size = new System.Drawing.Size(51, 20);
            this.labelOfficeAcronym.TabIndex = 3;
            this.labelOfficeAcronym.Text = "label1";
            // 
            // labelRequestSubmittedDate
            // 
            this.labelRequestSubmittedDate.AutoSize = true;
            this.labelRequestSubmittedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestSubmittedDate.Location = new System.Drawing.Point(530, 64);
            this.labelRequestSubmittedDate.Name = "labelRequestSubmittedDate";
            this.labelRequestSubmittedDate.Size = new System.Drawing.Size(51, 20);
            this.labelRequestSubmittedDate.TabIndex = 4;
            this.labelRequestSubmittedDate.Text = "label1";
            // 
            // PendingRequestControlBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.labelRequestSubmittedDate);
            this.Controls.Add(this.labelOfficeAcronym);
            this.Controls.Add(this.labelCustodianName);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.labelOffice);
            this.Name = "PendingRequestControlBox";
            this.Size = new System.Drawing.Size(848, 134);
            this.Load += new System.EventHandler(this.PendingRequestControlBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOffice;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Label labelCustodianName;
        private System.Windows.Forms.Label labelOfficeAcronym;
        private System.Windows.Forms.Label labelRequestSubmittedDate;
    }
}
