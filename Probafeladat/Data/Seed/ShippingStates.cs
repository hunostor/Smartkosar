using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Probafeladat.Models;

namespace Probafeladat.Data.Seed
{
    public class ShippingStates: ISeed
    {
        public void Create(ModelBuilder builder)
        {
            builder.Entity<ShippingState>().HasData(
                new ShippingState()
                {
                    ID = 1,
                    State = "Waiting for Pick Up",
                    Sequence = 1,
                    Short = "WfpU",
                    Description = "Csomag a feladónál. Futárra vár."
                },
                new ShippingState()
                {
                    ID = 2,
                    State = "Picked Up",
                    Sequence = 2,
                    Short = "PU",
                    Description = "Csomag a futárnál. Depóba tart."
                },
                new ShippingState()
                {
                    ID = 3,
                    State = "In Depot",
                    Sequence = 3,
                    Short = "ID",
                    Description = "Depóban van. Kiszállításra vár"
                },
                new ShippingState()
                {
                    ID = 5,
                    State = "On Delivery",
                    Sequence = 4,
                    Short = "OD",
                    Description = "Kiszállítás alatt áll. Célba tart.",
                },
                new ShippingState()
                {
                    ID = 6,
                    State = "Delivered",
                    Sequence = 5,
                    Short = "DD",
                    Description = "Kiszállítva"
                });
        }
    }
}
