namespace dks3Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Weapons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WeaponClass = c.Int(nullable: false),
                        Name = c.String(),
                        Class = c.String(),
                        DamageType = c.String(),
                        Weight = c.Double(nullable: false),
                        Durability = c.Int(nullable: false),
                        WeaponArts_WeaponArtsType = c.String(),
                        WeaponArts_FPcost = c.String(),
                        AttackPower_Physical = c.Int(nullable: false),
                        AttackPower_Magic = c.Int(nullable: false),
                        AttackPower_Fire = c.Int(nullable: false),
                        AttackPower_Lightning = c.Int(nullable: false),
                        AttackPower_Dark = c.Int(nullable: false),
                        AttackPower_Critical = c.Int(nullable: false),
                        GuardAbsorption_Physical = c.Double(nullable: false),
                        GuardAbsorption_Magic = c.Double(nullable: false),
                        GuardAbsorption_Fire = c.Double(nullable: false),
                        GuardAbsorption_Lightning = c.Double(nullable: false),
                        GuardAbsorption_Dark = c.Double(nullable: false),
                        GuardAbsorption_Stability = c.Int(nullable: false),
                        AttributeBonus_Strength = c.String(),
                        AttributeBonus_Dexterity = c.String(),
                        AttributeBonus_Intelligence = c.String(),
                        AttributeBonus_Faith = c.String(),
                        AdditionalEffects_Bleed = c.Int(nullable: false),
                        AdditionalEffects_Poison = c.Int(nullable: false),
                        AdditionalEffects_Frost = c.Int(nullable: false),
                        AttributeRequirement_Strength = c.Int(nullable: false),
                        AttributeRequirement_Dexterity = c.Int(nullable: false),
                        AttributeRequirement_Intelligence = c.Int(nullable: false),
                        AttributeRequirement_Faith = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Weapons");
        }
    }
}
