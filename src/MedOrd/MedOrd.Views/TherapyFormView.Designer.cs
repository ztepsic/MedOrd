namespace MedOrd.Views {
	partial class TherapyFormView {
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
			this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.therapyGroupBox = new System.Windows.Forms.GroupBox();
			this.progressValueLabel = new System.Windows.Forms.Label();
			this.therapyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.progrressLabel = new System.Windows.Forms.Label();
			this.dateValueLabel = new System.Windows.Forms.Label();
			this.dateLabel = new System.Windows.Forms.Label();
			this.descRichTextBox = new System.Windows.Forms.RichTextBox();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.titleTextBox = new System.Windows.Forms.TextBox();
			this.titleLabel = new System.Windows.Forms.Label();
			this.quantityBoxNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.quantityBoxLabel = new System.Windows.Forms.Label();
			this.dailyLabel = new System.Windows.Forms.Label();
			this.intervalNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.intervalNumberLabel = new System.Windows.Forms.Label();
			this.dossageNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.dosageLabel = new System.Windows.Forms.Label();
			this.drugsComboBox = new System.Windows.Forms.ComboBox();
			this.drugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.drugLabel = new System.Windows.Forms.Label();
			this.drugGroupBox = new System.Windows.Forms.GroupBox();
			this.drugQuantitiInBoxLabel = new System.Windows.Forms.Label();
			this.drugQuantityInBoxLabel = new System.Windows.Forms.Label();
			this.drugManufacterValueLabel = new System.Windows.Forms.Label();
			this.drugManufacterLabel = new System.Windows.Forms.Label();
			this.drugDescValueLabel = new System.Windows.Forms.Label();
			this.drugDescLabel = new System.Windows.Forms.Label();
			this.drugGenericTitleValueLabel = new System.Windows.Forms.Label();
			this.drugGenericTitleLabel = new System.Windows.Forms.Label();
			this.drugTitleValueLabel = new System.Windows.Forms.Label();
			this.drugTitleLabel = new System.Windows.Forms.Label();
			this.bottomPanel = new System.Windows.Forms.Panel();
			this.cancelButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.mainTableLayoutPanel.SuspendLayout();
			this.therapyGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.therapyBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quantityBoxNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.intervalNumberNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dossageNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).BeginInit();
			this.drugGroupBox.SuspendLayout();
			this.bottomPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainTableLayoutPanel
			// 
			this.mainTableLayoutPanel.AutoSize = true;
			this.mainTableLayoutPanel.ColumnCount = 2;
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
			this.mainTableLayoutPanel.Controls.Add(this.therapyGroupBox, 0, 0);
			this.mainTableLayoutPanel.Controls.Add(this.drugGroupBox, 1, 0);
			this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			this.mainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
			this.mainTableLayoutPanel.RowCount = 2;
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.mainTableLayoutPanel.Size = new System.Drawing.Size(624, 378);
			this.mainTableLayoutPanel.TabIndex = 0;
			// 
			// therapyGroupBox
			// 
			this.therapyGroupBox.Controls.Add(this.progressValueLabel);
			this.therapyGroupBox.Controls.Add(this.progrressLabel);
			this.therapyGroupBox.Controls.Add(this.dateValueLabel);
			this.therapyGroupBox.Controls.Add(this.dateLabel);
			this.therapyGroupBox.Controls.Add(this.descRichTextBox);
			this.therapyGroupBox.Controls.Add(this.descriptionLabel);
			this.therapyGroupBox.Controls.Add(this.titleTextBox);
			this.therapyGroupBox.Controls.Add(this.titleLabel);
			this.therapyGroupBox.Controls.Add(this.quantityBoxNumericUpDown);
			this.therapyGroupBox.Controls.Add(this.quantityBoxLabel);
			this.therapyGroupBox.Controls.Add(this.dailyLabel);
			this.therapyGroupBox.Controls.Add(this.intervalNumberNumericUpDown);
			this.therapyGroupBox.Controls.Add(this.intervalNumberLabel);
			this.therapyGroupBox.Controls.Add(this.dossageNumericUpDown);
			this.therapyGroupBox.Controls.Add(this.dosageLabel);
			this.therapyGroupBox.Controls.Add(this.drugsComboBox);
			this.therapyGroupBox.Controls.Add(this.drugLabel);
			this.therapyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.therapyGroupBox.Location = new System.Drawing.Point(8, 8);
			this.therapyGroupBox.Name = "therapyGroupBox";
			this.therapyGroupBox.Size = new System.Drawing.Size(307, 342);
			this.therapyGroupBox.TabIndex = 0;
			this.therapyGroupBox.TabStop = false;
			this.therapyGroupBox.Text = "Terapija";
			// 
			// progressValueLabel
			// 
			this.progressValueLabel.AutoSize = true;
			this.progressValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.therapyBindingSource, "TherapyProgress", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
			this.progressValueLabel.Location = new System.Drawing.Point(129, 315);
			this.progressValueLabel.Name = "progressValueLabel";
			this.progressValueLabel.Size = new System.Drawing.Size(35, 13);
			this.progressValueLabel.TabIndex = 16;
			this.progressValueLabel.Text = "label1";
			// 
			// therapyBindingSource
			// 
			this.therapyBindingSource.DataSource = typeof(MedOrd.DomainModel.Therapy);
			// 
			// progrressLabel
			// 
			this.progrressLabel.AutoSize = true;
			this.progrressLabel.Location = new System.Drawing.Point(8, 315);
			this.progrressLabel.Name = "progrressLabel";
			this.progrressLabel.Size = new System.Drawing.Size(114, 13);
			this.progrressLabel.TabIndex = 15;
			this.progrressLabel.Text = "Napredovanje terapije:";
			// 
			// dateValueLabel
			// 
			this.dateValueLabel.AutoSize = true;
			this.dateValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.therapyBindingSource, "Date", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
			this.dateValueLabel.Location = new System.Drawing.Point(76, 290);
			this.dateValueLabel.Name = "dateValueLabel";
			this.dateValueLabel.Size = new System.Drawing.Size(35, 13);
			this.dateValueLabel.TabIndex = 14;
			this.dateValueLabel.Text = "label1";
			// 
			// dateLabel
			// 
			this.dateLabel.AutoSize = true;
			this.dateLabel.Location = new System.Drawing.Point(8, 290);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new System.Drawing.Size(56, 13);
			this.dateLabel.TabIndex = 13;
			this.dateLabel.Text = "Na datum:";
			// 
			// descRichTextBox
			// 
			this.descRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.therapyBindingSource, "Description", true));
			this.descRichTextBox.Location = new System.Drawing.Point(46, 184);
			this.descRichTextBox.Name = "descRichTextBox";
			this.descRichTextBox.Size = new System.Drawing.Size(255, 90);
			this.descRichTextBox.TabIndex = 12;
			this.descRichTextBox.Text = "";
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(8, 184);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(31, 13);
			this.descriptionLabel.TabIndex = 11;
			this.descriptionLabel.Text = "Opis:";
			// 
			// titleTextBox
			// 
			this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.therapyBindingSource, "Title", true));
			this.titleTextBox.Location = new System.Drawing.Point(46, 141);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(255, 20);
			this.titleTextBox.TabIndex = 10;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(8, 144);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(37, 13);
			this.titleLabel.TabIndex = 9;
			this.titleLabel.Text = "Naziv:";
			// 
			// quantityBoxNumericUpDown
			// 
			this.quantityBoxNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.therapyBindingSource, "BoxQuantity", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "1", "N0"));
			this.quantityBoxNumericUpDown.Location = new System.Drawing.Point(46, 94);
			this.quantityBoxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.quantityBoxNumericUpDown.Name = "quantityBoxNumericUpDown";
			this.quantityBoxNumericUpDown.Size = new System.Drawing.Size(40, 20);
			this.quantityBoxNumericUpDown.TabIndex = 8;
			this.quantityBoxNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// quantityBoxLabel
			// 
			this.quantityBoxLabel.AutoSize = true;
			this.quantityBoxLabel.Location = new System.Drawing.Point(8, 96);
			this.quantityBoxLabel.Name = "quantityBoxLabel";
			this.quantityBoxLabel.Size = new System.Drawing.Size(36, 13);
			this.quantityBoxLabel.TabIndex = 7;
			this.quantityBoxLabel.Text = "Kutija:";
			// 
			// dailyLabel
			// 
			this.dailyLabel.AutoSize = true;
			this.dailyLabel.Location = new System.Drawing.Point(152, 62);
			this.dailyLabel.Name = "dailyLabel";
			this.dailyLabel.Size = new System.Drawing.Size(43, 13);
			this.dailyLabel.TabIndex = 6;
			this.dailyLabel.Text = "dnevno";
			// 
			// intervalNumberNumericUpDown
			// 
			this.intervalNumberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.therapyBindingSource, "PerDay", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "1", "N0"));
			this.intervalNumberNumericUpDown.Location = new System.Drawing.Point(109, 60);
			this.intervalNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.intervalNumberNumericUpDown.Name = "intervalNumberNumericUpDown";
			this.intervalNumberNumericUpDown.Size = new System.Drawing.Size(40, 20);
			this.intervalNumberNumericUpDown.TabIndex = 5;
			this.intervalNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// intervalNumberLabel
			// 
			this.intervalNumberLabel.AutoSize = true;
			this.intervalNumberLabel.Location = new System.Drawing.Point(92, 62);
			this.intervalNumberLabel.Name = "intervalNumberLabel";
			this.intervalNumberLabel.Size = new System.Drawing.Size(14, 13);
			this.intervalNumberLabel.TabIndex = 4;
			this.intervalNumberLabel.Text = "X";
			// 
			// dossageNumericUpDown
			// 
			this.dossageNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.therapyBindingSource, "Dosage", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "1", "N0"));
			this.dossageNumericUpDown.Location = new System.Drawing.Point(46, 60);
			this.dossageNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.dossageNumericUpDown.Name = "dossageNumericUpDown";
			this.dossageNumericUpDown.Size = new System.Drawing.Size(40, 20);
			this.dossageNumericUpDown.TabIndex = 3;
			this.dossageNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// dosageLabel
			// 
			this.dosageLabel.AutoSize = true;
			this.dosageLabel.Location = new System.Drawing.Point(8, 62);
			this.dosageLabel.Name = "dosageLabel";
			this.dosageLabel.Size = new System.Drawing.Size(35, 13);
			this.dosageLabel.TabIndex = 2;
			this.dosageLabel.Text = "Doza:";
			// 
			// drugsComboBox
			// 
			this.drugsComboBox.DataSource = this.drugsBindingSource;
			this.drugsComboBox.DisplayMember = "Name";
			this.drugsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.drugsComboBox.FormattingEnabled = true;
			this.drugsComboBox.Location = new System.Drawing.Point(46, 20);
			this.drugsComboBox.Name = "drugsComboBox";
			this.drugsComboBox.Size = new System.Drawing.Size(255, 21);
			this.drugsComboBox.TabIndex = 1;
			this.drugsComboBox.ValueMember = "Id";
			// 
			// drugsBindingSource
			// 
			this.drugsBindingSource.DataSource = typeof(MedOrd.DomainModel.Drug);
			// 
			// drugLabel
			// 
			this.drugLabel.AutoSize = true;
			this.drugLabel.Location = new System.Drawing.Point(8, 23);
			this.drugLabel.Name = "drugLabel";
			this.drugLabel.Size = new System.Drawing.Size(32, 13);
			this.drugLabel.TabIndex = 0;
			this.drugLabel.Text = "Lijek:";
			// 
			// drugGroupBox
			// 
			this.drugGroupBox.Controls.Add(this.drugQuantitiInBoxLabel);
			this.drugGroupBox.Controls.Add(this.drugQuantityInBoxLabel);
			this.drugGroupBox.Controls.Add(this.drugManufacterValueLabel);
			this.drugGroupBox.Controls.Add(this.drugManufacterLabel);
			this.drugGroupBox.Controls.Add(this.drugDescValueLabel);
			this.drugGroupBox.Controls.Add(this.drugDescLabel);
			this.drugGroupBox.Controls.Add(this.drugGenericTitleValueLabel);
			this.drugGroupBox.Controls.Add(this.drugGenericTitleLabel);
			this.drugGroupBox.Controls.Add(this.drugTitleValueLabel);
			this.drugGroupBox.Controls.Add(this.drugTitleLabel);
			this.drugGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.drugGroupBox.Location = new System.Drawing.Point(321, 8);
			this.drugGroupBox.Name = "drugGroupBox";
			this.drugGroupBox.Size = new System.Drawing.Size(295, 342);
			this.drugGroupBox.TabIndex = 1;
			this.drugGroupBox.TabStop = false;
			this.drugGroupBox.Text = "Detalji o lijeku";
			// 
			// drugQuantitiInBoxLabel
			// 
			this.drugQuantitiInBoxLabel.AutoSize = true;
			this.drugQuantitiInBoxLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "QuantityInBox", true));
			this.drugQuantitiInBoxLabel.Location = new System.Drawing.Point(105, 108);
			this.drugQuantitiInBoxLabel.Name = "drugQuantitiInBoxLabel";
			this.drugQuantitiInBoxLabel.Size = new System.Drawing.Size(118, 13);
			this.drugQuantitiInBoxLabel.TabIndex = 9;
			this.drugQuantitiInBoxLabel.Text = "drugQuantitiInBoxValue";
			// 
			// drugQuantityInBoxLabel
			// 
			this.drugQuantityInBoxLabel.AutoSize = true;
			this.drugQuantityInBoxLabel.Location = new System.Drawing.Point(10, 109);
			this.drugQuantityInBoxLabel.Name = "drugQuantityInBoxLabel";
			this.drugQuantityInBoxLabel.Size = new System.Drawing.Size(80, 13);
			this.drugQuantityInBoxLabel.TabIndex = 8;
			this.drugQuantityInBoxLabel.Text = "Količina u kutiji:";
			// 
			// drugManufacterValueLabel
			// 
			this.drugManufacterValueLabel.AutoSize = true;
			this.drugManufacterValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "Manufacturer", true));
			this.drugManufacterValueLabel.Location = new System.Drawing.Point(105, 76);
			this.drugManufacterValueLabel.Name = "drugManufacterValueLabel";
			this.drugManufacterValueLabel.Size = new System.Drawing.Size(109, 13);
			this.drugManufacterValueLabel.TabIndex = 7;
			this.drugManufacterValueLabel.Text = "drugManufacterValue";
			// 
			// drugManufacterLabel
			// 
			this.drugManufacterLabel.AutoSize = true;
			this.drugManufacterLabel.Location = new System.Drawing.Point(10, 77);
			this.drugManufacterLabel.Name = "drugManufacterLabel";
			this.drugManufacterLabel.Size = new System.Drawing.Size(64, 13);
			this.drugManufacterLabel.TabIndex = 6;
			this.drugManufacterLabel.Text = "Proizvođač:";
			// 
			// drugDescValueLabel
			// 
			this.drugDescValueLabel.AutoSize = true;
			this.drugDescValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "Description", true));
			this.drugDescValueLabel.Location = new System.Drawing.Point(48, 141);
			this.drugDescValueLabel.Name = "drugDescValueLabel";
			this.drugDescValueLabel.Size = new System.Drawing.Size(80, 13);
			this.drugDescValueLabel.TabIndex = 5;
			this.drugDescValueLabel.Text = "drugDescValue";
			// 
			// drugDescLabel
			// 
			this.drugDescLabel.AutoSize = true;
			this.drugDescLabel.Location = new System.Drawing.Point(10, 141);
			this.drugDescLabel.Name = "drugDescLabel";
			this.drugDescLabel.Size = new System.Drawing.Size(31, 13);
			this.drugDescLabel.TabIndex = 4;
			this.drugDescLabel.Text = "Opis:";
			// 
			// drugGenericTitleValueLabel
			// 
			this.drugGenericTitleValueLabel.AutoSize = true;
			this.drugGenericTitleValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "GenericName", true));
			this.drugGenericTitleValueLabel.Location = new System.Drawing.Point(105, 49);
			this.drugGenericTitleValueLabel.Name = "drugGenericTitleValueLabel";
			this.drugGenericTitleValueLabel.Size = new System.Drawing.Size(112, 13);
			this.drugGenericTitleValueLabel.TabIndex = 3;
			this.drugGenericTitleValueLabel.Text = "drugGenericTitleValue";
			// 
			// drugGenericTitleLabel
			// 
			this.drugGenericTitleLabel.AutoSize = true;
			this.drugGenericTitleLabel.Location = new System.Drawing.Point(10, 49);
			this.drugGenericTitleLabel.Name = "drugGenericTitleLabel";
			this.drugGenericTitleLabel.Size = new System.Drawing.Size(83, 13);
			this.drugGenericTitleLabel.TabIndex = 2;
			this.drugGenericTitleLabel.Text = "Generički naziv:";
			// 
			// drugTitleValueLabel
			// 
			this.drugTitleValueLabel.AutoSize = true;
			this.drugTitleValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "Name", true));
			this.drugTitleValueLabel.Location = new System.Drawing.Point(105, 23);
			this.drugTitleValueLabel.Name = "drugTitleValueLabel";
			this.drugTitleValueLabel.Size = new System.Drawing.Size(75, 13);
			this.drugTitleValueLabel.TabIndex = 1;
			this.drugTitleValueLabel.Text = "drugTitleValue";
			// 
			// drugTitleLabel
			// 
			this.drugTitleLabel.AutoSize = true;
			this.drugTitleLabel.Location = new System.Drawing.Point(10, 23);
			this.drugTitleLabel.Name = "drugTitleLabel";
			this.drugTitleLabel.Size = new System.Drawing.Size(37, 13);
			this.drugTitleLabel.TabIndex = 0;
			this.drugTitleLabel.Text = "Naziv:";
			// 
			// bottomPanel
			// 
			this.bottomPanel.Controls.Add(this.cancelButton);
			this.bottomPanel.Controls.Add(this.saveButton);
			this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomPanel.Location = new System.Drawing.Point(0, 378);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(624, 64);
			this.bottomPanel.TabIndex = 10;
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(321, 21);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Odustani";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.saveButton.Enabled = false;
			this.saveButton.Location = new System.Drawing.Point(204, 21);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 0;
			this.saveButton.Text = "Spremi";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// TherapyFormView
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.saveButton;
			this.ClientSize = new System.Drawing.Size(624, 442);
			this.Controls.Add(this.mainTableLayoutPanel);
			this.Controls.Add(this.bottomPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TherapyFormView";
			this.ShowInTaskbar = false;
			this.Text = "Terapija";
			this.mainTableLayoutPanel.ResumeLayout(false);
			this.therapyGroupBox.ResumeLayout(false);
			this.therapyGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.therapyBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quantityBoxNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.intervalNumberNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dossageNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).EndInit();
			this.drugGroupBox.ResumeLayout(false);
			this.drugGroupBox.PerformLayout();
			this.bottomPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
		private System.Windows.Forms.GroupBox therapyGroupBox;
		private System.Windows.Forms.ComboBox drugsComboBox;
		private System.Windows.Forms.Label drugLabel;
		private System.Windows.Forms.BindingSource drugsBindingSource;
		private System.Windows.Forms.NumericUpDown dossageNumericUpDown;
		private System.Windows.Forms.Label dosageLabel;
		private System.Windows.Forms.NumericUpDown intervalNumberNumericUpDown;
		private System.Windows.Forms.Label intervalNumberLabel;
		private System.Windows.Forms.NumericUpDown quantityBoxNumericUpDown;
		private System.Windows.Forms.Label quantityBoxLabel;
		private System.Windows.Forms.Label dailyLabel;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.RichTextBox descRichTextBox;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.TextBox titleTextBox;
		private System.Windows.Forms.GroupBox drugGroupBox;
		private System.Windows.Forms.Label drugTitleLabel;
		private System.Windows.Forms.Label drugDescLabel;
		private System.Windows.Forms.Label drugGenericTitleValueLabel;
		private System.Windows.Forms.Label drugGenericTitleLabel;
		private System.Windows.Forms.Label drugTitleValueLabel;
		private System.Windows.Forms.Label drugQuantitiInBoxLabel;
		private System.Windows.Forms.Label drugQuantityInBoxLabel;
		private System.Windows.Forms.Label drugManufacterValueLabel;
		private System.Windows.Forms.Label drugManufacterLabel;
		private System.Windows.Forms.Label drugDescValueLabel;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.BindingSource therapyBindingSource;
		private System.Windows.Forms.Label dateLabel;
		private System.Windows.Forms.Label dateValueLabel;
		private System.Windows.Forms.Label progrressLabel;
		private System.Windows.Forms.Label progressValueLabel;
	}
}