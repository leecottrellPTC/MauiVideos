using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BindingVideos.Models;
namespace BindingVideos.Data
{
    public class DataClass
    {
        public Conversions[] DataRay = new Conversions[4];

        public DataClass()
        {
            DataRay[0] = new Conversions("Kg to Lb", 2.205);
            DataRay[1] = new Conversions("G to Oz", .0353);
            DataRay[2] = new Conversions("Oz to G", 26.349);
            DataRay[3] = new Conversions("Lb to Kg", .4536);
        }

    }
}
