namespace MedOrd.Views {
	partial class MedicalExaminationFormView {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalExaminationFormView));
			this.generalTabControl = new System.Windows.Forms.TabControl();
			this.anamnesisTabPage = new System.Windows.Forms.TabPage();
			this.anamnesisRichTextBox = new System.Windows.Forms.RichTextBox();
			this.medicalExaminationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.recommendationTabPage = new System.Windows.Forms.TabPage();
			this.recommendationRichTextBox = new System.Windows.Forms.RichTextBox();
			this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
			this.medicalFeaturesTabControl = new System.Windows.Forms.TabControl();
			this.diagnosisTabPage = new System.Windows.Forms.TabPage();
			this.medCaseGroupBox = new System.Windows.Forms.GroupBox();
			this.medCaseTitleTextBox = new System.Windows.Forms.TextBox();
			this.medicalCaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.medCaseTitleLabel = new System.Windows.Forms.Label();
			this.diagnosisComboBox = new System.Windows.Forms.ComboBox();
			this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.diagnosisLabel = new System.Windows.Forms.Label();
			this.therapiesTabPage = new System.Windows.Forms.TabPage();
			this.therapyDataGridView = new System.Windows.Forms.DataGridView();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.therapyDrugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dosageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.boxQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.therapiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.therapiesToolStrip = new System.Windows.Forms.ToolStrip();
			this.addTherapyToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.removeTherapyToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.medicalReferencesTabPage = new System.Windows.Forms.TabPage();
			this.medicalReferencesDataGridView = new System.Windows.Forms.DataGridView();
			this.medicalCareActivityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.medicalInstitutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.wantedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.medicalReferencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.medicalReferenceToolStrip = new System.Windows.Forms.ToolStrip();
			this.addMedRefToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.deleteMedRegToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.saveButton = new System.Windows.Forms.Button();
			this.bottomPanel = new System.Windows.Forms.Panel();
			this.cancelButton = new System.Windows.Forms.Button();
			this.generalTabControl.SuspendLayout();
			this.anamnesisTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.medicalExaminationBindingSource)).BeginInit();
			this.recommendationTabPage.SuspendLayout();
			this.mainSplitContainer.Panel1.SuspendLayout();
			this.mainSplitContainer.Panel2.SuspendLayout();
			this.mainSplitContainer.SuspendLayout();
			this.medicalFeaturesTabControl.SuspendLayout();
			this.diagnosisTabPage.SuspendLayout();
			this.medCaseGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.medicalCaseBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
			this.therapiesTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.therapyDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.therapiesBindingSource)).BeginInit();
			this.therapiesToolStrip.SuspendLayout();
			this.medicalReferencesTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.medicalReferencesDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.medicalReferencesBindingSource)).BeginInit();
			this.medicalReferenceToolStrip.SuspendLayout();
			this.bottomPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// generalTabControl
			// 
			this.generalTabControl.Controls.Add(this.anamnesisTabPage);
			this.generalTabControl.Controls.Add(this.recommendationTabPage);
			this.generalTabControl.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.medicalExaminationBindingSource, "Recommendation", true));
			this.generalTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.generalTabControl.Location = new System.Drawing.Point(0, 0);
			this.generalTabControl.Name = "generalTabControl";
			this.generalTabControl.SelectedIndex = 0;
			this.generalTabControl.Size = new System.Drawing.Size(694, 231);
			this.generalTabControl.TabIndex = 0;
			// 
			// anamnesisTabPage
			// 
			this.anamnesisTabPage.Controls.Add(this.anamnesisRichTextBox);
			this.anamnesisTabPage.Location = new System.Drawing.Point(4, 22);
			this.anamnesisTabPage.Name = "anamnesisTabPage";
			this.anamnesisTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.anamnesisTabPage.Size = new System.Drawing.Size(686, 205);
			this.anamnesisTabPage.TabIndex = 0;
			this.anamnesisTabPage.Text = "Anamneza";
			this.anamnesisTabPage.UseVisualStyleBackColor = true;
			// 
			// anamnesisRichTextBox
			// 
			this.anamnesisRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicalExaminationBindingSource, "Anamnesis", true));
			this.anamnesisRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.anamnesisRichTextBox.Location = new System.Drawing.Point(3, 3);
			this.anamnesisRichTextBox.Name = "anamnesisRichTextBox";
			this.anamnesisRichTextBox.Size = new System.Drawing.Size(680, 199);
			this.anamnesisRichTextBox.TabIndex = 0;
			this.anamnesisRichTextBox.Text = "";
			// 
			// medicalExaminationBindingSource
			// 
			this.medicalExaminationBindingSource.DataSource = typeof(MedOrd.DomainModel.MedicalExamination);
			// 
			// recommendationTabPage
			// 
			this.recommendationTabPage.Controls.Add(this.recommendationRichTextBox);
			this.recommendationTabPage.Location = new System.Drawing.Point(4, 22);
			this.recommendationTabPage.Name = "recommendationTabPage";
			this.recommendationTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.recommendationTabPage.Size = new System.Drawing.Size(686, 205);
			this.recommendationTabPage.TabIndex = 1;
			this.recommendationTabPage.Text = "Preporuka";
			this.recommendationTabPage.UseVisualStyleBackColor = true;
			// 
			// recommendationRichTextBox
			// 
			this.recommendationRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicalExaminationBindingSource, "Recommendation", true));
			this.recommendationRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.recommendationRichTextBox.Location = new System.Drawing.Point(3, 3);
			this.recommendationRichTextBox.Name = "recommendationRichTextBox";
			this.recommendationRichTextBox.Size = new System.Drawing.Size(680, 199);
			this.recommendationRichTextBox.TabIndex = 0;
			this.recommendationRichTextBox.Text = "";
			// 
			// mainSplitContainer
			// 
			this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainSplitContainer.Location = new System.Drawing.Point(5, 5);
			this.mainSplitContainer.Name = "mainSplitContainer";
			this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// mainSplitContainer.Panel1
			// 
			this.mainSplitContainer.Panel1.Controls.Add(this.generalTabControl);
			// 
			// mainSplitContainer.Panel2
			// 
			this.mainSplitContainer.Panel2.Controls.Add(this.medicalFeaturesTabControl);
			this.mainSplitContainer.Size = new System.Drawing.Size(694, 589);
			this.mainSplitContainer.SplitterDistance = 231;
			this.mainSplitContainer.SplitterWidth = 10;
			this.mainSplitContainer.TabIndex = 0;
			// 
			// medicalFeaturesTabControl
			// 
			this.medicalFeaturesTabControl.Controls.Add(this.diagnosisTabPage);
			this.medicalFeaturesTabControl.Controls.Add(this.therapiesTabPage);
			this.medicalFeaturesTabControl.Controls.Add(this.medicalReferencesTabPage);
			this.medicalFeaturesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.medicalFeaturesTabControl.Location = new System.Drawing.Point(0, 0);
			this.medicalFeaturesTabControl.Name = "medicalFeaturesTabControl";
			this.medicalFeaturesTabControl.SelectedIndex = 0;
			this.medicalFeaturesTabControl.Size = new System.Drawing.Size(694, 348);
			this.medicalFeaturesTabControl.TabIndex = 1;
			// 
			// diagnosisTabPage
			// 
			this.diagnosisTabPage.Controls.Add(this.medCaseGroupBox);
			this.diagnosisTabPage.Location = new System.Drawing.Point(4, 22);
			this.diagnosisTabPage.Name = "diagnosisTabPage";
			this.diagnosisTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.diagnosisTabPage.Size = new System.Drawing.Size(686, 322);
			this.diagnosisTabPage.TabIndex = 0;
			this.diagnosisTabPage.Text = "Dijagnoza i medicinski slučaj";
			this.diagnosisTabPage.UseVisualStyleBackColor = true;
			// 
			// medCaseGroupBox
			// 
			this.medCaseGroupBox.Controls.Add(this.medCaseTitleTextBox);
			this.medCaseGroupBox.Controls.Add(this.medCaseTitleLabel);
			this.medCaseGroupBox.Controls.Add(this.diagnosisComboBox);
			this.medCaseGroupBox.Controls.Add(this.diagnosisLabel);
			this.medCaseGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.medCaseGroupBox.Location = new System.Drawing.Point(3, 3);
			this.medCaseGroupBox.Name = "medCaseGroupBox";
			this.medCaseGroupBox.Size = new System.Drawing.Size(680, 316);
			this.medCaseGroupBox.TabIndex = 9;
			this.medCaseGroupBox.TabStop = false;
			this.medCaseGroupBox.Text = "Detalji medicinskog slučaja:";
			// 
			// medCaseTitleTextBox
			// 
			this.medCaseTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.medCaseTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicalCaseBindingSource, "Title", true));
			this.medCaseTitleTextBox.Location = new System.Drawing.Point(158, 75);
			this.medCaseTitleTextBox.Name = "medCaseTitleTextBox";
			this.medCaseTitleTextBox.Size = new System.Drawing.Size(505, 20);
			this.medCaseTitleTextBox.TabIndex = 3;
			// 
			// medicalCaseBindingSource
			// 
			this.medicalCaseBindingSource.DataSource = typeof(MedOrd.DomainModel.MedicalCase);
			// 
			// medCaseTitleLabel
			// 
			this.medCaseTitleLabel.AutoSize = true;
			this.medCaseTitleLabel.Location = new System.Drawing.Point(15, 78);
			this.medCaseTitleLabel.Name = "medCaseTitleLabel";
			this.medCaseTitleLabel.Size = new System.Drawing.Size(135, 13);
			this.medCaseTitleLabel.TabIndex = 2;
			this.medCaseTitleLabel.Text = "Naziv medicinskog slučaja:";
			// 
			// diagnosisComboBox
			// 
			this.diagnosisComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.diagnosisComboBox.DataSource = this.diagnosisBindingSource;
			this.diagnosisComboBox.DisplayMember = "Title";
			this.diagnosisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.diagnosisComboBox.FormattingEnabled = true;
			this.diagnosisComboBox.Location = new System.Drawing.Point(158, 29);
			this.diagnosisComboBox.Name = "diagnosisComboBox";
			this.diagnosisComboBox.Size = new System.Drawing.Size(505, 21);
			this.diagnosisComboBox.TabIndex = 1;
			this.diagnosisComboBox.ValueMember = "Id";
			// 
			// diagnosisBindingSource
			// 
			this.diagnosisBindingSource.DataSource = typeof(MedOrd.DomainModel.Diagnosis);
			// 
			// diagnosisLabel
			// 
			this.diagnosisLabel.AutoSize = true;
			this.diagnosisLabel.Location = new System.Drawing.Point(15, 32);
			this.diagnosisLabel.Name = "diagnosisLabel";
			this.diagnosisLabel.Size = new System.Drawing.Size(57, 13);
			this.diagnosisLabel.TabIndex = 0;
			this.diagnosisLabel.Text = "Dijagnoza:";
			// 
			// therapiesTabPage
			// 
			this.therapiesTabPage.Controls.Add(this.therapyDataGridView);
			this.therapiesTabPage.Controls.Add(this.therapiesToolStrip);
			this.therapiesTabPage.Location = new System.Drawing.Point(4, 22);
			this.therapiesTabPage.Name = "therapiesTabPage";
			this.therapiesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.therapiesTabPage.Size = new System.Drawing.Size(686, 322);
			this.therapiesTabPage.TabIndex = 1;
			this.therapiesTabPage.Text = "Terapije";
			this.therapiesTabPage.UseVisualStyleBackColor = true;
			// 
			// therapyDataGridView
			// 
			this.therapyDataGridView.AllowUserToAddRows = false;
			this.therapyDataGridView.AllowUserToDeleteRows = false;
			this.therapyDataGridView.AutoGenerateColumns = false;
			this.therapyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.therapyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.therapyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.therapyDrugDataGridViewTextBoxColumn,
            this.dosageDataGridViewTextBoxColumn,
            this.perDayDataGridViewTextBoxColumn,
            this.boxQuantityDataGridViewTextBoxColumn});
			this.therapyDataGridView.DataSource = this.therapiesBindingSource;
			this.therapyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.therapyDataGridView.Location = new System.Drawing.Point(3, 28);
			this.therapyDataGridView.MultiSelect = false;
			this.therapyDataGridView.Name = "therapyDataGridView";
			this.therapyDataGridView.ReadOnly = true;
			this.therapyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.therapyDataGridView.Size = new System.Drawing.Size(680, 291);
			this.therapyDataGridView.TabIndex = 0;
			this.therapyDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.therapyDataGridView_CellContentDoubleClick);
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Datum";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "Naziv";
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			this.titleDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "Opis";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
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
			// therapiesToolStrip
			// 
			this.therapiesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTherapyToolStripButton,
            this.removeTherapyToolStripButton});
			this.therapiesToolStrip.Location = new System.Drawing.Point(3, 3);
			this.therapiesToolStrip.Name = "therapiesToolStrip";
			this.therapiesToolStrip.Size = new System.Drawing.Size(680, 25);
			this.therapiesToolStrip.TabIndex = 1;
			this.therapiesToolStrip.Text = "Terapije alatna traka";
			// 
			// addTherapyToolStripButton
			// 
			this.addTherapyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.addTherapyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addTherapyToolStripButton.Image")));
			this.addTherapyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addTherapyToolStripButton.Name = "addTherapyToolStripButton";
			this.addTherapyToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.addTherapyToolStripButton.Text = "Nova terapija";
			this.addTherapyToolStripButton.Click += new System.EventHandler(this.addTherapyToolStripButton_Click);
			// 
			// removeTherapyToolStripButton
			// 
			this.removeTherapyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.removeTherapyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("removeTherapyToolStripButton.Image")));
			this.removeTherapyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.removeTherapyToolStripButton.Name = "removeTherapyToolStripButton";
			this.removeTherapyToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.removeTherapyToolStripButton.Text = "Obriši terapiju";
			this.removeTherapyToolStripButton.Click += new System.EventHandler(this.removeTherapyToolStripButton_Click);
			// 
			// medicalReferencesTabPage
			// 
			this.medicalReferencesTabPage.Controls.Add(this.medicalReferencesDataGridView);
			this.medicalReferencesTabPage.Controls.Add(this.medicalReferenceToolStrip);
			this.medicalReferencesTabPage.Location = new System.Drawing.Point(4, 22);
			this.medicalReferencesTabPage.Name = "medicalReferencesTabPage";
			this.medicalReferencesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.medicalReferencesTabPage.Size = new System.Drawing.Size(686, 322);
			this.medicalReferencesTabPage.TabIndex = 2;
			this.medicalReferencesTabPage.Text = "Uputnice";
			this.medicalReferencesTabPage.UseVisualStyleBackColor = true;
			// 
			// medicalReferencesDataGridView
			// 
			this.medicalReferencesDataGridView.AllowUserToAddRows = false;
			this.medicalReferencesDataGridView.AllowUserToDeleteRows = false;
			this.medicalReferencesDataGridView.AutoGenerateColumns = false;
			this.medicalReferencesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.medicalReferencesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.medicalReferencesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicalCareActivityDataGridViewTextBoxColumn,
            this.medicalInstitutionDataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn,
            this.wantedDataGridViewTextBoxColumn});
			this.medicalReferencesDataGridView.DataSource = this.medicalReferencesBindingSource;
			this.medicalReferencesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.medicalReferencesDataGridView.Location = new System.Drawing.Point(3, 28);
			this.medicalReferencesDataGridView.Name = "medicalReferencesDataGridView";
			this.medicalReferencesDataGridView.ReadOnly = true;
			this.medicalReferencesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.medicalReferencesDataGridView.Size = new System.Drawing.Size(680, 291);
			this.medicalReferencesDataGridView.TabIndex = 0;
			this.medicalReferencesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medicalReferencesDataGridView_CellDoubleClick);
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
			// medicalReferencesBindingSource
			// 
			this.medicalReferencesBindingSource.DataSource = typeof(MedOrd.DomainModel.MedicalReference);
			// 
			// medicalReferenceToolStrip
			// 
			this.medicalReferenceToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMedRefToolStripButton,
            this.deleteMedRegToolStripButton});
			this.medicalReferenceToolStrip.Location = new System.Drawing.Point(3, 3);
			this.medicalReferenceToolStrip.Name = "medicalReferenceToolStrip";
			this.medicalReferenceToolStrip.Size = new System.Drawing.Size(680, 25);
			this.medicalReferenceToolStrip.TabIndex = 1;
			this.medicalReferenceToolStrip.Text = "toolStrip1";
			// 
			// addMedRefToolStripButton
			// 
			this.addMedRefToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.addMedRefToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addMedRefToolStripButton.Image")));
			this.addMedRefToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addMedRefToolStripButton.Name = "addMedRefToolStripButton";
			this.addMedRefToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.addMedRefToolStripButton.Text = "Nova uputnica";
			this.addMedRefToolStripButton.Click += new System.EventHandler(this.addMedRefToolStripButton_Click);
			// 
			// deleteMedRegToolStripButton
			// 
			this.deleteMedRegToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.deleteMedRegToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteMedRegToolStripButton.Image")));
			this.deleteMedRegToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteMedRegToolStripButton.Name = "deleteMedRegToolStripButton";
			this.deleteMedRegToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.deleteMedRegToolStripButton.Text = "Obriši uputnicu";
			this.deleteMedRegToolStripButton.Click += new System.EventHandler(this.deleteMedRegToolStripButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.saveButton.Enabled = false;
			this.saveButton.Location = new System.Drawing.Point(243, 5);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 50);
			this.saveButton.TabIndex = 0;
			this.saveButton.Text = "Spremi";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// bottomPanel
			// 
			this.bottomPanel.Controls.Add(this.cancelButton);
			this.bottomPanel.Controls.Add(this.saveButton);
			this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomPanel.Location = new System.Drawing.Point(5, 594);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(694, 61);
			this.bottomPanel.TabIndex = 0;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(377, 5);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 50);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Odustani";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// MedicalExaminationFormView
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(704, 660);
			this.Controls.Add(this.mainSplitContainer);
			this.Controls.Add(this.bottomPanel);
			this.Name = "MedicalExaminationFormView";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.Text = "Medicinski pregled:";
			this.generalTabControl.ResumeLayout(false);
			this.anamnesisTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.medicalExaminationBindingSource)).EndInit();
			this.recommendationTabPage.ResumeLayout(false);
			this.mainSplitContainer.Panel1.ResumeLayout(false);
			this.mainSplitContainer.Panel2.ResumeLayout(false);
			this.mainSplitContainer.ResumeLayout(false);
			this.medicalFeaturesTabControl.ResumeLayout(false);
			this.diagnosisTabPage.ResumeLayout(false);
			this.medCaseGroupBox.ResumeLayout(false);
			this.medCaseGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.medicalCaseBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
			this.therapiesTabPage.ResumeLayout(false);
			this.therapiesTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.therapyDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.therapiesBindingSource)).EndInit();
			this.therapiesToolStrip.ResumeLayout(false);
			this.therapiesToolStrip.PerformLayout();
			this.medicalReferencesTabPage.ResumeLayout(false);
			this.medicalReferencesTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.medicalReferencesDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.medicalReferencesBindingSource)).EndInit();
			this.medicalReferenceToolStrip.ResumeLayout(false);
			this.medicalReferenceToolStrip.PerformLayout();
			this.bottomPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl generalTabControl;
		private System.Windows.Forms.TabPage anamnesisTabPage;
		private System.Windows.Forms.TabPage recommendationTabPage;
		private System.Windows.Forms.RichTextBox anamnesisRichTextBox;
		private System.Windows.Forms.RichTextBox recommendationRichTextBox;
		private System.Windows.Forms.SplitContainer mainSplitContainer;
		private System.Windows.Forms.TabControl medicalFeaturesTabControl;
		private System.Windows.Forms.TabPage diagnosisTabPage;
		private System.Windows.Forms.TabPage therapiesTabPage;
		private System.Windows.Forms.TabPage medicalReferencesTabPage;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.BindingSource medicalReferencesBindingSource;
		private System.Windows.Forms.DataGridView medicalReferencesDataGridView;
		private System.Windows.Forms.ToolStrip medicalReferenceToolStrip;
		private System.Windows.Forms.ToolStripButton addMedRefToolStripButton;
		private System.Windows.Forms.ToolStripButton deleteMedRegToolStripButton;
		private System.Windows.Forms.BindingSource therapiesBindingSource;
		private System.Windows.Forms.DataGridView therapyDataGridView;
		private System.Windows.Forms.ToolStrip therapiesToolStrip;
		private System.Windows.Forms.ToolStripButton addTherapyToolStripButton;
		private System.Windows.Forms.ToolStripButton removeTherapyToolStripButton;
		private System.Windows.Forms.Label diagnosisLabel;
		private System.Windows.Forms.ComboBox diagnosisComboBox;
		private System.Windows.Forms.BindingSource diagnosisBindingSource;
		private System.Windows.Forms.TextBox medCaseTitleTextBox;
		private System.Windows.Forms.Label medCaseTitleLabel;
		private System.Windows.Forms.GroupBox medCaseGroupBox;
		private System.Windows.Forms.BindingSource medicalExaminationBindingSource;
		private System.Windows.Forms.BindingSource medicalCaseBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
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