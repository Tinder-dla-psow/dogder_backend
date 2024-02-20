using Adoptooj_backend.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions;
using Npgsql;
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

        public DbSet<refresh_token> Refresh_Token { get; set; }
        public DbSet<user> User { get; set; }
        public DbSet<user_dog_shelter> User_Dog_Shelter { get; set; }
        public DbSet<role> Role { get; set; }
        public DbSet<dog_shelter> Dog_Shelter { get; set; }
        public DbSet<dog> Dog { get; set; }
        public DbSet<pair> Pair { get; set; }
        public DbSet<disease> Disease { get; set; }
    }
}
