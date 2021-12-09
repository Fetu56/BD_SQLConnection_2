
namespace BD_FORM_CONNECTION
{
    partial class ViewServerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBoxServer = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxLogin = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxPass = new System.Windows.Forms.ToolStripTextBox();
            this.buttonStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenuTemplates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuProc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExecProc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExecProcWithRet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSimpleProc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSimpleProc1Par = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSimpleProc2Par = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuTables = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSimple = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSimpledesc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSimpledescanddate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuInsertInto1col = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuInsertInto2col = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuInsertInto3col = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuTableWithForeign = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDeleteTable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDeleteTableWhere = new System.Windows.Forms.ToolStripMenuItem();
            this.truncateTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxDataBases = new System.Windows.Forms.TreeView();
            this.textBoxSqlExec = new System.Windows.Forms.TextBox();
            this.buttonExec = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonUnuse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxServer,
            this.toolStripTextBoxLogin,
            this.toolStripTextBoxPass,
            this.buttonStrip,
            this.toolStripMenuTemplates});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBoxServer
            // 
            this.toolStripTextBoxServer.Name = "toolStripTextBoxServer";
            this.toolStripTextBoxServer.Size = new System.Drawing.Size(125, 23);
            this.toolStripTextBoxServer.Text = "sql5080.site4now.net";
            // 
            // toolStripTextBoxLogin
            // 
            this.toolStripTextBoxLogin.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.toolStripTextBoxLogin.Name = "toolStripTextBoxLogin";
            this.toolStripTextBoxLogin.Size = new System.Drawing.Size(125, 23);
            this.toolStripTextBoxLogin.Text = "db_a7d303_fet_admin";
            // 
            // toolStripTextBoxPass
            // 
            this.toolStripTextBoxPass.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripTextBoxPass.Name = "toolStripTextBoxPass";
            this.toolStripTextBoxPass.Size = new System.Drawing.Size(125, 23);
            this.toolStripTextBoxPass.Text = "EgorPrivet123";
            // 
            // buttonStrip
            // 
            this.buttonStrip.Name = "buttonStrip";
            this.buttonStrip.Size = new System.Drawing.Size(64, 20);
            this.buttonStrip.Text = "CONFIRM";
            // 
            // toolStripMenuTemplates
            // 
            this.toolStripMenuTemplates.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuProc,
            this.toolStripMenuTables,
            this.toolStripMenuQuery});
            this.toolStripMenuTemplates.Enabled = false;
            this.toolStripMenuTemplates.Margin = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.toolStripMenuTemplates.Name = "toolStripMenuTemplates";
            this.toolStripMenuTemplates.Size = new System.Drawing.Size(72, 23);
            this.toolStripMenuTemplates.Text = "Templates";
            // 
            // toolStripMenuProc
            // 
            this.toolStripMenuProc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuExecProc,
            this.toolStripExecProcWithRet,
            this.toolStripMenuSimpleProc,
            this.toolStripSimpleProc1Par,
            this.toolStripMenuSimpleProc2Par});
            this.toolStripMenuProc.Name = "toolStripMenuProc";
            this.toolStripMenuProc.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuProc.Text = "Proc";
            // 
            // toolStripMenuExecProc
            // 
            this.toolStripMenuExecProc.Name = "toolStripMenuExecProc";
            this.toolStripMenuExecProc.Size = new System.Drawing.Size(233, 22);
            this.toolStripMenuExecProc.Text = "Execute procedure";
            // 
            // toolStripExecProcWithRet
            // 
            this.toolStripExecProcWithRet.Name = "toolStripExecProcWithRet";
            this.toolStripExecProcWithRet.Size = new System.Drawing.Size(233, 22);
            this.toolStripExecProcWithRet.Text = "Execute procedure with return";
            // 
            // toolStripMenuSimpleProc
            // 
            this.toolStripMenuSimpleProc.Name = "toolStripMenuSimpleProc";
            this.toolStripMenuSimpleProc.Size = new System.Drawing.Size(233, 22);
            this.toolStripMenuSimpleProc.Text = "Simple procedure";
            // 
            // toolStripSimpleProc1Par
            // 
            this.toolStripSimpleProc1Par.Name = "toolStripSimpleProc1Par";
            this.toolStripSimpleProc1Par.Size = new System.Drawing.Size(233, 22);
            this.toolStripSimpleProc1Par.Text = "Simple proc with 1 param";
            // 
            // toolStripMenuSimpleProc2Par
            // 
            this.toolStripMenuSimpleProc2Par.Name = "toolStripMenuSimpleProc2Par";
            this.toolStripMenuSimpleProc2Par.Size = new System.Drawing.Size(233, 22);
            this.toolStripMenuSimpleProc2Par.Text = "Simple proc with 2 params";
            // 
            // toolStripMenuTables
            // 
            this.toolStripMenuTables.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuSimple,
            this.toolStripMenuSimpledesc,
            this.toolStripMenuSimpledescanddate,
            this.toolStripMenuInsertInto1col,
            this.toolStripMenuInsertInto2col,
            this.toolStripMenuInsertInto3col,
            this.toolStripMenuTableWithForeign});
            this.toolStripMenuTables.Name = "toolStripMenuTables";
            this.toolStripMenuTables.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuTables.Text = "Tables";
            // 
            // toolStripMenuSimple
            // 
            this.toolStripMenuSimple.Name = "toolStripMenuSimple";
            this.toolStripMenuSimple.Size = new System.Drawing.Size(300, 22);
            this.toolStripMenuSimple.Text = "Simple table with name";
            // 
            // toolStripMenuSimpledesc
            // 
            this.toolStripMenuSimpledesc.Name = "toolStripMenuSimpledesc";
            this.toolStripMenuSimpledesc.Size = new System.Drawing.Size(300, 22);
            this.toolStripMenuSimpledesc.Text = "Simple table with name with desc";
            // 
            // toolStripMenuSimpledescanddate
            // 
            this.toolStripMenuSimpledescanddate.Name = "toolStripMenuSimpledescanddate";
            this.toolStripMenuSimpledescanddate.Size = new System.Drawing.Size(300, 22);
            this.toolStripMenuSimpledescanddate.Text = "Simple table with name with desc and date";
            // 
            // toolStripMenuInsertInto1col
            // 
            this.toolStripMenuInsertInto1col.Name = "toolStripMenuInsertInto1col";
            this.toolStripMenuInsertInto1col.Size = new System.Drawing.Size(300, 22);
            this.toolStripMenuInsertInto1col.Text = "Insert into Table - 1 column";
            // 
            // toolStripMenuInsertInto2col
            // 
            this.toolStripMenuInsertInto2col.Name = "toolStripMenuInsertInto2col";
            this.toolStripMenuInsertInto2col.Size = new System.Drawing.Size(300, 22);
            this.toolStripMenuInsertInto2col.Text = "Insert into Table - 2 column";
            // 
            // toolStripMenuInsertInto3col
            // 
            this.toolStripMenuInsertInto3col.Name = "toolStripMenuInsertInto3col";
            this.toolStripMenuInsertInto3col.Size = new System.Drawing.Size(300, 22);
            this.toolStripMenuInsertInto3col.Text = "Insert into Table - 3 column";
            // 
            // toolStripMenuTableWithForeign
            // 
            this.toolStripMenuTableWithForeign.Name = "toolStripMenuTableWithForeign";
            this.toolStripMenuTableWithForeign.Size = new System.Drawing.Size(300, 22);
            this.toolStripMenuTableWithForeign.Text = "Table with foreign key";
            // 
            // toolStripMenuQuery
            // 
            this.toolStripMenuQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuDeleteTable,
            this.toolStripDeleteTableWhere,
            this.truncateTableToolStripMenuItem,
            this.updateTableToolStripMenuItem});
            this.toolStripMenuQuery.Name = "toolStripMenuQuery";
            this.toolStripMenuQuery.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuQuery.Text = "Query";
            // 
            // toolStripMenuDeleteTable
            // 
            this.toolStripMenuDeleteTable.Name = "toolStripMenuDeleteTable";
            this.toolStripMenuDeleteTable.Size = new System.Drawing.Size(225, 22);
            this.toolStripMenuDeleteTable.Text = "DELETE FROM TABLE";
            // 
            // toolStripDeleteTableWhere
            // 
            this.toolStripDeleteTableWhere.Name = "toolStripDeleteTableWhere";
            this.toolStripDeleteTableWhere.Size = new System.Drawing.Size(225, 22);
            this.toolStripDeleteTableWhere.Text = "DELETE FROM TABLE WHERE";
            // 
            // truncateTableToolStripMenuItem
            // 
            this.truncateTableToolStripMenuItem.Name = "truncateTableToolStripMenuItem";
            this.truncateTableToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.truncateTableToolStripMenuItem.Text = "Truncate table";
            // 
            // updateTableToolStripMenuItem
            // 
            this.updateTableToolStripMenuItem.Name = "updateTableToolStripMenuItem";
            this.updateTableToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.updateTableToolStripMenuItem.Text = "Update table";
            // 
            // listBoxDataBases
            // 
            this.listBoxDataBases.Enabled = false;
            this.listBoxDataBases.Location = new System.Drawing.Point(7, 30);
            this.listBoxDataBases.Name = "listBoxDataBases";
            this.listBoxDataBases.Size = new System.Drawing.Size(229, 408);
            this.listBoxDataBases.TabIndex = 3;
            // 
            // textBoxSqlExec
            // 
            this.textBoxSqlExec.Enabled = false;
            this.textBoxSqlExec.Location = new System.Drawing.Point(242, 238);
            this.textBoxSqlExec.Multiline = true;
            this.textBoxSqlExec.Name = "textBoxSqlExec";
            this.textBoxSqlExec.Size = new System.Drawing.Size(453, 200);
            this.textBoxSqlExec.TabIndex = 4;
            // 
            // buttonExec
            // 
            this.buttonExec.Enabled = false;
            this.buttonExec.Location = new System.Drawing.Point(613, 209);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(82, 23);
            this.buttonExec.TabIndex = 5;
            this.buttonExec.Text = "Execute SQL";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Enabled = false;
            this.dataGridView.Location = new System.Drawing.Point(242, 30);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(453, 173);
            this.dataGridView.TabIndex = 6;
            // 
            // buttonUnuse
            // 
            this.buttonUnuse.Enabled = false;
            this.buttonUnuse.Location = new System.Drawing.Point(242, 209);
            this.buttonUnuse.Name = "buttonUnuse";
            this.buttonUnuse.Size = new System.Drawing.Size(82, 23);
            this.buttonUnuse.TabIndex = 7;
            this.buttonUnuse.Text = "Unuse db";
            this.buttonUnuse.UseVisualStyleBackColor = true;
            this.buttonUnuse.Click += new System.EventHandler(this.buttonUnuse_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(461, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "RE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(420, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "exe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUnuse);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.textBoxSqlExec);
            this.Controls.Add(this.listBoxDataBases);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewServerForm";
            this.Text = "SQL connection";
            this.Load += new System.EventHandler(this.ViewServerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxServer;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxLogin;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPass;
        private System.Windows.Forms.TreeView listBoxDataBases;
        private System.Windows.Forms.TextBox textBoxSqlExec;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuTemplates;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuProc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuTables;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuQuery;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSimple;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSimpledesc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuInsertInto1col;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSimpledescanddate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuInsertInto2col;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuInsertInto3col;
        private System.Windows.Forms.Button buttonUnuse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuTableWithForeign;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExecProc;
        private System.Windows.Forms.ToolStripMenuItem toolStripExecProcWithRet;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSimpleProc;
        private System.Windows.Forms.ToolStripMenuItem toolStripSimpleProc1Par;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSimpleProc2Par;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDeleteTable;
        private System.Windows.Forms.ToolStripMenuItem toolStripDeleteTableWhere;
        private System.Windows.Forms.ToolStripMenuItem truncateTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTableToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}

