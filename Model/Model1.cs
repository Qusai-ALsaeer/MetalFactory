using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Acco.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tb_account> tb_account { get; set; }
        public virtual DbSet<tb_car> tb_car { get; set; }
        public virtual DbSet<tb_category> tb_category { get; set; }
        public virtual DbSet<tb_company> tb_company { get; set; }
        public virtual DbSet<tb_currency> tb_currency { get; set; }
        public virtual DbSet<tb_employee> tb_employee { get; set; }
        public virtual DbSet<tb_entry> tb_entry { get; set; }
        public virtual DbSet<tb_entry_d> tb_entry_d { get; set; }
        public virtual DbSet<tb_final> tb_final { get; set; }
        public virtual DbSet<tb_fran> tb_fran { get; set; }
        public virtual DbSet<tb_general> tb_general { get; set; }
        public virtual DbSet<tb_item> tb_item { get; set; }
        public virtual DbSet<tb_jop> tb_jop { get; set; }
        public virtual DbSet<tb_manufact> tb_manufact { get; set; }
        public virtual DbSet<tb_motion> tb_motion { get; set; }
        public virtual DbSet<tb_oven> tb_oven { get; set; }
        public virtual DbSet<tb_payment> tb_payment { get; set; }
        public virtual DbSet<tb_purchases> tb_purchases { get; set; }
        public virtual DbSet<tb_purchases_d> tb_purchases_d { get; set; }
        public virtual DbSet<tb_receipt> tb_receipt { get; set; }
        public virtual DbSet<tb_salary> tb_salary { get; set; }
        public virtual DbSet<tb_salary_d> tb_salary_d { get; set; }
        public virtual DbSet<tb_sale_d> tb_sale_d { get; set; }
        public virtual DbSet<tb_sales> tb_sales { get; set; }
        public virtual DbSet<tb_supervisor> tb_supervisor { get; set; }
        public virtual DbSet<tb_transfer> tb_transfer { get; set; }
        public virtual DbSet<tb_unit> tb_unit { get; set; }
        public virtual DbSet<tb_user> tb_user { get; set; }
        public virtual DbSet<tb_week> tb_week { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tb_currency>()
                .Property(e => e.cu_sym)
                .IsFixedLength();

            modelBuilder.Entity<tb_currency>()
                .Property(e => e.cu_part)
                .IsFixedLength();

            modelBuilder.Entity<tb_currency>()
                .Property(e => e.cu_iso)
                .IsFixedLength();

            modelBuilder.Entity<tb_purchases>()
                .Property(e => e.inv_date)
                .IsFixedLength();
        }
    }
}
