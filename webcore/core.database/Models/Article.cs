﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using core.database.Interfaces;

namespace core.database.Models
{
    [Table("Article")]

    public class Article : IAuditable, IMeta

    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string? Title { get; set; }
        [MaxLength(50)]
        public string? Picture { get; set; }
        [MaxLength(500)]
        public string? Intro { get; set; }
        public string? Content { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? KeyWord { get; set ; }
        public string? Description { get ; set; }
    }
}