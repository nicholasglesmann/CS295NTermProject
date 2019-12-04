using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS295NTermProject.Models
{
    public class Message
    {
        public int MessageID { get; set; }

        // properties
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string MessageTitle { get; set; }

        public string MessageBody { get; set; }
    }
}
