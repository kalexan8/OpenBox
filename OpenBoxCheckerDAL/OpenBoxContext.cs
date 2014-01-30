﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using OpenBoxLibrary;
using OpenBoxLibrary.Models;

namespace OpenBoxCheckerDAL
{
    public class OpenBoxContext : DbContext
    {
        public OpenBoxContext()
            : base("OpenBoxContext")
        {
        }
        public DbSet<NeweggItem> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
