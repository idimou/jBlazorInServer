using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jBlazorInServer.Data
{
    public class ArtItem
    {
        public int ID { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public int ArtistID { get; set; }
    }
}
