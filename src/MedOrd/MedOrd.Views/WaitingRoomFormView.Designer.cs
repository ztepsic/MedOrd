namespace MedOrd.Views {
	partial class WaitingRoomFormView {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitingRoomFormView));
			this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.waitingRoomDataGridView = new System.Windows.Forms.DataGridView();
			this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.waitingRoomToolStrip = new System.Windows.Forms.ToolStrip();
			this.addPatientToolStripButton = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.waitingRoomDataGridView)).BeginInit();
			this.waitingRoomToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// patientBindingSource
			// 
			this.patientBindingSource.DataSource = typeof(MedOrd.DomainModel.Patient);
			// 
			// waitingRoomDataGridView
			// 
			this.waitingRoomDataGridView.AllowUserToAddRows = false;
			this.waitingRoomDataGridView.AllowUserToDeleteRows = false;
			this.waitingRoomDataGridView.AutoGenerateColumns = false;
			this.waitingRoomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.waitingRoomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.waitingRoomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn});
			this.waitingRoomDataGridView.DataSource = this.patientBindingSource;
			this.waitingRoomDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.waitingRoomDataGridView.Location = new System.Drawing.Point(5, 30);
			this.waitingRoomDataGridView.MultiSelect = false;
			this.waitingRoomDataGridView.Name = "waitingRoomDataGridView";
			this.waitingRoomDataGridView.ReadOnly = true;
			this.waitingRoomDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.waitingRoomDataGridView.Size = new System.Drawing.Size(694, 503);
			this.waitingRoomDataGridView.TabIndex = 0;
			this.waitingRoomDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.waitingRoomDataGridView_CellDoubleClick);
			// 
			// fullNameDataGridViewTextBoxColumn
			// 
			this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
			this.fullNameDataGridViewTextBoxColumn.HeaderText = "Ime i prezime";
			this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
			this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// waitingRoomToolStrip
			// 
			this.waitingRoomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatientToolStripButton});
			this.waitingRoomToolStrip.Location = new System.Drawing.Point(5, 5);
			this.waitingRoomToolStrip.Name = "waitingRoomToolStrip";
			this.waitingRoomToolStrip.Size = new System.Drawing.Size(694, 25);
			this.waitingRoomToolStrip.TabIndex = 1;
			this.waitingRoomToolStrip.Text = "Čekaonica alatna traka";
			// 
			// addPatientToolStripButton
			// 
			this.addPatientToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.addPatientToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addPatientToolStripButton.Image")));
			this.addPatientToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addPatientToolStripButton.Name = "addPatientToolStripButton";
			this.addPatientToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.addPatientToolStripButton.Text = "Dodaj pacijenta u čekaonicu";
			this.addPatientToolStripButton.Click += new System.EventHandler(this.addPatientToolStripButton_Click);
			// 
			// WaitingRoomFormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 538);
			this.Controls.Add(this.waitingRoomDataGridView);
			this.Controls.Add(this.waitingRoomToolStrip);
			this.Name = "WaitingRoomFormView";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.Text = "Čekaonica";
			this.Load += new System.EventHandler(this.WaitingRoomFormView_Load);
			((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.waitingRoomDataGridView)).EndInit();
			this.waitingRoomToolStrip.ResumeLayout(false);
			this.waitingRoomToolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource patientBindingSource;
		private System.Windows.Forms.DataGridView waitingRoomDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStrip waitingRoomToolStrip;
		private System.Windows.Forms.ToolStripButton addPatientToolStripButton;
	}
}