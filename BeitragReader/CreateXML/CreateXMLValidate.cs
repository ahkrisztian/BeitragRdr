using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitragReader.CreateXML
{
    public class CreateXMLValidate
    {
       public static bool Validate(IXmlData data)
        {
            CreateXMLFile mc = new CreateXMLFile();

            if (string.IsNullOrWhiteSpace(data.BeitragID))
            {
                mc.ErrorMessage($"BeitragID not valid!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(data.Path) && CreateXMLFile.TextBox != "")
            {
                mc.ErrorMessage($"Path not valid!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(data.Name))
            {
                mc.ErrorMessage($"Name not valid!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(data.Type))
            {
                mc.ErrorMessage($"Comment not valid!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(data.Text))
            {
                mc.ErrorMessage($"Text not valid!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(data.Hash))
            {
                mc.ErrorMessage($"Hashtgas are not valid!");
                return false;
            }

            return true;
        }
    }
}
