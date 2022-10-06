﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebAPI.Data
{
    [Table("Good")]
    public class Good
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0, double.MaxValue)]
        public double UnitPrice { get; set; }
        public byte SaleRate { get; set; } 
        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
