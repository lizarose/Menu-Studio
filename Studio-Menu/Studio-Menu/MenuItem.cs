namespace Helpers
{
    public class MenuItem
    {
        //Fields
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; } = true;
        //Constructors
        public MenuItem(double price, string description, string category) 
        {
            Price = price;
            Description = description;
            Category = category;
        }
        //Methods
    }
}