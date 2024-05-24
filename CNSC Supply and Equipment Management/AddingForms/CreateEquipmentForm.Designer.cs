
namespace CNSC_Supply_and_Equipment_Management
{
    partial class CreateEquipmentForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEDescription = new System.Windows.Forms.TextBox();
            this.textBoxEPNumber = new System.Windows.Forms.TextBox();
            this.textBoxEQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.buttonAddNewSupply = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUnitCosts = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Property Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adding New Equipment Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description";
            // 
            // textBoxEDescription
            // 
            this.textBoxEDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEDescription.Location = new System.Drawing.Point(196, 96);
            this.textBoxEDescription.Name = "textBoxEDescription";
            this.textBoxEDescription.Size = new System.Drawing.Size(282, 26);
            this.textBoxEDescription.TabIndex = 19;
            // 
            // textBoxEPNumber
            // 
            this.textBoxEPNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEPNumber.Location = new System.Drawing.Point(196, 131);
            this.textBoxEPNumber.Name = "textBoxEPNumber";
            this.textBoxEPNumber.Size = new System.Drawing.Size(282, 26);
            this.textBoxEPNumber.TabIndex = 20;
            // 
            // textBoxEQuantity
            // 
            this.textBoxEQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEQuantity.Location = new System.Drawing.Point(196, 195);
            this.textBoxEQuantity.Name = "textBoxEQuantity";
            this.textBoxEQuantity.Size = new System.Drawing.Size(282, 26);
            this.textBoxEQuantity.TabIndex = 22;
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Items.AddRange(new object[] {
            "Pcs",
            "Pack",
            "Unit"});
            this.comboBoxUnit.Location = new System.Drawing.Point(196, 163);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(282, 28);
            this.comboBoxUnit.TabIndex = 23;
            // 
            // buttonAddNewSupply
            // 
            this.buttonAddNewSupply.Location = new System.Drawing.Point(52, 276);
            this.buttonAddNewSupply.Name = "buttonAddNewSupply";
            this.buttonAddNewSupply.Size = new System.Drawing.Size(408, 41);
            this.buttonAddNewSupply.TabIndex = 24;
            this.buttonAddNewSupply.Text = "Add New Equipment";
            this.buttonAddNewSupply.UseVisualStyleBackColor = true;
            this.buttonAddNewSupply.Click += new System.EventHandler(this.buttonAddNewSupply_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Unit Cost";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(196, 67);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(282, 26);
            this.textBoxName.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Name";
            // 
            // textBoxUnitCosts
            // 
            this.textBoxUnitCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitCosts.Location = new System.Drawing.Point(196, 227);
            this.textBoxUnitCosts.Name = "textBoxUnitCosts";
            this.textBoxUnitCosts.Size = new System.Drawing.Size(282, 26);
            this.textBoxUnitCosts.TabIndex = 29;
            // 
            // CreateEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 329);
            this.Controls.Add(this.textBoxUnitCosts);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAddNewSupply);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.textBoxEQuantity);
            this.Controls.Add(this.textBoxEPNumber);
            this.Controls.Add(this.textBoxEDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "CreateEquipmentForm";
            this.Text = "CreateEquipmentForm";
            this.Load += new System.EventHandler(this.CreateEquipmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEDescription;
        private System.Windows.Forms.TextBox textBoxEPNumber;
        private System.Windows.Forms.TextBox textBoxEQuantity;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.Button buttonAddNewSupply;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUnitCosts;
    }
}