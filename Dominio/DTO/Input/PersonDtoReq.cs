using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Input
{
    public class PersonDtoReq
    {

        [FromBody]
        public string Names { get; set; }
        [FromBody]
        public string LastName { get; set; }
        [FromBody]
        public string IdentificationNumber { get; set; }
        [FromBody]
        public string Email { get; set; }
        [FromBody]
        public string TypeIdentification { get; set; }
        [FromBody]

        public string UserName { get; set; }
        [FromBody]
        public string Password { get; set; }        
    }
}
