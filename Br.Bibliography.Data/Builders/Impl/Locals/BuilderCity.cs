using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Locals
{
    public class BuilderCity : BuilderText<BuilderCity, EntityCity>, IBuilderCity<BuilderCity>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityCity>();

            // Table
            e.ToTable("tbl_city");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_city");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_city").IsUnique();

            e.HasIndex(e => e.KeyState).HasDatabaseName("idx_key_city_state").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_city")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyState)
                .HasColumnName("key_state")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_city")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityState)
                .WithMany(x => x.EnumerableCity)
                .HasForeignKey(x => x.KeyState)
                .HasPrincipalKey(x=> x.Key)
                .HasConstraintName("fk_state_city");

            e.HasMany(x => x.EnumerablePublisher)
                .WithOne(x => x.EntityCity)
                .HasForeignKey(x => x.KeyCity)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_state_publisher");
        }
    }
}
