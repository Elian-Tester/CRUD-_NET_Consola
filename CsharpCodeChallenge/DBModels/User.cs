using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CsharpCodeChallenge.DBModels
{
    public partial class User
    {
        public User()
        {
            Favorite_TVs = new HashSet<Favorite_TV>();
        }

        [Key]
        public int id { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string name { get; set; } = null!;

        [InverseProperty("idUserNavigation")]
        public virtual ICollection<Favorite_TV> Favorite_TVs { get; set; }
    }
}
