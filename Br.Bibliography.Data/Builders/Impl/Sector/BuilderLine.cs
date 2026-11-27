
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Sector
{
    public class BuilderLine : 
        BuilderLine<BuilderLine, EntityLine>, 
        IBuilderLine<BuilderLine>
    {
        public override string[] EntityNameParts => [Constant.Base.LINE];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityLine>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Fluent.PrimaryKeyConstraintFromParams(EntityNameParts));

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Fluent.PrimaryKeyIndexFromParams(EntityNameParts)).IsUnique();

            e.HasIndex(x => x.KeySection)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.LINE, Constant.Base.SECTION]))
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

            e.Property(x => x.LineMark)
                .HasColumnName(Fluent.TextColumnNameFromParams([ Constant.Properties.MARK, Constant.Base.LINE]))
                .HasMaxLength(Constant.Max.MaxMark)
                .HasColumnOrder(order++)
                .IsRequired(false);

            e.Property(x => x.LineOrder)
                .HasColumnName(Fluent.NumberColumnNameFromParams([Constant.Properties.ORDER, Constant.Base.LINE]))
                .HasColumnOrder(order++)
                .IsRequired(false);

            e.Property(x => x.Text)
                .HasColumnName(Fluent.TextColumnNameFromParams(EntityNameParts))
                .HasMaxLength(Constant.Max.MaxText)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntitySection)
                .WithMany(x => x.EnumerableLine)
                .HasForeignKey(x => x.KeySection)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.LINE, Constant.Base.SECTION]));

            #endregion
        }
    }
}
