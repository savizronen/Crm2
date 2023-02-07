using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm2
{
    public class Car : Yad2Item
    {
        public int HowManyPreviousOwners { get; set; }
        public int BuiltYear { get; set; }
        public int HowManyKm { get; set; }

        public DateTime PublishDate { get; set; }
        public double Price { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string OwnerId { get; set; }
        public string Description { get; set; }
    }
}
