using System;
using Mngrs;
using Mngrs.External_Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLdumpGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WatermarkExtension.SetWatermark(txtMysqlUsername, "Username");
            WatermarkExtension.SetWatermark(txtMysqlPassword, "Password");
            tssl1.Text = "";
        }

        private bool Login()
        {
            try
            {
                tssl1.Text = Connection.CreateConnection(txtMysqlUsername.Text, txtMysqlPassword.Text);
                DAO dao = new DAO();
                dao.loadTable("show databases");
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                if (ex.Message.Contains("Access denied"))
                {
                    tssl1.Text = ex.Message;
                }
                return false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select the folder which MySQL is installed"})
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtFolderLocation.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnLoadDBs_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                DAO dao = new DAO();
                foreach (DataRow item in dao.loadTable("show databases").Rows)
                {
                    cbDatabases.Items.Add(item[0]);
                } 
            }
        }

        private void btnSearchBackup_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select the folder which the backup will be saved." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtBackupLocal.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (UtilitiesMngr.isFieldsEmpty(new object[] { txtBackupLocal, txtFolderLocation, txtMysqlPassword, txtMysqlUsername }))
            {
                string db = "A";
                if (cbDatabases.SelectedIndex != 0)
                {
                    db = "B" + cbDatabases.Text;
                }
                List<string> cmdlst = new List<string>();

                cmdlst.Add("cd " + '"' + txtFolderLocation.Text + @"\bin" + '"');
                cmdlst.Add(string.Format("mysqldump --add-drop-table -u{0} -p{1} -x -e -{2} > " + '"' + "{3}\\backup{4}.sql" + '"',
                    txtMysqlUsername.Text,
                    txtMysqlPassword.Text,
                    db,
                    txtBackupLocal.Text,
                    Data() + db.Substring(1)
                    ));

                tssl1.Text = "Backing up...";
                DirMngr.runCmdExit(cmdlst);
                tssl1.Text = "Backup Complete";
            }
            else
            {
                tssl1.Text = "Empty Fields";
            }
        }

        private string Data()
        {
            string date = DateTime.Today.ToString("d");
            string[] dma = date.Split('/');
            date = dma[0] + "-" + dma[1] + "-" + dma[2];
            return date;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opd = new OpenFileDialog() { Filter = "SQL Script|*.sql", Multiselect = false })
            {
                string path, db = "";
                if (opd.ShowDialog() == DialogResult.OK)
                {
                    path = opd.FileName;
                    if (cbDatabases.SelectedIndex != 0)
                    {
                        db = "--database=" + cbDatabases.SelectedText;
                    }

                    List<string> cmdLst = new List<string>();

                    cmdLst.Add("echo off");
                    cmdLst.Add("cd " + '"' + txtFolderLocation.Text + @"\bin" + '"');
                    cmdLst.Add(string.Format("mysql -u{0} -p{1} {2} < " + '"' + "{3}" + '"',
                        txtMysqlUsername.Text,
                        txtMysqlPassword.Text,
                        db,
                        path
                        ));

                    tssl1.Text = "Restoring...";
                    DirMngr.runCmdExit(cmdLst);
                    tssl1.Text = "Restore Complete";
                }
            }
        }
    }
}
