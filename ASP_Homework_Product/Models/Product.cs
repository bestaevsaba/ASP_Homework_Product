namespace ASP_Homework_Product.Models
{
    public class Product
    {
        private  static int instanceCounter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public Product() 
        {
            Id = instanceCounter;
            instanceCounter++;
        }

        public Product(string name, decimal cost, string description, string imagePath)
        {
            Description = description;
            Name = name;
            Cost = cost;
            Id = instanceCounter++;
            ImagePath = imagePath;
        }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Cost}";
        }
    }
}
