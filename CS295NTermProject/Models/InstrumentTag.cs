using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS295NTermProject.Models
{
    public class InstrumentTag : ITag
    {
        [Key]
        public int ID { get; set; }

        public string Tag { get; set; }

        public virtual ICollection<MusicTrackInstrumentTag> MusicTrackInstrumentTags { get; set; }
    }
}
