using Challenge02_Alkemy.Entities;
using Microsoft.EntityFrameworkCore;


namespace Challenge02_Alkemy.Data
{
    public class BlogContext : DbContext
    { //Cadena de conección
        public BlogContext (DbContextOptions<BlogContext> options) : base(options)
        { }

        // Debo agregar las entidades que tiene mi proyecto public DbSet<Entidad> Entidad {get;set;}
        public DbSet<User> User { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Comment> Comment { get; set; }

    }
}
