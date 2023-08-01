using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingVideos.Models
{
    public class Conversions
    {
        public string Name { get; set; }
        public double Multiplier { get; set; }

        public Conversions() { }

        public Conversions(string name, double multiplier)
        {
            Name = name;
            Multiplier = multiplier;
        }
    }
}
