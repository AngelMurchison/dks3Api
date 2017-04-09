using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dks3Api.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string DamageType { get; set; }
        public double Weight { get; set; }
        public int Durability { get; set; }

        public WeaponClass WeaponClass { get; set; }
        public WeaponArts WeaponArts { get; set; }
        public AttackPower AttackPower { get; set; }
        public GuardAbsorption GuardAbsorption { get; set; }
        public AttributeBonus AttributeBonus { get; set; }
        public AdditionalEffects AdditionalEffects { get; set; }
        public AttributeRequirement AttributeRequirement { get; set; }
    }
}