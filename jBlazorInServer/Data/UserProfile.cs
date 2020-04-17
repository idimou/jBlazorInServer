using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jBlazorInServer.Data
{
    public class UserProfile
    {
        public int ID { get; set; }
        public string email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address UserAddress { get; set; }
        public IList<WorkForm> UserPreferedWorkForms { get; set; }
        public IList<ArtSchools> UserPReferedArtSchool { get; set; }
        public IList<Theme> UserPreferedTheme { get; set; }

    }
}
