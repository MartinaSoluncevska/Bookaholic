using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Collections.Generic;

namespace BookaholicFin.Models
{
    [Bind(Exclude = "BookId")]
    public class Book
    {
        [ScaffoldColumn(false)]
        public int BookId { get; set; }

        [DisplayName("Genre")]
        public int GenreId { get; set; }

        [DisplayName("Artist")]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "A Book Title is required")]
        [StringLength(160)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(1, 100,
            ErrorMessage = "Price must be between 1 and 100")]
        public decimal Price { get; set; }

        [DisplayName("Cover Art URL")]
        [StringLength(1024)]
        public string CoverArtUrl { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Author Author { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}