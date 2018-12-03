using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Probafeladat.Data.Seed
{
    interface ISeed
    {
        void Create(ModelBuilder builder);
    }
}
