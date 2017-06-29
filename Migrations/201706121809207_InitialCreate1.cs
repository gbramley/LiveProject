namespace KingslandRedux.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.IngredientSandwich", "Ingredient_IngredientID", "dbo.Ingredient");
            DropForeignKey("dbo.IngredientSandwich", "Sandwich_SandwichID", "dbo.Sandwich");
            DropForeignKey("dbo.Sandwich", "Sandwich_SandwichID", "dbo.Sandwich");
            DropIndex("dbo.Sandwich", new[] { "Sandwich_SandwichID" });
            DropIndex("dbo.IngredientSandwich", new[] { "Ingredient_IngredientID" });
            DropIndex("dbo.IngredientSandwich", new[] { "Sandwich_SandwichID" });
            AddColumn("dbo.Ingredient", "Sandwich_SandwichID", c => c.Int());
            CreateIndex("dbo.Ingredient", "Sandwich_SandwichID");
            AddForeignKey("dbo.Ingredient", "Sandwich_SandwichID", "dbo.Sandwich", "SandwichID");
            DropColumn("dbo.Sandwich", "Category");
            DropColumn("dbo.Sandwich", "UsedInSandwich");
            DropColumn("dbo.Sandwich", "IngredientString");
            DropColumn("dbo.Sandwich", "Sandwich_SandwichID");
            DropColumn("dbo.Ingredient", "MyProperty");
            DropColumn("dbo.Ingredient", "IngredientString");
            DropTable("dbo.IngredientSandwich");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.IngredientSandwich",
                c => new
                    {
                        Ingredient_IngredientID = c.Int(nullable: false),
                        Sandwich_SandwichID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ingredient_IngredientID, t.Sandwich_SandwichID });
            
            AddColumn("dbo.Ingredient", "IngredientString", c => c.String());
            AddColumn("dbo.Ingredient", "MyProperty", c => c.Int(nullable: false));
            AddColumn("dbo.Sandwich", "Sandwich_SandwichID", c => c.Int());
            AddColumn("dbo.Sandwich", "IngredientString", c => c.String());
            AddColumn("dbo.Sandwich", "UsedInSandwich", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sandwich", "Category", c => c.Int(nullable: false));
            DropForeignKey("dbo.Ingredient", "Sandwich_SandwichID", "dbo.Sandwich");
            DropIndex("dbo.Ingredient", new[] { "Sandwich_SandwichID" });
            DropColumn("dbo.Ingredient", "Sandwich_SandwichID");
            CreateIndex("dbo.IngredientSandwich", "Sandwich_SandwichID");
            CreateIndex("dbo.IngredientSandwich", "Ingredient_IngredientID");
            CreateIndex("dbo.Sandwich", "Sandwich_SandwichID");
            AddForeignKey("dbo.Sandwich", "Sandwich_SandwichID", "dbo.Sandwich", "SandwichID");
            AddForeignKey("dbo.IngredientSandwich", "Sandwich_SandwichID", "dbo.Sandwich", "SandwichID", cascadeDelete: true);
            AddForeignKey("dbo.IngredientSandwich", "Ingredient_IngredientID", "dbo.Ingredient", "IngredientID", cascadeDelete: true);
        }
    }
}
