using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm2
{
    public class RealEstateProperty : Yad2Item
    {
        public string Address { get; set; }
        public int NumberOfRooms { get; set; }
        public double SqrMeter { get; set; }
        public int Floor { get; set; }

        public DateTime PublishDate { get; set; }
        public double Price { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string OwnerId { get; set; }
        public string Description { get; set; }
    }
}
