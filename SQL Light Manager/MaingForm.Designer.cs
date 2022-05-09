
namespace SQL_Light_Manager
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtConn = new System.Windows.Forms.TextBox();
            this.lblQuery = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblConn = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.gvResult = new System.Windows.Forms.DataGridView();
            this.txtError = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnNonQuery = new System.Windows.Forms.Button();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblTableRows = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConn
            // 
            this.txtConn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtConn, 2);
            this.txtConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConn.Location = new System.Drawing.Point(3, 28);
            this.txtConn.Name = "txtConn";
            this.txtConn.Size = new System.Drawing.Size(794, 23);
            this.txtConn.TabIndex = 0;
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblQuery, 2);
            this.lblQuery.Location = new System.Drawing.Point(3, 55);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(38, 13);
            this.lblQuery.TabIndex = 4;
            this.lblQuery.Text = "Query:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblConn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQuery, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtConn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtQuery, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblResult, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblError, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.gvResult, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtError, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnNonQuery, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbTables, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblRows, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblTableRows, 1, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblConn
            // 
            this.lblConn.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblConn, 2);
            this.lblConn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConn.Location = new System.Drawing.Point(3, 0);
            this.lblConn.Name = "lblConn";
            this.lblConn.Size = new System.Drawing.Size(794, 13);
            this.lblConn.TabIndex = 5;
            this.lblConn.Text = "Connection String:";
            // 
            // txtQuery
            // 
            this.txtQuery.AcceptsReturn = true;
            this.txtQuery.AcceptsTab = true;
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtQuery, 2);
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(3, 83);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuery.Size = new System.Drawing.Size(794, 109);
            this.txtQuery.TabIndex = 6;
            this.txtQuery.WordWrap = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(3, 195);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Resultado:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblError, 2);
            this.lblError.Location = new System.Drawing.Point(3, 335);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(32, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Error:";
            // 
            // gvResult
            // 
            this.gvResult.AllowUserToAddRows = false;
            this.gvResult.AllowUserToDeleteRows = false;
            this.gvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.gvResult, 2);
            this.gvResult.Location = new System.Drawing.Point(3, 223);
            this.gvResult.Name = "gvResult";
            this.gvResult.ReadOnly = true;
            this.gvResult.Size = new System.Drawing.Size(794, 109);
            this.gvResult.TabIndex = 9;
            this.gvResult.Visible = false;
            // 
            // txtError
            // 
            this.txtError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtError, 2);
            this.txtError.Location = new System.Drawing.Point(3, 363);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtError.Size = new System.Drawing.Size(794, 32);
            this.txtError.TabIndex = 10;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(3, 401);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.Query);
            // 
            // btnNonQuery
            // 
            this.btnNonQuery.Location = new System.Drawing.Point(403, 401);
            this.btnNonQuery.Name = "btnNonQuery";
            this.btnNonQuery.Size = new System.Drawing.Size(75, 23);
            this.btnNonQuery.TabIndex = 12;
            this.btnNonQuery.Text = "No Query";
            this.btnNonQuery.UseVisualStyleBackColor = true;
            this.btnNonQuery.Click += new System.EventHandler(this.NonQuery);
            // 
            // cmbTables
            // 
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(403, 198);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(121, 21);
            this.cmbTables.TabIndex = 13;
            this.cmbTables.SelectionChangeCommitted += new System.EventHandler(this.SwitchTable);
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(3, 428);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(81, 13);
            this.lblRows.TabIndex = 14;
            this.lblRows.Text = "Filas afectadas:";
            // 
            // lblTableRows
            // 
            this.lblTableRows.AutoSize = true;
            this.lblTableRows.Location = new System.Drawing.Point(403, 428);
            this.lblTableRows.Name = "lblTableRows";
            this.lblTableRows.Size = new System.Drawing.Size(86, 13);
            this.lblTableRows.TabIndex = 15;
            this.lblTableRows.Text = "Filas en la tabla: ";
            this.lblTableRows.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SQL Light Manager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtConn;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblConn;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView gvResult;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Button btnNonQuery;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblTableRows;
    }
}

