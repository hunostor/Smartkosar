using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Probafeladat.Data.Seed.SQL
{
    public static class JoinIdentityUserToPackages
    {
        public static void Join(MigrationBuilder migrationBuilder)
        {
            string[] userIDs = new string[] { "4933201c-5883-43f3-a5ee-35c4cc0bb048", "6e220958-34bf-458d-a3ba-f81e101e8323" };
            Random rand = new Random();
            for (int id = 1; id < 50; id++)
            {
                string sql;
                sql = $"UPDATE Packages SET UserId = '{userIDs[rand.Next(0, 2)]}' WHERE ID = {id}";            
                migrationBuilder.Sql(sql);
            }
        }
    }
}
