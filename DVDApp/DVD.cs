using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDApp
{
   public class DVD
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        public string MaturityLevel { get; set; }


        public DVD(int id, string name, string genre, int rating, string maturity)
        {
            this.ID = id;
            this.Name = name;
            this.Genre = genre;
            this.Rating = rating;
            this.MaturityLevel = maturity;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}