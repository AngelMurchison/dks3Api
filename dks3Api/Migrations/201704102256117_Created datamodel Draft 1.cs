namespace dks3Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateddatamodelDraft1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Weapons", "WeaponArt_WeaponArtsType", c => c.String());
            AddColumn("dbo.Weapons", "WeaponArt_WeaponArtsDescription", c => c.String());
            AddColumn("dbo.Weapons", "WeaponArt_FPcost", c => c.String());
            AddColumn("dbo.Weapons", "DamageScaling_Strength", c => c.Double(nullable: false));
            AddColumn("dbo.Weapons", "DamageScaling_Dexterity", c => c.Double(nullable: false));
            AddColumn("dbo.Weapons", "DamageScaling_Intelligence", c => c.Double(nullable: false));
            AddColumn("dbo.Weapons", "DamageScaling_Faith", c => c.Double(nullable: false));
            AddColumn("dbo.Weapons", "StatRequirement_Strength", c => c.Int(nullable: false));
            AddColumn("dbo.Weapons", "StatRequirement_Dexterity", c => c.Int(nullable: false));
            AddColumn("dbo.Weapons", "StatRequirement_Intelligence", c => c.Int(nullable: false));
            AddColumn("dbo.Weapons", "StatRequirement_Faith", c => c.Int(nullable: false));
            DropColumn("dbo.Weapons", "Class");
            DropColumn("dbo.Weapons", "WeaponArts_WeaponArtsType");
            DropColumn("dbo.Weapons", "WeaponArts_WeaponArtsDescription");
            DropColumn("dbo.Weapons", "WeaponArts_FPcost");
            DropColumn("dbo.Weapons", "AttributeBonus_Strength");
            DropColumn("dbo.Weapons", "AttributeBonus_Dexterity");
            DropColumn("dbo.Weapons", "AttributeBonus_Intelligence");
            DropColumn("dbo.Weapons", "AttributeBonus_Faith");
            DropColumn("dbo.Weapons", "AttributeRequirement_Strength");
            DropColumn("dbo.Weapons", "AttributeRequirement_Dexterity");
            DropColumn("dbo.Weapons", "AttributeRequirement_Intelligence");
            DropColumn("dbo.Weapons", "AttributeRequirement_Faith");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Weapons", "AttributeRequirement_Faith", c => c.Int(nullable: false));
            AddColumn("dbo.Weapons", "AttributeRequirement_Intelligence", c => c.Int(nullable: false));
            AddColumn("dbo.Weapons", "AttributeRequirement_Dexterity", c => c.Int(nullable: false));
            AddColumn("dbo.Weapons", "AttributeRequirement_Strength", c => c.Int(nullable: false));
            AddColumn("dbo.Weapons", "AttributeBonus_Faith", c => c.String());
            AddColumn("dbo.Weapons", "AttributeBonus_Intelligence", c => c.String());
            AddColumn("dbo.Weapons", "AttributeBonus_Dexterity", c => c.String());
            AddColumn("dbo.Weapons", "AttributeBonus_Strength", c => c.String());
            AddColumn("dbo.Weapons", "WeaponArts_FPcost", c => c.String());
            AddColumn("dbo.Weapons", "WeaponArts_WeaponArtsDescription", c => c.String());
            AddColumn("dbo.Weapons", "WeaponArts_WeaponArtsType", c => c.String());
            AddColumn("dbo.Weapons", "Class", c => c.String());
            DropColumn("dbo.Weapons", "StatRequirement_Faith");
            DropColumn("dbo.Weapons", "StatRequirement_Intelligence");
            DropColumn("dbo.Weapons", "StatRequirement_Dexterity");
            DropColumn("dbo.Weapons", "StatRequirement_Strength");
            DropColumn("dbo.Weapons", "DamageScaling_Faith");
            DropColumn("dbo.Weapons", "DamageScaling_Intelligence");
            DropColumn("dbo.Weapons", "DamageScaling_Dexterity");
            DropColumn("dbo.Weapons", "DamageScaling_Strength");
            DropColumn("dbo.Weapons", "WeaponArt_FPcost");
            DropColumn("dbo.Weapons", "WeaponArt_WeaponArtsDescription");
            DropColumn("dbo.Weapons", "WeaponArt_WeaponArtsType");
        }
    }
}
