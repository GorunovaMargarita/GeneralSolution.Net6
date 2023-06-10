namespace Home13.Pages
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }

        public Product(string name, string description, string price, string quantity)
        {
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }
    }
}