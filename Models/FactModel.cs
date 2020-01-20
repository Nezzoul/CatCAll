using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatApp.Models
{
    public class FactModel
    {
        public bool Used { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public bool deleted { get; set; }
        public string _id { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string User { get; set; }
        public string Text { get; set; }
        public int __v { get; set; }
        public Status status { get; set; }

    }
}
