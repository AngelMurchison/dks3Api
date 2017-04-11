namespace dks3Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedseeddata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Weapons", "DamageAbsorption_Physical", c => c.Double(nullable: false));
            AddColumn("dbo.Weapons", "DamageAbsorption_Magic", c => c.Double(nullable: false));
            AddColumn("dbo.Weapons", "DamageAbsorption_Fire", c => c.Double(nullable: false));
            AddColumn("dbo.Weapons", "DamageAbsorption_Lightning", c => c.Double(nullable: false));
            AddColumn("dbo.Weapons", "DamageAbsorption_Dark", c => c.Double(nullable: false));
            AddColumn("dbo.Weapons", "DamageAbsorption_Stability", c => c.Int(nullable: false));
            DropColumn("dbo.Weapons", "GuardAbsorption_Physical");
            DropColumn("dbo.Weapons", "GuardAbsorption_Magic");
            DropColumn("dbo.Weapons", "GuardAbsorption_Fire");
            DropColumn("dbo.Weapons", "GuardAbsorption_Lightning");
            DropColumn("dbo.Weapons", "GuardAbsorption_Dark");
            DropColumn("dbo.Weapons", "GuardAbsorption_Stability");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Weapons", "GuardAbsorption_Stability", c => c.Int(nullable: false));
            AddColumn("dbo.Weapons", "GuardAbsorption_Dark", c => c.Double(nullable: false));
            AddColumn("dbo.Weapons", "GuardAbsorption_Lightning", c => c.Double(nullable: false));
            AddColumn("dbo.Weapons", "GuardAbsorption_Fire", c => c.Double(nullable: false));
            AddColumn("dbo.Weapons", "GuardAbsorption_Magic", c => c.Double(nullable: false));
            AddColumn("dbo.Weapons", "GuardAbsorption_Physical", c => c.Double(nullable: false));
            DropColumn("dbo.Weapons", "DamageAbsorption_Stability");
            DropColumn("dbo.Weapons", "DamageAbsorption_Dark");
            DropColumn("dbo.Weapons", "DamageAbsorption_Lightning");
            DropColumn("dbo.Weapons", "DamageAbsorption_Fire");
            DropColumn("dbo.Weapons", "DamageAbsorption_Magic");
            DropColumn("dbo.Weapons", "DamageAbsorption_Physical");
        }
    }
}
