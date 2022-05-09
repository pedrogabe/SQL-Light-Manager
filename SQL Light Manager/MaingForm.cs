using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DB;

namespace SQL_Light_Manager
{
    public partial class MainForm : Form
    {
        private DBResponse LastQueryResult;
        public MainForm()
        {
            InitializeComponent();
        }

        private void FillWithRange(ComboBox box, in int size)
        {
            box.Items.Clear();
            if (size > 0)
            {
                for(int i = 0; i<size; i++)
                {
                    box.Items.Add(i);
                }
                box.SelectedIndex = 0;
            }
        }

        private void Query(object sender, EventArgs e)
        {
            DBManager.connString = txtConn.Text;
            string query = txtQuery.SelectedText.Length > 0 ? txtQuery.SelectedText : txtQuery.Text;
            var result = DBManager.Query(query);

            txtError.Text = result.Error ?? "";
            if (result.Successful)
            {
                FillWithRange(cmbTables, result.Tables.Count);
                if (result.HasTables)
                {
                    gvResult.DataSource = result.Tables[0];
                    gvResult.Refresh();
                    gvResult.Visible = true;
                    UpdateRowsInTable(result.Tables[0].Rows.Count);
                }
                else
                {
                    gvResult.Visible = false;
                    UpdateRowsInTable();
                }

                UpdateAffectedRows(result.AffectedRows);
                LastQueryResult = result;
            }

        }

        private void SwitchTable(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            var selectedTable = LastQueryResult.Tables[combo.SelectedIndex];
            gvResult.DataSource = selectedTable;
            gvResult.Refresh();
            UpdateRowsInTable(selectedTable.Rows.Count);
        }

        private void NonQuery(object sender, EventArgs e)
        {
            DBManager.connString = txtConn.Text;
            var result = DBManager.NonQuery(txtQuery.Text);

            txtError.Text = result.Error ?? "";

            if (result.Successful)
            {
                UpdateAffectedRows(result.AffectedRows);
                UpdateRowsInTable();
            }
        }

        private void UpdateAffectedRows(in int affectedRows)
        {
            lblRows.Text = "Filas afectadas: " + affectedRows;
        }

        private void UpdateRowsInTable(in int? rowsInTable = null)
        {
            if (rowsInTable == null)
            {
                lblTableRows.Visible = false;
            }
            else
            {
                lblTableRows.Visible = true;
                lblTableRows.Text = "Filas en la tabla: " + rowsInTable;
            }
        }
    }
}
