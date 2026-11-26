using Br.Bibliography.Core.Constants.Impl.Series;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Series
{
    public class BuilderPeriod : 
        BuilderText<BuilderPeriod, EntityPeriod, ConstantPeriod>, 
        IBuilderPeriod<BuilderPeriod>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityPeriod>();

            // Table
            e.ToTable("tbl_period");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_period");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_period").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_period")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_period")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableCourse)
                .WithOne(x => x.EntityPeriod)
                .HasForeignKey(x => x.KeyPeriod)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_period_course");
        }
    }
}
