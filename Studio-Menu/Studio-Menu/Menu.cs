using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Helpers
{
    
    public class Menu
    {
        //Fields
        private List<MenuItem> menuItems = [];  

        private DateTime lastUpdated  = DateTime.Now; //this creates current date time w/no access to change unless in the class
        public DateTime LastUpdated                 //this allows access but no change 
        {
            get{return lastUpdated;}
        }


        //Constructors



        //Override
        public override string ToString()
        {
            string nl = Environment.NewLine;
            StringBuilder menuItemsSB = new();
            foreach (MenuItem item in menuItems)
            {
                menuItemsSB.Append(item);

            }
            return nl + "Welcome to the Restaurant" + menuItemsSB;
        }


        //Methods
        public void AddMenuItem(MenuItem menuItem) {
            

            foreach(MenuItem mi in menuItems)
            {
                if(menuItem.Equals(mi))
                {
                    Console.WriteLine("Warning! Item already exists!");
                    return;
                }
            }
            menuItems.Add(menuItem);
            lastUpdated = DateTime.Now;
        }

        public void RemoveMenuItem(string description)
        {
            MenuItem? removeItem = null;
            foreach(MenuItem mi in menuItems)
            {
                if(description.Equals(mi.Description))
                {
                    removeItem = mi;
                    break;
                }
            }
            if(removeItem != null)
            {
                menuItems.Remove(removeItem);
            }
            lastUpdated = DateTime.Now;
        }
    }
} 


