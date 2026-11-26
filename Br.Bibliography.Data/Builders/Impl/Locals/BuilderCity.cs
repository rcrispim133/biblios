using Br.Bibliography.Core.Constants.Impl.Locals;
using Br.Bibliography.Core.Constants.Interfaces.Locals;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Locals
{
    public class BuilderCity : 
        BuilderText<BuilderCity, EntityCity, IConstantCity>, 
        IBuilderCity<BuilderCity>
    {
        public override IConstantCity Constant { get; init; } = ConstantCity.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityCity>();

            // Table
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(e => e.KeyState).HasDatabaseName("idx_key_city_state").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyColumnName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyState)
                .HasColumnName("key_state")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextColumnName)
                .HasMaxLength(Constant.PropertyTextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityState)
                .WithMany(x => x.EnumerableCity)
                .HasForeignKey(x => x.KeyState)
                .HasPrincipalKey(x=> x.Key)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.CITY, StaticEntityNames.STATE]));

            e.HasMany(x => x.EnumerablePublisher)
                .WithOne(x => x.EntityCity)
                .HasForeignKey(x => x.KeyCity)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.CITY, StaticEntityNames.PUBLISHER]));
        }
    }
}
