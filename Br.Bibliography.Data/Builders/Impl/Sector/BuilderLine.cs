using Br.Bibliography.Core.Constants.Impl.Sector;
using Br.Bibliography.Core.Constants.Interfaces.Sector;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Sector
{
    public class BuilderLine : 
        BuilderLine<BuilderLine, EntityLine, IConstantLine>, 
        IBuilderLine<BuilderLine>
    {
        public override IConstantLine Constant { get; init; } = ConstantLine.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityLine>();

            // Table
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.KeySection).HasDatabaseName("idx_key_line_section").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyName)
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
                .HasColumnName(Constant.PropertyTextName)
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
