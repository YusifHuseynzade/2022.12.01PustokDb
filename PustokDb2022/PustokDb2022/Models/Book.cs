using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PustokDb2022.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PustokDb2022.Models
{
    public class Book : BaseEntity
    {
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public bool StockStatus { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DisCountPercent { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CostPrice { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsSpecial { get; set; }
        public bool IsNew { get; set; }
        public Genre Genres { get; set; }
        public Author Authors { get; set; }
        public List<BookImage> BookImages { get; set; }

    }
}
