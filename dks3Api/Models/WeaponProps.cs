using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dks3Api.Models
{
    // Defining all of the properties that weapons share.
    public enum WeaponClass
    {
        Dagger,
        Sword,
        [Display(Name = "Straight Sword")]
        StraightSword,
        [Display(Name = "Great Sword")]
        GreatSword,
        Katana
    }

    public class WeaponArt
    {
        [Display(Name = "Weapon Arts Type")]
        public string WeaponArtsType { get; set; }
        [Display(Name = "Weapon Arts Description")]
        public string WeaponArtsDescription { get; set; }
        [Display(Name = "FP Cost")]
        public int? FPcost { get; set; }
    }

    public class StatRequirements
    {
        public int? Strength { get; set; }
        public int? Dexterity { get; set; }
        public int? Intelligence { get; set; }
        public int? Faith { get; set; }
    }

    public class DamageScaling
    {
        public double? Strength { get; set; }
        public double? Dexterity { get; set; }
        public double? Intelligence { get; set; }
        public double? Faith { get; set; }
    }

    public class DamageAbsorption
    {
        public double? Physical { get; set; }
        public double? Magic { get; set; }
        public double? Fire { get; set; }
        public double? Lightning { get; set; }
        public double? Dark { get; set; }
        public int? Stability { get; set; }
    }

    public class AttackPower
    {
        public int? Physical { get; set; }
        public int? Magic { get; set; }
        public int? Fire { get; set; }
        public int? Lightning { get; set; }
        public int? Dark { get; set; }
        public int? Critical { get; set; }
    }

    public class AdditionalEffects
    {
        public int? Bleed { get; set; }
        public int? Poison { get; set; }
        public int? Frost { get; set; }
    }

    public class Moveset
    {
        public int ID { get; set; }
        public string URL { get; set; }
    }

}