using Microsoft.EntityFrameworkCore;
using Postinger.Models;
using System.Configuration;


namespace Postinger.DataAccess
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options)
    :       base(options)
            { }
 
        public DbSet<PostViewModel> Post{ get; set; }

    }
}
