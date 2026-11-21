using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Entitled
{
    public class BuilderEdition : BuilderText<BuilderEdition, EntityEdition>, IBuilderEdition<BuilderEdition>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityEdition>();

            // Table
            e.ToTable("tbl_edition");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_edition");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_edition").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_edition")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_edition")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableTitle)
                .WithOne(x => x.EntityEdition)
                .HasForeignKey(x => x.KeyEdition)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_edition_title");
        }
    }
}
