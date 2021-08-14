using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitragReader.Search
{
    public class SearchListType : ISearchType
    {
        public string Name { get; set; }

        public string Type { get; set; }
        public string Text { get; set; }
        public string Hash { get; set; }
        public string ID { get; set; }
        public ISearchController SearchProcessor { get; set; } = new SearchController();
    }
}
