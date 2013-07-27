namespace MedOrd.Views {
	partial class PatientSearchFormView {
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
			this.searchCriteriaGroupBox = new System.Windows.Forms.GroupBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.surnameTextBox = new System.Windows.Forms.TextBox();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.patientsDataGridView = new System.Windows.Forms.DataGridView();
			this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.jmbg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numberOfInsuredPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.buttonPanel = new System.Windows.Forms.Panel();
			this.detailsButton = new System.Windows.Forms.Button();
			this.openMedicalRecordButton = new System.Windows.Forms.Button();
			this.addToWaitingRoomButton = new System.Windows.Forms.Button();
			this.searchCriteriaGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
			this.buttonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// searchCriteriaGroupBox
			// 
			this.searchCriteriaGroupBox.Controls.Add(this.searchButton);
			this.searchCriteriaGroupBox.Controls.Add(this.surnameTextBox);
			this.searchCriteriaGroupBox.Controls.Add(this.surnameLabel);
			this.searchCriteriaGroupBox.Controls.Add(this.nameTextBox);
			this.searchCriteriaGroupBox.Controls.Add(this.nameLabel);
			this.searchCriteriaGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.searchCriteriaGroupBox.Location = new System.Drawing.Point(5, 5);
			this.searchCriteriaGroupBox.Name = "searchCriteriaGroupBox";
			this.searchCriteriaGroupBox.Padding = new System.Windows.Forms.Padding(5);
			this.searchCriteriaGroupBox.Size = new System.Drawing.Size(714, 74);
			this.searchCriteriaGroupBox.TabIndex = 0;
			this.searchCriteriaGroupBox.TabStop = false;
			this.searchCriteriaGroupBox.Text = "Kriterij pretraživanja";
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(647, 26);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(59, 23);
			this.searchButton.TabIndex = 4;
			this.searchButton.Text = "Traži";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// surnameTextBox
			// 
			this.surnameTextBox.Location = new System.Drawing.Point(379, 29);
			this.surnameTextBox.Name = "surnameTextBox";
			this.surnameTextBox.Size = new System.Drawing.Size(250, 20);
			this.surnameTextBox.TabIndex = 3;
			this.surnameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.surnameTextBox_KeyDown);
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Location = new System.Drawing.Point(320, 33);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(47, 13);
			this.surnameLabel.TabIndex = 2;
			this.surnameLabel.Text = "Prezime:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(54, 29);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(250, 20);
			this.nameTextBox.TabIndex = 1;
			this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTextBox_KeyDown);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(15, 33);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(27, 13);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Ime:";
			// 
			// patientsDataGridView
			// 
			this.patientsDataGridView.AllowUserToAddRows = false;
			this.patientsDataGridView.AllowUserToDeleteRows = false;
			this.patientsDataGridView.AutoGenerateColumns = false;
			this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.patientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Person,
            this.jmbg,
            this.numberOfInsuredPersonDataGridViewTextBoxColumn,
            this.cardNumberDataGridViewTextBoxColumn});
			this.patientsDataGridView.DataSource = this.patientBindingSource;
			this.patientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.patientsDataGridView.Location = new System.Drawing.Point(5, 79);
			this.patientsDataGridView.MultiSelect = false;
			this.patientsDataGridView.Name = "patientsDataGridView";
			this.patientsDataGridView.ReadOnly = true;
			this.patientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.patientsDataGridView.Size = new System.Drawing.Size(714, 290);
			this.patientsDataGridView.TabIndex = 1;
			this.patientsDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsDataGridView_RowEnter);
			// 
			// Person
			// 
			this.Person.DataPropertyName = "FullName";
			this.Person.HeaderText = "Ime i Prezime";
			this.Person.Name = "Person";
			this.Person.ReadOnly = true;
			this.Person.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// jmbg
			// 
			this.jmbg.DataPropertyName = "Jmbg";
			this.jmbg.HeaderText = "Jmbg";
			this.jmbg.Name = "jmbg";
			this.jmbg.ReadOnly = true;
			// 
			// numberOfInsuredPersonDataGridViewTextBoxColumn
			// 
			this.numberOfInsuredPersonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.numberOfInsuredPersonDataGridViewTextBoxColumn.DataPropertyName = "NumberOfInsuredPerson";
			this.numberOfInsuredPersonDataGridViewTextBoxColumn.HeaderText = "Broj osigurane osobe";
			this.numberOfInsuredPersonDataGridViewTextBoxColumn.Name = "numberOfInsuredPersonDataGridViewTextBoxColumn";
			this.numberOfInsuredPersonDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// cardNumberDataGridViewTextBoxColumn
			// 
			this.cardNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cardNumberDataGridViewTextBoxColumn.DataPropertyName = "CardNumber";
			this.cardNumberDataGridViewTextBoxColumn.HeaderText = "Broj zdravstvene kartice";
			this.cardNumberDataGridViewTextBoxColumn.Name = "cardNumberDataGridViewTextBoxColumn";
			this.cardNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// patientBindingSource
			// 
			this.patientBindingSource.DataSource = typeof(MedOrd.DomainModel.Patient);
			// 
			// buttonPanel
			// 
			this.buttonPanel.Controls.Add(this.detailsButton);
			this.buttonPanel.Controls.Add(this.openMedicalRecordButton);
			this.buttonPanel.Controls.Add(this.addToWaitingRoomButton);
			this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonPanel.Location = new System.Drawing.Point(5, 306);
			this.buttonPanel.Name = "buttonPanel";
			this.buttonPanel.Size = new System.Drawing.Size(714, 63);
			this.buttonPanel.TabIndex = 2;
			// 
			// detailsButton
			// 
			this.detailsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.detailsButton.Enabled = false;
			this.detailsButton.Location = new System.Drawing.Point(451, 20);
			this.detailsButton.Name = "detailsButton";
			this.detailsButton.Size = new System.Drawing.Size(75, 23);
			this.detailsButton.TabIndex = 2;
			this.detailsButton.Text = "Detalji";
			this.detailsButton.UseVisualStyleBackColor = true;
			this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
			// 
			// openMedicalRecordButton
			// 
			this.openMedicalRecordButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.openMedicalRecordButton.Enabled = false;
			this.openMedicalRecordButton.Location = new System.Drawing.Point(332, 20);
			this.openMedicalRecordButton.Name = "openMedicalRecordButton";
			this.openMedicalRecordButton.Size = new System.Drawing.Size(94, 23);
			this.openMedicalRecordButton.TabIndex = 1;
			this.openMedicalRecordButton.Text = "Otvori karton";
			this.openMedicalRecordButton.UseVisualStyleBackColor = true;
			this.openMedicalRecordButton.Click += new System.EventHandler(this.openMedicalRecordButton_Click);
			// 
			// addToWaitingRoomButton
			// 
			this.addToWaitingRoomButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.addToWaitingRoomButton.Enabled = false;
			this.addToWaitingRoomButton.Location = new System.Drawing.Point(189, 20);
			this.addToWaitingRoomButton.Name = "addToWaitingRoomButton";
			this.addToWaitingRoomButton.Size = new System.Drawing.Size(118, 23);
			this.addToWaitingRoomButton.TabIndex = 0;
			this.addToWaitingRoomButton.Text = "Dodaj u čekaonicu";
			this.addToWaitingRoomButton.UseVisualStyleBackColor = true;
			this.addToWaitingRoomButton.Click += new System.EventHandler(this.addToWaitingRoomButton_Click);
			// 
			// PatientSearchFormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 374);
			this.Controls.Add(this.buttonPanel);
			this.Controls.Add(this.patientsDataGridView);
			this.Controls.Add(this.searchCriteriaGroupBox);
			this.Name = "PatientSearchFormView";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Pretraživanje kartoteke";
			this.Load += new System.EventHandler(this.PatientSearchFormView_Load);
			this.searchCriteriaGroupBox.ResumeLayout(false);
			this.searchCriteriaGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
			this.buttonPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox searchCriteriaGroupBox;
		private System.Windows.Forms.DataGridView patientsDataGridView;
		private System.Windows.Forms.BindingSource patientBindingSource;
		private System.Windows.Forms.TextBox surnameTextBox;
		private System.Windows.Forms.Label surnameLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Panel buttonPanel;
		private System.Windows.Forms.Button detailsButton;
		private System.Windows.Forms.Button openMedicalRecordButton;
		private System.Windows.Forms.Button addToWaitingRoomButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn Person;
		private System.Windows.Forms.DataGridViewTextBoxColumn jmbg;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberOfInsuredPersonDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cardNumberDataGridViewTextBoxColumn;
	}
}