using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Probafeladat.Models
{
    public class Package
    {
        public int ID { get; set; }

        [Required]
        [StringLength(8)]
        public string Identifier { get; set; }

        public ShippingState ShippingState { get; set; }

        [Required]
        public int ShippingStateID { get; set; }

        public virtual IdentityUser User { get; set; }
    }
}
