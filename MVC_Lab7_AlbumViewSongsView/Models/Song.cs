using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;

namespace MusicStore.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Release Date")]
        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0:MM/dd/yyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Album Cover")]
        public string ImagePath {  get; set; }
        public decimal Price { get; set; }

        public bool IsActive { get; set; }
        public bool IsFeatured { get; set; }


    }
}
