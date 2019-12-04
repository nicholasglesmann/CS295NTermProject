using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS295NTermProject.Models
{
    public class GenreTag : ITag
    {
        [Key]
        public int GenreTagID { get; set; }

        public string Tag { get; set; }

    }
}
