using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Sector
{
    public class BuilderLine : BuilderLine<BuilderLine, EntityLine>, IBuilderLine<BuilderLine>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityLine>();

            // Table
            e.ToTable("tbl_line");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_line");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_line").IsUnique();

            e.HasIndex(x => x.KeySection).HasDatabaseName("idx_key_line_section").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_line")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.LineMark)
                .HasColumnName("mark_line")
                .HasMaxLength(MarkMax)
                .HasColumnOrder(order++)
                .IsRequired(false);

            e.Property(x => x.LineOrder)
                .HasColumnName("order_line")
                .HasColumnOrder(order++)
                .IsRequired(false);

            e.Property(x => x.Text)
                .HasColumnName("txt_line")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntitySection)
                .WithMany(x => x.EnumerableLine)
                .HasForeignKey(x => x.KeySection)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_line_section");
        }
    }
}
