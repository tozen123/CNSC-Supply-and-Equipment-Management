
namespace CNSC_Supply_and_Equipment_Management
{
    partial class OfficeRecords
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
            this.labelMain = new System.Windows.Forms.Label();
            this.dataGridViewOffices = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonNewOffice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffices)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(7, 12);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(163, 29);
            this.labelMain.TabIndex = 7;
            this.labelMain.Text = "List of Offices";
            // 
            // dataGridViewOffices
            // 
            this.dataGridViewOffices.AllowUserToAddRows = false;
            this.dataGridViewOffices.AllowUserToDeleteRows = false;
            this.dataGridViewOffices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOffices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffices.Location = new System.Drawing.Point(12, 79);
            this.dataGridViewOffices.Name = "dataGridViewOffices";
            this.dataGridViewOffices.ReadOnly = true;
            this.dataGridViewOffices.Size = new System.Drawing.Size(786, 425);
            this.dataGridViewOffices.TabIndex = 8;
            this.dataGridViewOffices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOffices_CellContentClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(248, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(550, 27);
            this.textBoxSearch.TabIndex = 10;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonNewOffice
            // 
            this.buttonNewOffice.Location = new System.Drawing.Point(640, 45);
            this.buttonNewOffice.Name = "buttonNewOffice";
            this.buttonNewOffice.Size = new System.Drawing.Size(158, 31);
            this.buttonNewOffice.TabIndex = 11;
            this.buttonNewOffice.Text = "Add New Office";
            this.buttonNewOffice.UseVisualStyleBackColor = true;
            this.buttonNewOffice.Click += new System.EventHandler(this.buttonNewOffice_Click);
            // 
            // OfficeRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 511);
            this.Controls.Add(this.buttonNewOffice);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.dataGridViewOffices);
            this.Name = "OfficeRecords";
            this.Text = "DepartmentRecords";
            this.Load += new System.EventHandler(this.DepartmentRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.DataGridView dataGridViewOffices;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonNewOffice;
    }
}