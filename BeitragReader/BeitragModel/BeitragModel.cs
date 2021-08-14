using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitragReader.BeitragModel
{
    public class BeitragModel : IBeitragModel
    {
        public int BeitragID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }
        public string Hash { get; set; }
        public IBeitragController BeitragProcessor { get; set; } = new BeitragController();
    }
}
