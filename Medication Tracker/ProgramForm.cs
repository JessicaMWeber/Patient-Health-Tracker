using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public ProgramForm()
        {
            
            InitializeComponent();

            MakeLocationArrayMapping();

            CreatePanels();

            PT = new Patient(); 
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
                    Controls.Add(pnl);
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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DueNow_Click(object sender, EventArgs e)
        {

        }

        #region EVENTS     

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
            VitalSignsForm form = new VitalSignsForm();
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
            }
        }

        private void PnlInit_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
 