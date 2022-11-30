using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PustokDb2022.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PustokDb2022.Models
{
    public class Slider : BaseEntity
    {
        [Required]
        [MaxLength(30)]
        public string Title1 { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title2 { get; set; }
        [Required]
        [MaxLength(250)]
        public string Desc { get; set; }
        [Required]
        [MaxLength(75)]
        public string Image { get; set; }
        [Required]
        [MaxLength(30)]
        public string BtnText { get; set; }
        [Required]
        [MaxLength(100)]
        public string RedirectUrl { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Order { get; set; }
    }

}
