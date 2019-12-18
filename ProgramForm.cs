using Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Medication_Tracker
{
    public partial class ProgramForm : Form
    {
        #region Fields

        private Point[] locations;
        private int currIndex;
        private const int SPACING = 25;
        private Patient PT;
        private readonly DataConnection data;
        private bool settingUpComboBox;

        #endregion Fields

        #region Initialize

        public ProgramForm()
        {
            CenterToParent();

            InitializeComponent();

            MakeLocationArrayMapping();

            pnlInit.Visible = false;

            PT = new Patient();
            data = new DataConnection();

            Initialize();

            timerCurrTime.Start();
        }

        private void Initialize()
        {
            settingUpComboBox = true;
            currIndex = 0;
            DataSet ds = data.GetDataSet("GetPatientIDs");
            if(ds.Tables[0].Rows.Count == 0)
            {
                ResetFields();
                return;
            }
            cmbPatient.Enabled = true;
            btnAddVitalSigns.Enabled = true;
            cmbPatient.DisplayMember = "PatientName";
            cmbPatient.ValueMember = "ID";
            cmbPatient.DataSource = ds.Tables[0].DefaultView;

            PT = new Patient((int)cmbPatient.SelectedValue);

            SetupPatient();

            settingUpComboBox = false;
        }

        private void ResetFields()
        {
            lblDOB_Display.Text = "";
            lblRoomNumber_Display.Text = "";
            lblAllergies_Display.Text = "";
            lblCodeStatus_Display.Text = "";
            lblP_Display.Text = "";
            lblT_Display.Text = "";
            lblBPT_Display.Text = "";
            lblBPB_Display.Text = "";
            lblO2_Display.Text = "";
            lblR_Display.Text = "";
            cmbPatient.Enabled = false;
            btnAddVitalSigns.Enabled = false;
            tsAddMed.Enabled = false;
        }

        private void SetupPatient()
        {
            ArrayList parms = new ArrayList()
            {
                new SqlParameter("@PatientID", PT.ID)
            };

            DataSet ds = data.GetDataSet("GetMedsForPatient", parms);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                Medications m = new Medications((int)r["ID"])
                {
                    MedName = (string)r["MedName"], 
                    Symptom = (string)r["Symptom"], 
                    Dose = (string)r["Dose"], 
                    Route = (string)r["Route"], 
                    MedTime = (DateTime)r["MedTime"]
                };
                PT.Medications.Add(m);
            }

            SetupForm();
        }

        public void SetupForm()
        {

            lblDOB_Display.Text = PT.DateOfBirth.ToShortDateString();
            lblRoomNumber_Display.Text = PT.Room.ToString();
            lblAllergies_Display.Text = PT.Allergies.ToString();
            lblCodeStatus_Display.Text = PT.CodeStatus.ToString();
            lblP_Display.Text = PT.Pulse.ToString();
            lblT_Display.Text = PT.Temp.ToString("0.#");
            lblBPT_Display.Text = PT.BloodPressureTop.ToString();
            lblBPB_Display.Text = PT.BloodPressureBottom.ToString();
            lblO2_Display.Text = PT.Oxygen.ToString();
            lblR_Display.Text = PT.Respiration.ToString();

            foreach (Medications m in PT.Medications)
            {
                AddPanel(locations[currIndex], m);
                currIndex++;
            }

            pnlMeds.AutoSize = false;
            pnlMeds.Size = new Size(0, 0);
            pnlMeds.AutoSize = true;

            ChangeMedicationColors();
        }

        #endregion Initalize

        #region Helper Methods

        private Panel AddPanel(Point loc, Medications m)
        {
            Panel pnl = new Panel()
            {
                Location = loc,
                BackColor = pnlInit.BackColor,
                Width = pnlInit.Width,
                Height = pnlInit.Height
            };
            pnl.Tag = m.ID;
            Label labelTime = new Label()
            {
                Font = lblTime.Font,
                Location = lblTime.Location,
                AutoSize = true,
                Text = m.MedTime.ToShortTimeString()
            };
            Label labelName = new Label()
            {
                Font = lblMedName.Font,
                Location = lblMedName.Location,
                AutoSize = true,
                Text = m.MedName
            };
            Label labelDoseRoute = new Label()
            {
                Font = lblMed_Dose_Route.Font,
                Location = lblMed_Dose_Route.Location,
                AutoSize = true,
                Text = m.Dose + " " + m.Route
            };
            Label labelSymptom = new Label()
            {
                Font =  lblMed_Symptom.Font,
                Location = lblMed_Symptom.Location,
                AutoSize = true,
                Text = m.Symptom
            };
            Button buttonYes = new Button()
            {
                Text = "Y",
                Font = btnYes.Font,
                Location = btnYes.Location,
                Size = btnYes.Size,
                BackColor = btnYes.BackColor
            };
            Button buttonNo = new Button()
            {
                Text = "N",
                Font = btnNo.Font,
                Location = btnNo.Location,
                Size = btnNo.Size,
                BackColor = btnNo.BackColor
            };
            buttonYes.Click += BtnYes_Click;
            buttonNo.Click += BtnNo_Click;

            pnl.Controls.AddRange(new Control[] { labelTime, labelName, labelDoseRoute, labelSymptom, buttonYes, buttonNo } );
            pnlMeds.Controls.Add(pnl);

            return pnl;
        }

        private void MakeLocationArrayMapping()
        {
            locations = new Point[200];

            int startX = pnlInit.Location.X;
            int startY = pnlInit.Location.Y;

            int x = startX;
            int y = startY;

            for(int i = 0; i < 200; i+=2)
            {
                for(int j = 0; j < 2; j++)
                {
                    locations[i+j] = new Point(x, y);
                    x = x + pnlInit.Width + SPACING;
                }
                x = startX;
                y = y + pnlInit.Height + SPACING;
            }
        }

        private void AddVitalSigns()
        {
            VitalSignsForm form = new VitalSignsForm(PT);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                PT = form.Patient;
                lblT_Display.Text = PT.Temp.ToString("0.#");
                lblP_Display.Text = PT.Pulse.ToString();
                lblO2_Display.Text = PT.Oxygen.ToString();
                lblR_Display.Text = PT.Respiration.ToString();
                lblBPT_Display.Text = PT.BloodPressureTop.ToString();
                lblBPB_Display.Text = PT.BloodPressureBottom.ToString();
            }
        }

        private void AddPatient()
        {
            PatientForm form = new PatientForm(PT);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                currIndex = 0;
                pnlMeds.Controls.Clear();
                settingUpComboBox = true;
                PT = form.Patient;
                cmbPatient.Text = PT.PatientName;
                lblRoomNumber_Display.Text = PT.Room.ToString();
                lblAllergies_Display.Text = PT.Allergies;
                lblDOB_Display.Text = PT.DateOfBirth.ToShortDateString();
                lblCodeStatus_Display.Text = PT.CodeStatus;

                cmbPatient.DataSource = null;
                cmbPatient.DisplayMember = "PatientName";
                cmbPatient.ValueMember = "ID";
                cmbPatient.DataSource = data.GetDataSet("GetPatientIDs").Tables[0].DefaultView;
                cmbPatient.SelectedValue = PT.ID;
                cmbPatient.Enabled = true;
                btnAddVitalSigns.Enabled = true;
                tsAddMed.Enabled = true;
                settingUpComboBox = false;
            }
        }

        private void ChangeMedicationColors()
        {
            ArrayList parms = new ArrayList()
            {
                new SqlParameter("@PatientID", PT.ID),
                new SqlParameter("@Date", calCurrDay.SelectionEnd.Date)
            };

            DataSet ds = data.GetDataSet("GetMedsTakenByDate", parms);

            List<int> meds = new List<int>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                meds.Add((int)row["MedID"]);
            }

            foreach (Control control in pnlMeds.Controls)
            {
                if (control is Panel panel && panel.Tag != null)
                {
                    if (meds.Contains((int)panel.Tag))
                    {
                        panel.BackColor = Color.FromArgb(153,255,153);
                    }
                    else
                    {
                        SetColor(panel);
                    }
                }
            }
        }

        private void SetColor(Panel panel)
        {
            int medIndex = GetMedIndexByID((int)panel.Tag);
            TimeSpan dateTime = PT.Medications[medIndex].MedTime.TimeOfDay;
            TimeSpan currTime = DateTime.Now.TimeOfDay;
            TimeSpan hour = TimeSpan.FromHours(1);

            if (dateTime >= currTime.Subtract(hour) && dateTime <= currTime.Add(hour))
            {
                panel.BackColor = Color.FromArgb(255,255,153);
            }
            else if (currTime >= dateTime.Add(hour))
            {
                panel.BackColor = Color.FromArgb(255,153,153);
            }
            else
            {
                panel.BackColor = Color.LightGray;
            }
        }

        private int GetMedIndexByID(int id)
        {
            for (int i = 0; i < PT.Medications.Count; i++)
            {
                Medications m = PT.Medications[i];
                if (m.ID == id)
                {
                    return i;
                }
            }
            return -1;
        }

        #endregion Helper Methods

        #region Events    

        #region Click Events

        private void DueNow_Click(object sender, EventArgs e)
        {
            pnlMeds.Controls.Clear();

            ArrayList parms = new ArrayList()
            {
                new SqlParameter("@PatientID", PT.ID),
                new SqlParameter("@Date", calCurrDay.SelectionEnd.Date)
            };

            DataSet ds = data.GetDataSet("GetMedsTakenByDate", parms);

            List<int> meds = new List<int>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                meds.Add((int)row["MedID"]);
            }

            currIndex = 0;
            foreach (Medications m in PT.Medications)
            {
                if (!meds.Contains(m.ID) && m.MedTime >= DateTime.Now.AddHours(-1) && m.MedTime <= DateTime.Now.AddHours(1))
                {
                    AddPanel(locations[currIndex], m).BackColor = Color.FromArgb(255,255,153);
                    currIndex++;
                }
            }

            pnlMeds.AutoSize = false;
            pnlMeds.Size = new Size(0, 0);
            pnlMeds.AutoSize = true;

            GC.Collect();
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            pnlMeds.Controls.Clear();
            currIndex = 0;
            SetupForm();
            GC.Collect();
        }

        private void BtnAddVitalSigns_Click(object sender, EventArgs e)
        {
            AddVitalSigns();

        }

        private void AddPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatient();
        }
        
        private void AddMedicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicationSearchForm medSearchForm = new MedicationSearchForm();
            medSearchForm.ShowDialog();
            if (medSearchForm.DialogResult == DialogResult.OK)
            {
                Medications m = new Medications(medSearchForm.MedID)
                {
                    MedName = medSearchForm.MedName,
                    PatientID = PT.ID,
                    Symptom = medSearchForm.Symptom, 
                    Dose = medSearchForm.Dose, 
                    Route = medSearchForm.Route, 
                    MedTime = medSearchForm.Time
                };

                if(GetMedIndexByID(m.ID) > -1)
                {
                    MessageBox.Show("Med already being taken by patient");
                    return;
                }

                m.Save(insert : true);

                PT.Medications.Add(m);

                AddPanel(locations[currIndex], m);

                pnlMeds.Size = new Size(0, 0);
                pnlMeds.Refresh();

                currIndex++;

                ChangeMedicationColors();
            }
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            Panel pnl = (Panel)((Button)sender).Parent;
            pnl.BackColor = Color.FromArgb(153,255,153);
            MedsTakenHistory hist = new MedsTakenHistory();
            hist.PatientID = PT.ID;
            hist.MedID = (int)pnl.Tag;
            hist.TimeTaken = calCurrDay.SelectionEnd.Date;
            hist.Save(insert: true);
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            Panel pnl = (Panel)((Button)sender).Parent;
            SetColor(pnl);
            ArrayList parms = new ArrayList()
            {
                new SqlParameter("@MedID", pnl.Tag)
            };
            DataSet ds = data.GetDataSet("GetMedsTakenHistoryIDByMedID", parms);
            if (ds.Tables[0].Rows.Count == 0)
                return;
            int histID = (int)ds.Tables[0].Rows[0]["ID"];
            MedsTakenHistory hist = new MedsTakenHistory(histID);
            hist.Delete();
        }

        #endregion Click Events

        #region Change Events

        private void calCurrDay_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (settingUpComboBox)
            {
                return;
            }

            currIndex = 0;
            pnlMeds.Controls.Clear();
            SetupForm();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime_Display.Text = DateTime.Now.ToString();
        }

        private void CmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (settingUpComboBox)
                return;

            PT = new Patient((int)cmbPatient.SelectedValue);
            pnlMeds.Controls.Clear();
            currIndex = 0;

            SetupPatient();
        }

        #endregion Change Events

        #endregion Events  

        private void PnlInit_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 