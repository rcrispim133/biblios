using Br.Bibliography.Core.Constants.Impl.Series;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Series
{
    public class BuilderUnit : 
        BuilderAcronym<BuilderUnit, EntityUnit, IConstantUnit>, 
        IBuilderUnit<BuilderUnit>
    {
        public override IConstantUnit Constant { get; init; } = ConstantUnit.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityUnit>();

            // Table
            e.ToTable("tbl_unit");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_unit");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_unit").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_unit")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();
            
            e.Property(x => x.Acronym)
                .HasColumnName("acronym_unit")
                .HasMaxLength(AcronymMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_unit")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableCourse)
                .WithOne(x => x.EntityUnit)
                .HasForeignKey(x => x.KeyUnit)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_unit_course");
        }
    }
}
