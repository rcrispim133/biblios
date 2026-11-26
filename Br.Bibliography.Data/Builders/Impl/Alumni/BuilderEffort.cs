using Br.Bibliography.Core.Constants.Impl.Alumni;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Alumni
{
    public class BuilderEffort : BuilderText<BuilderEffort, EntityEffort, IConstantEffort>, IBuilderEffort<BuilderEffort>
    {
        public override IConstantEffort Constant { get; init; } = ConstantEffort.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityEffort>();

            // Table
            e.ToTable("tbl_effort");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_effort");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_effort").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_effort")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_effort")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableLecture)
                .WithOne(x => x.EntityEffort)
                .HasForeignKey(x => x.KeyEffort)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_effort_lecture");
        }
    }
}
