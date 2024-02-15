// DonationDbContextFactory.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ReactApp.Models
{
    public class DonationDbContextFactory : IDesignTimeDbContextFactory<DonationDBContext>
    {
        public DonationDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Could not find a valid connection string named 'DefaultConnection' in your appsettings.json file.");
            }

            var builder = new DbContextOptionsBuilder<DonationDBContext>();
            builder.UseSqlServer(connectionString);

            return new DonationDBContext(builder.Options);
        }
    }
}
