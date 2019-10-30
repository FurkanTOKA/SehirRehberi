using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi2.API.Models
{
    public class City
    {

        public City()
        {
            Photos = new List<Photo>();
        }

        public int Id { get; set; }
        public int  UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Photo> Photos { get; set; }
        public virtual User User { get; set; }

    }
}
