using Data;
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

namespace Medication_Tracker
{
    public partial class ProgramForm : Form
    {
        private Point[] locations;
        int currIndex;
        private const int SPACING = 25;
        Patient PT;
        DataConnection data;
        bool settingUpComboBox;

        public ProgramForm()
        {
            CenterToParent();

            InitializeComponent();

            MakeLocationArrayMapping();

            pnlInit.Visible = false;

            PT = new Patient(0);
            data = new DataConnection();

            Initialize();

            timer1.Start();          

        }
        private void Initialize()
        {
            settingUpComboBox = true;
            currIndex = 0;
            DataSet ds = data.GetDataSet("GetPatientIDs");
            if(ds.Tables[0].Rows.Count == 0)
            {
                cmbPatient.Enabled = false;
                btnAddVitalSigns.Enabled = false;
                lblP_Display.Text = "";
                lblT_Display.Text = "";
                lblBPT_Display.Text = "";
                lblBPB_Display.Text = "";
                lblO2_Display.Text = "";
                lblR_Display.Text = "";
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

        private void SetupPatient()
        {
            ArrayList parms = new ArrayList()
            {
                new SqlParameter("@PatientID", PT.ID)
            };

            DataSet ds = data.GetDataSet("GetMedsForPatient", parms);
            foreach(DataRow r in ds.Tables[0].Rows)
            {
                Meds m = new Meds((int)r["ID"], (string)r["Name"], (string)r["Symptom"], (string)r["Dose"], (string)r["Route"], (DateTime)r["MedTime"]);
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

            int i = 0;
            int j = 0;
            foreach (Meds m in PT.Medications)
            {
                AddPanel(locations[currIndex], m);
                if (j == 0)
                {
                    j = 1;
                }
                else
                {
                    j = 0;
                    i += 1;
                }
                currIndex++;
            }

            pnlMeds.AutoSize = false;
            pnlMeds.Size = new Size(0, 0);
            pnlMeds.AutoSize = true;
        }

        private void AddPanel(Point loc, Meds m)
        {
            Panel pnl = new Panel()
            {
                Location = loc,
                BackColor = pnlInit.BackColor,
                Width = pnlInit.Width,
                Height = pnlInit.Height
            };
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

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //view different date
        }


        #region Events    
        
        private void DueNow_Click(object sender, EventArgs e)
        {
            //show only medications that are yellow colored
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            //show all mediations
        }

        private void BtnAddVitalSigns_Click(object sender, EventArgs e)
        {
            SetVitalSignValues();

        }

        private void AddPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPatientInfoValues();
        }
        
        private void ChangeMedicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicationSearchForm medSearchForm = new MedicationSearchForm();
            medSearchForm.ShowDialog();
            if(medSearchForm.DialogResult == DialogResult.OK)
            {
                Meds m = new Meds(medSearchForm.MedID, medSearchForm.MedName, medSearchForm.Symptom, medSearchForm.Dose, medSearchForm.Route, medSearchForm.Time);

                ArrayList parms = new ArrayList()
                {
                    new SqlParameter("@MedID", m.ID),
                    new SqlParameter("@PatientID", PT.ID),
                    new SqlParameter("@Dose", m.Dose),
                    new SqlParameter("@Route", m.Route),
                    new SqlParameter("@MedTime", m.MedTime)
                };

                data.InsertUpdateDelete("AddMedToPatient", parms);

                PT.Medications.Add(m);

                AddPanel(locations[currIndex], m);

                currIndex++;
            }
        }

        #endregion Events

        private void SetVitalSignValues()
        {
            VitalSignsForm form = new VitalSignsForm(PT);
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
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
        private void SetPatientInfoValues()
        {
            PatientForm form = new PatientForm(PT);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
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
                settingUpComboBox = false;
            }
        }

        private void ChangeMedicationColors()
        {
            
          /*  if(DateTime.Now >= medtime due - 1 hr && medtaken = false)  // med is due
            {
                currentPanel.backcolor = yellow;

            }
            else if(DateTime.Now.TimeOfDay > MedTime + 1:00 && medtaken = false)  //med is past due
            {
                currentPanel.backcolor = red;
            }
            else 
            {
                currentPanel.backcolor = grey;
            }*/
        }

        private void AddMedication()
        {

        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            //medtaken = true
            //currentPanel.backcolor = green

        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
           //medtaken = false
            //change color back to what ever color it was
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime_Display.Text = DateTime.Now.ToString();
          //  timer1.Start();
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

       
    }
}
 