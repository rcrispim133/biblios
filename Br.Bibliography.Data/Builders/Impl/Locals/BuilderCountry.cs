using Br.Bibliography.Core.Constants.Impl.Locals;
using Br.Bibliography.Core.Constants.Interfaces.Locals;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Locals
{
    public class BuilderCountry : 
        BuilderText<BuilderCountry, EntityCountry, IConstantCountry>, 
        IBuilderCountry<BuilderCountry>
    {
        public override IConstantCountry Constant { get; init; } = ConstantCountry.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityCountry>();

            // Table
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextName)
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableStates)
                .WithOne(x => x.EntityCountry)
                .HasForeignKey(x => x.KeyCountry)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_country_state");
        }
    }
}
