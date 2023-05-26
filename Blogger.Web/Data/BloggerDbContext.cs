using Blogger.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blogger.Web.Data
{
    //db context is responsible for interacting with the database 
    //middle man between domain models and the database 
    //perofrming CRUD operations our database tables using Entity Frmaework Core 
    public class BloggerDbContext : DbContext
    {
        public BloggerDbContext(DbContextOptions options) : base(options)
        {
        }

        //we need two properties that correspond to our domain models for entity framework to create tables for
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; } 
    }
}
