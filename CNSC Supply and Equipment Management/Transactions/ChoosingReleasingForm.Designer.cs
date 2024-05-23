
namespace CNSC_Supply_and_Equipment_Management.Transactions
{
    partial class ChoosingReleasingForm
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
            this.buttonICS = new System.Windows.Forms.Button();
            this.buttonPAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonICS
            // 
            this.buttonICS.Location = new System.Drawing.Point(12, 59);
            this.buttonICS.Name = "buttonICS";
            this.buttonICS.Size = new System.Drawing.Size(212, 42);
            this.buttonICS.TabIndex = 0;
            this.buttonICS.Text = "INVENTORY CUSTODIAN  SLIP";
            this.buttonICS.UseVisualStyleBackColor = true;
            this.buttonICS.Click += new System.EventHandler(this.buttonICS_Click);
            // 
            // buttonPAR
            // 
            this.buttonPAR.Location = new System.Drawing.Point(230, 59);
            this.buttonPAR.Name = "buttonPAR";
            this.buttonPAR.Size = new System.Drawing.Size(212, 42);
            this.buttonPAR.TabIndex = 1;
            this.buttonPAR.Text = "PROPERTY ACKNOWLEDGMENT RECEIPT";
            this.buttonPAR.UseVisualStyleBackColor = true;
            this.buttonPAR.Click += new System.EventHandler(this.buttonPAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Type of Form";
            // 
            // ChoosingReleasingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 113);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPAR);
            this.Controls.Add(this.buttonICS);
            this.Name = "ChoosingReleasingForm";
            this.Text = "ChoosingReleasingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonICS;
        private System.Windows.Forms.Button buttonPAR;
        private System.Windows.Forms.Label label1;
    }
}