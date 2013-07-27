namespace MedOrd.Views {
	partial class MedicalRecordFormView {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.topPanel = new System.Windows.Forms.Panel();
			this.patientGroupBox = new System.Windows.Forms.GroupBox();
			this.creationDateValueLabel = new System.Windows.Forms.Label();
			this.medicalRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.creationDateLabel = new System.Windows.Forms.Label();
			this.doctorValueLabel = new System.Windows.Forms.Label();
			this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.doctorLabel = new System.Windows.Forms.Label();
			this.numberOfInsuredPersonValueLabel = new System.Windows.Forms.Label();
			this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.numberOfInsuredPersonLabel = new System.Windows.Forms.Label();
			this.patientNameValueLabel = new System.Windows.Forms.Label();
			this.patientNameLabel = new System.Windows.Forms.Label();
			this.mainTabControl = new System.Windows.Forms.TabControl();
			this.examinationTabPage = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.anamnesisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.recommendationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.medicalExaminationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.therapiesTabPage = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.therapyDrugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dosageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.boxQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.therapiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.medRefTabPage = new System.Windows.Forms.TabPage();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.medicalCareActivityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.medicalInstitutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.wantedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.medRefBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bottomPanel = new System.Windows.Forms.Panel();
			this.closeButton = new System.Windows.Forms.Button();
			this.newExaminationButton = new System.Windows.Forms.Button();
			this.topPanel.SuspendLayout();
			this.patientGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.medicalRecordBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
			this.mainTabControl.SuspendLayout();
			this.examinationTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.medicalExaminationsBindingSource)).BeginInit();
			this.therapiesTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.therapiesBindingSource)).BeginInit();
			this.medRefTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.medRefBindingSource)).BeginInit();
			this.bottomPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.Controls.Add(this.patientGroupBox);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(5, 5);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(694, 100);
			this.topPanel.TabIndex = 0;
			// 
			// patientGroupBox
			// 
			this.patientGroupBox.Controls.Add(this.creationDateValueLabel);
			this.patientGroupBox.Controls.Add(this.creationDateLabel);
			this.patientGroupBox.Controls.Add(this.doctorValueLabel);
			this.patientGroupBox.Controls.Add(this.doctorLabel);
			this.patientGroupBox.Controls.Add(this.numberOfInsuredPersonValueLabel);
			this.patientGroupBox.Controls.Add(this.numberOfInsuredPersonLabel);
			this.patientGroupBox.Controls.Add(this.patientNameValueLabel);
			this.patientGroupBox.Controls.Add(this.patientNameLabel);
			this.patientGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.patientGroupBox.Location = new System.Drawing.Point(0, 0);
			this.patientGroupBox.Name = "patientGroupBox";
			this.patientGroupBox.Size = new System.Drawing.Size(694, 100);
			this.patientGroupBox.TabIndex = 0;
			this.patientGroupBox.TabStop = false;
			this.patientGroupBox.Text = "Pacijent";
			// 
			// creationDateValueLabel
			// 
			this.creationDateValueLabel.AutoSize = true;
			this.creationDateValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicalRecordBindingSource, "CreationDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
			this.creationDateValueLabel.Location = new System.Drawing.Point(451, 65);
			this.creationDateValueLabel.Name = "creationDateValueLabel";
			this.creationDateValueLabel.Size = new System.Drawing.Size(35, 13);
			this.creationDateValueLabel.TabIndex = 9;
			this.creationDateValueLabel.Text = "label1";
			// 
			// medicalRecordBindingSource
			// 
			this.medicalRecordBindingSource.DataSource = typeof(MedOrd.DomainModel.MedicalRecord);
			// 
			// creationDateLabel
			// 
			this.creationDateLabel.AutoSize = true;
			this.creationDateLabel.Location = new System.Drawing.Point(317, 65);
			this.creationDateLabel.Name = "creationDateLabel";
			this.creationDateLabel.Size = new System.Drawing.Size(127, 13);
			this.creationDateLabel.TabIndex = 8;
			this.creationDateLabel.Text = "Datum otvaranja kartona:";
			// 
			// doctorValueLabel
			// 
			this.doctorValueLabel.AutoSize = true;
			this.doctorValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "FullName", true));
			this.doctorValueLabel.Location = new System.Drawing.Point(89, 65);
			this.doctorValueLabel.Name = "doctorValueLabel";
			this.doctorValueLabel.Size = new System.Drawing.Size(35, 13);
			this.doctorValueLabel.TabIndex = 7;
			this.doctorValueLabel.Text = "label1";
			// 
			// doctorBindingSource
			// 
			this.doctorBindingSource.DataSource = typeof(MedOrd.DomainModel.Patient);
			// 
			// doctorLabel
			// 
			this.doctorLabel.AutoSize = true;
			this.doctorLabel.Location = new System.Drawing.Point(10, 65);
			this.doctorLabel.Name = "doctorLabel";
			this.doctorLabel.Size = new System.Drawing.Size(46, 13);
			this.doctorLabel.TabIndex = 6;
			this.doctorLabel.Text = "Liječnik:";
			// 
			// numberOfInsuredPersonValueLabel
			// 
			this.numberOfInsuredPersonValueLabel.AutoSize = true;
			this.numberOfInsuredPersonValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "NumberOfInsuredPerson", true));
			this.numberOfInsuredPersonValueLabel.Location = new System.Drawing.Point(451, 31);
			this.numberOfInsuredPersonValueLabel.Name = "numberOfInsuredPersonValueLabel";
			this.numberOfInsuredPersonValueLabel.Size = new System.Drawing.Size(35, 13);
			this.numberOfInsuredPersonValueLabel.TabIndex = 5;
			this.numberOfInsuredPersonValueLabel.Text = "label1";
			// 
			// patientBindingSource
			// 
			this.patientBindingSource.DataSource = typeof(MedOrd.DomainModel.Patient);
			// 
			// numberOfInsuredPersonLabel
			// 
			this.numberOfInsuredPersonLabel.AutoSize = true;
			this.numberOfInsuredPersonLabel.Location = new System.Drawing.Point(317, 31);
			this.numberOfInsuredPersonLabel.Name = "numberOfInsuredPersonLabel";
			this.numberOfInsuredPersonLabel.Size = new System.Drawing.Size(109, 13);
			this.numberOfInsuredPersonLabel.TabIndex = 4;
			this.numberOfInsuredPersonLabel.Text = "Broj osigurane osobe:";
			// 
			// patientNameValueLabel
			// 
			this.patientNameValueLabel.AutoSize = true;
			this.patientNameValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "FullName", true));
			this.patientNameValueLabel.Location = new System.Drawing.Point(89, 31);
			this.patientNameValueLabel.Name = "patientNameValueLabel";
			this.patientNameValueLabel.Size = new System.Drawing.Size(35, 13);
			this.patientNameValueLabel.TabIndex = 1;
			this.patientNameValueLabel.Text = "label1";
			// 
			// patientNameLabel
			// 
			this.patientNameLabel.AutoSize = true;
			this.patientNameLabel.Location = new System.Drawing.Point(10, 31);
			this.patientNameLabel.Name = "patientNameLabel";
			this.patientNameLabel.Size = new System.Drawing.Size(71, 13);
			this.patientNameLabel.TabIndex = 0;
			this.patientNameLabel.Text = "Ime i prezime:";
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.examinationTabPage);
			this.mainTabControl.Controls.Add(this.therapiesTabPage);
			this.mainTabControl.Controls.Add(this.medRefTabPage);
			this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabControl.Location = new System.Drawing.Point(5, 105);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(694, 328);
			this.mainTabControl.TabIndex = 1;
			// 
			// examinationTabPage
			// 
			this.examinationTabPage.Controls.Add(this.dataGridView1);
			this.examinationTabPage.Location = new System.Drawing.Point(4, 22);
			this.examinationTabPage.Name = "examinationTabPage";
			this.examinationTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.examinationTabPage.Size = new System.Drawing.Size(686, 302);
			this.examinationTabPage.TabIndex = 0;
			this.examinationTabPage.Text = "Pregledi";
			this.examinationTabPage.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.anamnesisDataGridViewTextBoxColumn,
            this.recommendationDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.medicalExaminationsBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(680, 296);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			dataGridViewCellStyle1.Format = "d";
			dataGridViewCellStyle1.NullValue = null;
			this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.dateDataGridViewTextBoxColumn.HeaderText = "Datum";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// anamnesisDataGridViewTextBoxColumn
			// 
			this.anamnesisDataGridViewTextBoxColumn.DataPropertyName = "Anamnesis";
			this.anamnesisDataGridViewTextBoxColumn.HeaderText = "Anamneza";
			this.anamnesisDataGridViewTextBoxColumn.Name = "anamnesisDataGridViewTextBoxColumn";
			this.anamnesisDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// recommendationDataGridViewTextBoxColumn
			// 
			this.recommendationDataGridViewTextBoxColumn.DataPropertyName = "Recommendation";
			this.recommendationDataGridViewTextBoxColumn.HeaderText = "Preporuka";
			this.recommendationDataGridViewTextBoxColumn.Name = "recommendationDataGridViewTextBoxColumn";
			this.recommendationDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// medicalExaminationsBindingSource
			// 
			this.medicalExaminationsBindingSource.DataSource = typeof(MedOrd.DomainModel.MedicalExamination);
			// 
			// therapiesTabPage
			// 
			this.therapiesTabPage.Controls.Add(this.dataGridView2);
			this.therapiesTabPage.Location = new System.Drawing.Point(4, 22);
			this.therapiesTabPage.Name = "therapiesTabPage";
			this.therapiesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.therapiesTabPage.Size = new System.Drawing.Size(686, 302);
			this.therapiesTabPage.TabIndex = 1;
			this.therapiesTabPage.Text = "Terapije";
			this.therapiesTabPage.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn,
            this.therapyDrugDataGridViewTextBoxColumn,
            this.dosageDataGridViewTextBoxColumn,
            this.perDayDataGridViewTextBoxColumn,
            this.boxQuantityDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.therapiesBindingSource;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(3, 3);
			this.dataGridView2.MultiSelect = false;
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(680, 296);
			this.dataGridView2.TabIndex = 0;
			this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
			// 
			// dateDataGridViewTextBoxColumn1
			// 
			this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
			dataGridViewCellStyle2.Format = "d";
			dataGridViewCellStyle2.NullValue = null;
			this.dateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dateDataGridViewTextBoxColumn1.HeaderText = "Datum";
			this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
			this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "Naziv";
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			this.titleDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// therapyDrugDataGridViewTextBoxColumn
			// 
			this.therapyDrugDataGridViewTextBoxColumn.DataPropertyName = "TherapyDrugName";
			this.therapyDrugDataGridViewTextBoxColumn.HeaderText = "Lijek";
			this.therapyDrugDataGridViewTextBoxColumn.Name = "therapyDrugDataGridViewTextBoxColumn";
			this.therapyDrugDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dosageDataGridViewTextBoxColumn
			// 
			this.dosageDataGridViewTextBoxColumn.DataPropertyName = "Dosage";
			this.dosageDataGridViewTextBoxColumn.HeaderText = "Doza";
			this.dosageDataGridViewTextBoxColumn.Name = "dosageDataGridViewTextBoxColumn";
			this.dosageDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// perDayDataGridViewTextBoxColumn
			// 
			this.perDayDataGridViewTextBoxColumn.DataPropertyName = "PerDay";
			this.perDayDataGridViewTextBoxColumn.HeaderText = "Dnevno";
			this.perDayDataGridViewTextBoxColumn.Name = "perDayDataGridViewTextBoxColumn";
			this.perDayDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// boxQuantityDataGridViewTextBoxColumn
			// 
			this.boxQuantityDataGridViewTextBoxColumn.DataPropertyName = "BoxQuantity";
			this.boxQuantityDataGridViewTextBoxColumn.HeaderText = "Broj kutija";
			this.boxQuantityDataGridViewTextBoxColumn.Name = "boxQuantityDataGridViewTextBoxColumn";
			this.boxQuantityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// therapiesBindingSource
			// 
			this.therapiesBindingSource.DataSource = typeof(MedOrd.DomainModel.Therapy);
			// 
			// medRefTabPage
			// 
			this.medRefTabPage.Controls.Add(this.dataGridView3);
			this.medRefTabPage.Location = new System.Drawing.Point(4, 22);
			this.medRefTabPage.Name = "medRefTabPage";
			this.medRefTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.medRefTabPage.Size = new System.Drawing.Size(686, 302);
			this.medRefTabPage.TabIndex = 2;
			this.medRefTabPage.Text = "Uputnice";
			this.medRefTabPage.UseVisualStyleBackColor = true;
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToAddRows = false;
			this.dataGridView3.AllowUserToDeleteRows = false;
			this.dataGridView3.AutoGenerateColumns = false;
			this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicalCareActivityDataGridViewTextBoxColumn,
            this.medicalInstitutionDataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn,
            this.wantedDataGridViewTextBoxColumn});
			this.dataGridView3.DataSource = this.medRefBindingSource;
			this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView3.Location = new System.Drawing.Point(3, 3);
			this.dataGridView3.MultiSelect = false;
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.ReadOnly = true;
			this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView3.Size = new System.Drawing.Size(680, 296);
			this.dataGridView3.TabIndex = 0;
			this.dataGridView3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
			// 
			// medicalCareActivityDataGridViewTextBoxColumn
			// 
			this.medicalCareActivityDataGridViewTextBoxColumn.DataPropertyName = "MedicalCareActivityTitle";
			this.medicalCareActivityDataGridViewTextBoxColumn.HeaderText = "Upućuje se";
			this.medicalCareActivityDataGridViewTextBoxColumn.Name = "medicalCareActivityDataGridViewTextBoxColumn";
			this.medicalCareActivityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// medicalInstitutionDataGridViewTextBoxColumn
			// 
			this.medicalInstitutionDataGridViewTextBoxColumn.DataPropertyName = "MedicalInstitutionName";
			this.medicalInstitutionDataGridViewTextBoxColumn.HeaderText = "Ustanova";
			this.medicalInstitutionDataGridViewTextBoxColumn.Name = "medicalInstitutionDataGridViewTextBoxColumn";
			this.medicalInstitutionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// diagnosisDataGridViewTextBoxColumn
			// 
			this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "DiagnosisTitle";
			this.diagnosisDataGridViewTextBoxColumn.HeaderText = "Dijagnoza";
			this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
			this.diagnosisDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// wantedDataGridViewTextBoxColumn
			// 
			this.wantedDataGridViewTextBoxColumn.DataPropertyName = "Wanted";
			this.wantedDataGridViewTextBoxColumn.HeaderText = "Traži se";
			this.wantedDataGridViewTextBoxColumn.Name = "wantedDataGridViewTextBoxColumn";
			this.wantedDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// medRefBindingSource
			// 
			this.medRefBindingSource.DataSource = typeof(MedOrd.DomainModel.MedicalReference);
			// 
			// bottomPanel
			// 
			this.bottomPanel.Controls.Add(this.closeButton);
			this.bottomPanel.Controls.Add(this.newExaminationButton);
			this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomPanel.Location = new System.Drawing.Point(5, 433);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(694, 100);
			this.bottomPanel.TabIndex = 0;
			// 
			// closeButton
			// 
			this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.Location = new System.Drawing.Point(385, 25);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 50);
			this.closeButton.TabIndex = 1;
			this.closeButton.Text = "Zatvori";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// newExaminationButton
			// 
			this.newExaminationButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.newExaminationButton.Location = new System.Drawing.Point(234, 25);
			this.newExaminationButton.Name = "newExaminationButton";
			this.newExaminationButton.Size = new System.Drawing.Size(75, 50);
			this.newExaminationButton.TabIndex = 0;
			this.newExaminationButton.Text = "Novi pregled";
			this.newExaminationButton.UseVisualStyleBackColor = true;
			this.newExaminationButton.Click += new System.EventHandler(this.newExaminationButton_Click);
			// 
			// MedicalRecordFormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(704, 538);
			this.Controls.Add(this.mainTabControl);
			this.Controls.Add(this.bottomPanel);
			this.Controls.Add(this.topPanel);
			this.Name = "MedicalRecordFormView";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.Text = "Medicinski karton";
			this.Load += new System.EventHandler(this.MedicalRecordFormView_Load);
			this.topPanel.ResumeLayout(false);
			this.patientGroupBox.ResumeLayout(false);
			this.patientGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.medicalRecordBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
			this.mainTabControl.ResumeLayout(false);
			this.examinationTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.medicalExaminationsBindingSource)).EndInit();
			this.therapiesTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.therapiesBindingSource)).EndInit();
			this.medRefTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.medRefBindingSource)).EndInit();
			this.bottomPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.GroupBox patientGroupBox;
		private System.Windows.Forms.Label patientNameValueLabel;
		private System.Windows.Forms.Label patientNameLabel;
		private System.Windows.Forms.Label numberOfInsuredPersonValueLabel;
		private System.Windows.Forms.Label numberOfInsuredPersonLabel;
		private System.Windows.Forms.Label doctorValueLabel;
		private System.Windows.Forms.Label doctorLabel;
		private System.Windows.Forms.TabControl mainTabControl;
		private System.Windows.Forms.TabPage examinationTabPage;
		private System.Windows.Forms.TabPage therapiesTabPage;
		private System.Windows.Forms.Label creationDateValueLabel;
		private System.Windows.Forms.Label creationDateLabel;
		private System.Windows.Forms.TabPage medRefTabPage;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button newExaminationButton;
		private System.Windows.Forms.BindingSource medicalExaminationsBindingSource;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource therapiesBindingSource;
		private System.Windows.Forms.BindingSource medRefBindingSource;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.BindingSource patientBindingSource;
		private System.Windows.Forms.BindingSource medicalRecordBindingSource;
		private System.Windows.Forms.BindingSource doctorBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn anamnesisDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn recommendationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn therapyDrugDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dosageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn perDayDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn boxQuantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn medicalCareActivityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn medicalInstitutionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn wantedDataGridViewTextBoxColumn;
	}
}