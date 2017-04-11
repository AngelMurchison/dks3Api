namespace dks3Api.Migrations
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using dks3Api.Models;
    using System.Linq;
    using System.Net;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }


        protected override void Seed(ApplicationDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            /* var weapons = new List<Weapon>()
            {
                 Refer to https://github.com/AngelMurchison/dks3Api/commit/24331f9feae2583f10cf35f45a41b2370c1283a6 for the seed generator.
            };
            weapons.ForEach(weapon => context.Weapons.AddOrUpdate(weapon));
            context.SaveChanges(); */
        }
    }
}
