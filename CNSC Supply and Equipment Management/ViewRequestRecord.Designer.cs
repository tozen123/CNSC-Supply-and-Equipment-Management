
namespace CNSC_Supply_and_Equipment_Management
{
    partial class ViewRequestRecord
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewApproved = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApproved)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Approved Request Records";
            // 
            // dataGridViewApproved
            // 
            this.dataGridViewApproved.AllowUserToAddRows = false;
            this.dataGridViewApproved.AllowUserToDeleteRows = false;
            this.dataGridViewApproved.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewApproved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApproved.Location = new System.Drawing.Point(17, 42);
            this.dataGridViewApproved.Name = "dataGridViewApproved";
            this.dataGridViewApproved.ReadOnly = true;
            this.dataGridViewApproved.Size = new System.Drawing.Size(889, 599);
            this.dataGridViewApproved.TabIndex = 5;
            this.dataGridViewApproved.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewApproved_CellContentClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(462, 9);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(444, 29);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // ViewRequestRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 653);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewApproved);
            this.Controls.Add(this.label2);
            this.Name = "ViewRequestRecord";
            this.Text = "ViewRequestRecord";
            this.Load += new System.EventHandler(this.ViewRequestRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApproved)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewApproved;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}