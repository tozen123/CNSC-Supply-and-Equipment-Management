
namespace CNSC_Supply_and_Equipment_Management
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.approvedRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disapprovedRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTypeUser = new System.Windows.Forms.Label();
            this.tabControlOfficesRecord = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(11, 37);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(570, 29);
            this.labelMain.TabIndex = 4;
            this.labelMain.Text = "CNSC Supply and Equipment Management System";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.recordsToolStripMenuItem,
            this.officeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "Menu";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestToolStripMenuItem,
            this.pendingRequestsToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // requestToolStripMenuItem
            // 
            this.requestToolStripMenuItem.Name = "requestToolStripMenuItem";
            this.requestToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.requestToolStripMenuItem.Text = "Request";
            this.requestToolStripMenuItem.Click += new System.EventHandler(this.requestToolStripMenuItem_Click);
            // 
            // pendingRequestsToolStripMenuItem
            // 
            this.pendingRequestsToolStripMenuItem.Name = "pendingRequestsToolStripMenuItem";
            this.pendingRequestsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.pendingRequestsToolStripMenuItem.Text = "Pending Requests";
            this.pendingRequestsToolStripMenuItem.Click += new System.EventHandler(this.pendingRequestsToolStripMenuItem_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplyToolStripMenuItem1,
            this.equipmentsToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.requestsToolStripMenuItem});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.recordsToolStripMenuItem.Text = "Master Records";
            // 
            // supplyToolStripMenuItem1
            // 
            this.supplyToolStripMenuItem1.Name = "supplyToolStripMenuItem1";
            this.supplyToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.supplyToolStripMenuItem1.Text = "Supply";
            this.supplyToolStripMenuItem1.Click += new System.EventHandler(this.supplyToolStripMenuItem1_Click);
            // 
            // equipmentsToolStripMenuItem
            // 
            this.equipmentsToolStripMenuItem.Name = "equipmentsToolStripMenuItem";
            this.equipmentsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.equipmentsToolStripMenuItem.Text = "Equipments";
            this.equipmentsToolStripMenuItem.Click += new System.EventHandler(this.equipmentsToolStripMenuItem_Click);
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.departmentsToolStripMenuItem.Text = "Offices";
            this.departmentsToolStripMenuItem.Click += new System.EventHandler(this.departmentsToolStripMenuItem_Click);
            // 
            // requestsToolStripMenuItem
            // 
            this.requestsToolStripMenuItem.Name = "requestsToolStripMenuItem";
            this.requestsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.requestsToolStripMenuItem.Text = "Requests";
            this.requestsToolStripMenuItem.Click += new System.EventHandler(this.requestsToolStripMenuItem_Click);
            // 
            // officeToolStripMenuItem
            // 
            this.officeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordsToolStripMenuItem1,
            this.equipmentToolStripMenuItem1,
            this.approvedRequestToolStripMenuItem,
            this.disapprovedRequestsToolStripMenuItem,
            this.pendingRequestToolStripMenuItem});
            this.officeToolStripMenuItem.Name = "officeToolStripMenuItem";
            this.officeToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.officeToolStripMenuItem.Text = "Office Records";
            // 
            // recordsToolStripMenuItem1
            // 
            this.recordsToolStripMenuItem1.Name = "recordsToolStripMenuItem1";
            this.recordsToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.recordsToolStripMenuItem1.Text = "Supply";
            this.recordsToolStripMenuItem1.Click += new System.EventHandler(this.recordsToolStripMenuItem1_Click);
            // 
            // equipmentToolStripMenuItem1
            // 
            this.equipmentToolStripMenuItem1.Name = "equipmentToolStripMenuItem1";
            this.equipmentToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.equipmentToolStripMenuItem1.Text = "Equipment";
            this.equipmentToolStripMenuItem1.Click += new System.EventHandler(this.equipmentToolStripMenuItem1_Click);
            // 
            // approvedRequestToolStripMenuItem
            // 
            this.approvedRequestToolStripMenuItem.Name = "approvedRequestToolStripMenuItem";
            this.approvedRequestToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.approvedRequestToolStripMenuItem.Text = "Approved Requests";
            this.approvedRequestToolStripMenuItem.Click += new System.EventHandler(this.approvedRequestToolStripMenuItem_Click);
            // 
            // disapprovedRequestsToolStripMenuItem
            // 
            this.disapprovedRequestsToolStripMenuItem.Name = "disapprovedRequestsToolStripMenuItem";
            this.disapprovedRequestsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.disapprovedRequestsToolStripMenuItem.Text = "Disapproved Requests";
            this.disapprovedRequestsToolStripMenuItem.Click += new System.EventHandler(this.disapprovedRequestsToolStripMenuItem_Click);
            // 
            // pendingRequestToolStripMenuItem
            // 
            this.pendingRequestToolStripMenuItem.Name = "pendingRequestToolStripMenuItem";
            this.pendingRequestToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pendingRequestToolStripMenuItem.Text = "Pending Request";
            this.pendingRequestToolStripMenuItem.Click += new System.EventHandler(this.pendingRequestToolStripMenuItem_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelName.Location = new System.Drawing.Point(12, 79);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(95, 22);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Hello, User";
            // 
            // labelTypeUser
            // 
            this.labelTypeUser.AutoSize = true;
            this.labelTypeUser.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeUser.Location = new System.Drawing.Point(14, 101);
            this.labelTypeUser.Name = "labelTypeUser";
            this.labelTypeUser.Size = new System.Drawing.Size(68, 18);
            this.labelTypeUser.TabIndex = 7;
            this.labelTypeUser.Text = "TypeUser";
            // 
            // tabControlOfficesRecord
            // 
            this.tabControlOfficesRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlOfficesRecord.Location = new System.Drawing.Point(12, 136);
            this.tabControlOfficesRecord.Name = "tabControlOfficesRecord";
            this.tabControlOfficesRecord.SelectedIndex = 0;
            this.tabControlOfficesRecord.Size = new System.Drawing.Size(981, 526);
            this.tabControlOfficesRecord.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CNSC_Supply_and_Equipment_Management.Properties.Resources.CNSC_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(910, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(806, 101);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(98, 29);
            this.buttonRefresh.TabIndex = 16;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1005, 695);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControlOfficesRecord);
            this.Controls.Add(this.labelTypeUser);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "CNSC Supply and Equipment Management";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendingRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem equipmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTypeUser;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem equipmentToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControlOfficesRecord;
        private System.Windows.Forms.ToolStripMenuItem approvedRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disapprovedRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendingRequestToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

