using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitragReader.BeitragModel
{
    public class BeitragController : IBeitragController
    {
        public BeitragModel Create(IBeitragModel beitrag)
        {
            BeitragModel output = new BeitragModel();

            output.BeitragID = beitrag.BeitragID;
            output.Name = beitrag.Name;
            output.Type = beitrag.Type;
            output.Text = beitrag.Text;
            output.Hash = beitrag.Hash;

            return output;
        }
    }
}
