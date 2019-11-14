using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBookstore_FinalProject.Models
{
    public class ShoppingCart
    {
        [Key]
        public int CartID { get; set; }
        public int UserId { get; set; }
        public LinkedList<Book> Cart { get; set; }

    }
}
