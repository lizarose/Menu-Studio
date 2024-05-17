using System.ComponentModel.DataAnnotations;

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
        
        //Override
        public override bool Equals(object toBeCompared)
        {
            if(toBeCompared == this) { return true; }
            if(toBeCompared == null) { return false; }
            if(toBeCompared.GetType() != this.GetType()) { return false; }
            MenuItem mi = toBeCompared as MenuItem;
            return mi.Description == Description; 
        }

        public override string ToString()
        {
            string nl = Environment.NewLine;
            return nl + Category + ": " + Description + " ($" + Price + ")";
        }
        //Methods
    }
}