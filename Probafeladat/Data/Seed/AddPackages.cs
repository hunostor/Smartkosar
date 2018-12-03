using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Probafeladat.Models;

namespace Probafeladat.Data.Seed
{
    public class AddPackages : ISeed
    {
        private int IdentifierPieceLength = 4;
        private Random _rand = new Random();

        public void Create(ModelBuilder builder)
        {
            for (int i = 1; i < 50; i++)
            {
                builder.Entity<Package>().HasData(
                new Package
                {
                    ID = i,
                    Identifier = GeneratePackageIdentifier(IdentifierPieceLength),
                    ShippingStateID = _rand.Next(1, 6)
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
