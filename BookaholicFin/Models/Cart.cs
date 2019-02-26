using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BookaholicFin.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int BookId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }

        public virtual Book Book { get; set; }
    }
}