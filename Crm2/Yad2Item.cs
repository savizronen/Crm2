using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm2
{
    public interface Yad2Item
    {
        DateTime PublishDate { get; set; }
        double Price { get; set; }
        string PhoneNumber { get; set; }
        string ContactName { get; set; }
        string City { get; set; }
        string OwnerId { get; set; }
        string Description { get; set; }
    }
}
