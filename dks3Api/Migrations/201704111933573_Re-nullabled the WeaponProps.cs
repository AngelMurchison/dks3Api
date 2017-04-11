namespace dks3Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenullabledtheWeaponProps : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Weapons", "WeaponArt_FPcost", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Weapons", "WeaponArt_FPcost", c => c.String());
        }
    }
}
