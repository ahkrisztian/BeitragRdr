using System;
using System.Windows.Forms;
using System.IO;

namespace BeitragReader
{
    public partial class CreateXMLFile : UserControl
    {
        public static string TextBox { get; set; }
        public CreateXMLFile()
        {
            InitializeComponent();
        }

        private void createXMLButton_Click(object sender, EventArgs e)
        {
            Add.AddtoXML mc = new Add.AddtoXML();
            TextBox = pathTextBox.Text;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = string.IsNullOrWhiteSpace(TextBox) ? null : $"{desktopPath}\\{TextBox}.XML";

            if(filePath != null)
            {
                var xmlData = new CreateXML.XmlData
                {
                    Path = filePath,
                    BeitragID = IDtextBox.Text,
                    Name = companytextBox.Text,
                    Type = commenttextBox.Text,
                    Text = textrichTextBox.Text,
                    Hash = hashtagstextBox.Text,
                };

                bool isDataValid = CreateXML.CreateXMLValidate.Validate(xmlData);

                if (isDataValid == true)
                {
                    if (!File.Exists(filePath))
                    {                        
                        mc.CreateXmlFile(xmlData);
                        ErrorMessage("File Created!");
                        Beitrag.Path = filePath;
                    }
                    else
                    {
                        ErrorMessage("File already Exists!");
                    }
                }           
            }
            else
            {
                string x = string.IsNullOrWhiteSpace(pathTextBox.Text) ? "File Name not valid!" : "File already Exists!";
                ErrorMessage(x);
            }
        }
        public void ErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
