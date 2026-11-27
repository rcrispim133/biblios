
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Locals;
using Microsoft.EntityFrameworkCore;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Model.Entities.Impl.Locals;
using Br.Bibliography.Util.Fluent.Base;

namespace Br.Bibliography.Data.Builders.Impl.Locals
{
    public class BuilderCountry : 
        BuilderText<BuilderCountry, EntityCountry>, 
        IBuilderCountry<BuilderCountry>
    {
        public override string[] EntityNameParts => [Constant.Base.COUNTRY];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityCountry>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Fluent.PrimaryKeyConstraintFromParams(EntityNameParts));

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Fluent.PrimaryKeyIndexFromParams(EntityNameParts)).IsUnique();

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

            e.Property(x => x.Text)
                .HasColumnName(Fluent.TextColumnNameFromParams(EntityNameParts))
                .HasMaxLength(Constant.Max.MaxText)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasMany(x => x.EnumerableStates)
                .WithOne(x => x.EntityCountry)
                .HasForeignKey(x => x.KeyCountry)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.COUNTRY, Constant.Base.STATE]));

            #endregion
        }
    }
}
