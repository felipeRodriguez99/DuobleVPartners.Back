using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Output
{
    public class GetPersonsDtoRes
    {
        public string Names { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; }
        public string Email { get; set; }       
        public string TypeIdentification { get; set; }
        public DateTime DateCreated { get; set; }
        public string FullName { get; set; }
        public string FullIdentification { get; set; }
    }
}
