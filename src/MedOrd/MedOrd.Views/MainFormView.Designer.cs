namespace MedOrd.Views {
	partial class MainFormView {
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
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.noviPacijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.otvoriKartonPacijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.cekaonicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.izlazToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(734, 24);
			this.mainMenuStrip.TabIndex = 1;
			this.mainMenuStrip.Text = "mainMenuStrip";
			// 
			// izlazToolStripMenuItem
			// 
			this.izlazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviPacijentToolStripMenuItem,
            this.otvoriKartonPacijentaToolStripMenuItem,
            this.toolStripSeparator2,
            this.cekaonicaToolStripMenuItem,
            this.toolStripSeparator1,
            this.izlazToolStripMenuItem1});
			this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
			this.izlazToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.izlazToolStripMenuItem.Text = "&Kartoteka";
			// 
			// noviPacijentToolStripMenuItem
			// 
			this.noviPacijentToolStripMenuItem.AutoToolTip = true;
			this.noviPacijentToolStripMenuItem.Name = "noviPacijentToolStripMenuItem";
			this.noviPacijentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.noviPacijentToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
			this.noviPacijentToolStripMenuItem.Text = "&Novi pacijent";
			this.noviPacijentToolStripMenuItem.Click += new System.EventHandler(this.noviPacijentToolStripMenuItem_Click);
			// 
			// otvoriKartonPacijentaToolStripMenuItem
			// 
			this.otvoriKartonPacijentaToolStripMenuItem.Name = "otvoriKartonPacijentaToolStripMenuItem";
			this.otvoriKartonPacijentaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.otvoriKartonPacijentaToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
			this.otvoriKartonPacijentaToolStripMenuItem.Text = "&Otvori karton pacijenta";
			this.otvoriKartonPacijentaToolStripMenuItem.Click += new System.EventHandler(this.otvoriKartonPacijentaToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(235, 6);
			// 
			// cekaonicaToolStripMenuItem
			// 
			this.cekaonicaToolStripMenuItem.Name = "cekaonicaToolStripMenuItem";
			this.cekaonicaToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
			this.cekaonicaToolStripMenuItem.Text = "Čekaonica";
			this.cekaonicaToolStripMenuItem.Click += new System.EventHandler(this.cekaonicaToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(235, 6);
			// 
			// izlazToolStripMenuItem1
			// 
			this.izlazToolStripMenuItem1.Name = "izlazToolStripMenuItem1";
			this.izlazToolStripMenuItem1.Size = new System.Drawing.Size(238, 22);
			this.izlazToolStripMenuItem1.Text = "I&zlaz";
			this.izlazToolStripMenuItem1.Click += new System.EventHandler(this.izlazToolStripMenuItem1_Click);
			// 
			// MainFormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 514);
			this.Controls.Add(this.mainMenuStrip);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.mainMenuStrip;
			this.Name = "MainFormView";
			this.Text = "MedOrd";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormView_Load);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem noviPacijentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem otvoriKartonPacijentaToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem cekaonicaToolStripMenuItem;
	}
}