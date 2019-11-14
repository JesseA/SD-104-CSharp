﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBookstore_FinalProject.Models
{
    public class Recommendations
    {
        [Key]
        public int RecID { get; set; }
        public int UserID { get; set; }
        public LinkedList<Book> MyRecs { get; set; }
    }
}
