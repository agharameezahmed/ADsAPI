using ADsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ADsAPI.Context
{
    public class AdContext : DbContext
    {
        public AdContext(DbContextOptions<AdContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Advertiser> Advertisers { get; set; }
    }
}
