namespace KingslandRedux.Migrations
{
    using KingslandRedux.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KingslandRedux.Data.KingslandContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(KingslandRedux.Data.KingslandContext context)
        {
            // BEVERAGES
            var beverages = new List<Beverage>
            {
                new Beverage { BeverageID = 1, BeverageName = "Guinness", BeverageCost = 12.99m },
                new Beverage { BeverageID = 2, BeverageName = "Cider", BeverageCost = 14.99m }
            };
            beverages.ForEach(b => context.Beverages.AddOrUpdate(b));
            context.SaveChanges();


            // BREADS
            var breads = new List<Bread>
            {
                new Bread { BreadID = 1, BreadName = "White Bread", BreadCost = 11.95m },
                new Bread { BreadID = 2, BreadName = "Muffin", BreadCost = 21.50m },
                new Bread { BreadID = 3, BreadName = "French Roll", BreadCost = 15.50m },
                new Bread { BreadID = 4, BreadName = "Papadum", BreadCost = 10.40m }
            };
            breads.ForEach(b => context.Breads.AddOrUpdate(b));
            context.SaveChanges();


            // CONDIMENTS
            var condiments = new List<Condiment>
            {
                new Condiment { CondimentID = 1, CondimentName = "Jam", CondimentCost = 3.99m },
                new Condiment { CondimentID = 2, CondimentName = "Tomato Jam", CondimentCost = 4.99m },
                new Condiment { CondimentID = 3, CondimentName = "Mayonnaise", CondimentCost = 2.40m },
                new Condiment { CondimentID = 4, CondimentName = "Raita", CondimentCost = 3.20m },
                new Condiment { CondimentID = 5, CondimentName = "Chutney - Apple Chili", CondimentCost = 8.50m },

                new Condiment { CondimentID = 6, CondimentName = "Salsa - Roja", CondimentCost = 9.99m },
                new Condiment { CondimentID = 7, CondimentName = "Salsa - Cucumber Tomato", CondimentCost = 5.99m },
                new Condiment { CondimentID = 8, CondimentName = "Salsa - Pineapple", CondimentCost = 7.70m },

                new Condiment { CondimentID = 9, CondimentName = "Sauce - Dijon", CondimentCost = 4.50m },
                new Condiment { CondimentID = 10, CondimentName = "Sauce - HP Brown", CondimentCost = 5.99m },
                new Condiment { CondimentID = 11, CondimentName = "Sauce - Marinara", CondimentCost = 4.49m },

                new Condiment { CondimentID = 12, CondimentName = "Mumbai Spice", CondimentCost = 11.99m },
                new Condiment { CondimentID = 13, CondimentName = "Jerk Chicken Spice", CondimentCost = 14.00m },
                new Condiment { CondimentID = 14, CondimentName = "Chili Spice", CondimentCost = 10.70m }
            };
            condiments.ForEach(c => context.Condiments.AddOrUpdate(c));
            context.SaveChanges();


            // DAIRY
            var dairy = new List<Dairy>
            {
                new Dairy { DairyID = 1, DairyName = "Cheddar Cheese", DairyCost = 25.99m },
                new Dairy { DairyID = 2, DairyName = "Pepper Jack Cheese", DairyCost = 28.99m },
                new Dairy { DairyID = 3, DairyName = "Mozzarella Cheese", DairyCost = 22.99m },
                new Dairy { DairyID = 4, DairyName = "Butter", DairyCost = 14.44m }
            };
            dairy.ForEach(d => context.Dairys.AddOrUpdate(d));
            context.SaveChanges();


            // MEATS/PROTEIN
            var meats = new List<Meat>
            {
                new Meat { MeatID = 1, MeatName = "Eggs", MeatCost = 17.00m },
                new Meat { MeatID = 2, MeatName = "Pork Sausage", MeatCost = 32.95m },
                new Meat { MeatID = 3, MeatName = "Turkey Sausage", MeatCost = 28.00m },
                new Meat { MeatID = 4, MeatName = "Ham", MeatCost = 44.60m },
                new Meat { MeatID = 5, MeatName = "Bacon - Applewood", MeatCost = 54.00m },
                new Meat { MeatID = 6, MeatName = "Bacon - Other", MeatCost = 52.00m },
                new Meat { MeatID = 7, MeatName = "Black Pudding", MeatCost = 22.70m },
                new Meat { MeatID = 8, MeatName = "Chicken Breast", MeatCost = 72.00m },
                new Meat { MeatID = 9, MeatName = "Meatballs", MeatCost = 33.00m },
                new Meat { MeatID = 10, MeatName = "Pork", MeatCost = 68.40m },
                new Meat { MeatID = 11, MeatName = "Pork Crackling", MeatCost = 7.70m },
                new Meat { MeatID = 12, MeatName = "Beef", MeatCost = 82.60m }
            };
            meats.ForEach(m => context.Meats.AddOrUpdate(m));
            context.SaveChanges();


            // PRODUCE
            var produce = new List<Produce>
            {
                new Produce { ProduceID = 1, ProduceName = "Arugula", ProduceCost = 16.50m },
                new Produce { ProduceID = 2, ProduceName = "Mushrooms", ProduceCost = 14.99m },
                new Produce { ProduceID = 3, ProduceName = "Tomatoes", ProduceCost = 11.90m },
                new Produce { ProduceID = 4, ProduceName = "Cabbage", ProduceCost = 8.20m },
                new Produce { ProduceID = 5, ProduceName = "Cucumbers", ProduceCost = 10.70m },
                new Produce { ProduceID = 6, ProduceName = "Onions", ProduceCost = 8.00m },
                new Produce { ProduceID = 7, ProduceName = "Spring Onions", ProduceCost = 1.99m },
                new Produce { ProduceID = 8, ProduceName = "Garlic", ProduceCost = 14.00m },
                new Produce { ProduceID = 9, ProduceName = "Cilantro", ProduceCost = 0.99m },
                new Produce { ProduceID = 10, ProduceName = "Limes", ProduceCost = 9.00m },
                new Produce { ProduceID = 11, ProduceName = "Apples", ProduceCost = 7.00m }
            };
            produce.ForEach(p => context.Produces.AddOrUpdate(p));
            context.SaveChanges();


            // TO GO PACKAGING/UTENSILS
            var togos = new List<ToGo>
            {
                new ToGo { ToGoID = 1, ToGoName = "Forks", ToGoCost = 15.99m },
                new ToGo { ToGoID = 2, ToGoName = "Box - Small", ToGoCost = 11.99m },
                new ToGo { ToGoID = 3, ToGoName = "Box - Large", ToGoCost = 14.99m }
            };
            togos.ForEach(t => context.ToGos.AddOrUpdate(t));
            context.SaveChanges();
        }
    }
}
