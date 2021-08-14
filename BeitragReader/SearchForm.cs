using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace BeitragReader
{
    public partial class SearchForm : UserControl
    {

        List<Search.ISearchType> resultList = new List<Search.ISearchType>();
        public Search.SearchXML mc = new Search.SearchXML();

        Form1Code.Form1CodeFiles FilePath = new Form1Code.Form1CodeFiles();
        public int SelectedItem { get; set; }

        public SearchForm()
        {
            InitializeComponent();
            Load += newSearchButton_Click;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            searchDataGridView.DataSource = null;
            resultList.Clear();

            if (Beitrag.Path != "")
            {
                DataSet newDS = FilePath.LoadDataSet();

                searchDataGridView.DataSource = newDS.Tables[0];

                if (string.IsNullOrEmpty(searchTextBox.Text))
                {
                    (searchDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    (searchDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE'%{0}%' OR Type LIKE'%{0}%' OR Text LIKE'%{0}%' OR Hash LIKE'%{0}%'", searchTextBox.Text);
                }
            }         
        }

        private void newSearchButton_Click(object sender, EventArgs e)
        {
            if(Beitrag.Path != "")
            {
                try
                {
                    DataSet newDS = FilePath.LoadDataSet();
                    searchTextBox.Text = null;
                    searchDataGridView.DataSource = newDS.Tables[0];
                    searchDataGridView.Refresh();
                    resultList.Clear();
                }
                catch
                {
                    MessageBox.Show("File is Empty! Please add elements first!");
                }
            }
        }
        private void searchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.searchDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                this.searchDataGridView.ReadOnly = true;

                DataGridViewRow selectedRows = this.searchDataGridView.Rows[e.RowIndex];

                CommentTextBox.Text = selectedRows.Cells[1].Value.ToString();
                textRichTextBox.Text = selectedRows.Cells[2].Value.ToString();
                hashTextBox.Text = selectedRows.Cells[3].Value.ToString();

                SelectedItem = Convert.ToInt32(selectedRows.Cells[4].Value);
            }
            catch
            {
               
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //XmlDocument xmlDoc = new XmlDocument();
            if(Beitrag.Path != "") 
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Beitrag.Path);
                //XmlNodeList xnList = xmlDoc.SelectNodes($"/Beitrags/Beitrag[@ID='{SelectedItem}']");           

                XmlNode textElement = xmlDoc.SelectSingleNode(String.Format($"/Beitrags/Beitrag[@ID='{SelectedItem}']/Text"));
                XmlNode hashElement = xmlDoc.SelectSingleNode(String.Format($"/Beitrags/Beitrag[@ID='{SelectedItem}']/Hash"));
                XmlNode commentsElement = xmlDoc.SelectSingleNode(String.Format($"/Beitrags/Beitrag[@ID='{SelectedItem}']/Type"));
                textElement.InnerText = textRichTextBox.Text;
                hashElement.InnerText = hashTextBox.Text;
                commentsElement.InnerText = CommentTextBox.Text;

                xmlDoc.Save(Beitrag.Path);

                DataSet newDS = FilePath.LoadDataSet();

                searchDataGridView.DataSource = newDS.Tables[0];
                CommentTextBox.Refresh();
                textRichTextBox.Refresh();
                hashTextBox.Refresh();

                MessageBox.Show("Data Saved!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(SelectedItem != 0)
            {
                try
                {
                    if (MessageBox.Show("Are you sure to delete this item?", "Delete Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        if (Beitrag.Path != "") { xmlDoc.Load(Beitrag.Path); }

                        XmlNode node = xmlDoc.SelectSingleNode($"/Beitrags/Beitrag[@ID='{SelectedItem}']");
                        node.ParentNode.RemoveChild(node);

                        xmlDoc.Save(Beitrag.Path);

                        DataSet newDS = FilePath.LoadDataSet();

                        searchDataGridView.DataSource = newDS.Tables[0];

                        CommentTextBox.Clear();
                        textRichTextBox.Clear();
                        hashTextBox.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("You can not delete the last item, but edit.");
                }
               
            }
            else
            {
                MessageBox.Show("Please Select Item!");
            }
        }
    }
}
