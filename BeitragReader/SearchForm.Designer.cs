namespace BeitragReader
{
    partial class SearchForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchButton = new System.Windows.Forms.Button();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.textRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.hashTextBox = new System.Windows.Forms.TextBox();
            this.newSearchButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(307, 207);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AllowUserToAddRows = false;
            this.searchDataGridView.AllowUserToDeleteRows = false;
            this.searchDataGridView.AllowUserToResizeColumns = false;
            this.searchDataGridView.AllowUserToResizeRows = false;
            this.searchDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(125, 20);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchDataGridView.Size = new System.Drawing.Size(543, 150);
            this.searchDataGridView.TabIndex = 1;
            this.searchDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchDataGridView_CellContentClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Location = new System.Drawing.Point(307, 188);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(161, 16);
            this.searchTextBox.TabIndex = 2;
            // 
            // textRichTextBox
            // 
            this.textRichTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.textRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRichTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRichTextBox.Location = new System.Drawing.Point(125, 267);
            this.textRichTextBox.Name = "textRichTextBox";
            this.textRichTextBox.Size = new System.Drawing.Size(543, 120);
            this.textRichTextBox.TabIndex = 3;
            this.textRichTextBox.Text = "";
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.CommentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CommentTextBox.Location = new System.Drawing.Point(125, 241);
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(543, 16);
            this.CommentTextBox.TabIndex = 4;
            // 
            // hashTextBox
            // 
            this.hashTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.hashTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hashTextBox.Location = new System.Drawing.Point(125, 393);
            this.hashTextBox.Name = "hashTextBox";
            this.hashTextBox.Size = new System.Drawing.Size(543, 16);
            this.hashTextBox.TabIndex = 5;
            // 
            // newSearchButton
            // 
            this.newSearchButton.Location = new System.Drawing.Point(393, 207);
            this.newSearchButton.Name = "newSearchButton";
            this.newSearchButton.Size = new System.Drawing.Size(75, 23);
            this.newSearchButton.TabIndex = 6;
            this.newSearchButton.Text = "New search";
            this.newSearchButton.UseVisualStyleBackColor = true;
            this.newSearchButton.Click += new System.EventHandler(this.newSearchButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(687, 267);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 120);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(32, 267);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 120);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Remove";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.newSearchButton);
            this.groupBox1.Controls.Add(this.hashTextBox);
            this.groupBox1.Controls.Add(this.CommentTextBox);
            this.groupBox1.Controls.Add(this.textRichTextBox);
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.searchDataGridView);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 419);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchForm";
            this.Size = new System.Drawing.Size(800, 424);
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RichTextBox textRichTextBox;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.TextBox hashTextBox;
        private System.Windows.Forms.Button newSearchButton;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
