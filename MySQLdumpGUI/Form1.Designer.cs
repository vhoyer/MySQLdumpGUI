namespace MySQLdumpGUI
{
    partial class Form1
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFolderLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMysqlPassword = new System.Windows.Forms.TextBox();
            this.txtMysqlUsername = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBackupLocal = new System.Windows.Forms.TextBox();
            this.btnSearchBackup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoadDBs = new System.Windows.Forms.Button();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(415, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFolderLocation
            // 
            this.txtFolderLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderLocation.Location = new System.Drawing.Point(12, 32);
            this.txtFolderLocation.Name = "txtFolderLocation";
            this.txtFolderLocation.Size = new System.Drawing.Size(397, 20);
            this.txtFolderLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MySQL Server 5.x Folder Location";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMysqlPassword);
            this.groupBox1.Controls.Add(this.txtMysqlUsername);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 75);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MySQL Credentials";
            // 
            // txtMysqlPassword
            // 
            this.txtMysqlPassword.Location = new System.Drawing.Point(6, 45);
            this.txtMysqlPassword.Name = "txtMysqlPassword";
            this.txtMysqlPassword.Size = new System.Drawing.Size(153, 20);
            this.txtMysqlPassword.TabIndex = 2;
            this.txtMysqlPassword.UseSystemPasswordChar = true;
            // 
            // txtMysqlUsername
            // 
            this.txtMysqlUsername.Location = new System.Drawing.Point(6, 19);
            this.txtMysqlUsername.Name = "txtMysqlUsername";
            this.txtMysqlUsername.Size = new System.Drawing.Size(153, 20);
            this.txtMysqlUsername.TabIndex = 0;
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup.Location = new System.Drawing.Point(415, 128);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(415, 157);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Backup Folder Location";
            // 
            // txtBackupLocal
            // 
            this.txtBackupLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackupLocal.Location = new System.Drawing.Point(13, 77);
            this.txtBackupLocal.Name = "txtBackupLocal";
            this.txtBackupLocal.Size = new System.Drawing.Size(397, 20);
            this.txtBackupLocal.TabIndex = 7;
            // 
            // btnSearchBackup
            // 
            this.btnSearchBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchBackup.Location = new System.Drawing.Point(416, 75);
            this.btnSearchBackup.Name = "btnSearchBackup";
            this.btnSearchBackup.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBackup.TabIndex = 6;
            this.btnSearchBackup.Text = "Search";
            this.btnSearchBackup.UseVisualStyleBackColor = true;
            this.btnSearchBackup.Click += new System.EventHandler(this.btnSearchBackup_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoadDBs);
            this.groupBox2.Controls.Add(this.cbDatabases);
            this.groupBox2.Location = new System.Drawing.Point(184, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 75);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Databases";
            // 
            // btnLoadDBs
            // 
            this.btnLoadDBs.Location = new System.Drawing.Point(7, 46);
            this.btnLoadDBs.Name = "btnLoadDBs";
            this.btnLoadDBs.Size = new System.Drawing.Size(116, 23);
            this.btnLoadDBs.TabIndex = 1;
            this.btnLoadDBs.Text = "Load Databases";
            this.btnLoadDBs.UseVisualStyleBackColor = true;
            this.btnLoadDBs.Click += new System.EventHandler(this.btnLoadDBs_Click);
            // 
            // cbDatabases
            // 
            this.cbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Items.AddRange(new object[] {
            "Everthing"});
            this.cbDatabases.Location = new System.Drawing.Point(7, 19);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(116, 21);
            this.cbDatabases.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 189);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(504, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl1
            // 
            this.tssl1.Name = "tssl1";
            this.tssl1.Size = new System.Drawing.Size(30, 17);
            this.tssl1.Text = "tssl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 211);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBackupLocal);
            this.Controls.Add(this.btnSearchBackup);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFolderLocation);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.Text = "MySQLdumpGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFolderLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMysqlPassword;
        private System.Windows.Forms.TextBox txtMysqlUsername;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBackupLocal;
        private System.Windows.Forms.Button btnSearchBackup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Button btnLoadDBs;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl1;
    }
}

