using Challenge02_Alkemy.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge02_Alkemy.Entities
{
    public class User : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        //propiedad de navegación Collection 
        public ICollection<Post> Post { get; set; }
        public ICollection<Comment> Comment { get; set; }

    }
}
