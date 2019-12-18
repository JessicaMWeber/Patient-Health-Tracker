using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Data;

namespace Medication_Tracker
{
    public partial class MedicationSearchForm : Form
    {
        #region Properties

        public int MedID { get; set; }
        public string MedName { get; set; }
        public string Symptom { get; set; }
        public string Dose { get; set; }
        public string Route { get; set; }
        public DateTime Time { get; set; }

        #endregion Propeties

        #region Fields

        readonly DataConnection data;

        #endregion Fields

        #region Constructors

        public MedicationSearchForm()
        {
            CenterToParent();

            InitializeComponent();

            gridMedicine.Visible = false;

            data = new DataConnection();
        }

        #endregion Cosntructors

        #region Events

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void txtSymptom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void GridMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridMedicine.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                MedName = (string)gridMedicine.Rows[e.RowIndex].Cells["MedName"].Value;
                MedID = (int)gridMedicine.Rows[e.RowIndex].Cells["ID"].Value;
                Symptom = (string)gridMedicine.Rows[e.RowIndex].Cells["Symptom"].Value;
                OpenMedForm();
            }
        }

        private void gridMedicine_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridMedicine.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                MedName = (string)gridMedicine.Rows[e.RowIndex].Cells["MedName"].Value;
                MedID = (int)gridMedicine.Rows[e.RowIndex].Cells["ID"].Value;
                Symptom = (string)gridMedicine.Rows[e.RowIndex].Cells["Symptom"].Value;
                OpenMedForm();
            }
        }

        private void gridMedicine_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            e.ContextMenuStrip = cmsAdd;
            MedName = (string)gridMedicine.Rows[e.RowIndex].Cells["Name"].Value;
            MedID = (int)gridMedicine.Rows[e.RowIndex].Cells["ID"].Value;
            Symptom = (string)gridMedicine.Rows[e.RowIndex].Cells["Symptom"].Value;
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            OpenMedForm();
        }

        #endregion Events

        #region Helper Methods

        private void OpenMedForm()
        {
            AddMedForm medForm = new AddMedForm(MedName);
            medForm.ShowDialog();

            if (medForm.DialogResult == DialogResult.OK)
            {
                Dose = medForm.Dose;
                Route = medForm.Route;
                Time = medForm.Time;
                DialogResult = DialogResult.OK;
            }
        }

        private void Search()
        {
            if (txtName.Text == "" && txtSymptom.Text == "")
            {
                return;
            }
            gridMedicine.Refresh();

            gridMedicine.Visible = true;
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
            }
            else //Searching by symptom
            {
                ArrayList parms = new ArrayList()
                {
                    new SqlParameter("@Symptom", txtSymptom.Text)
                };
                ds = data.GetDataSet("GetMedicationsBySymptom", parms);
            }

            gridMedicine.DataSource = ds.Tables[0];
            gridMedicine.Font = new Font("Microsoft Sans Serif", 16F);
            DataGridViewButtonColumn col = new DataGridViewButtonColumn
            {
                Name = "AddMed",
                HeaderText = ""
            };
            gridMedicine.Columns.Add(col);

            foreach (DataGridViewRow row in gridMedicine.Rows)
            {
                row.Cells["AddMed"].Value = "Add";
            }

            gridMedicine.Refresh();
            ResizeGrid();
        }

        private void ResizeGrid()
        {
            if (gridMedicine.Rows.Count == 0)
                return;
            int height = gridMedicine.ColumnHeadersHeight;

            foreach (DataGridViewRow row in gridMedicine.Rows)
            {
                height += row.Height;
            }

            gridMedicine.Height = height;
            gridMedicine.Width = Width;
        }

        #endregion Helper Methods
    }
}
