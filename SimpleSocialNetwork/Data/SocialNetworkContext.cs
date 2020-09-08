using Microsoft.EntityFrameworkCore;
using SimpleSocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleSocialNetwork.Data
{
    public class SocialNetworkContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=tcp:simplesocialnetwork-db-server.database.windows.net,1433;Initial Catalog=SimpleSocialNetwork-Db;Persist Security Info=False;User ID=gustavo;Password=@dsInf123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
