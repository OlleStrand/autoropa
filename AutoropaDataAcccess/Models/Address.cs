using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoropaDataAccess.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string StreetAddress { get; set; }
        [Required]
        [MaxLength(100)]
        public string City { get; set; }
        [Required]
        [MaxLength(15)]
        [Column(TypeName = "varchar(15)")]
        public string ZipCode { get; set; }
    }
}
