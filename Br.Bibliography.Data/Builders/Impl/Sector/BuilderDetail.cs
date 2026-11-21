using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Sector
{
    public class BuilderDetail : BuilderText<BuilderDetail, EntityDetail>, IBuilderDetail<BuilderDetail>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityDetail>();

            // Table
            e.ToTable("tbl_detail");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_detail");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_detail").IsUnique();


            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_detail")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_detail")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableSection)
                .WithOne(x => x.EntityDetail)
                .HasForeignKey(x => x.KeyDetail)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_detail_section");
        }
    }
}
