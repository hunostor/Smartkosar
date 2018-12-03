using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Probafeladat.Models
{
    public class ShippingState
    {
        public int ID { get; set; }

        [Required]
        [StringLength(120)]
        public string State { get; set; }
    }
}
