﻿
namespace CNSC_Supply_and_Equipment_Management
{
    partial class PendingRequestRecord
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
            this.dataGridViewPending = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOfficeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPending)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPending
            // 
            this.dataGridViewPending.AllowUserToAddRows = false;
            this.dataGridViewPending.AllowUserToDeleteRows = false;
            this.dataGridViewPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPending.Location = new System.Drawing.Point(13, 60);
            this.dataGridViewPending.Name = "dataGridViewPending";
            this.dataGridViewPending.ReadOnly = true;
            this.dataGridViewPending.Size = new System.Drawing.Size(847, 546);
            this.dataGridViewPending.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Office Pending Request";
            // 
            // labelOfficeName
            // 
            this.labelOfficeName.AutoSize = true;
            this.labelOfficeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfficeName.Location = new System.Drawing.Point(13, 33);
            this.labelOfficeName.Name = "labelOfficeName";
            this.labelOfficeName.Size = new System.Drawing.Size(180, 16);
            this.labelOfficeName.TabIndex = 2;
            this.labelOfficeName.Text = "Your Office Pending Request";
            // 
            // PendingRequestRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 618);
            this.Controls.Add(this.labelOfficeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPending);
            this.Name = "PendingRequestRecord";
            this.Text = "PendingRequestRecord";
            this.Load += new System.EventHandler(this.PendingRequestRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPending)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPending;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOfficeName;
    }
}