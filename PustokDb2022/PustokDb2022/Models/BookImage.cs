﻿using PustokDb2022.Models;
using System.ComponentModel.DataAnnotations;

namespace PustokDb2022.Models
{
    public class BookImage : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Image { get; set; }
        public int BookId { get; set; }
        public bool PosterStatus { get; set; }
        public Book Books { get; set; }
    }
}
