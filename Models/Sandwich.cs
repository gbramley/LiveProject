using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingslandRedux.Models
{
    public enum meal
    {
        breakfast, lunch, both
    }

    public class Sandwich
    {
        public int SandwichID { get; set; }
        public string SandwichName { get; set; }
        public decimal SandwichCost { get; set; }
        public meal Meal { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public virtual ICollection<Beverage> Beverages { get; set; }
        public virtual ICollection<Bread> Breads { get; set; }
        public virtual ICollection<Condiment> Condiments { get; set; }
        public virtual ICollection<Dairy> Dairys { get; set; }
        public virtual ICollection<Meat> Meats { get; set; }
        public virtual ICollection<Produce> Produces { get; set; }
        public virtual ICollection<ToGo> ToGos { get; set; }
    }
}