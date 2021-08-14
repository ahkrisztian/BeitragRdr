using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace BeitragReader.Form1Code
{
    public class Form1CodeFiles
    {
        public void OpenFileAddPath()
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "XML files (*.XML)|*.XML|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    Beitrag.Path = $"{openFileDialog.FileName}";                   
                }

            }
            
        }

        public DataSet LoadDataSet()
        {
            if(Beitrag.Path != "")
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(Beitrag.Path);
                return dataSet;
            }
            else
            {
                MessageBox.Show("Please choose XML file!");
                return null;
            }
            
        }
    }
}
