
using Crm2;

public class WeddingDress : Yad2Item
    {
        public WeddingDress(double price)
        {
                this.Price = CheckPriceValidation(price);
        }
        public int Size { get; set; }
        public int Length { get; set; }
        public string FabricType { get; set; }

        public DateTime PublishDate { get; set; }
        public double Price { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string OwnerId { get; set; }
        public string Description { get; set; }

        public double CheckPriceValidation(double price)
        {
            try
            {
                if (price < 0)
                {
                    throw new ArgumentOutOfRangeException("Price", "Price must be greater than or equal to zero.");
                }
                
                Console.WriteLine("Price is valid.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return price;
        }
    }



