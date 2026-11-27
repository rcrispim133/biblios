
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Locals;
using Microsoft.EntityFrameworkCore;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;

namespace Br.Bibliography.Data.Builders.Impl.Locals
{
    public class BuilderState : 
        BuilderText<BuilderState, Model.Entities.Impl.Locals.EntityState>, 
        IBuilderState<BuilderState>
    {
        public override string[] EntityNameParts => [Constant.Base.STATE];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<Model.Entities.Impl.Locals.EntityState>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Fluent.PrimaryKeyConstraintFromParams(EntityNameParts));

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Fluent.PrimaryKeyIndexFromParams(EntityNameParts)).IsUnique();

            e.HasIndex(x => x.KeyCountry)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.STATE, Constant.Base.COUNTRY]))
                .IsUnique(false);

            #endregion

            #region Order

            var order = Constant.Math.Zero;

            #endregion

            #region Properties

            e.Property(x => x.Key)
                .HasColumnName(Fluent.KeyColumnNameFromParams(EntityNameParts))
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyCountry)
                .HasColumnName(Fluent.TextColumnNameFromParams([Constant.Base.COUNTRY]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Fluent.TextColumnNameFromParams(EntityNameParts))
                .HasMaxLength(Constant.Max.MaxText)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityCountry)
                .WithMany(x => x.EnumerableStates)
                .HasForeignKey(x => x.KeyCountry)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.STATE, Constant.Base.COUNTRY]));

            e.HasMany(x => x.EnumerableCity)
                .WithOne(x => x.EntityState)
                .HasForeignKey(x => x.KeyState)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.STATE, Constant.Base.CITY]));

            #endregion
        }
    }
}
