using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dks3Api.Models
{

    public class Weapon
    {
        public Weapon()
        {
            this.WeaponClass = new WeaponClass();
            this.WeaponArt = new WeaponArt();
            this.AttackPower = new AttackPower();
            this.DamageAbsorption = new DamageAbsorption();
            this.DamageScaling = new DamageScaling();
            this.AdditionalEffects = new AdditionalEffects();
            this.StatRequirements = new StatRequirements();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int? Durability { get; set; }
        public string NewColumn { get; set; }

        #region WeaponProps
        [Display(Name = "Damage Type")] public string DamageType { get; set; }
        [Display(Name = "Weapon Class")] public WeaponClass WeaponClass { get; set; }
        [Display(Name = "Weapon Art")] public WeaponArt WeaponArt { get; set; }
        [Display(Name = "Attack Power")] public AttackPower AttackPower { get; set; }
        [Display(Name = "Damage Absorption")] public DamageAbsorption DamageAbsorption { get; set; }
        [Display(Name = "Damage Scaling")] public DamageScaling DamageScaling { get; set; }
        [Display(Name = "Additional Effects")] public AdditionalEffects AdditionalEffects { get; set; }
        [Display(Name = "Stat Requirements")] public StatRequirements StatRequirements { get; set; }
        #endregion
    }
}