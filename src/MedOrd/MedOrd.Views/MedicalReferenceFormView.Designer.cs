namespace MedOrd.Views {
	partial class MedicalReferenceFormView {
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
			this.medicalReferenceGroupBox = new System.Windows.Forms.GroupBox();
			this.diagnosisValueLabel = new System.Windows.Forms.Label();
			this.diagnosisLabel = new System.Windows.Forms.Label();
			this.wantedRichTextBox = new System.Windows.Forms.RichTextBox();
			this.wantedLabel = new System.Windows.Forms.Label();
			this.medInstitutionComboBox = new System.Windows.Forms.ComboBox();
			this.medicalInstitutionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.medicalInstitutionLabel = new System.Windows.Forms.Label();
			this.medCareActivityComboBox = new System.Windows.Forms.ComboBox();
			this.medicalCareActivitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.healthCareActivityLabel = new System.Windows.Forms.Label();
			this.bottomPanel = new System.Windows.Forms.Panel();
			this.cancelButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.medicalReferenceGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.medicalInstitutionsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.medicalCareActivitiesBindingSource)).BeginInit();
			this.bottomPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// medicalReferenceGroupBox
			// 
			this.medicalReferenceGroupBox.Controls.Add(this.diagnosisValueLabel);
			this.medicalReferenceGroupBox.Controls.Add(this.diagnosisLabel);
			this.medicalReferenceGroupBox.Controls.Add(this.wantedRichTextBox);
			this.medicalReferenceGroupBox.Controls.Add(this.wantedLabel);
			this.medicalReferenceGroupBox.Controls.Add(this.medInstitutionComboBox);
			this.medicalReferenceGroupBox.Controls.Add(this.medicalInstitutionLabel);
			this.medicalReferenceGroupBox.Controls.Add(this.medCareActivityComboBox);
			this.medicalReferenceGroupBox.Controls.Add(this.healthCareActivityLabel);
			this.medicalReferenceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.medicalReferenceGroupBox.Location = new System.Drawing.Point(5, 5);
			this.medicalReferenceGroupBox.Name = "medicalReferenceGroupBox";
			this.medicalReferenceGroupBox.Padding = new System.Windows.Forms.Padding(5);
			this.medicalReferenceGroupBox.Size = new System.Drawing.Size(504, 239);
			this.medicalReferenceGroupBox.TabIndex = 0;
			this.medicalReferenceGroupBox.TabStop = false;
			this.medicalReferenceGroupBox.Text = "Uputnica";
			// 
			// diagnosisValueLabel
			// 
			this.diagnosisValueLabel.AutoSize = true;
			this.diagnosisValueLabel.Location = new System.Drawing.Point(92, 94);
			this.diagnosisValueLabel.Name = "diagnosisValueLabel";
			this.diagnosisValueLabel.Size = new System.Drawing.Size(35, 13);
			this.diagnosisValueLabel.TabIndex = 7;
			this.diagnosisValueLabel.Text = "label1";
			// 
			// diagnosisLabel
			// 
			this.diagnosisLabel.AutoSize = true;
			this.diagnosisLabel.Location = new System.Drawing.Point(12, 94);
			this.diagnosisLabel.Name = "diagnosisLabel";
			this.diagnosisLabel.Size = new System.Drawing.Size(57, 13);
			this.diagnosisLabel.TabIndex = 6;
			this.diagnosisLabel.Text = "Dijagnoza:";
			// 
			// wantedRichTextBox
			// 
			this.wantedRichTextBox.Location = new System.Drawing.Point(95, 126);
			this.wantedRichTextBox.Name = "wantedRichTextBox";
			this.wantedRichTextBox.Size = new System.Drawing.Size(383, 96);
			this.wantedRichTextBox.TabIndex = 5;
			this.wantedRichTextBox.Text = "";
			// 
			// wantedLabel
			// 
			this.wantedLabel.AutoSize = true;
			this.wantedLabel.Location = new System.Drawing.Point(12, 126);
			this.wantedLabel.Name = "wantedLabel";
			this.wantedLabel.Size = new System.Drawing.Size(76, 13);
			this.wantedLabel.TabIndex = 4;
			this.wantedLabel.Text = "Molim, traži se:";
			// 
			// medInstitutionComboBox
			// 
			this.medInstitutionComboBox.DataSource = this.medicalInstitutionsBindingSource;
			this.medInstitutionComboBox.DisplayMember = "Name";
			this.medInstitutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.medInstitutionComboBox.FormattingEnabled = true;
			this.medInstitutionComboBox.Location = new System.Drawing.Point(95, 58);
			this.medInstitutionComboBox.Name = "medInstitutionComboBox";
			this.medInstitutionComboBox.Size = new System.Drawing.Size(383, 21);
			this.medInstitutionComboBox.TabIndex = 3;
			this.medInstitutionComboBox.ValueMember = "Id";
			// 
			// medicalInstitutionsBindingSource
			// 
			this.medicalInstitutionsBindingSource.DataSource = typeof(MedOrd.DomainModel.MedicalInstitution);
			// 
			// medicalInstitutionLabel
			// 
			this.medicalInstitutionLabel.AutoSize = true;
			this.medicalInstitutionLabel.Location = new System.Drawing.Point(12, 61);
			this.medicalInstitutionLabel.Name = "medicalInstitutionLabel";
			this.medicalInstitutionLabel.Size = new System.Drawing.Size(56, 13);
			this.medicalInstitutionLabel.TabIndex = 2;
			this.medicalInstitutionLabel.Text = "Ustanova:";
			// 
			// medCareActivityComboBox
			// 
			this.medCareActivityComboBox.DataSource = this.medicalCareActivitiesBindingSource;
			this.medCareActivityComboBox.DisplayMember = "Title";
			this.medCareActivityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.medCareActivityComboBox.FormattingEnabled = true;
			this.medCareActivityComboBox.Location = new System.Drawing.Point(95, 19);
			this.medCareActivityComboBox.Name = "medCareActivityComboBox";
			this.medCareActivityComboBox.Size = new System.Drawing.Size(383, 21);
			this.medCareActivityComboBox.TabIndex = 1;
			this.medCareActivityComboBox.ValueMember = "Id";
			// 
			// medicalCareActivitiesBindingSource
			// 
			this.medicalCareActivitiesBindingSource.DataSource = typeof(MedOrd.DomainModel.MedicalCareActivity);
			// 
			// healthCareActivityLabel
			// 
			this.healthCareActivityLabel.AutoSize = true;
			this.healthCareActivityLabel.Location = new System.Drawing.Point(12, 22);
			this.healthCareActivityLabel.Name = "healthCareActivityLabel";
			this.healthCareActivityLabel.Size = new System.Drawing.Size(64, 13);
			this.healthCareActivityLabel.TabIndex = 0;
			this.healthCareActivityLabel.Text = "Upućuje se:";
			// 
			// bottomPanel
			// 
			this.bottomPanel.Controls.Add(this.cancelButton);
			this.bottomPanel.Controls.Add(this.saveButton);
			this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomPanel.Location = new System.Drawing.Point(5, 244);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(504, 57);
			this.bottomPanel.TabIndex = 6;
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(268, 17);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Odustani";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Enabled = false;
			this.saveButton.Location = new System.Drawing.Point(161, 17);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 0;
			this.saveButton.Text = "Spremi";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// MedicalReferenceFormView
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(514, 306);
			this.Controls.Add(this.medicalReferenceGroupBox);
			this.Controls.Add(this.bottomPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MedicalReferenceFormView";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.ShowInTaskbar = false;
			this.Text = "Uputnica";
			this.medicalReferenceGroupBox.ResumeLayout(false);
			this.medicalReferenceGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.medicalInstitutionsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.medicalCareActivitiesBindingSource)).EndInit();
			this.bottomPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox medicalReferenceGroupBox;
		private System.Windows.Forms.ComboBox medCareActivityComboBox;
		private System.Windows.Forms.Label healthCareActivityLabel;
		private System.Windows.Forms.ComboBox medInstitutionComboBox;
		private System.Windows.Forms.Label medicalInstitutionLabel;
		private System.Windows.Forms.RichTextBox wantedRichTextBox;
		private System.Windows.Forms.Label wantedLabel;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.BindingSource medicalCareActivitiesBindingSource;
		private System.Windows.Forms.BindingSource medicalInstitutionsBindingSource;
		private System.Windows.Forms.Label diagnosisLabel;
		private System.Windows.Forms.Label diagnosisValueLabel;
	}
}