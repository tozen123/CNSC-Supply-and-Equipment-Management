
namespace CNSC_Supply_and_Equipment_Management
{
    partial class CustodianItemSupplyEquipmentRecordsForm
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewitem = new System.Windows.Forms.DataGridView();
            this.labelMain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewitem)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(489, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(550, 33);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dataGridViewitem
            // 
            this.dataGridViewitem.AllowUserToAddRows = false;
            this.dataGridViewitem.AllowUserToDeleteRows = false;
            this.dataGridViewitem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewitem.Location = new System.Drawing.Point(17, 51);
            this.dataGridViewitem.Name = "dataGridViewitem";
            this.dataGridViewitem.ReadOnly = true;
            this.dataGridViewitem.Size = new System.Drawing.Size(1022, 654);
            this.dataGridViewitem.TabIndex = 11;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(12, 15);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(116, 29);
            this.labelMain.TabIndex = 10;
            this.labelMain.Text = "ItemType";
            // 
            // CustodianItemSupplyEquipmentRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 717);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewitem);
            this.Controls.Add(this.labelMain);
            this.Name = "CustodianItemSupplyEquipmentRecordsForm";
            this.Text = "CustodianItemSupplyEquipmentRecordsForm";
            this.Load += new System.EventHandler(this.CustodianItemSupplyEquipmentRecordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewitem;
        private System.Windows.Forms.Label labelMain;
    }
}