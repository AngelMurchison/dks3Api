using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dks3Api.Models
{
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

    public class WeaponArts
    {
        [Display(Name = "Weapon Arts Type")]
        public string WeaponArtsType { get; set; }
        [Display(Name = "Weapon Arts Description")]
        public string WeaponArtsDescription { get; set; }
        [Display(Name = "FP Cost")]
        public string FPcost { get; set; }
    }
    public class AttributeRequirement
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Faith { get; set; }
    }
    public class AttributeBonus
    {
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Intelligence { get; set; }
        public string Faith { get; set; }
    }
    public class GuardAbsorption
    {
        public double Physical { get; set; }
        public double Magic { get; set; }
        public double Fire { get; set; }
        public double Lightning { get; set; }
        public double Dark { get; set; }
        public int Stability { get; set; }
    }
    public class AttackPower
    {
        public int Physical { get; set; }
        public int Magic { get; set; }
        public int Fire { get; set; }
        public int Lightning { get; set; }
        public int Dark { get; set; }
        public int Critical { get; set; }
    }
    public class AdditionalEffects
    {
        public int Bleed { get; set; }
        public int Poison { get; set; }
        public int Frost { get; set; }
    }

}