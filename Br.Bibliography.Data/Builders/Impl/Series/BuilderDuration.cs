using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Series
{
    public class BuilderDuration : BuilderText<BuilderDuration, EntityDuration>, IBuilderDuration<BuilderDuration>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityDuration>();

            // Table
            e.ToTable("tbl_duration");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_duration");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_duration").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_duration")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_duration")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableCourse)
                .WithOne(x => x.EntityDuration)
                .HasForeignKey(x => x.KeyDuration)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_duration_course");
        }
    }
}
