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
            migrationBuilder.Sql("INSERT INTO AspNetUsers " +
                "(Id, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount) VALUES" +
                "('28085c1c-5fd6-4022-ac3e-7e8915657e43', 'poroszkai.attila@gmail.com', 'POROSZKAI.ATTILA@GMAIL.COM', 'poroszkai.attila@gmail.com', 'POROSZKAI.ATTILA@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAELcx4fukG67I+iLLp/qxP4eX07X7boJBLjfTEgjXB1/eea56S9R5Su8YDSiqC/ZHmQ==', 'ACUB2VRTFTLCMENDG2GEYJSQXZLK3LY7', '7bc0cf85-a4bf-4ced-a7ad-bf696b1ba4a5',NULL,0,0,NULL,1,0)," +
                "('4933201c-5883-43f3-a5ee-35c4cc0bb048', 'felhasznalo2@gmail.com', 'FELHASZNALO2@GMAIL.COM', 'felhasznalo2@gmail.com', 'FELHASZNALO2@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEDIhIKFkT4dAfHkjRBjn7jCzsEymvUuTqaTrigBM3oNYNAkqx4PJ3WV4mFI9Qgk+2w==', 'SL6A67M7AWZH7YITDAX3CX4UZDHOKGXD', '56d4b392-1b94-4054-bcc8-4829697f14cb',NULL,0,0,NULL,1,0)," +
                "('6e220958-34bf-458d-a3ba-f81e101e8323', 'felhasznalo1@gmail.com', 'FELHASZNALO1@GMAIL.COM', 'felhasznalo1@gmail.com', 'FELHASZNALO1@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEOh1f7mNjy49Z/0b8FOLh46jhxer+OVoSQMdBJBz++H4+I6UExQTbTomLs/0vqIjcQ==', 'LM2SP7EFM3YPGCBNFZVRUIZ7TTUN2ACD', 'd8b33342-9012-4f3a-92d3-033c01306309',NULL,0,0,NULL,1,0)"
                );
        }
    }
}
