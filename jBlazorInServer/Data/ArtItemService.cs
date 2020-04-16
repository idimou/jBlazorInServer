using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jBlazorInServer.Data
{
    public class ArtItemService
    {
        public Task<ArtItem[]> GetForecastAsync()
        {

            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new ArtItem
            {
                ID = index,
                ImageURL= "https://ae01.alicdn.com/kf/HTB154QnXVooBKNjSZFPq6xa2XXaH.jpg",
                Title = "Sample Title " + index.ToString(),
                ArtistID = 1                
            }).ToArray()) ;
        }
    }


}
