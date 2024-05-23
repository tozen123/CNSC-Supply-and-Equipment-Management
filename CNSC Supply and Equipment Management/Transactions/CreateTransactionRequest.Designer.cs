
namespace CNSC_Supply_and_Equipment_Management
{
    partial class CreateTransactionRequest
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
            this.groupBoxRequestingType = new System.Windows.Forms.GroupBox();
            this.checkBoxEquipment = new System.Windows.Forms.CheckBox();
            this.checkBoxSupply = new System.Windows.Forms.CheckBox();
            this.buttonRequestNext = new System.Windows.Forms.Button();
            this.groupBoxRequestingType.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(12, 22);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(244, 29);
            this.labelMain.TabIndex = 8;
            this.labelMain.Text = "Create Request Form";
            // 
            // groupBoxRequestingType
            // 
            this.groupBoxRequestingType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRequestingType.Controls.Add(this.checkBoxEquipment);
            this.groupBoxRequestingType.Controls.Add(this.checkBoxSupply);
            this.groupBoxRequestingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxRequestingType.Location = new System.Drawing.Point(17, 67);
            this.groupBoxRequestingType.Name = "groupBoxRequestingType";
            this.groupBoxRequestingType.Size = new System.Drawing.Size(342, 100);
            this.groupBoxRequestingType.TabIndex = 9;
            this.groupBoxRequestingType.TabStop = false;
            this.groupBoxRequestingType.Text = "Item Request Type";
            // 
            // checkBoxEquipment
            // 
            this.checkBoxEquipment.AutoSize = true;
            this.checkBoxEquipment.Location = new System.Drawing.Point(19, 64);
            this.checkBoxEquipment.Name = "checkBoxEquipment";
            this.checkBoxEquipment.Size = new System.Drawing.Size(105, 24);
            this.checkBoxEquipment.TabIndex = 1;
            this.checkBoxEquipment.Text = "Equipment";
            this.checkBoxEquipment.UseVisualStyleBackColor = true;
            this.checkBoxEquipment.CheckedChanged += new System.EventHandler(this.checkBoxEquipment_CheckedChanged);
            // 
            // checkBoxSupply
            // 
            this.checkBoxSupply.AutoSize = true;
            this.checkBoxSupply.Location = new System.Drawing.Point(19, 34);
            this.checkBoxSupply.Name = "checkBoxSupply";
            this.checkBoxSupply.Size = new System.Drawing.Size(76, 24);
            this.checkBoxSupply.TabIndex = 0;
            this.checkBoxSupply.Text = "Supply";
            this.checkBoxSupply.UseVisualStyleBackColor = true;
            this.checkBoxSupply.CheckedChanged += new System.EventHandler(this.checkBoxSupply_CheckedChanged);
            // 
            // buttonRequestNext
            // 
            this.buttonRequestNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRequestNext.Location = new System.Drawing.Point(17, 174);
            this.buttonRequestNext.Name = "buttonRequestNext";
            this.buttonRequestNext.Size = new System.Drawing.Size(342, 56);
            this.buttonRequestNext.TabIndex = 10;
            this.buttonRequestNext.Text = "Next";
            this.buttonRequestNext.UseVisualStyleBackColor = true;
            this.buttonRequestNext.Click += new System.EventHandler(this.buttonRequestNext_Click);
            // 
            // CreateTransactionRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 242);
            this.Controls.Add(this.buttonRequestNext);
            this.Controls.Add(this.groupBoxRequestingType);
            this.Controls.Add(this.labelMain);
            this.Name = "CreateTransactionRequest";
            this.Text = "CreateTransactionRequest";
            this.Load += new System.EventHandler(this.CreateTransactionRequest_Load);
            this.groupBoxRequestingType.ResumeLayout(false);
            this.groupBoxRequestingType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.GroupBox groupBoxRequestingType;
        private System.Windows.Forms.CheckBox checkBoxEquipment;
        private System.Windows.Forms.CheckBox checkBoxSupply;
        private System.Windows.Forms.Button buttonRequestNext;
    }
}