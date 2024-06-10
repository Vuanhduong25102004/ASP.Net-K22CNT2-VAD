using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lesson08_VAD.Models
{
    public class VadBookStore : DbContext
    {
        public VadBookStore() : base("VadBookStoreConnectionString")
        {

        }
        // tao cac bang
        public DbSet<VadCategory> VadCategories { get; set; }
        public DbSet<VadBook> VadBooks { get; set; }
        
    }
}