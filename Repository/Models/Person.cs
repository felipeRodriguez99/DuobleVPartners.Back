using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Identifier { get; set; }
        [Required]
        [MaxLength(100)]
        public string Names { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        public string IdentificationNumber { get; set; }
        public string Email { get; set; }
        [Required]
        public string TypeIdentification { get; set; }
        public DateTime DateCreated { get; set; }
        public string FullName { get; set; }
        public string FullIdentification { get; set; }

    }
}
