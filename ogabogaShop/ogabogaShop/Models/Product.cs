namespace ogabogaShop.Models
{
     public class Product
    {
        private decimal _price;

        public int Id { get; set; }
        public required string Name { get; set; }


        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative.");
                }
                _price = value;
            }
        }
    }

}
