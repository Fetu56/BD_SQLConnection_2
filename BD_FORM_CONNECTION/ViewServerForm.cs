using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace BD_FORM_CONNECTION
{
    public partial class ViewServerForm : Form
    {
        private SqlConnection cn;
        private string _useDB;
        private string _useTB;
        private string _table;
        ToolStripButton buttonStrip;
        public ViewServerForm()
        {
            InitializeComponent();
        }

        private void ListBoxDataBases_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Level == 1)
            {
                LoadDataGreed(e.Node);
            }
        }

        private void ListBoxDataBases_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                if (e.Node.Level == 0)
                {
                    if (listBoxDataBases.Nodes.IndexOf(e.Node) != -1)
                    {
                        _useDB = e.Node.Text;
                        LoadTbs(e.Node);
                    }
                }
                else if (e.Node.Level == 1)
                {
                    _useTB = e.Node.Text;
                    _table = (_useTB != string.Empty ? "[" + _useTB + "]" : "[Table]");
                    LoadColums(e.Node);
                }
            }

        }
        private void LoadDataGreed(TreeNode node)
        {
            try
            {
                DataTable data = new DataTable();
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM [{node.Text}]", cn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                }
                dataGridView.DataSource = data;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { GC.Collect(); }
        }

        private void OnCloseForm(object sender, EventArgs e)
        {
            if (cn != null && cn.State != ConnectionState.Closed)
                cn.Close();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (TryConnect())
            {
                MessageBox.Show("Connected");
                LoadDbs();
                UnlockContent();
            }
            else { MessageBox.Show("Error"); }
        }
        private void UnlockContent()
        {
            foreach (var item in this.Controls)
            {
                (item as Control).Enabled = true;
            }
            toolStripMenuTemplates.Enabled = true;
        }
        private void LoadDbs()
        {
            listBoxDataBases.Nodes.Clear();
            List<string> dbs = new List<string>();
            Console.WriteLine("Базы данных:");
            using (SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases", cn))
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        dbs.Add(dr[0].ToString());
                    }
                }
            }
            listBoxDataBases.Nodes.AddRange(dbs.ConvertAll<TreeNode>(x => new TreeNode(x)).ToArray());
            //for(int i = 0; i < dbs.Count; i++)
            //{
            //    LoadTbs(dbs[i], i);
            //}
            GC.Collect();
        }
        private void LoadTbs(TreeNode node)
        {
            List<string> tbs = new List<string>();
            using (SqlCommand cmd = new SqlCommand($"USE {node.Text};SELECT name FROM sys.Tables", cn))
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        tbs.Add(dr[0].ToString());
                    }
                }
            }
            node.Nodes.Clear();
            node.Nodes.AddRange(tbs.ConvertAll<TreeNode>(x => new TreeNode(x)).ToArray());
            GC.Collect();
        }
        private void LoadColums(TreeNode node)
        {
            List<string> clmns = new List<string>();
            using (SqlCommand cmd = new SqlCommand($"SELECT [COLUMN_NAME], [DATA_TYPE] FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{node.Text}'", cn))
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        clmns.Add(dr[0].ToString() + " - " + dr[1].ToString());
                    }
                }
            }
            node.Nodes.Clear();
            node.Nodes.AddRange(clmns.ConvertAll<TreeNode>(x => new TreeNode(x)).ToArray());
            GC.Collect();
        }
        private bool TryConnect()
        {
            bool res = false;
            try
            {
                cn = new SqlConnection($"Data Source={toolStripTextBoxServer.Text};Initial Catalog=master;Integrated Security=False;User id={toolStripTextBoxLogin.Text};Password={toolStripTextBoxPass.Text}");
                cn.Open();
                if (cn.State != ConnectionState.Closed)
                {
                    res = true;
                }
            }
            catch { res = false; }
            return res;
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            try
            {

                string com = (_useDB != string.Empty ? "USE " + _useDB + ";" : "");
                using (SqlCommand cmd = new SqlCommand(com + textBoxSqlExec.Text, cn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { button1_Click(null, null); }
        }

        private void ViewServerForm_Load(object sender, EventArgs e)
        {
            this.buttonStrip.Click += Button_Click;

            this.updateTableToolStripMenuItem.Click += (s, e) => textBoxSqlExec.Text += "UPDATE " + _table + "SET col1='new'  WHERE id=1;";
            this.truncateTableToolStripMenuItem.Click += (s, e) => textBoxSqlExec.Text += "TRUNCATE TABLE " + _table + ";";

            this.toolStripMenuDeleteTable.Click += (s, e) => textBoxSqlExec.Text += "DELETE TABLE " + _table + ";";
            this.toolStripDeleteTableWhere.Click += (s, e) => textBoxSqlExec.Text += "DELETE FROM " + _table + " WHERE id = 0;";

            this.toolStripMenuSimpleProc.Click += (s, e) => textBoxSqlExec.Text += "CREATE PROCEDURE PROC1 AS BEGIN SELECT * FROM " + _table + " END;";
            this.toolStripSimpleProc1Par.Click += (s, e) => textBoxSqlExec.Text += "CREATE PROCEDURE PROC1 @id INT AS BEGIN SELECT * FROM " + _table + " WHERE id = @id END;";
            this.toolStripMenuSimpleProc2Par.Click += (s, e) => textBoxSqlExec.Text += "CREATE PROCEDURE PROC1 @id INT, @name VARCHAR(25) AS BEGIN SELECT * FROM " + _table + " WHERE id = @id AND name = @name END;";

            this.toolStripMenuExecProc.Click += (s, e) => textBoxSqlExec.Text += "EXEC PROC PROC1;";
            this.toolStripExecProcWithRet.Click += (s, e) => textBoxSqlExec.Text += "DECLARE @return_value INT EXEC @return_value = PROC1";

            this.toolStripMenuTableWithForeign.Click += (s, e) => textBoxSqlExec.Text += "CREATE TABLE Table1([id] INT INDENTITY PRIMARY KEY, [name] VARCHAR(25) NOT NULL, table_id int,  FOREIGN KEY (table_id) REFERENCES Table2(talbe2_id));";
            this.toolStripMenuSimple.Click += (s, e) => textBoxSqlExec.Text += "CREATE TABLE [Table]([id] INT INDENTITY PRIMARY KEY, [name] VARCHAR(25) NOT NULL);";
            this.toolStripMenuSimpledesc.Click += (s, e) => textBoxSqlExec.Text += "CREATE TABLE [Table]([id] INT INDENTITY PRIMARY KEY, [name] VARCHAR(25) NOT NULL, [desc] TEXT NULL);";
            this.toolStripMenuInsertInto1col.Click += (s, e) => textBoxSqlExec.Text += "INSERT INTO " + _table + " VALUES(col1);";
            this.toolStripMenuInsertInto2col.Click += (s, e) => textBoxSqlExec.Text += "INSERT INTO " + _table + " VALUES(col1, col2);";
            this.toolStripMenuInsertInto3col.Click += (s, e) => textBoxSqlExec.Text += "INSERT INTO " + _table + " VALUES(col1, col2, col3);";
            this.toolStripMenuSimpledescanddate.Click += (s, e) => textBoxSqlExec.Text += "CREATE TABLE [Table]([id] INT INDENTITY PRIMARY KEY, [name] VARCHAR(25) NOT NULL, [desc] TEXT NULL, [date] DATETIME NULL);";
            this.FormClosing += OnCloseForm;
            this.listBoxDataBases.NodeMouseClick += ListBoxDataBases_NodeMouseClick;
            dataGridView.ScrollBars = ScrollBars.Both;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
            this.listBoxDataBases.BeforeSelect += ListBoxDataBases_BeforeSelect;
        }

        private void buttonUnuse_Click(object sender, EventArgs e)
        {
            this._useDB = string.Empty;
            this._useTB = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxDataBases.SelectedNode != null && listBoxDataBases.SelectedNode.Level == 1)
            {
                LoadDataGreed(listBoxDataBases.SelectedNode);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string com = Interaction.InputBox("Input your sql command to take result");
            using (SqlCommand cmd = new SqlCommand(com + textBoxSqlExec.Text, cn))
            {
                MessageBox.Show(Convert.ToString(cmd.ExecuteScalar()));
            }
        }
    }
}
