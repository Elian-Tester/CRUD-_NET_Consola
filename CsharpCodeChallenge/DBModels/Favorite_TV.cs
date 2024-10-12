using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CsharpCodeChallenge.DBModels
{
    [Table("Favorite_TV")]
    public partial class Favorite_TV
    {
        [Key]
        public int id { get; set; }
        public int idUser { get; set; }
        public int idProgram_TV { get; set; }
        public int? isFavorite { get; set; }

        [ForeignKey("idProgram_TV")]
        [InverseProperty("Favorite_TVs")]
        public virtual Programs_TV idProgram_TVNavigation { get; set; } = null!;
        [ForeignKey("idUser")]
        [InverseProperty("Favorite_TVs")]
        public virtual User idUserNavigation { get; set; } = null!;
    }
}
