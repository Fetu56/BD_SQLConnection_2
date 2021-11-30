
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
            this.listBoxDataBases = new System.Windows.Forms.TreeView();
            this.textBoxSqlExec = new System.Windows.Forms.TextBox();
            this.buttonExec = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxServer,
            this.toolStripTextBoxLogin,
            this.toolStripTextBoxPass});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBoxServer
            // 
            this.toolStripTextBoxServer.Name = "toolStripTextBoxServer";
            this.toolStripTextBoxServer.Size = new System.Drawing.Size(175, 23);
            this.toolStripTextBoxServer.Text = "sql5080.site4now.net";
            // 
            // toolStripTextBoxLogin
            // 
            this.toolStripTextBoxLogin.Margin = new System.Windows.Forms.Padding(40, 0, 1, 0);
            this.toolStripTextBoxLogin.Name = "toolStripTextBoxLogin";
            this.toolStripTextBoxLogin.Size = new System.Drawing.Size(150, 23);
            this.toolStripTextBoxLogin.Text = "db_a7d303_fet_admin";
            // 
            // toolStripTextBoxPass
            // 
            this.toolStripTextBoxPass.Margin = new System.Windows.Forms.Padding(40, 0, 60, 0);
            this.toolStripTextBoxPass.Name = "toolStripTextBoxPass";
            this.toolStripTextBoxPass.Size = new System.Drawing.Size(150, 23);
            this.toolStripTextBoxPass.Text = "EgorPrivet123";
            // 
            // listBoxDataBases
            // 
            this.listBoxDataBases.Location = new System.Drawing.Point(7, 30);
            this.listBoxDataBases.Name = "listBoxDataBases";
            this.listBoxDataBases.Size = new System.Drawing.Size(229, 408);
            this.listBoxDataBases.TabIndex = 3;
            // 
            // textBoxSqlExec
            // 
            this.textBoxSqlExec.Location = new System.Drawing.Point(242, 238);
            this.textBoxSqlExec.Multiline = true;
            this.textBoxSqlExec.Name = "textBoxSqlExec";
            this.textBoxSqlExec.Size = new System.Drawing.Size(453, 200);
            this.textBoxSqlExec.TabIndex = 4;
            // 
            // buttonExec
            // 
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
            this.dataGridView.Location = new System.Drawing.Point(242, 30);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(453, 173);
            this.dataGridView.TabIndex = 6;
            // 
            // ViewServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.textBoxSqlExec);
            this.Controls.Add(this.listBoxDataBases);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewServerForm";
            this.Text = "SQL connection";
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
    }
}

