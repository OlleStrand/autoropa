using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AutoropaDataAccess.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(60)]
        public string LastName { get; set; }

        public string Username { get; set; }
        [Required]
        [MaxLength(200)]
        public string Password { get; set; }

        public List<Address> Addresses { get; set; }
        public List<Email> EmailAddresses { get; set; }

        [Required]
        [MaxLength(40)]
        public string Role { get; set; }
        public string Token { get; set; }
    }
}
