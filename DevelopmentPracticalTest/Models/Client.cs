using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopmentPracticalTest.Models
{
    public class Client
    {   [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
         public string ClientCode { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
