using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Owner
    {
        public int Id { get; set; }
        [Required, MaxLength(30)]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        [Required, MaxLength(50)]
        public string Adress { get; set; }
        [Required, MaxLength(20)]
        public string Area { get; set; }
    }
}
