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
        [StringLength(150)]
        public string State { get; set; }

        /// <summary>
        /// Sets where this action is in the delivery queue
        /// </summary>
        [Required]
        public int Sequence { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        [StringLength(10)]
        public string Short { get; set; }
    }
}
