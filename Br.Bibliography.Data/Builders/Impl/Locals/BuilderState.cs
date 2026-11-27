using Br.Bibliography.Core.Constants.Impl.Locals;
using Br.Bibliography.Core.Constants.Interfaces.Locals;
using Br.Bibliography.Core.Static;
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
            #region Entity

            var e = builder.Entity<Model.Entities.Impl.Locals.EntityState>();

            #endregion

            #region Table

            e.ToTable(Constant.TableName);

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.KeyCountry)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.STATE, StaticEntityNames.COUNTRY]))
                .IsUnique(false);

            #endregion

            #region Order

            var order = Constant.BaseOrder;

            #endregion

            #region Properties

            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyColumnName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyCountry)
                .HasColumnName(Constant.TextColumnName([StaticEntityNames.COUNTRY]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextColumnName)
                .HasMaxLength(Constant.DefaultTextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityCountry)
                .WithMany(x => x.EnumerableStates)
                .HasForeignKey(x => x.KeyCountry)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.STATE, StaticEntityNames.COUNTRY]));

            e.HasMany(x => x.EnumerableCity)
                .WithOne(x => x.EntityState)
                .HasForeignKey(x => x.KeyState)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.STATE, StaticEntityNames.CITY]));

            #endregion
        }
    }
}
