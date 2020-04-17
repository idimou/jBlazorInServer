using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jBlazorInServer.Data
{
    public class UserProfileService
    {

        public Task<UserProfile> GetUserProfileAsync(int ID)
        {

            //return Task.FromResult(Enumerable.Range(1, 5).Select(index => new ArtItem
            //{
            //    ID = index,
            //    ImageURL= "https://ae01.alicdn.com/kf/HTB154QnXVooBKNjSZFPq6xa2XXaH.jpg",
            //    Title = "Sample Title " + index.ToString(),
            //    ArtistID = 1                
            //}).ToArray()) ;

            UserProfile userProfile= new UserProfile
                {
                ID = ID, 
                FirstName="Pelatis", 
                LastName="Pelatopoulos", 
                email="p.pelatopoulos@gmail.com", 
                UserPReferedArtSchool= new List<ArtSchools> (){ArtSchools.ModernArt, ArtSchools.Sourrealism}, 
                UserPreferedTheme = new List<Theme>() { Theme.Abstract, Theme.Landscapes},
                UserPreferedWorkForms = new List<WorkForm>() {WorkForm.painting, WorkForm.statue, WorkForm.functionalObject }
                };

            return Task.FromResult(userProfile);
        }
    }
}
