using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace Medication_Tracker
{
    public partial class MedicationSearchForm : Form
    {
        DataConnection data;

        public MedicationSearchForm()
        {
            InitializeComponent();

            data = new DataConnection();
        }

        #region EVENTS

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtSymptom.Text == "")
            {
                return;
            }
            gridMedicine.Columns.Clear();
            gridMedicine.DataSource = null;
            DataSet ds;
            if (txtName.Text != "") //Searching by name
            {
                ArrayList parms = new ArrayList()
                {
                    new SqlParameter("@Name", txtName.Text)
                };
                ds = data.GetDataSet("GetMedicationByName", parms);
                ds.Tables[0].Columns.Remove("ID");
            }
            else //Searching by symptom
            {
                ArrayList parms = new ArrayList()
                {
                    new SqlParameter("@Symptom", txtSymptom.Text)
                };
                ds = data.GetDataSet("GetMedicationsBySymptom", parms);
                ds.Tables[0].Columns.Remove("ID");
            }

            gridMedicine.DataSource = ds.Tables[0];
            gridMedicine.Font = new Font("Microsoft Sans Serif", 16F);
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.HeaderText = "Add";
            col.Name = "AddMed";
            gridMedicine.Columns.Add(col);
            foreach(DataGridViewRow row in gridMedicine.Rows)
            {
                DataGridViewButtonCell cell = (DataGridViewButtonCell)row.Cells["AddMed"];
                cell.Value = "Add";
            }
        }
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSearch_Click(this, new EventArgs());
            }
        }

        private void txtSymptom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSearch_Click(this, new EventArgs());
            }
        }
        #endregion EVENTS

        private void GridMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //this is part of add button in grid
                AddMedForm medForm = new AddMedForm();
                medForm.ShowDialog();

                
                if(medForm.DialogResult == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
