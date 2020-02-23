using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Postinger.Models;
using System.Configuration;
using Postinger.DataAccess;

namespace Postinger.DataAccess
{
    public class PostContext : IdentityDbContext<ApplicationUser>
    {
        public PostContext(DbContextOptions<PostContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<PostViewModel> Post{ get; set; }
        public DbSet<CommentsViewModel> Comment{ get; set; }

    }
}