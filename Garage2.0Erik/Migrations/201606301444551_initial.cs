namespace Garage2._0Erik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GarageSlots",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PTime = c.DateTime(nullable: false),
                        PVehicle_RegNr = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Vehicles", t => t.PVehicle_RegNr)
                .Index(t => t.PVehicle_RegNr);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        RegNr = c.String(nullable: false, maxLength: 128),
                        Owner = c.String(),
                        Color = c.Int(nullable: false),
                        NumberOfWheels = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RegNr);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GarageSlots", "PVehicle_RegNr", "dbo.Vehicles");
            DropIndex("dbo.GarageSlots", new[] { "PVehicle_RegNr" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.GarageSlots");
        }
    }
}
