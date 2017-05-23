using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Service.Domain;

namespace Service.Infrastructure
{
    public class HeckYaBabyContext : DbContext
    {
        public DbSet<ProfileEntity> Profiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public override int SaveChanges()
        {
            var context = ((IObjectContextAdapter) this).ObjectContext;

            var entries = context.ObjectStateManager
                .GetObjectStateEntries(EntityState.Added | EntityState.Modified)
                .Where(x => !x.IsRelationship)
                .Where(x => x.Entity != null)
                .Where(x => x.Entity is IAuditable)
                .ToList();

            var date = DateTime.Now;

            entries
                .Select(x => x.Entity)
                .Cast<IAuditable>()
                .ToList()
                .ForEach(x => x.RowDate = date);

            entries
                .Where(x => x.State == EntityState.Modified)
                .Select(x => x.Entity)
                .Cast<IAuditable>()
                .ToList()
                .ForEach(x => x.RowStatus = "UPDATED");

            entries
                .Where(x => x.State == EntityState.Added)
                .Select(x => x.Entity)
                .Cast<IAuditable>()
                .ToList()
                .ForEach(x => x.RowStatus = "INSERTED");

            return base.SaveChanges();
        }
    }
}
