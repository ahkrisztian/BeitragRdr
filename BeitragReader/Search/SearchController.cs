using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitragReader.Search
{
    public class SearchController : ISearchController
    {
        public SearchType Create(ISearchType beitrag)
        {
            SearchType output = new SearchType();

            output.Name = beitrag.Name;
            output.Type = beitrag.Type;
            output.Text = beitrag.Text;
            output.Hash = beitrag.Hash;
            output.ID = beitrag.ID;

            return output;
        }
    }
}
