
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Series
{
    public class BuilderUnit : 
        BuilderAcronym<BuilderUnit, EntityUnit>, 
        IBuilderUnit<BuilderUnit>
    {
        public override string[] EntityNameParts => [Constant.Base.UNIT];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityUnit>();

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
            
            e.Property(x => x.Acronym)
                .HasColumnName(Fluent.AcronymColumnNameFromParams(EntityNameParts))
                .HasMaxLength(Constant.Max.MaxAcronym)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Fluent.TextColumnNameFromParams(EntityNameParts))
                .HasMaxLength(Constant.Max.MaxText)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasMany(x => x.EnumerableCourse)
                .WithOne(x => x.EntityUnit)
                .HasForeignKey(x => x.KeyUnit)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.UNIT, Constant.Base.COURSE]));

            #endregion
        }
    }
}
