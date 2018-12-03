using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Probafeladat.Models;

namespace Probafeladat.Data.Seed
{
    public class AddPackages : ISeed
    {

        public AddPackages(ApplicationDbContext context)
        {
            _context = context;
        }

        private int IdentifierPieceLength = 4;
        private Random _rand = new Random();
        private ApplicationDbContext _context;

        public void Create(ModelBuilder builder)
        {
            //var user = _context.Users.Single(u => u.Id == "28085c1c-5fd6-4022-ac3e-7e8915657e43");
            for (int i = 1; i < 50; i++)
            {
                builder.Entity<Package>().HasData(
                new Package
                {
                    ID = i,
                    Identifier = GeneratePackageIdentifier(IdentifierPieceLength),
                    ShippingStateID = _rand.Next(1, 6),
                });
            }
        }

        private string GetCharacterRandom(int length)
        {
            const string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] buffer = new char[length];

            for (int i = 0; i < length; i++)
            {
                buffer[i] = _chars[_rand.Next(_chars.Length)];
            }

            return new string(buffer);
        }

        private int GetForIntRandom(int length)
        {
            return _rand.Next(1000, 9999);
        }

        private string GeneratePackageIdentifier(int length)
        {
            return GetCharacterRandom(length) + GetForIntRandom(length);
        }
    }
}
