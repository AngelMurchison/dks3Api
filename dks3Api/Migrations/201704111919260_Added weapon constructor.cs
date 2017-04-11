namespace dks3Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedweaponconstructor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Weapons", "StatRequirements_Strength", c => c.Int());
            AddColumn("dbo.Weapons", "StatRequirements_Dexterity", c => c.Int());
            AddColumn("dbo.Weapons", "StatRequirements_Intelligence", c => c.Int());
            AddColumn("dbo.Weapons", "StatRequirements_Faith", c => c.Int());
            DropColumn("dbo.Weapons", "StatRequirement_Strength");
            DropColumn("dbo.Weapons", "StatRequirement_Dexterity");
            DropColumn("dbo.Weapons", "StatRequirement_Intelligence");
            DropColumn("dbo.Weapons", "StatRequirement_Faith");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Weapons", "StatRequirement_Faith", c => c.Int());
            AddColumn("dbo.Weapons", "StatRequirement_Intelligence", c => c.Int());
            AddColumn("dbo.Weapons", "StatRequirement_Dexterity", c => c.Int());
            AddColumn("dbo.Weapons", "StatRequirement_Strength", c => c.Int());
            DropColumn("dbo.Weapons", "StatRequirements_Faith");
            DropColumn("dbo.Weapons", "StatRequirements_Intelligence");
            DropColumn("dbo.Weapons", "StatRequirements_Dexterity");
            DropColumn("dbo.Weapons", "StatRequirements_Strength");
        }
    }
}
