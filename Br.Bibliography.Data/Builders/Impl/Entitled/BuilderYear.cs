using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Entitled
{
    public class BuilderYear : BuilderBase<BuilderYear, EntityYear>, IBuilderYear<BuilderYear>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityYear>();

            // Table
            e.ToTable("tbl_year");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_year");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_year").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_year")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableTitle)
                .WithOne(x => x.EntityYear)
                .HasForeignKey(x => x.KeyYear)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_year_title");
        }
    }
}
