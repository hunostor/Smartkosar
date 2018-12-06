using Probafeladat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Probafeladat.ViewDTO
{
    public class MyPackages
    {
        public List<Package> Packages { get; set; }
        public List<ShippingState> ShippingStates { get; set; }
    }
}
