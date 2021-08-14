namespace BeitragReader
{
    partial class Beitrag
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCompaniesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createXMLFile2 = new BeitragReader.CreateXMLFile();
            this.addForm1 = new BeitragReader.AddForm();
            this.searchForm2 = new BeitragReader.SearchForm();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Silver;
            this.menuStrip2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem1,
            this.addToolStripMenuItem1,
            this.searchToolStripMenuItem1,
            this.createXMLToolStripMenuItem,
            this.manageCompaniesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(798, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.homeToolStripMenuItem1.Text = "Home";
            this.homeToolStripMenuItem1.Click += new System.EventHandler(this.homeToolStripMenuItem1_Click);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(42, 20);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // createXMLToolStripMenuItem
            // 
            this.createXMLToolStripMenuItem.Name = "createXMLToolStripMenuItem";
            this.createXMLToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.createXMLToolStripMenuItem.Text = "Create XML";
            this.createXMLToolStripMenuItem.Click += new System.EventHandler(this.createXMLToolStripMenuItem_Click);
            // 
            // manageCompaniesToolStripMenuItem
            // 
            this.manageCompaniesToolStripMenuItem.Name = "manageCompaniesToolStripMenuItem";
            this.manageCompaniesToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.manageCompaniesToolStripMenuItem.Text = "Manage Companies";
            this.manageCompaniesToolStripMenuItem.Click += new System.EventHandler(this.manageCompaniesToolStripMenuItem_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(300, 163);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(170, 108);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open File";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openButton);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 422);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Home";
            // 
            // createXMLFile2
            // 
            this.createXMLFile2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createXMLFile2.Location = new System.Drawing.Point(0, 27);
            this.createXMLFile2.Name = "createXMLFile2";
            this.createXMLFile2.Size = new System.Drawing.Size(800, 424);
            this.createXMLFile2.TabIndex = 5;
            // 
            // addForm1
            // 
            this.addForm1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addForm1.beitragID = 0;
            this.addForm1.beitragIDFinal = 0;
            this.addForm1.beitragIDNumber = 0;
            this.addForm1.i = 0;
            this.addForm1.index = 0;
            this.addForm1.listindex = 0;
            this.addForm1.Location = new System.Drawing.Point(0, 27);
            this.addForm1.Name = "addForm1";
            this.addForm1.Size = new System.Drawing.Size(800, 424);
            this.addForm1.TabIndex = 6;
            // 
            // searchForm2
            // 
            this.searchForm2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchForm2.Location = new System.Drawing.Point(0, 27);
            this.searchForm2.Name = "searchForm2";
            this.searchForm2.SelectedItem = 0;
            this.searchForm2.Size = new System.Drawing.Size(800, 424);
            this.searchForm2.TabIndex = 3;
            // 
            // Beitrag
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(798, 449);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.createXMLFile2);
            this.Controls.Add(this.addForm1);
            this.Controls.Add(this.searchForm2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Beitrag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tamás Csilla Programja";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private SearchForm searchForm2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ToolStripMenuItem createXMLToolStripMenuItem;
        private CreateXMLFile createXMLFile2;
        private System.Windows.Forms.ToolStripMenuItem manageCompaniesToolStripMenuItem;
        private AddForm addForm1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

