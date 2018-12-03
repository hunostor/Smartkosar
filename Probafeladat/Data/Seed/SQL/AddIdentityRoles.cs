using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Data.Seed.SQL
{
    public static class AddIdentityRoles
    {
        public static void RunSQLScript(MigrationBuilder migrationBuilder)
        {
            // add masteradmin roles
            migrationBuilder.Sql($"INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp) VALUES " +
                $"('28085aaa-5fd6-4022-ac3e-7e8915657e43', 'masteradmin', 'masteradmin', '{Guid.NewGuid().ToString()}')");
        }
    }
}
