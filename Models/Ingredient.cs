using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingslandRedux.Models
{
    public enum category
    {
        beverage, bread, condiment, dairy, produce, protein, togo
    }

    public class Ingredient
    {
        public int IngredientID { get; set; }
        public string IngredientName { get; set; }
        public decimal IngredientCost { get; set; }
        public category Category { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public bool UsedInSandwich { get; set; }

        public class Bread
        {
            public int BreadID { get; set; }
            public string BreadName { get; set; }
            public decimal BreadCost { get; set; }

            public virtual ICollection<Sandwich> Sandwiches { get; set; }
        }
        public class Condiment
        {
            public int CondimentID { get; set; }
            public string CondimentName { get; set; }
            public decimal CondimentCost { get; set; }

            public virtual ICollection<Sandwich> Sandwiches { get; set; }
        }
        public class Dairy
        {
            public int DairyID { get; set; }
            public string DairyName { get; set; }
            public decimal DairyCost { get; set; }

            public virtual ICollection<Sandwich> Sandwiches { get; set; }
        }
        public class Meat
        {
            public int MeatID { get; set; }
            public string MeatName { get; set; }
            public decimal MeatCost { get; set; }

            public virtual ICollection<Sandwich> Sandwiches { get; set; }
        }
        public class Produce
        {
            public int ProduceID { get; set; }
            public string ProduceName { get; set; }
            public decimal ProduceCost { get; set; }

            public virtual ICollection<Sandwich> Sandwiches { get; set; }
        }
        public class ToGo
        {
            public int ToGoID { get; set; }
            public string ToGoName { get; set; }
            public decimal ToGoCost { get; set; }

            public virtual ICollection<Sandwich> Sandwiches { get; set; }
        }

        public class MealCategory
        {
            public int MealCategoryID { get; set; }
            public virtual ICollection<Sandwich> Sandwiches { get; set; }
            public int BreadID { get; set; }
            public int CondimentID { get; set; }
            public int DairyID { get; set; }
            public int MeatID { get; set; }
            public int ProduceID { get; set; }
            public int ToGoID { get; set; }
        }

    }
}