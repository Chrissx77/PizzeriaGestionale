namespace WebApplication1.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public decimal Price { get; set;}

        public Pizza(string Name, string Description, string PhotoUrl, decimal Price)
        {
            this.Name = Name;
            this.Description = Description;
            this.PhotoUrl = PhotoUrl;
            this.Price = Price;
        }
    }
}
