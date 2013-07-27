namespace MedOrd.Views {
	partial class PatientFormView {
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
			this.personGroupBox = new System.Windows.Forms.GroupBox();
			this.addressGroupBox = new System.Windows.Forms.GroupBox();
			this.cityComboBox = new System.Windows.Forms.ComboBox();
			this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cityLabel = new System.Windows.Forms.Label();
			this.streetNumberTextBox = new System.Windows.Forms.TextBox();
			this.streetNumberLabel = new System.Windows.Forms.Label();
			this.streetTextBox = new System.Windows.Forms.TextBox();
			this.streetLabel = new System.Windows.Forms.Label();
			this.jmbgTextBox = new System.Windows.Forms.TextBox();
			this.jmbgLabel = new System.Windows.Forms.Label();
			this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.birthDateLabel = new System.Windows.Forms.Label();
			this.surnameTextBox = new System.Windows.Forms.TextBox();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.patientGroupBox = new System.Windows.Forms.GroupBox();
			this.cardNumberTextBox = new System.Windows.Forms.TextBox();
			this.cardNumberLabel = new System.Windows.Forms.Label();
			this.numberOfInsuredPersonTextBox = new System.Windows.Forms.TextBox();
			this.numberOfInsuredPersonLabel = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.buttonPanel = new System.Windows.Forms.Panel();
			this.editButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.contentPanel = new System.Windows.Forms.Panel();
			this.personGroupBox.SuspendLayout();
			this.addressGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
			this.patientGroupBox.SuspendLayout();
			this.buttonPanel.SuspendLayout();
			this.contentPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// personGroupBox
			// 
			this.personGroupBox.Controls.Add(this.addressGroupBox);
			this.personGroupBox.Controls.Add(this.jmbgTextBox);
			this.personGroupBox.Controls.Add(this.jmbgLabel);
			this.personGroupBox.Controls.Add(this.birthDateTimePicker);
			this.personGroupBox.Controls.Add(this.birthDateLabel);
			this.personGroupBox.Controls.Add(this.surnameTextBox);
			this.personGroupBox.Controls.Add(this.surnameLabel);
			this.personGroupBox.Controls.Add(this.nameTextBox);
			this.personGroupBox.Controls.Add(this.nameLabel);
			this.personGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.personGroupBox.Location = new System.Drawing.Point(0, 0);
			this.personGroupBox.Name = "personGroupBox";
			this.personGroupBox.Padding = new System.Windows.Forms.Padding(5);
			this.personGroupBox.Size = new System.Drawing.Size(519, 180);
			this.personGroupBox.TabIndex = 0;
			this.personGroupBox.TabStop = false;
			this.personGroupBox.Text = "Informacije o osobi";
			// 
			// addressGroupBox
			// 
			this.addressGroupBox.Controls.Add(this.cityComboBox);
			this.addressGroupBox.Controls.Add(this.cityLabel);
			this.addressGroupBox.Controls.Add(this.streetNumberTextBox);
			this.addressGroupBox.Controls.Add(this.streetNumberLabel);
			this.addressGroupBox.Controls.Add(this.streetTextBox);
			this.addressGroupBox.Controls.Add(this.streetLabel);
			this.addressGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.addressGroupBox.Location = new System.Drawing.Point(5, 89);
			this.addressGroupBox.Name = "addressGroupBox";
			this.addressGroupBox.Size = new System.Drawing.Size(509, 86);
			this.addressGroupBox.TabIndex = 8;
			this.addressGroupBox.TabStop = false;
			this.addressGroupBox.Text = "Adresa";
			// 
			// cityComboBox
			// 
			this.cityComboBox.DataSource = this.citiesBindingSource;
			this.cityComboBox.DisplayMember = "Name";
			this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cityComboBox.FormattingEnabled = true;
			this.cityComboBox.Location = new System.Drawing.Point(49, 54);
			this.cityComboBox.Name = "cityComboBox";
			this.cityComboBox.Size = new System.Drawing.Size(207, 21);
			this.cityComboBox.TabIndex = 6;
			this.cityComboBox.ValueMember = "Id";
			// 
			// citiesBindingSource
			// 
			this.citiesBindingSource.DataSource = typeof(MedOrd.DomainModel.City);
			// 
			// cityLabel
			// 
			this.cityLabel.AutoSize = true;
			this.cityLabel.Location = new System.Drawing.Point(12, 57);
			this.cityLabel.Name = "cityLabel";
			this.cityLabel.Size = new System.Drawing.Size(33, 13);
			this.cityLabel.TabIndex = 5;
			this.cityLabel.Text = "Grad:";
			// 
			// streetNumberTextBox
			// 
			this.streetNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.streetNumberTextBox.Location = new System.Drawing.Point(294, 22);
			this.streetNumberTextBox.MaxLength = 10;
			this.streetNumberTextBox.Name = "streetNumberTextBox";
			this.streetNumberTextBox.Size = new System.Drawing.Size(100, 20);
			this.streetNumberTextBox.TabIndex = 3;
			// 
			// streetNumberLabel
			// 
			this.streetNumberLabel.AutoSize = true;
			this.streetNumberLabel.Location = new System.Drawing.Point(260, 25);
			this.streetNumberLabel.Name = "streetNumberLabel";
			this.streetNumberLabel.Size = new System.Drawing.Size(28, 13);
			this.streetNumberLabel.TabIndex = 2;
			this.streetNumberLabel.Text = "Broj:";
			// 
			// streetTextBox
			// 
			this.streetTextBox.Location = new System.Drawing.Point(49, 22);
			this.streetTextBox.Name = "streetTextBox";
			this.streetTextBox.Size = new System.Drawing.Size(207, 20);
			this.streetTextBox.TabIndex = 1;
			// 
			// streetLabel
			// 
			this.streetLabel.AutoSize = true;
			this.streetLabel.Location = new System.Drawing.Point(9, 25);
			this.streetLabel.Name = "streetLabel";
			this.streetLabel.Size = new System.Drawing.Size(34, 13);
			this.streetLabel.TabIndex = 0;
			this.streetLabel.Text = "Ulica:";
			// 
			// jmbgTextBox
			// 
			this.jmbgTextBox.Location = new System.Drawing.Point(53, 62);
			this.jmbgTextBox.MaxLength = 13;
			this.jmbgTextBox.Name = "jmbgTextBox";
			this.jmbgTextBox.Size = new System.Drawing.Size(94, 20);
			this.jmbgTextBox.TabIndex = 7;
			this.jmbgTextBox.Text = "1234567890123";
			// 
			// jmbgLabel
			// 
			this.jmbgLabel.AutoSize = true;
			this.jmbgLabel.Location = new System.Drawing.Point(8, 65);
			this.jmbgLabel.Name = "jmbgLabel";
			this.jmbgLabel.Size = new System.Drawing.Size(39, 13);
			this.jmbgLabel.TabIndex = 6;
			this.jmbgLabel.Text = "JMBG:";
			// 
			// birthDateTimePicker
			// 
			this.birthDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.birthDateTimePicker.Location = new System.Drawing.Point(329, 62);
			this.birthDateTimePicker.Name = "birthDateTimePicker";
			this.birthDateTimePicker.Size = new System.Drawing.Size(181, 20);
			this.birthDateTimePicker.TabIndex = 5;
			// 
			// birthDateLabel
			// 
			this.birthDateLabel.AutoSize = true;
			this.birthDateLabel.Location = new System.Drawing.Point(243, 65);
			this.birthDateLabel.Name = "birthDateLabel";
			this.birthDateLabel.Size = new System.Drawing.Size(80, 13);
			this.birthDateLabel.TabIndex = 4;
			this.birthDateLabel.Text = "Datum rođenja:";
			// 
			// surnameTextBox
			// 
			this.surnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.surnameTextBox.Location = new System.Drawing.Point(294, 23);
			this.surnameTextBox.Name = "surnameTextBox";
			this.surnameTextBox.Size = new System.Drawing.Size(216, 20);
			this.surnameTextBox.TabIndex = 3;
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Location = new System.Drawing.Point(243, 28);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(47, 13);
			this.surnameLabel.TabIndex = 2;
			this.surnameLabel.Text = "Prezime:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(39, 23);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(198, 20);
			this.nameTextBox.TabIndex = 1;
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(8, 28);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(27, 13);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Ime:";
			// 
			// patientGroupBox
			// 
			this.patientGroupBox.Controls.Add(this.cardNumberTextBox);
			this.patientGroupBox.Controls.Add(this.cardNumberLabel);
			this.patientGroupBox.Controls.Add(this.numberOfInsuredPersonTextBox);
			this.patientGroupBox.Controls.Add(this.numberOfInsuredPersonLabel);
			this.patientGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.patientGroupBox.Location = new System.Drawing.Point(0, 180);
			this.patientGroupBox.Name = "patientGroupBox";
			this.patientGroupBox.Padding = new System.Windows.Forms.Padding(5);
			this.patientGroupBox.Size = new System.Drawing.Size(519, 91);
			this.patientGroupBox.TabIndex = 1;
			this.patientGroupBox.TabStop = false;
			this.patientGroupBox.Text = "Informacije o pacijentu";
			// 
			// cardNumberTextBox
			// 
			this.cardNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cardNumberTextBox.Location = new System.Drawing.Point(142, 53);
			this.cardNumberTextBox.Name = "cardNumberTextBox";
			this.cardNumberTextBox.Size = new System.Drawing.Size(205, 20);
			this.cardNumberTextBox.TabIndex = 3;
			// 
			// cardNumberLabel
			// 
			this.cardNumberLabel.AutoSize = true;
			this.cardNumberLabel.Location = new System.Drawing.Point(9, 56);
			this.cardNumberLabel.Name = "cardNumberLabel";
			this.cardNumberLabel.Size = new System.Drawing.Size(124, 13);
			this.cardNumberLabel.TabIndex = 2;
			this.cardNumberLabel.Text = "Broj zdravstvene kartice:";
			// 
			// numberOfInsuredPersonTextBox
			// 
			this.numberOfInsuredPersonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.numberOfInsuredPersonTextBox.Location = new System.Drawing.Point(142, 19);
			this.numberOfInsuredPersonTextBox.Name = "numberOfInsuredPersonTextBox";
			this.numberOfInsuredPersonTextBox.Size = new System.Drawing.Size(205, 20);
			this.numberOfInsuredPersonTextBox.TabIndex = 1;
			// 
			// numberOfInsuredPersonLabel
			// 
			this.numberOfInsuredPersonLabel.AutoSize = true;
			this.numberOfInsuredPersonLabel.Location = new System.Drawing.Point(9, 22);
			this.numberOfInsuredPersonLabel.Name = "numberOfInsuredPersonLabel";
			this.numberOfInsuredPersonLabel.Size = new System.Drawing.Size(109, 13);
			this.numberOfInsuredPersonLabel.TabIndex = 0;
			this.numberOfInsuredPersonLabel.Text = "Broj osigurane osobe:";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(222, 15);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 4;
			this.saveButton.Text = "Spremi";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveEditButton_Click);
			// 
			// buttonPanel
			// 
			this.buttonPanel.Controls.Add(this.editButton);
			this.buttonPanel.Controls.Add(this.cancelButton);
			this.buttonPanel.Controls.Add(this.saveButton);
			this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonPanel.Location = new System.Drawing.Point(5, 276);
			this.buttonPanel.Name = "buttonPanel";
			this.buttonPanel.Size = new System.Drawing.Size(519, 53);
			this.buttonPanel.TabIndex = 4;
			// 
			// editButton
			// 
			this.editButton.Enabled = false;
			this.editButton.Location = new System.Drawing.Point(122, 14);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(75, 23);
			this.editButton.TabIndex = 6;
			this.editButton.Text = "Uredi";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(322, 14);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "Odustani";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// contentPanel
			// 
			this.contentPanel.Controls.Add(this.personGroupBox);
			this.contentPanel.Controls.Add(this.patientGroupBox);
			this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentPanel.Location = new System.Drawing.Point(5, 5);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Size = new System.Drawing.Size(519, 271);
			this.contentPanel.TabIndex = 4;
			// 
			// PatientFormView
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(529, 334);
			this.Controls.Add(this.contentPanel);
			this.Controls.Add(this.buttonPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PatientFormView";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Stvaranje pacijenta";
			this.Load += new System.EventHandler(this.PatientFormView_Load);
			this.personGroupBox.ResumeLayout(false);
			this.personGroupBox.PerformLayout();
			this.addressGroupBox.ResumeLayout(false);
			this.addressGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
			this.patientGroupBox.ResumeLayout(false);
			this.patientGroupBox.PerformLayout();
			this.buttonPanel.ResumeLayout(false);
			this.contentPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox personGroupBox;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label surnameLabel;
		private System.Windows.Forms.TextBox surnameTextBox;
		private System.Windows.Forms.DateTimePicker birthDateTimePicker;
		private System.Windows.Forms.Label birthDateLabel;
		private System.Windows.Forms.TextBox jmbgTextBox;
		private System.Windows.Forms.Label jmbgLabel;
		private System.Windows.Forms.GroupBox addressGroupBox;
		private System.Windows.Forms.TextBox streetNumberTextBox;
		private System.Windows.Forms.Label streetNumberLabel;
		private System.Windows.Forms.TextBox streetTextBox;
		private System.Windows.Forms.Label streetLabel;
		private System.Windows.Forms.Label cityLabel;
		private System.Windows.Forms.ComboBox cityComboBox;
		private System.Windows.Forms.GroupBox patientGroupBox;
		private System.Windows.Forms.Label numberOfInsuredPersonLabel;
		private System.Windows.Forms.TextBox numberOfInsuredPersonTextBox;
		private System.Windows.Forms.Label cardNumberLabel;
		private System.Windows.Forms.TextBox cardNumberTextBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Panel buttonPanel;
		private System.Windows.Forms.Panel contentPanel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.BindingSource citiesBindingSource;
		private System.Windows.Forms.Button editButton;
	}
}