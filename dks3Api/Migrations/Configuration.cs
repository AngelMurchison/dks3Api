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

            //TODO: Why aren't these in the database?
            var weapons = new List<Weapon>();
            {
                var weapon0 = new Weapon()
                {
                    Name = "Battle Axe",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 250,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 8,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon1 = new Weapon()
                {
                    Name = "Man Serpent Hatchet",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 250,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 16,
                        Dexterity = 13,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon2 = new Weapon()
                {
                    Name = "Brigand Axe",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 248,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 14,
                        Dexterity = 8,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon3 = new Weapon()
                {
                    Name = "Winged Knight Twinaxes",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 244,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 20,
                        Dexterity = 12,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon4 = new Weapon()
                {
                    Name = "Eleonora",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 284,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 20,
                        Dexterity = 8,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon5 = new Weapon()
                {
                    Name = "Hand Axe",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 220,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 9,
                        Dexterity = 8,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon6 = new Weapon()
                {
                    Name = "Butcher Knife",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 190,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 24,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon7 = new Weapon()
                {
                    Name = "Thrall Axe",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 208,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 8,
                        Dexterity = 8,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon8 = new Weapon()
                {
                    Name = "Dragonslayer's Axe",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 180,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 180
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 18,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon9 = new Weapon()
                {
                    Name = "Dragonrider Bow",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 200,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 19,
                        Dexterity = 15,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon10 = new Weapon()
                {
                    Name = "Composite Bow",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 146,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 12,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon11 = new Weapon()
                {
                    Name = "Black Bow of Pharis",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 134,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 9,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon12 = new Weapon()
                {
                    Name = "Longbow",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 164,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 9,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon13 = new Weapon()
                {
                    Name = "Short Bow",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 154,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 7,
                        Dexterity = 12,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon14 = new Weapon()
                {
                    Name = "Darkmoon Longbow",
                    AttackPower = new AttackPower()
                    {
                        Magic = 80,
                        Physical = 66,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 7,
                        Dexterity = 16,
                        Faith = 0,
                        Intelligence = 10
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon15 = new Weapon()
                {
                    Name = "Manikin Claws",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 158,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 8,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 34,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon16 = new Weapon()
                {
                    Name = "Claw",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 150,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 6,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 33,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon17 = new Weapon()
                {
                    Name = "Arbalest",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 156,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 18,
                        Dexterity = 8,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon18 = new Weapon()
                {
                    Name = "Heavy Crossbow",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 144,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 14,
                        Dexterity = 8,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon19 = new Weapon()
                {
                    Name = "Sniper Crossbow",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 140,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 18,
                        Dexterity = 16,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon20 = new Weapon()
                {
                    Name = "Avelyn",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 128,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 16,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon21 = new Weapon()
                {
                    Name = "Light Crossbow",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 128,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 8,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon22 = new Weapon()
                {
                    Name = "Knight's Crossbow",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 80,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 80
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 8,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon23 = new Weapon()
                {
                    Name = "Old Wolf Curved Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 280,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 19,
                        Dexterity = 25,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon24 = new Weapon()
                {
                    Name = "Exile Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 292,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 24,
                        Dexterity = 16,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon25 = new Weapon()
                {
                    Name = "Murakumo",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 270,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 20,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon26 = new Weapon()
                {
                    Name = "Carthus Curved Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 244,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 18,
                        Dexterity = 22,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 38,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon27 = new Weapon()
                {
                    Name = "Carthus Curved Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 230,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 15,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 35,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon28 = new Weapon()
                {
                    Name = "Falchion",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 234,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 9,
                        Dexterity = 13,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon29 = new Weapon()
                {
                    Name = "Pontiff Knight Curved Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 214,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 10
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon30 = new Weapon()
                {
                    Name = "Carthus Shotel",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 212,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 19,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 34,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon31 = new Weapon()
                {
                    Name = "Storm Curved Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 200,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 14,
                        Dexterity = 20,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon32 = new Weapon()
                {
                    Name = "Shotel",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 208,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 9,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon33 = new Weapon()
                {
                    Name = "Rotten Ghru Curved Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 206,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 13,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 33,
                        Frost = 0
                    }
                };
                var weapon34 = new Weapon()
                {
                    Name = "Sellsword Twinblades",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 198,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 16,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon35 = new Weapon()
                {
                    Name = "Scimitar",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 180,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 7,
                        Dexterity = 13,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon36 = new Weapon()
                {
                    Name = "Warden Twinblades",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 186,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 33,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon37 = new Weapon()
                {
                    Name = "Painting Guardian's Curved Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 176,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 7,
                        Dexterity = 19,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 35,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon38 = new Weapon()
                {
                    Name = "Crescent Moon Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 142,
                        Physical = 142,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 16,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon39 = new Weapon()
                {
                    Name = "Dancer's Enchanted Swords",
                    AttackPower = new AttackPower()
                    {
                        Magic = 144,
                        Physical = 144,
                        Critical = 100,
                        Dark = 0,
                        Fire = 144,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 20,
                        Faith = 9,
                        Intelligence = 9
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon40 = new Weapon()
                {
                    Name = "Corvian Greatknife",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 166,
                        Critical = 110,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 16,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon41 = new Weapon()
                {
                    Name = "Tailbone Short Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 164,
                        Critical = 110,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 8,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon42 = new Weapon()
                {
                    Name = "Bandit's Knife",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 132,
                        Critical = 110,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 6,
                        Dexterity = 12,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 33,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon43 = new Weapon()
                {
                    Name = "Mail Breaker",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 150,
                        Critical = 130,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 7,
                        Dexterity = 12,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon44 = new Weapon()
                {
                    Name = "Dagger",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 110,
                        Critical = 130,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 5,
                        Dexterity = 9,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon45 = new Weapon()
                {
                    Name = "Rotten Ghru Dagger",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 108,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 8,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 34,
                        Frost = 0
                    }
                };
                var weapon46 = new Weapon()
                {
                    Name = "Scholar's Candlestick",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 116,
                        Critical = 110,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 7,
                        Dexterity = 7,
                        Faith = 16,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon47 = new Weapon()
                {
                    Name = "Handmaid's Dagger",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 144,
                        Critical = 110,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 4,
                        Dexterity = 8,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon48 = new Weapon()
                {
                    Name = "Brigand Twindaggers",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 110,
                        Critical = 110,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon49 = new Weapon()
                {
                    Name = "Harpe",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 104,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 8,
                        Dexterity = 10,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon50 = new Weapon()
                {
                    Name = "Parrying Dagger",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 100,
                        Critical = 110,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 5,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon51 = new Weapon()
                {
                    Name = "Caestus",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 160,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 5,
                        Dexterity = 8,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon52 = new Weapon()
                {
                    Name = "Demon's Fist",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 170,
                        Critical = 100,
                        Dark = 0,
                        Fire = 140,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 20,
                        Dexterity = 8,
                        Faith = 9,
                        Intelligence = 9
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon53 = new Weapon()
                {
                    Name = "Dark Hand",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 77,
                        Critical = 100,
                        Dark = 150,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 0,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon54 = new Weapon()
                {
                    Name = "Smough's Great Hammer",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 358,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 45,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon55 = new Weapon()
                {
                    Name = "Morne's Great Hammer",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 348,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 50,
                        Dexterity = 0,
                        Faith = 30,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon56 = new Weapon()
                {
                    Name = "Dragon Tooth",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 342,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 40,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon57 = new Weapon()
                {
                    Name = "Vordt's Great Hammer",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 320,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 30,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon58 = new Weapon()
                {
                    Name = "Great Club",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 304,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 28,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon59 = new Weapon()
                {
                    Name = "Old King's Great Hammer",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 328,
                        Critical = 100,
                        Dark = 0,
                        Fire = 126,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 30,
                        Dexterity = 0,
                        Faith = 10,
                        Intelligence = 10
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon60 = new Weapon()
                {
                    Name = "Great Mace",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 346,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 32,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon61 = new Weapon()
                {
                    Name = "Spiked Mace",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 298,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 21,
                        Dexterity = 13,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 33,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon62 = new Weapon()
                {
                    Name = "Large Club",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 296,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 22,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon63 = new Weapon()
                {
                    Name = "Pickaxe",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 280,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 18,
                        Dexterity = 9,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon64 = new Weapon()
                {
                    Name = "Gargoyle Flame Hammer",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 244,
                        Critical = 100,
                        Dark = 0,
                        Fire = 200,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 22,
                        Dexterity = 0,
                        Faith = 9,
                        Intelligence = 9
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon65 = new Weapon()
                {
                    Name = "Great Wooden Hammer",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 206,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 18,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon66 = new Weapon()
                {
                    Name = "Black Knight Greataxe",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 376,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 36,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon67 = new Weapon()
                {
                    Name = "Yhorm's Great Machete",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 338,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 38,
                        Dexterity = 10,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon68 = new Weapon()
                {
                    Name = "Greataxe",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 376,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 32,
                        Dexterity = 8,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon69 = new Weapon()
                {
                    Name = "Dragonslayer Greataxe",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 370,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 136
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 40,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon70 = new Weapon()
                {
                    Name = "Great Machete",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 334,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 24,
                        Dexterity = 12,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon71 = new Weapon()
                {
                    Name = "Demon's Greataxe",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 286,
                        Critical = 100,
                        Dark = 0,
                        Fire = 160,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 28,
                        Dexterity = 0,
                        Faith = 12,
                        Intelligence = 12
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon72 = new Weapon()
                {
                    Name = "Dragonslayer Greatbow",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 220,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 20,
                        Dexterity = 20,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon73 = new Weapon()
                {
                    Name = "Onislayer Greatbow",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 194,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 18,
                        Dexterity = 24,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon74 = new Weapon()
                {
                    Name = "Hollowslayer Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 264,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 14,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon75 = new Weapon()
                {
                    Name = "Claymore",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 276,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 16,
                        Dexterity = 13,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon76 = new Weapon()
                {
                    Name = "Bastard Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 276,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 16,
                        Dexterity = 10,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon77 = new Weapon()
                {
                    Name = "Black Knight Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 272,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 20,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon78 = new Weapon()
                {
                    Name = "Executioner's Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 262,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 19,
                        Dexterity = 13,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon79 = new Weapon()
                {
                    Name = "Wolf Knight's Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 230,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 24,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon80 = new Weapon()
                {
                    Name = "Storm Ruler",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 260,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 0,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon81 = new Weapon()
                {
                    Name = "Flamberge",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 288,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 15,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 33,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon82 = new Weapon()
                {
                    Name = "Wolnir's Holy Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 250,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 13,
                        Dexterity = 13,
                        Faith = 13,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon83 = new Weapon()
                {
                    Name = "Twin Princes' Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 216,
                        Critical = 100,
                        Dark = 0,
                        Fire = 134,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 22,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon84 = new Weapon()
                {
                    Name = "Firelink Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 218,
                        Critical = 100,
                        Dark = 0,
                        Fire = 146,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 20,
                        Dexterity = 10,
                        Faith = 10,
                        Intelligence = 10
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon85 = new Weapon()
                {
                    Name = "Greatsword of Judgement",
                    AttackPower = new AttackPower()
                    {
                        Magic = 122,
                        Physical = 184,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 17,
                        Dexterity = 15,
                        Faith = 0,
                        Intelligence = 12
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon86 = new Weapon()
                {
                    Name = "Drakeblood Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 130,
                        Physical = 166,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 130
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 18,
                        Dexterity = 16,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon87 = new Weapon()
                {
                    Name = "Moonlight Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 200,
                        Physical = 144,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 16,
                        Dexterity = 11,
                        Faith = 0,
                        Intelligence = 26
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon88 = new Weapon()
                {
                    Name = "Black Knight Glaive",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 278,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 28,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon89 = new Weapon()
                {
                    Name = "Gundyr's Halberd",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 264,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 30,
                        Dexterity = 15,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon90 = new Weapon()
                {
                    Name = "Red Hilted Halberd",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 260,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 14,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon91 = new Weapon()
                {
                    Name = "Winged Knight Halberd",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 290,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 26,
                        Dexterity = 16,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon92 = new Weapon()
                {
                    Name = "Halberd",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 250,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 16,
                        Dexterity = 12,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon93 = new Weapon()
                {
                    Name = "Lucerne",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 252,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 15,
                        Dexterity = 13,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon94 = new Weapon()
                {
                    Name = "Glaive",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 282,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 17,
                        Dexterity = 11,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon95 = new Weapon()
                {
                    Name = "Crescent Axe",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 238,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 14,
                        Dexterity = 12,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon96 = new Weapon()
                {
                    Name = "Immolation Tinder",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 206,
                        Critical = 100,
                        Dark = 0,
                        Fire = 132,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 18,
                        Dexterity = 18,
                        Faith = 12,
                        Intelligence = 12
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon97 = new Weapon()
                {
                    Name = "Mace",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 230,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 7,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon98 = new Weapon()
                {
                    Name = "Warpick",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 226,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 10,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon99 = new Weapon()
                {
                    Name = "Morning Star",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 244,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 11,
                        Dexterity = 9,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 33,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon100 = new Weapon()
                {
                    Name = "Reinforced Club",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 220,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon101 = new Weapon()
                {
                    Name = "Drang Hammers",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 220,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 18,
                        Dexterity = 16,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon102 = new Weapon()
                {
                    Name = "Club",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 216,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon103 = new Weapon()
                {
                    Name = "Blacksmith Hammer",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 210,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 13,
                        Dexterity = 13,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon104 = new Weapon()
                {
                    Name = "Heysel Pick",
                    AttackPower = new AttackPower()
                    {
                        Magic = 122,
                        Physical = 162,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 10,
                        Faith = 0,
                        Intelligence = 19
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon105 = new Weapon()
                {
                    Name = "Washing Pole",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 252,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 18,
                        Dexterity = 20,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 33,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon106 = new Weapon()
                {
                    Name = "Black Blade",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 244,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 18,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 33,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon107 = new Weapon()
                {
                    Name = "Chaos Blade",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 180,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 16,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 35,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon108 = new Weapon()
                {
                    Name = "Onikiri and Ubadachi",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 208,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 13,
                        Dexterity = 25,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 35,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon109 = new Weapon()
                {
                    Name = "Uchigatana",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 230,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 11,
                        Dexterity = 16,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 34,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon110 = new Weapon()
                {
                    Name = "Darkdrift",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 226,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 28,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 33,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon111 = new Weapon()
                {
                    Name = "Bloodlust",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 184,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 11,
                        Dexterity = 24,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 34,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon112 = new Weapon()
                {
                    Name = "Irithyll Rapier",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 202,
                        Critical = 110,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 16,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 35
                    }
                };
                var weapon113 = new Weapon()
                {
                    Name = "Estoc",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 210,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 12,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon114 = new Weapon()
                {
                    Name = "Ricard's Rapier",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 194,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 8,
                        Dexterity = 20,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon115 = new Weapon()
                {
                    Name = "Rapier",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 190,
                        Critical = 110,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 7,
                        Dexterity = 12,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon116 = new Weapon()
                {
                    Name = "Crystal Sage's Rapier",
                    AttackPower = new AttackPower()
                    {
                        Magic = 150,
                        Physical = 100,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 13,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon117 = new Weapon()
                {
                    Name = "Great Corvian Scythe",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 194,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 16,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 36,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon118 = new Weapon()
                {
                    Name = "Pontiff Knight Great Scythe",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 174,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 14,
                        Dexterity = 19,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon119 = new Weapon()
                {
                    Name = "Great Scythe",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 210,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 14,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 33,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon120 = new Weapon()
                {
                    Name = "Caitha's Chime",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 130,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 3,
                        Dexterity = 0,
                        Faith = 12,
                        Intelligence = 12
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon121 = new Weapon()
                {
                    Name = "Crystal Chime",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 128,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 3,
                        Dexterity = 0,
                        Faith = 18,
                        Intelligence = 18
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon122 = new Weapon()
                {
                    Name = "Yorshka's Chime",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 123,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 3,
                        Dexterity = 0,
                        Faith = 30,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon123 = new Weapon()
                {
                    Name = "Cleric's Sacred Chime",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 118,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 3,
                        Dexterity = 0,
                        Faith = 14,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon124 = new Weapon()
                {
                    Name = "Priest's Chime",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 117,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 3,
                        Dexterity = 0,
                        Faith = 10,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon125 = new Weapon()
                {
                    Name = "Saint-tree Bellvine",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 117,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 3,
                        Dexterity = 0,
                        Faith = 18,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon126 = new Weapon()
                {
                    Name = "Greatlance",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 258,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 21,
                        Dexterity = 16,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon127 = new Weapon()
                {
                    Name = "Dragonslayer Swordspear",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 234,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 62
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 16,
                        Dexterity = 22,
                        Faith = 18,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon128 = new Weapon()
                {
                    Name = "Lothric Knight Long Spear",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 224,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 14,
                        Dexterity = 20,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon129 = new Weapon()
                {
                    Name = "Partizan",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 216,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 14,
                        Dexterity = 12,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon130 = new Weapon()
                {
                    Name = "Arstor's Spear",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 216,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 11,
                        Dexterity = 19,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 33,
                        Frost = 0
                    }
                };
                var weapon131 = new Weapon()
                {
                    Name = "Dragonslayer Spear",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 198,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 122
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 20,
                        Dexterity = 20,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon132 = new Weapon()
                {
                    Name = "Winged Spear",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 190,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 15,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon133 = new Weapon()
                {
                    Name = "Four-Pronged Plow",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 210,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 13,
                        Dexterity = 11,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon134 = new Weapon()
                {
                    Name = "Pike",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 210,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 18,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon135 = new Weapon()
                {
                    Name = "Rotten Ghru Spear",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 208,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 12,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 34,
                        Frost = 0
                    }
                };
                var weapon136 = new Weapon()
                {
                    Name = "Spear",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 208,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 11,
                        Dexterity = 10,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon137 = new Weapon()
                {
                    Name = "Drang Twinspears",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 200,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 14,
                        Dexterity = 20,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon138 = new Weapon()
                {
                    Name = "Tailbone Spear",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 216,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 13,
                        Dexterity = 15,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon139 = new Weapon()
                {
                    Name = "Yorshka's Spear",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 172,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 18,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon140 = new Weapon()
                {
                    Name = "Gargoyle Flame Spear",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 206,
                        Critical = 100,
                        Dark = 0,
                        Fire = 180,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 15,
                        Dexterity = 18,
                        Faith = 9,
                        Intelligence = 9
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon141 = new Weapon()
                {
                    Name = "Saint Bident",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 196,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 12,
                        Faith = 16,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon142 = new Weapon()
                {
                    Name = "Golden Ritual Spear",
                    AttackPower = new AttackPower()
                    {
                        Magic = 134,
                        Physical = 128,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 10,
                        Faith = 14,
                        Intelligence = 18
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon143 = new Weapon()
                {
                    Name = "Soldering Iron",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 78,
                        Critical = 100,
                        Dark = 0,
                        Fire = 192,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 12,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon144 = new Weapon()
                {
                    Name = "Izalith Staff",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 210,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 0,
                        Faith = 10,
                        Intelligence = 14
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon145 = new Weapon()
                {
                    Name = "Archdecon Great Staff",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 156,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 8,
                        Dexterity = 0,
                        Faith = 12,
                        Intelligence = 12
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon146 = new Weapon()
                {
                    Name = "Sage's Crystal Staff",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 154,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 7,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 24
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon147 = new Weapon()
                {
                    Name = "Man-Grub's Staff",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 158,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 9,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 18
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon148 = new Weapon()
                {
                    Name = "Heretic's Staff",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 142,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 8,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 16
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon149 = new Weapon()
                {
                    Name = "Court Sorcerer's Staff",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 135,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 6,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 14
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon150 = new Weapon()
                {
                    Name = "Storyteller's Staff",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 136,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 6,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 12
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon151 = new Weapon()
                {
                    Name = "Sorcerer's Staff",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 135,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 6,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 10
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon152 = new Weapon()
                {
                    Name = "Mendicant's Staff",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 135,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 7,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 18
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon153 = new Weapon()
                {
                    Name = "Witch Tree Branch",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 129,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 7,
                        Dexterity = 0,
                        Faith = 0,
                        Intelligence = 18
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon154 = new Weapon()
                {
                    Name = "Sunlight Straight Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 196,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 12,
                        Faith = 16,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon155 = new Weapon()
                {
                    Name = "Dark Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 230,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 16,
                        Dexterity = 15,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon156 = new Weapon()
                {
                    Name = "Broadsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 234,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 10,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon157 = new Weapon()
                {
                    Name = "Longsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 220,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 10,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon158 = new Weapon()
                {
                    Name = "Lothric Knight Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 206,
                        Critical = 110,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 11,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon159 = new Weapon()
                {
                    Name = "Barbed Straight Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 222,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 11,
                        Dexterity = 11,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 41,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon160 = new Weapon()
                {
                    Name = "Morion Blade",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 228,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 17,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 33,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon161 = new Weapon()
                {
                    Name = "Irithyll Straight Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 216,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 35
                    }
                };
                var weapon162 = new Weapon()
                {
                    Name = "Shortsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 198,
                        Critical = 110,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 8,
                        Dexterity = 10,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon163 = new Weapon()
                {
                    Name = "Astora Straight Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 258,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 10,
                        Faith = 12,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon164 = new Weapon()
                {
                    Name = "Gotthard Twinswords",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 200,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 12,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon165 = new Weapon()
                {
                    Name = "Lothric's Holy Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 196,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 18,
                        Faith = 14,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon166 = new Weapon()
                {
                    Name = "Anri's Straight Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 204,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 10,
                        Dexterity = 10,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon167 = new Weapon()
                {
                    Name = "Broken Straight Sword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 140,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 8,
                        Dexterity = 8,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon168 = new Weapon()
                {
                    Name = "Cleric's Candlestick",
                    AttackPower = new AttackPower()
                    {
                        Magic = 126,
                        Physical = 115,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 8,
                        Dexterity = 12,
                        Faith = 12,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon169 = new Weapon()
                {
                    Name = "Sunless Talisman",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 130,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 4,
                        Dexterity = 0,
                        Faith = 24,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon170 = new Weapon()
                {
                    Name = "White Hair Talisman",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 128,
                        Critical = 100,
                        Dark = 0,
                        Fire = 138,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 4,
                        Dexterity = 0,
                        Faith = 16,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon171 = new Weapon()
                {
                    Name = "Saint's Talisman",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 120,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 4,
                        Dexterity = 0,
                        Faith = 16,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon172 = new Weapon()
                {
                    Name = "Sunlight Talisman",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 120,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 4,
                        Dexterity = 0,
                        Faith = 14,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon173 = new Weapon()
                {
                    Name = "Canvas Talisman",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 117,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 4,
                        Dexterity = 0,
                        Faith = 14,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon174 = new Weapon()
                {
                    Name = "Talisman",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 117,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 4,
                        Dexterity = 0,
                        Faith = 10,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon175 = new Weapon()
                {
                    Name = "Black Knight Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 322,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 30,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon176 = new Weapon()
                {
                    Name = "Profaned Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 294,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 22,
                        Dexterity = 10,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon177 = new Weapon()
                {
                    Name = "Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 318,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 28,
                        Dexterity = 10,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon178 = new Weapon()
                {
                    Name = "Fume Ultra Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 260,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 50,
                        Dexterity = 10,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon179 = new Weapon()
                {
                    Name = "Zweihander",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 290,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 19,
                        Dexterity = 11,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon180 = new Weapon()
                {
                    Name = "Cathedral Knight Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 298,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 26,
                        Dexterity = 10,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon181 = new Weapon()
                {
                    Name = "Astora Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 264,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 16,
                        Dexterity = 18,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon182 = new Weapon()
                {
                    Name = "Lorian's Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 276,
                        Critical = 100,
                        Dark = 0,
                        Fire = 144,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 26,
                        Dexterity = 10,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon183 = new Weapon()
                {
                    Name = "Farron Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 228,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 18,
                        Dexterity = 20,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon184 = new Weapon()
                {
                    Name = "Lothric Knight Greatsword",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 262,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 174
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 24,
                        Dexterity = 16,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon185 = new Weapon()
                {
                    Name = "Spotted Whip",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 204,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 9,
                        Dexterity = 20,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 33,
                        Frost = 0
                    }
                };
                var weapon186 = new Weapon()
                {
                    Name = "Whip",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 180,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 6,
                        Dexterity = 14,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon187 = new Weapon()
                {
                    Name = "Notched Whip",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 190,
                        Critical = 100,
                        Dark = 0,
                        Fire = 0,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 6,
                        Dexterity = 19,
                        Faith = 0,
                        Intelligence = 0
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 33,
                        Poison = 0,
                        Frost = 0
                    }
                };
                var weapon188 = new Weapon()
                {
                    Name = "Witch's Locks",
                    AttackPower = new AttackPower()
                    {
                        Magic = 0,
                        Physical = 134,
                        Critical = 100,
                        Dark = 0,
                        Fire = 140,
                        Lightning = 0
                    },
                    StatRequirement = new StatRequirements()
                    {
                        Strength = 9,
                        Dexterity = 17,
                        Faith = 12,
                        Intelligence = 12
                    },
                    AdditionalEffects = new AdditionalEffects()
                    {
                        Bleed = 0,
                        Poison = 0,
                        Frost = 0
                    }
                };
            }
            weapons.ForEach(weapon => context.Weapons.AddOrUpdate(w => w.Name, weapon));
            context.SaveChanges();
        }
    }
}
