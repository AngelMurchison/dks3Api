namespace dks3Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Numericalpropertiesarenullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Weapons", "Durability", c => c.Int());
            AlterColumn("dbo.Weapons", "AttackPower_Physical", c => c.Int());
            AlterColumn("dbo.Weapons", "AttackPower_Magic", c => c.Int());
            AlterColumn("dbo.Weapons", "AttackPower_Fire", c => c.Int());
            AlterColumn("dbo.Weapons", "AttackPower_Lightning", c => c.Int());
            AlterColumn("dbo.Weapons", "AttackPower_Dark", c => c.Int());
            AlterColumn("dbo.Weapons", "AttackPower_Critical", c => c.Int());
            AlterColumn("dbo.Weapons", "DamageAbsorption_Physical", c => c.Double());
            AlterColumn("dbo.Weapons", "DamageAbsorption_Magic", c => c.Double());
            AlterColumn("dbo.Weapons", "DamageAbsorption_Fire", c => c.Double());
            AlterColumn("dbo.Weapons", "DamageAbsorption_Lightning", c => c.Double());
            AlterColumn("dbo.Weapons", "DamageAbsorption_Dark", c => c.Double());
            AlterColumn("dbo.Weapons", "DamageAbsorption_Stability", c => c.Int());
            AlterColumn("dbo.Weapons", "DamageScaling_Strength", c => c.Double());
            AlterColumn("dbo.Weapons", "DamageScaling_Dexterity", c => c.Double());
            AlterColumn("dbo.Weapons", "DamageScaling_Intelligence", c => c.Double());
            AlterColumn("dbo.Weapons", "DamageScaling_Faith", c => c.Double());
            AlterColumn("dbo.Weapons", "AdditionalEffects_Bleed", c => c.Int());
            AlterColumn("dbo.Weapons", "AdditionalEffects_Poison", c => c.Int());
            AlterColumn("dbo.Weapons", "AdditionalEffects_Frost", c => c.Int());
            AlterColumn("dbo.Weapons", "StatRequirement_Strength", c => c.Int());
            AlterColumn("dbo.Weapons", "StatRequirement_Dexterity", c => c.Int());
            AlterColumn("dbo.Weapons", "StatRequirement_Intelligence", c => c.Int());
            AlterColumn("dbo.Weapons", "StatRequirement_Faith", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Weapons", "StatRequirement_Faith", c => c.Int(nullable: false));
            AlterColumn("dbo.Weapons", "StatRequirement_Intelligence", c => c.Int(nullable: false));
            AlterColumn("dbo.Weapons", "StatRequirement_Dexterity", c => c.Int(nullable: false));
            AlterColumn("dbo.Weapons", "StatRequirement_Strength", c => c.Int(nullable: false));
            AlterColumn("dbo.Weapons", "AdditionalEffects_Frost", c => c.Int(nullable: false));
            AlterColumn("dbo.Weapons", "AdditionalEffects_Poison", c => c.Int(nullable: false));
            AlterColumn("dbo.Weapons", "AdditionalEffects_Bleed", c => c.Int(nullable: false));
            AlterColumn("dbo.Weapons", "DamageScaling_Faith", c => c.Double(nullable: false));
            AlterColumn("dbo.Weapons", "DamageScaling_Intelligence", c => c.Double(nullable: false));
            AlterColumn("dbo.Weapons", "DamageScaling_Dexterity", c => c.Double(nullable: false));
            AlterColumn("dbo.Weapons", "DamageScaling_Strength", c => c.Double(nullable: false));
            AlterColumn("dbo.Weapons", "DamageAbsorption_Stability", c => c.Int(nullable: false));
            AlterColumn("dbo.Weapons", "DamageAbsorption_Dark", c => c.Double(nullable: false));
            AlterColumn("dbo.Weapons", "DamageAbsorption_Lightning", c => c.Double(nullable: false));
            AlterColumn("dbo.Weapons", "DamageAbsorption_Fire", c => c.Double(nullable: false));
            AlterColumn("dbo.Weapons", "DamageAbsorption_Magic", c => c.Double(nullable: false));
            AlterColumn("dbo.Weapons", "DamageAbsorption_Physical", c => c.Double(nullable: false));
            AlterColumn("dbo.Weapons", "AttackPower_Critical", c => c.Int(nullable: false));
            AlterColumn("dbo.Weapons", "AttackPower_Dark", c => c.Int(nullable: false));
            AlterColumn("dbo.Weapons", "AttackPower_Lightning", c => c.Int(nullable: false));
            AlterColumn("dbo.Weapons", "AttackPower_Fire", c => c.Int(nullable: false));
            AlterColumn("dbo.Weapons", "AttackPower_Magic", c => c.Int(nullable: false));
            AlterColumn("dbo.Weapons", "AttackPower_Physical", c => c.Int(nullable: false));
            AlterColumn("dbo.Weapons", "Durability", c => c.Int(nullable: false));
        }
    }
}
