using Br.Bibliography.Core.Constants.Impl.Duo;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderTitleBiblio : 
        BuilderBase<BuilderTitleBiblio, EntityTitleBiblio, IConstantTitleBiblio>, 
        IBuilderTitleBiblio<BuilderTitleBiblio>
    {
        public override IConstantTitleBiblio Constant { get; init; } = ConstantTitleBiblio.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityTitleBiblio>();

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
                    [StaticEntityNames.TITLE, StaticEntityNames.BIBLIO, StaticEntityNames.TITLE]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyBiblio)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.TITLE, StaticEntityNames.BIBLIO, StaticEntityNames.BIBLIO]))
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

            e.Property(x => x.KeyBiblio)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.BIBLIO]))
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityTitle)
                .WithMany(x => x.EnumerableTitleBiblio)
                .HasForeignKey(x => x.KeyTitle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([StaticEntityNames.TITLE, StaticEntityNames.BIBLIO, StaticEntityNames.TITLE]));

            e.HasOne(x => x.EntityBiblio)
                .WithMany(x => x.EnumerableTitleBiblio)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([StaticEntityNames.TITLE, StaticEntityNames.BIBLIO, StaticEntityNames.BIBLIO]));

            #endregion
        }
    }
}
