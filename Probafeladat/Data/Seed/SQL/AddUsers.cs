using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Data.Seed.SQL
{
    public static class AddUsers
    {
        public static void RunSQLScript(MigrationBuilder migrationBuilder)
        {
            // custom Admin user
            migrationBuilder.Sql(@"INSERT INTO AspNetUsers " +
                "(Id, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount) VALUES" +
                "('28085c1c-5fd6-4022-ac3e-7e8915657e43', 'poroszkai.attila@gmail.com', 'POROSZKAI.ATTILA@GMAIL.COM', 'poroszkai.attila@gmail.com', 'POROSZKAI.ATTILA@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAELcx4fukG67I+iLLp/qxP4eX07X7boJBLjfTEgjXB1/eea56S9R5Su8YDSiqC/ZHmQ==', 'ACUB2VRTFTLCMENDG2GEYJSQXZLK3LY7', '7bc0cf85-a4bf-4ced-a7ad-bf696b1ba4a5',NULL,0,0,NULL,1,0)"
                );
        }
    }
}
