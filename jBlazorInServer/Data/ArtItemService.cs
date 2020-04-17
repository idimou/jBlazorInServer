using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jBlazorInServer.Data
{
    public class ArtItemService
    {
        public Task<ArtItem[]> GetArtitemsAsync()
        {

            //return Task.FromResult(Enumerable.Range(1, 5).Select(index => new ArtItem
            //{
            //    ID = index,
            //    ImageURL= "https://ae01.alicdn.com/kf/HTB154QnXVooBKNjSZFPq6xa2XXaH.jpg",
            //    Title = "Sample Title " + index.ToString(),
            //    ArtistID = 1                
            //}).ToArray()) ;

            ArtItem[] artItems = {
                new ArtItem{ID = 1, Title="Abstract colours", ArtistID=12, ImageURL="https://ae01.alicdn.com/kf/HTB154QnXVooBKNjSZFPq6xa2XXaH.jpg"},
                new ArtItem{ID = 2, Title="Fluffly ambience", ArtistID=12, ImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.ebayimg.com%2Fimages%2Fi%2F131368799488-0-1%2Fs-l1000.jpg&f=1&nofb=1"},
                new ArtItem{ID = 3, Title="Wallpaper thing", ArtistID=12, ImageURL="https://ae01.alicdn.com/kf/HTB18mMCHVXXXXXgXpXXq6xXFXXX3/100-hand-drawn-city-at-night-3-knife-painting-modern-living-room-wall-art-canvas-oil.jpg"},
                new ArtItem{ID = 4, Title="Self portrait", ArtistID=12, ImageURL="https://my-artwork.com/wp-content/uploads/2018/07/7031-epp1hq.jpg"},
                new ArtItem{ID = 5, Title="Accidental splash", ArtistID=12, ImageURL="https://ae01.alicdn.com/kf/HTB1pvccNXXXXXceXFXXq6xXFXXXm/Wall-Art-Abstract-Paintings-Modern-Oil-Painting-On-Canvas-Home-Decoration-Living-Room-Pictures-Handpainted-No.jpg"},
                new ArtItem{ID = 6, Title="My kid could have made this", ArtistID=12, ImageURL="https://ae01.alicdn.com/kf/HTB1LQPqaVGWBuNjy0Fbq6z4sXXaz/Large-Printing-Abstract-wonderful-two-horses-Wall-Art-Picture-Home-Decor-Living-Room-Modern-Canvas-Print.jpg"},
                new ArtItem{ID = 7, Title="Seriously?", ArtistID=12, ImageURL="https://i.pinimg.com/736x/c2/bf/80/c2bf8098586adc30e814759499684e48.jpg"},
                new ArtItem{ID = 8, Title="New meaning", ArtistID=12, ImageURL="https://cdn.wooshop.us/wp-content/uploads/2018/12/18130145/1386394826-1.jpg"},
                new ArtItem{ID = 9, Title="PASOK art", ArtistID=12, ImageURL="https://cdn.shopify.com/s/files/1/0460/8801/products/abstract-art-red-tree-painting-modern-textured-palette-knife-paintings-trees-horizon-christine-krainock-contemporary-trees-fall-holiday-vertical-coastal-artwork-home-decor-wall-art-1024pix-gif_1024x1024.gif?v=1464317691"},

            };

            return Task.FromResult(artItems);
        }
    }


}
