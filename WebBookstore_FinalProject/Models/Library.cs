using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBookstore_FinalProject.Models
{
    public class Library
    {
        [Key]
        public int LibraryID { get; set; }
        public int UserID { get; set; }
        public LinkedList<Book> MyLibrary { get; set; }
    }
}
