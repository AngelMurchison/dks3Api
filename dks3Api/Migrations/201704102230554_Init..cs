namespace dks3Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Weapons", "WeaponArts_WeaponArtsDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Weapons", "WeaponArts_WeaponArtsDescription");
        }
    }
}
