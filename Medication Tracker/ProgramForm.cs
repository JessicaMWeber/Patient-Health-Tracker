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
        private Point[,] locations;
        private const int SPACING = 25;
        Patient PT;
        DataConnection data;

        public ProgramForm()
        {
            InitializeComponent();

            MakeLocationArrayMapping();

            CreatePanels();

            PT = new Patient();
            data = new DataConnection();

            Initialize();

            timer1.Start();          

        }
        private void Initialize()
        {
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
            cmbPatient.DisplayMember = "Name";
            cmbPatient.ValueMember = "ID";
            cmbPatient.DataSource = ds.Tables[0];
        }

        private void SetupPatient(DataRow row)
        {
            PT.Name = (string)row["Name"];
            PT.ID = (int)row["ID"];
            PT.DOB = (DateTime)row["DateOfBirth"];
            PT.RoomNumber = (int)row["Room"];
            PT.Allergies = (string)row["Allergies"];
            PT.CodeStatus = (string)row["CodeStatus"];
            PT.Pulse = (int)row["Pulse"];
            PT.Temp = (decimal)(row["Temp"]);
            PT.BloodPressureTop = (int)row["BPT"];
            PT.BloodPressureBottom = (int)row["BPB"];
            PT.Oxygen = (int)row["Oxygen"];
            PT.Respiration = (int)row["Respiration"];

            SetupForm();
        }

        public void SetupForm()
        {
            
            lblDOB_Display.Text = PT.DOB.ToString();
            lblRoomNumber_Display.Text = PT.RoomNumber.ToString();
            lblAllergies_Display.Text = PT.Allergies.ToString();
            lblCodeStatus_Display.Text = PT.CodeStatus.ToString();
            lblP_Display.Text = PT.Pulse.ToString();
            lblT_Display.Text = PT.Temp.ToString();
            lblBPT_Display.Text = PT.BloodPressureTop.ToString();
            lblBPB_Display.Text = PT.BloodPressureBottom.ToString();
            lblO2_Display.Text = PT.Oxygen.ToString();
            lblR_Display.Text = PT.Respiration.ToString();
        }

        private void CreatePanels()
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    if (i + j == 0)
                        continue;
                    Panel pnl = new Panel()
                    {
                        Location = locations[i, j],
                        BackColor = Color.HotPink,
                        Width = pnlInit.Width,
                        Height = pnlInit.Height
                    };
                    pnlMeds.Controls.Add(pnl);
                }
            }
        }

        private void MakeLocationArrayMapping()
        {
            locations = new Point[100,2];

            int startX = pnlInit.Location.X;
            int startY = pnlInit.Location.Y;

            int x = startX;
            int y = startY;

            for(int i = 0; i < 100; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    locations[i,j] = new Point(x, y);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        #region EVENTS     
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
            setVitalSignValues();

        }
        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void AddPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setPatientInfoValues();
        }

        
        private void ChangeMedicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicationSearchForm form2 = new MedicationSearchForm();
            form2.ShowDialog();
        }

        
#endregion EVENTS

        private void setVitalSignValues()
        {
            VitalSignsForm form = new VitalSignsForm(PT.ID);
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                PT.Temp = form.Temp;
                PT.Pulse = form.Pulse;
                PT.Respiration = form.Respiration;
                PT.BloodPressureTop = form.BloodPressureTop;
                PT.BloodPressureBottom = form.BloodPressureBottom;
                PT.Oxygen = form.Oxygen;

                lblT_Display.Text = PT.Temp.ToString();
                lblP_Display.Text = PT.Pulse.ToString();
                lblO2_Display.Text = PT.Oxygen.ToString();
                lblR_Display.Text = PT.Respiration.ToString();
                lblBPT_Display.Text = PT.BloodPressureTop.ToString();
                lblBPB_Display.Text = PT.BloodPressureBottom.ToString();
            }
        }
        private void setPatientInfoValues()
        {
            PatientForm form = new PatientForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                PT.ID = form.ID;
                PT.Name = form.Name;
                PT.RoomNumber = form.RoomNumber;
                PT.Allergies = form.Allergies;
                PT.DOB = form.DOB;
                PT.CodeStatus = form.CodeStatus;

                cmbPatient.Text = PT.Name;
                lblRoomNumber_Display.Text = PT.RoomNumber.ToString();
                lblAllergies_Display.Text = PT.Allergies;
                lblDOB_Display.Text = PT.DOB.ToShortDateString();
                lblCodeStatus_Display.Text = PT.CodeStatus;

                cmbPatient.DataSource = null;
                cmbPatient.DisplayMember = "Name";
                cmbPatient.ValueMember = "ID";
                cmbPatient.DataSource = data.GetDataSet("GetPatientIDs").Tables[0];
                cmbPatient.SelectedValue = PT.ID;
            }
        }
        

        private void PnlInit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeMedicationColors()
        {
          /*  if(DateTime.Now.TimeOfDay == MedTime + 1:00 to MedTime - 1:00)
            {
                currentPanel.backcolor = yellow;

            }
            else if(DateTime.Now.TimeOfDay > MedTime + 1:00)
            {
                currentPanel.backcolor = red;
            }
            else
            {
                currentPanel.backcolor = grey;
            }*/

        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            //change color to green
            // log that they took it
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            //change color back to what ever color it was
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime_Display.Text = DateTime.Now.ToString();
          //  timer1.Start();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue == null)
                return;
            ArrayList cheese = new ArrayList()
            {
                new SqlParameter("@ID" , cmbPatient.SelectedValue)
            };
            DataSet ds = data.GetDataSet("LoadPatientandVitals", cheese);

            DataRow row = ds.Tables[0].Rows[0];

            SetupPatient(row);
        }
    }
}
 