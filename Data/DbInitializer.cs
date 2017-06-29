using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using KingslandRedux.Models;

namespace KingslandRedux.Data
{
    public class DbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<KingslandContext>
    {
        protected override void Seed(KingslandContext context)
        {
            var beverages = new List<Beverage>
            {
                new Beverage{BeverageName="Guinness",BeverageCost=1000 }
            };
            beverages.ForEach(b => context.Beverages.Add(b));
            context.SaveChanges();

            var sandwiches = new List<Sandwich>
            {
                new Sandwich{SandwichName="White bread toast and butter $1 add jam", SandwichCost=1.5m }
            };
            sandwiches.ForEach(s => context.Sandwiches.Add(s));
            context.SaveChanges();

            var ingredients = new List<Ingredient>
            {
                new Ingredient{IngredientName="white bread", IngredientCost=0.0m }
            };
            ingredients.ForEach(i => context.Ingredients.Add(i));
            context.SaveChanges();
        }
    }
}