using Br.Bibliography.Core.Constants.Impl.Entitled;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Entitled
{
    public class BuilderDisclaimer : 
        BuilderDesc<BuilderDisclaimer, EntityDisclaimer, ConstantDisclaimer>, 
        IBuilderDisclaimer<BuilderDisclaimer>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityDisclaimer>();

            // Table
            e.ToTable("tbl_disclaimer");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_disclaimer");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_disclaimer").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_disclaimer")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Desc)
                .HasColumnName("desc_disclaimer")
                .HasMaxLength(DescMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableTitle)
                .WithOne(x => x.EntityDisclaimer)
                .HasForeignKey(x => x.KeyDisclaimer)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_disclaimer_title");
        }
    }
}
