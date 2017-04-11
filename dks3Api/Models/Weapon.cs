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
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Durability { get; set; }

        #region WeaponProps
        [Display(Name = "Damage Type")] public string DamageType { get; set; }
        [Display(Name = "Weapon Class")] public WeaponClass WeaponClass { get; set; }
        [Display(Name = "Weapon Art")] public WeaponArt WeaponArt { get; set; }
        [Display(Name = "Attack Power")] public AttackPower AttackPower { get; set; }
        [Display(Name = "Damage Absorption")] public DamageAbsorption DamageAbsorption { get; set; }
        [Display(Name = "Damage Scaling")] public DamageScaling DamageScaling { get; set; }
        [Display(Name = "Additional Effects")] public AdditionalEffects AdditionalEffects { get; set; }
        [Display(Name = "Stat Requirements")] public StatRequirements StatRequirement { get; set; }
        #endregion
    }
}