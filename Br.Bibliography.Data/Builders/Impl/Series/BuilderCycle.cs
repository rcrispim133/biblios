using Br.Bibliography.Core.Constants.Impl.Series;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Series
{
    public class BuilderCycle : 
        BuilderText<BuilderCycle, EntityCycle, IConstantCycle>, 
        IBuilderCycle<BuilderCycle>
    {
        public override IConstantCycle Constant { get; init; } = ConstantCycle.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityCycle>();

            // Table
            e.ToTable("tbl_cycle");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_cycle");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_cycle").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_cycle")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_cycle")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableCourse)
                .WithOne(x => x.EntityCycle)
                .HasForeignKey(x => x.KeyCycle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_cycle_course");
        }
    }
}
