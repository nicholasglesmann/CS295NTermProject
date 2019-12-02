using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS295NTermProject.Models
{
    public class OtherTag : ITag
    {
        [Key]
        public int OtherTagID { get; set; }

        public OtherTag(string tag)
        {
            Tag = tag;
        }

        public string Tag { get; set; }
    }
}
