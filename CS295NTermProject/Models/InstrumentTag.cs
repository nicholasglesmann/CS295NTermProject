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
        public int InstrumentID { get; set; }

        public InstrumentTag(string instrument)
        {
            Tag = instrument;
        }

        public string Tag { get; set; }

    }
}
