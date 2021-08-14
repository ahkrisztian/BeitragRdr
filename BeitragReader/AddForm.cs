using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BeitragReader.BeitragModel;
using BeitragReader.Add;

namespace BeitragReader
{
    public partial class AddForm : UserControl
    {
        public AddtoXML addtoxmlcall = new AddtoXML();

        public List<BeitragModel.BeitragModel> beitragsModels = new List<BeitragModel.BeitragModel>();
        public int beitragID { get; set; }
        public int i { get; set; }
        public int beitragIDFinal { get; set; }
        public int listindex { get; set; }
        public int index { get; set; }
        public int beitragIDNumber { get; set; }

        public AddForm()
        {
            InitializeComponent();
            WireUpCompanyList();
        }
        private void addHashButton_Click(object sender, EventArgs e)
        {

            if (!hashListBox.Items.Contains(hashTextBox.Text) && !String.IsNullOrWhiteSpace(hashTextBox.Text))
            {
                hashListBox.Items.Add(hashTextBox.Text);
                //temp = string.Join(" ", hashListBox.Items.Cast<string>().ToList());
                hashTextBox.ResetText();
            }
            else
            {
                hashTextBox.ResetText();
            }
        }
        private async void saveButton_Click(object sender, EventArgs e)
        {
            AddtoXML mc = new AddtoXML();

            if (readyListBox.Items.Count > 0)
            {
                await mc.CreateXml(Beitrag.Path, beitragsModels);
            }
            else
            {
                MessageBox.Show("Please add Beitrag!");
            }

            MessageBox.Show("Data saved!");
            ClearFields2();
            beitragsModels.Clear();
            readyListBox.Items.Clear();
        }
        private void removeFromListButton_Click(object sender, EventArgs e)
        {
            hashListBox.Items.Remove(hashListBox.SelectedItem);
        }

        private void editListElementButton_Click(object sender, EventArgs e)
        {
            hashTextBox.Text = hashListBox.SelectedItem.ToString();
            hashListBox.Items.Remove(hashListBox.SelectedItem);
        }

        private void addToReadyListBoxButton_Click(object sender, EventArgs e)
        {
            BeitragModelIDList();
            string temp = string.Join(" ", hashListBox.Items.Cast<string>().ToList());

            if (comboBox1.SelectedItem != null)
            {
                readyListBox.Items.Clear();
                List<IBeitragModel> beitrags = new List<IBeitragModel>
                {
                new BeitragModel.BeitragModel{BeitragID = i, Name = comboBox1.SelectedItem.ToString(), Type = commentTextBox.Text, Text= addRichTextBox.Text, Hash = temp}
                };

                foreach (var beitragModel in beitrags)
                {
                    beitragsModels.Add(beitragModel.BeitragProcessor.Create(beitragModel));
                }

                foreach (var v in beitragsModels)
                {
                    readyListBox.Items.Add($"{v.BeitragID}. {v.Name}");
                }

                //Clear Fields
                ClearFields2();
                beitragIDNumber = readyListBox.Items.Count;
            }
            else
            {
                MessageBox.Show("Select Company!");
            }
        }
        private void newButton_Click(object sender, EventArgs e)
        {
            //Clear Fields
            ClearFields2();
            beitragIDtextBox.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Clear Fields
            ClearFields2();

            int listindex = readyListBox.SelectedIndex;
            beitragIDtextBox.Text = beitragsModels[listindex].BeitragID.ToString();
            addRichTextBox.Text = beitragsModels[listindex].Text.ToString();
            commentTextBox.Text = beitragsModels[listindex].Type.ToString();
            comboBox1.Text = beitragsModels[listindex].Name.ToString();
            string y = beitragsModels[listindex].Hash.ToString();
            string[] x = y.Split(' ');
            foreach (var v in x)
            {
                hashListBox.Items.Add(v);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Remove Element From List
            int index = beitragsModels.FindIndex(item => item.BeitragID == Convert.ToInt32(beitragIDtextBox.Text));
            beitragsModels.RemoveAt(index);
            readyListBox.Items.Clear();

            //Add Elements To Listbox
            foreach (var v in beitragsModels)
            {
                readyListBox.Items.Add($"{v.BeitragID}. {v.Name}");
            }
            //Clear Fields
            ClearFields2();
        }
        public void saveChangesbutton_Click(object sender, EventArgs e)
        {
            //Listbox to string
            string temp = string.Join(" ", hashListBox.Items.Cast<string>().ToList());

            //Find List Element and Change It 
            int index = beitragsModels.FindIndex(item => item.BeitragID == Convert.ToInt32(beitragIDtextBox.Text));

            BeitragModel.BeitragModel newItem = new BeitragModel.BeitragModel();
            newItem.BeitragID = Convert.ToInt32(beitragIDtextBox.Text);
            newItem.Name = comboBox1.Text;
            newItem.Type = commentTextBox.Text;
            newItem.Text = addRichTextBox.Text;
            newItem.Hash = temp;
            
            beitragsModels[index] = newItem;

            //Clear Fields
            readyListBox.Items.Clear();
            ClearFields2();

            //Add Elements To Listbox
            foreach (var v in beitragsModels)
            {
                readyListBox.Items.Add($"{v.BeitragID}. {v.Name}");
            }
        }
        private void clearreadyListBoxButton_Click(object sender, EventArgs e)
        {
            beitragsModels.Clear();
            readyListBox.Items.Clear();
        }

        public void ClearFields2()
        {
            comboBox1.SelectedItem = null;
            commentTextBox.Clear();
            addRichTextBox.Clear();
            hashListBox.Items.Clear();
            beitragIDtextBox.Clear();
        }

        public void BeitragModelIDList()
        {           
            List<int> newList = addtoxmlcall.GetLastId(Beitrag.Path);

            //List<int> IdList = new List<int>();

            if (beitragsModels.Count > 0)
            {
                foreach (var v in beitragsModels)
                {
                    newList.Add(v.BeitragID);
                }
            }       
            
            if(newList.Count != 0)
            {
                newList.Add(newList.Max() + 1);
                i = newList.Last();
            }

        }

        private void readyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear Fields
            ClearFields2();

            int listindex = readyListBox.SelectedIndex;
            beitragIDtextBox.Text = beitragsModels[listindex].BeitragID.ToString();
            addRichTextBox.Text = beitragsModels[listindex].Text.ToString();
            commentTextBox.Text = beitragsModels[listindex].Type.ToString();
            comboBox1.Text = beitragsModels[listindex].Name.ToString();
            string y = beitragsModels[listindex].Hash.ToString();
            string[] x = y.Split(' ');
            foreach (var v in x)
            {
                hashListBox.Items.Add(v);
            }
        }

        public void WireUpCompanyList()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = Beitrag.companies;
            comboBox1.DisplayMember = "CompanyName";
        }
    }
}
