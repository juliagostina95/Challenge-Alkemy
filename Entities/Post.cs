using Challenge02_Alkemy.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge02_Alkemy.Entities
{
    public class Post : IEntity
    {

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        //propiedad de navegacion Referencial | uno a uno
        public User User { get; set; }
    }
}
