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
        public int ID { get; set; }

        public string Tag { get; set; }

        public virtual ICollection<MusicTrackOtherTag> MusicTrackOtherTags { get; set; }
    }
}
