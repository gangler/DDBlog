using DwDxx.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DwDxx.Model
{
    public partial class DwdxxContext : DbContext
    {
        public DwdxxContext()
        {
        }

        public DwdxxContext(DbContextOptions<DwdxxContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<Post> Post { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(ConfigurationManager.GetConnectionString("MySqlConnection"));
            }
        }
    }
}
