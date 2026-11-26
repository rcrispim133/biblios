using Br.Bibliography.Core.Constants.Impl.Locals;
using Br.Bibliography.Core.Constants.Interfaces.Locals;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Locals;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Locals
{
    public class BuilderState : 
        BuilderText<BuilderState, Model.Entities.Impl.Locals.EntityState, IConstantState>, 
        IBuilderState<BuilderState>
    {
        public override IConstantState Constant { get; init; } = ConstantState.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<Model.Entities.Impl.Locals.EntityState>();

            // Table
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(e => e.KeyCountry).HasDatabaseName("idx_key_state_country").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyColumnName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyCountry)
                .HasColumnName("key_country")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextColumnName)
                .HasMaxLength(Constant.PropertyTextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityCountry)
                .WithMany(x => x.EnumerableStates)
                .HasForeignKey(x => x.KeyCountry)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.STATE, StaticEntityNames.COUNTRY]));

            e.HasMany(x => x.EnumerableCity)
                .WithOne(x => x.EntityState)
                .HasForeignKey(x => x.KeyState)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.STATE, StaticEntityNames.CITY]));
        }
    }
}
