namespace Medication_Tracker
{
    partial class MedicationSearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                data.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicationSearchForm));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSymptom = new System.Windows.Forms.TextBox();
            this.lblSymptom = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridMedicine = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSymptom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmsAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsAdd = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicine)).BeginInit();
            this.cmsAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 17);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 31);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Medication";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtName.Location = new System.Drawing.Point(154, 15);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 38);
            this.txtName.TabIndex = 19;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtSymptom
            // 
            this.txtSymptom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtSymptom.Location = new System.Drawing.Point(531, 15);
            this.txtSymptom.Margin = new System.Windows.Forms.Padding(2);
            this.txtSymptom.Name = "txtSymptom";
            this.txtSymptom.Size = new System.Drawing.Size(242, 38);
            this.txtSymptom.TabIndex = 21;
            this.txtSymptom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSymptom_KeyDown);
            // 
            // lblSymptom
            // 
            this.lblSymptom.AutoSize = true;
            this.lblSymptom.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymptom.Location = new System.Drawing.Point(400, 15);
            this.lblSymptom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSymptom.Name = "lblSymptom";
            this.lblSymptom.Size = new System.Drawing.Size(128, 31);
            this.lblSymptom.TabIndex = 20;
            this.lblSymptom.Text = "Symptom";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSearch.Location = new System.Drawing.Point(788, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 37);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // gridMedicine
            // 
            this.gridMedicine.AllowUserToAddRows = false;
            this.gridMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMedicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMedicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colSymptom,
            this.colButton});
            this.gridMedicine.Location = new System.Drawing.Point(14, 79);
            this.gridMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.gridMedicine.MaximumSize = new System.Drawing.Size(886, 314);
            this.gridMedicine.Name = "gridMedicine";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMedicine.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridMedicine.RowHeadersWidth = 51;
            this.gridMedicine.RowTemplate.Height = 24;
            this.gridMedicine.Size = new System.Drawing.Size(886, 35);
            this.gridMedicine.TabIndex = 23;
            this.gridMedicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMedicine_CellContentClick);
            this.gridMedicine.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMedicine_CellContentDoubleClick);
            this.gridMedicine.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.gridMedicine_CellContextMenuStripNeeded);
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            // 
            // colSymptom
            // 
            this.colSymptom.HeaderText = "Symptom";
            this.colSymptom.MinimumWidth = 6;
            this.colSymptom.Name = "colSymptom";
            // 
            // colButton
            // 
            this.colButton.HeaderText = "";
            this.colButton.MinimumWidth = 6;
            this.colButton.Name = "colButton";
            this.colButton.Text = "Add";
            // 
            // cmsAdd
            // 
            this.cmsAdd.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.cmsAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd});
            this.cmsAdd.Name = "cmsAdd";
            this.cmsAdd.Size = new System.Drawing.Size(122, 36);
            // 
            // tsAdd
            // 
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(121, 32);
            this.tsAdd.Text = "Add";
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // MedicationSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(920, 119);
            this.Controls.Add(this.gridMedicine);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSymptom);
            this.Controls.Add(this.lblSymptom);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MedicationSearchForm";
            this.Text = "Medications";
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicine)).EndInit();
            this.cmsAdd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSymptom;
        private System.Windows.Forms.Label lblSymptom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gridMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSymptom;
        private System.Windows.Forms.DataGridViewButtonColumn colButton;
        private System.Windows.Forms.ContextMenuStrip cmsAdd;
        private System.Windows.Forms.ToolStripMenuItem tsAdd;
    }
}