namespace CsvReader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cSVReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.msiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVReaderToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(1, 1, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cSVReaderToolStripMenuItem
            // 
            this.cSVReaderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiOpen,
            this.msiClose,
            this.toolStripSeparator1,
            this.msiQuit});
            this.cSVReaderToolStripMenuItem.Name = "cSVReaderToolStripMenuItem";
            this.cSVReaderToolStripMenuItem.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.cSVReaderToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.cSVReaderToolStripMenuItem.Text = "File";
            // 
            // msiOpen
            // 
            this.msiOpen.Name = "msiOpen";
            this.msiOpen.Size = new System.Drawing.Size(103, 22);
            this.msiOpen.Text = "Open";
            this.msiOpen.Click += new System.EventHandler(this.msiOpen_Click);
            // 
            // msiClose
            // 
            this.msiClose.Name = "msiClose";
            this.msiClose.Size = new System.Drawing.Size(103, 22);
            this.msiClose.Text = "Close";
            this.msiClose.Click += new System.EventHandler(this.msiClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // msiQuit
            // 
            this.msiQuit.Name = "msiQuit";
            this.msiQuit.Size = new System.Drawing.Size(103, 22);
            this.msiQuit.Text = "Quit";
            this.msiQuit.Click += new System.EventHandler(this.msiQuit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiHelp,
            this.msiAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // msiHelp
            // 
            this.msiHelp.Name = "msiHelp";
            this.msiHelp.Size = new System.Drawing.Size(142, 22);
            this.msiHelp.Text = "Help page";
            this.msiHelp.Click += new System.EventHandler(this.msiHelp_Click);
            // 
            // msiAbout
            // 
            this.msiAbout.Name = "msiAbout";
            this.msiAbout.Size = new System.Drawing.Size(142, 22);
            this.msiAbout.Text = "About mCSV";
            this.msiAbout.Click += new System.EventHandler(this.msiAbout_Click);
            // 
            // dgvGrid
            // 
            this.dgvGrid.AllowUserToAddRows = false;
            this.dgvGrid.AllowUserToDeleteRows = false;
            this.dgvGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrid.Location = new System.Drawing.Point(0, 24);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.ReadOnly = true;
            this.dgvGrid.Size = new System.Drawing.Size(800, 426);
            this.dgvGrid.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGrid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "mCSV Reader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cSVReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem msiQuit;
        private System.Windows.Forms.ToolStripMenuItem msiHelp;
        private System.Windows.Forms.ToolStripMenuItem msiAbout;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.ToolStripMenuItem msiClose;
    }
}

