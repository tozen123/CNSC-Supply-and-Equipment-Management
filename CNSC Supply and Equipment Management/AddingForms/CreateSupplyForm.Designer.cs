
namespace CNSC_Supply_and_Equipment_Management
{
    partial class CreateSupplyForm
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
            this.textBoxSupplyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSupplyDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSupplyQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddNewSupply = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxunitCost = new System.Windows.Forms.TextBox();
            this.textBoxInvenItemNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUsefulLife = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSupplyName
            // 
            this.textBoxSupplyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupplyName.Location = new System.Drawing.Point(238, 68);
            this.textBoxSupplyName.Name = "textBoxSupplyName";
            this.textBoxSupplyName.Size = new System.Drawing.Size(226, 26);
            this.textBoxSupplyName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adding New Supply Item";
            // 
            // textBoxSupplyDescription
            // 
            this.textBoxSupplyDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupplyDescription.Location = new System.Drawing.Point(238, 100);
            this.textBoxSupplyDescription.Name = "textBoxSupplyDescription";
            this.textBoxSupplyDescription.Size = new System.Drawing.Size(226, 26);
            this.textBoxSupplyDescription.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // textBoxSupplyQuantity
            // 
            this.textBoxSupplyQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupplyQuantity.Location = new System.Drawing.Point(238, 164);
            this.textBoxSupplyQuantity.Name = "textBoxSupplyQuantity";
            this.textBoxSupplyQuantity.Size = new System.Drawing.Size(226, 26);
            this.textBoxSupplyQuantity.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantity";
            // 
            // buttonAddNewSupply
            // 
            this.buttonAddNewSupply.Location = new System.Drawing.Point(42, 332);
            this.buttonAddNewSupply.Name = "buttonAddNewSupply";
            this.buttonAddNewSupply.Size = new System.Drawing.Size(422, 41);
            this.buttonAddNewSupply.TabIndex = 12;
            this.buttonAddNewSupply.Text = "Add New Supply";
            this.buttonAddNewSupply.UseVisualStyleBackColor = true;
            this.buttonAddNewSupply.Click += new System.EventHandler(this.buttonAddNewSupply_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unit";
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Items.AddRange(new object[] {
            "Pcs",
            "Unit"});
            this.comboBoxUnit.Location = new System.Drawing.Point(238, 132);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(226, 28);
            this.comboBoxUnit.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Unit Cost";
            // 
            // textBoxunitCost
            // 
            this.textBoxunitCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxunitCost.Location = new System.Drawing.Point(238, 196);
            this.textBoxunitCost.Name = "textBoxunitCost";
            this.textBoxunitCost.Size = new System.Drawing.Size(226, 26);
            this.textBoxunitCost.TabIndex = 16;
            // 
            // textBoxInvenItemNo
            // 
            this.textBoxInvenItemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInvenItemNo.Location = new System.Drawing.Point(238, 251);
            this.textBoxInvenItemNo.Name = "textBoxInvenItemNo";
            this.textBoxInvenItemNo.Size = new System.Drawing.Size(226, 26);
            this.textBoxInvenItemNo.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Inventory Item No.";
            // 
            // textBoxUsefulLife
            // 
            this.textBoxUsefulLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsefulLife.Location = new System.Drawing.Point(238, 283);
            this.textBoxUsefulLife.Name = "textBoxUsefulLife";
            this.textBoxUsefulLife.Size = new System.Drawing.Size(226, 26);
            this.textBoxUsefulLife.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Estimated Usefull Life (Yr)";
            // 
            // CreateSupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 385);
            this.Controls.Add(this.textBoxUsefulLife);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxInvenItemNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxunitCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAddNewSupply);
            this.Controls.Add(this.textBoxSupplyQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSupplyDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSupplyName);
            this.Controls.Add(this.label2);
            this.Name = "CreateSupplyForm";
            this.Text = "CreateSupplyForm";
            this.Load += new System.EventHandler(this.CreateSupplyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSupplyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSupplyDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSupplyQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddNewSupply;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxunitCost;
        private System.Windows.Forms.TextBox textBoxInvenItemNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUsefulLife;
        private System.Windows.Forms.Label label8;
    }
}