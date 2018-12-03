using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Data.Seed.SQL
{
    public static class IdentityUsersGoingToAdmin
    {
        public static void RunSQLScript(MigrationBuilder migrationBuilder)
        {
            // user set to masteradmin
            migrationBuilder.Sql($"INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES" +
                $"('28085c1c-5fd6-4022-ac3e-7e8915657e43', '28085aaa-5fd6-4022-ac3e-7e8915657e43')");
        }
    }
}
