using Br.Bibliography.Core.Constants.Impl.Sector;
using Br.Bibliography.Core.Constants.Interfaces.Sector;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Sector
{
    public class BuilderLine : 
        BuilderLine<BuilderLine, EntityLine, IConstantLine>, 
        IBuilderLine<BuilderLine>
    {
        public override IConstantLine Constant { get; init; } = ConstantLine.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityLine>();

            #endregion

            #region Table

            e.ToTable(Constant.TableName);

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.KeySection)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.LINE, StaticEntityNames.SECTION]))
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

            e.Property(x => x.LineMark)
                .HasColumnName(Constant.TextColumnName([ StaticPropertyNames.MARK, StaticEntityNames.LINE]))
                .HasMaxLength(Constant.DefaultMarkMaxLength)
                .HasColumnOrder(order++)
                .IsRequired(false);

            e.Property(x => x.LineOrder)
                .HasColumnName(Constant.NumberColumnName([StaticPropertyNames.ORDER, StaticEntityNames.LINE]))
                .HasColumnOrder(order++)
                .IsRequired(false);

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextColumnName)
                .HasMaxLength(Constant.DefaultTextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntitySection)
                .WithMany(x => x.EnumerableLine)
                .HasForeignKey(x => x.KeySection)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([StaticEntityNames.LINE, StaticEntityNames.SECTION]));

            #endregion
        }
    }
}
