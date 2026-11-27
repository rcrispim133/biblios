using Br.Bibliography.Core.Constants.Impl.Duo;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderTitleUrl : 
        BuilderBase<BuilderTitleUrl, EntityTitleUrl, IConstantTitleUrl>, 
        IBuilderTitleUrl<BuilderTitleUrl>
    {
        public override IConstantTitleUrl Constant { get; init; } = ConstantTitleUrl.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityTitleUrl>();

            #endregion

            #region Table

            e.ToTable(Constant.TableName);

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.KeyTitle)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.TITLE, StaticEntityNames.URL, StaticEntityNames.TITLE]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyUrl)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.TITLE, StaticEntityNames.URL, StaticEntityNames.URL]))
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

            e.Property(x => x.KeyTitle)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.TITLE]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyUrl)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.URL]))
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityTitle)
                .WithMany(x => x.EnumerableTitleUrl)
                .HasForeignKey(x => x.KeyTitle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.TITLE, StaticEntityNames.URL, StaticEntityNames.TITLE]));

            e.HasOne(x => x.EntityUrl)
                .WithMany(x => x.EnumerableTitleUrl)
                .HasForeignKey(x => x.KeyUrl)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.TITLE, StaticEntityNames.URL, StaticEntityNames.URL]));

            #endregion
        }
    }
}
