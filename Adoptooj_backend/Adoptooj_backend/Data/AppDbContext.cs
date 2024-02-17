﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions;
namespace Adoptooj_backend.Data
{
    public class AppDbContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<shelter> Shelter { get; set; }
    }
}
