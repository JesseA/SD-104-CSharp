using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;

namespace MusicStore.Models
{
    public class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Favorite Genre")]
        public string FavoriteGenre { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Favorite Song")]
        public string FavoriteSong { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Customer Image")]
        public string ImagePath { get; set; }
    }


}
