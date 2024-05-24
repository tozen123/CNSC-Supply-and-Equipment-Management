
namespace CNSC_Supply_and_Equipment_Management
{
    partial class CreateOfficeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOffice = new System.Windows.Forms.TextBox();
            this.buttonCreateDept = new System.Windows.Forms.Button();
            this.textBoxAcronym = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Office";
            // 
            // textBoxOffice
            // 
            this.textBoxOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOffice.Location = new System.Drawing.Point(158, 22);
            this.textBoxOffice.Name = "textBoxOffice";
            this.textBoxOffice.Size = new System.Drawing.Size(282, 26);
            this.textBoxOffice.TabIndex = 1;
            // 
            // buttonCreateDept
            // 
            this.buttonCreateDept.Location = new System.Drawing.Point(44, 96);
            this.buttonCreateDept.Name = "buttonCreateDept";
            this.buttonCreateDept.Size = new System.Drawing.Size(357, 36);
            this.buttonCreateDept.TabIndex = 2;
            this.buttonCreateDept.Text = "Create";
            this.buttonCreateDept.UseVisualStyleBackColor = true;
            this.buttonCreateDept.Click += new System.EventHandler(this.buttonCreateDept_Click);
            // 
            // textBoxAcronym
            // 
            this.textBoxAcronym.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAcronym.Location = new System.Drawing.Point(158, 54);
            this.textBoxAcronym.Name = "textBoxAcronym";
            this.textBoxAcronym.Size = new System.Drawing.Size(282, 26);
            this.textBoxAcronym.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Acronym";
            // 
            // CreateOfficeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 141);
            this.Controls.Add(this.textBoxAcronym);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCreateDept);
            this.Controls.Add(this.textBoxOffice);
            this.Controls.Add(this.label1);
            this.Name = "CreateOfficeForm";
            this.Text = "CreateOffice";
            this.Load += new System.EventHandler(this.CreateOfficeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOffice;
        private System.Windows.Forms.Button buttonCreateDept;
        private System.Windows.Forms.TextBox textBoxAcronym;
        private System.Windows.Forms.Label label2;
    }
}