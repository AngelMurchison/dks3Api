using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace dks3Api.Models
{
    public class dks3ApiContext : DbContext
    {
        public DbSet<Weapon> Weapons { get; set; }
    }
}