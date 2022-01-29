using Challenge02_Alkemy.Data;
using Challenge02_Alkemy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge02_Alkemy.Repositories
{
    public class CommentRepository : EfCoreRepository<Comment, BlogContext>
    {
        public CommentRepository(BlogContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}

