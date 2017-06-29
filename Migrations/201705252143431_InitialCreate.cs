namespace KingslandRedux.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beverage",
                c => new
                    {
                        BeverageID = c.Int(nullable: false, identity: true),
                        BeverageName = c.String(),
                        BeverageCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BeverageID);
            
            CreateTable(
                "dbo.Bread",
                c => new
                    {
                        BreadID = c.Int(nullable: false, identity: true),
                        BreadName = c.String(),
                        BreadCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BreadID);
            
            CreateTable(
                "dbo.Condiment",
                c => new
                    {
                        CondimentID = c.Int(nullable: false, identity: true),
                        CondimentName = c.String(),
                        CondimentCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CondimentID);
            
            CreateTable(
                "dbo.Dairy",
                c => new
                    {
                        DairyID = c.Int(nullable: false, identity: true),
                        DairyName = c.String(),
                        DairyCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.DairyID);
            
            CreateTable(
                "dbo.Meat",
                c => new
                    {
                        MeatID = c.Int(nullable: false, identity: true),
                        MeatName = c.String(),
                        MeatCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MeatID);
            
            CreateTable(
                "dbo.Produce",
                c => new
                    {
                        ProduceID = c.Int(nullable: false, identity: true),
                        ProduceName = c.String(),
                        ProduceCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProduceID);
            
            CreateTable(
                "dbo.ToGo",
                c => new
                    {
                        ToGoID = c.Int(nullable: false, identity: true),
                        ToGoName = c.String(),
                        ToGoCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ToGoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ToGo");
            DropTable("dbo.Produce");
            DropTable("dbo.Meat");
            DropTable("dbo.Dairy");
            DropTable("dbo.Condiment");
            DropTable("dbo.Bread");
            DropTable("dbo.Beverage");
        }
    }
}
