using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrsSolution.Models
{
    public class Test

    {
        [Key]
        public int Testid { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }
        
    }
}