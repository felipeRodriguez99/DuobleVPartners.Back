using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Input
{
    public class UseLoginReq
    {
        [FromQuery, Required]
        public string UserName { get; set;}
        [FromQuery, Required]
        public string Password { get; set;}
    }
}
