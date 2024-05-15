using System.Security.Cryptography.X509Certificates;

namespace Helpers
{
    
    public class Menu
    {
        //Fields

        //Accessors
        public List<MenuItem> MenuItems { get; set; } = [];  

        public DateTime LastUpdated { get; set; } = DateTime.Now;
      
       
        //Constructors

        //Methods
        public void AddMenuItem(MenuItem menuItem, DateTime lastUpdated) {
            MenuItems.Add(menuItem);
            LastUpdated = lastUpdated;

        }

        public Menu(List<MenuItem> menuItems, DateTime lastUpdated = default(DateTime))
        {
            MenuItems = menuItems;
            Console.WriteLine(lastUpdated);
        }
    }


}