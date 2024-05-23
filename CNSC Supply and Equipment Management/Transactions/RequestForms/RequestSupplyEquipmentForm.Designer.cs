
namespace CNSC_Supply_and_Equipment_Management.Transactions.RequestForms
{
    partial class RequestSupplyEquipmentForm
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
            this.dataGridViewSupplyList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUniqueRequestSupply = new System.Windows.Forms.Button();
            this.buttonFinalize = new System.Windows.Forms.Button();
            this.dataGridViewToCheckOut = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxSearchEquipment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewEquipmentList = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplyList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(7, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(452, 29);
            this.labelMain.TabIndex = 9;
            this.labelMain.Text = "Create Supply/Equipment Request Form";
            // 
            // dataGridViewSupplyList
            // 
            this.dataGridViewSupplyList.AllowUserToAddRows = false;
            this.dataGridViewSupplyList.AllowUserToDeleteRows = false;
            this.dataGridViewSupplyList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSupplyList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSupplyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplyList.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewSupplyList.Name = "dataGridViewSupplyList";
            this.dataGridViewSupplyList.ReadOnly = true;
            this.dataGridViewSupplyList.Size = new System.Drawing.Size(500, 267);
            this.dataGridViewSupplyList.TabIndex = 10;
            this.dataGridViewSupplyList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplyList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Available Supply Table";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(264, 50);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(248, 27);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonUniqueRequestSupply);
            this.groupBox1.Controls.Add(this.buttonFinalize);
            this.groupBox1.Controls.Add(this.dataGridViewToCheckOut);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(518, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 586);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request To Check";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Is the item that you\'re looking for was not available? Add Unique ";
            // 
            // buttonUniqueRequestSupply
            // 
            this.buttonUniqueRequestSupply.Location = new System.Drawing.Point(6, 470);
            this.buttonUniqueRequestSupply.Name = "buttonUniqueRequestSupply";
            this.buttonUniqueRequestSupply.Size = new System.Drawing.Size(212, 41);
            this.buttonUniqueRequestSupply.TabIndex = 7;
            this.buttonUniqueRequestSupply.Text = "Add Unique Item Request ";
            this.buttonUniqueRequestSupply.UseVisualStyleBackColor = true;
            this.buttonUniqueRequestSupply.Click += new System.EventHandler(this.buttonUniqueRequestSupply_Click);
            // 
            // buttonFinalize
            // 
            this.buttonFinalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalize.Location = new System.Drawing.Point(6, 534);
            this.buttonFinalize.Name = "buttonFinalize";
            this.buttonFinalize.Size = new System.Drawing.Size(373, 46);
            this.buttonFinalize.TabIndex = 4;
            this.buttonFinalize.Text = "FINALIZE";
            this.buttonFinalize.UseVisualStyleBackColor = true;
            this.buttonFinalize.Click += new System.EventHandler(this.buttonFinalize_Click);
            // 
            // dataGridViewToCheckOut
            // 
            this.dataGridViewToCheckOut.AllowUserToAddRows = false;
            this.dataGridViewToCheckOut.AllowUserToDeleteRows = false;
            this.dataGridViewToCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewToCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewToCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToCheckOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.description,
            this.quantity,
            this.unit,
            this.remove});
            this.dataGridViewToCheckOut.Location = new System.Drawing.Point(10, 33);
            this.dataGridViewToCheckOut.Name = "dataGridViewToCheckOut";
            this.dataGridViewToCheckOut.ReadOnly = true;
            this.dataGridViewToCheckOut.Size = new System.Drawing.Size(523, 431);
            this.dataGridViewToCheckOut.TabIndex = 0;
            this.dataGridViewToCheckOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewToCheckOut_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.HeaderText = "unit";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // remove
            // 
            this.remove.HeaderText = "remove";
            this.remove.Name = "remove";
            this.remove.ReadOnly = true;
            this.remove.Text = "Remove";
            this.remove.UseColumnTextForButtonValue = true;
            // 
            // textBoxSearchEquipment
            // 
            this.textBoxSearchEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchEquipment.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchEquipment.Location = new System.Drawing.Point(264, 356);
            this.textBoxSearchEquipment.Name = "textBoxSearchEquipment";
            this.textBoxSearchEquipment.Size = new System.Drawing.Size(248, 27);
            this.textBoxSearchEquipment.TabIndex = 16;
            this.textBoxSearchEquipment.TextChanged += new System.EventHandler(this.textBoxSearchEquipment_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Available Equipment Table";
            // 
            // dataGridViewEquipmentList
            // 
            this.dataGridViewEquipmentList.AllowUserToAddRows = false;
            this.dataGridViewEquipmentList.AllowUserToDeleteRows = false;
            this.dataGridViewEquipmentList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEquipmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEquipmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipmentList.Location = new System.Drawing.Point(12, 388);
            this.dataGridViewEquipmentList.Name = "dataGridViewEquipmentList";
            this.dataGridViewEquipmentList.ReadOnly = true;
            this.dataGridViewEquipmentList.Size = new System.Drawing.Size(500, 248);
            this.dataGridViewEquipmentList.TabIndex = 14;
            this.dataGridViewEquipmentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEquipmentList_CellContentClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(385, 534);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 46);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // RequestSupplyEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 648);
            this.Controls.Add(this.textBoxSearchEquipment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewEquipmentList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSupplyList);
            this.Controls.Add(this.labelMain);
            this.Name = "RequestSupplyEquipmentForm";
            this.Text = "RequestSupplyEquipmentForm";
            this.Load += new System.EventHandler(this.RequestSupplyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplyList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.DataGridView dataGridViewSupplyList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewToCheckOut;
        private System.Windows.Forms.Button buttonFinalize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUniqueRequestSupply;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewButtonColumn remove;
        private System.Windows.Forms.TextBox textBoxSearchEquipment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewEquipmentList;
        private System.Windows.Forms.Button buttonCancel;
    }
}