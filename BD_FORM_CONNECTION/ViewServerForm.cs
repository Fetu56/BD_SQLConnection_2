using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_FORM_CONNECTION
{
    public partial class ViewServerForm : Form
    {
        private SqlConnection cn;
        string useDB;
        public ViewServerForm()
        {
            InitializeComponent();
            ToolStripButton button = new ToolStripButton("CONFIRM");
            button.Click += Button_Click;
            this.menuStrip1.Items.Add(button);
            this.FormClosing += OnCloseForm;
            this.listBoxDataBases.NodeMouseClick += ListBoxDataBases_NodeMouseClick;
            dataGridView.ScrollBars = ScrollBars.Both;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
            this.listBoxDataBases.BeforeSelect += ListBoxDataBases_BeforeSelect;
        }

        private void ListBoxDataBases_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if(e.Node.Level == 1)
            {
                LoadDataGreed(e.Node);
            }
        }

        private void ListBoxDataBases_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Nodes.Count == 0)
            {
                if (e.Node.Level == 0)
                {
                    useDB = string.Empty;
                    if (listBoxDataBases.Nodes.IndexOf(e.Node) != -1)
                    {
                        useDB = e.Node.Text;
                        LoadTbs(e.Node);
                    }
                }
                else if (e.Node.Level == 1)
                {
                    LoadColums(e.Node);
                }
            }
            
        }
        private void LoadDataGreed(TreeNode node)
        {
            try
            {
                DataTable data = new DataTable();
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM {node.Text}", cn))
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
            if(cn != null && cn.State != ConnectionState.Closed)
                cn.Close();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (TryConnect())
            {
                MessageBox.Show("Connected");
                LoadDbs();
            }
            else { MessageBox.Show("Error"); }
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
                        clmns.Add(dr[0].ToString()+" - "+ dr[1].ToString());
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
                using (SqlCommand cmd = new SqlCommand((useDB != string.Empty ? useDB + ";" : "") + textBoxSqlExec.Text, cn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message);}
            
        }
    }
}
