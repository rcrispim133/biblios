using Br.Bibliography.Core.Constants.Impl.Entitled;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Entitled
{
    public class BuilderTitle : 
        BuilderText<BuilderTitle, EntityTitle, IConstantTitle>, 
        IBuilderTitle<BuilderTitle>
    {
        public override IConstantTitle Constant { get; init; } = ConstantTitle.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityTitle>();

            #endregion

            #region Table

            e.ToTable(Constant.TableName);

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.KeyEdition)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.TITLE, StaticEntityNames.EDITION]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyPublisher)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.TITLE, StaticEntityNames.PUBLISHER]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyLanguage)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.TITLE, StaticEntityNames.LANGUAGE]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyYear)
               .HasDatabaseName(Constant.IndexDatabaseName(
                   [StaticEntityNames.TITLE, StaticEntityNames.YEAR]))
               .IsUnique(false);

            e.HasIndex(x => x.KeyDisclaimer)
               .HasDatabaseName(Constant.IndexDatabaseName(
                   [StaticEntityNames.TITLE, StaticEntityNames.DISCLAIMER]))
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

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextColumnName)
                .HasMaxLength(Constant.DefaultTextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityEdition)
                .WithMany(x => x.EnumerableTitle)
                .HasForeignKey(x => x.KeyEdition)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([StaticEntityNames.TITLE, StaticEntityNames.EDITION]));

            e.HasOne(x => x.EntityPublisher)
                .WithMany(x => x.EnumerableTitle)
                .HasForeignKey(x => x.KeyPublisher)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([StaticEntityNames.TITLE, StaticEntityNames.PUBLISHER]));

            e.HasOne(x => x.EntityLanguage)
                .WithMany(x => x.EnumerableTitle)
                .HasForeignKey(x => x.KeyLanguage)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([StaticEntityNames.TITLE, StaticEntityNames.LANGUAGE]));

            e.HasOne(x => x.EntityYear)
                .WithMany(x => x.EnumerableTitle)
                .HasForeignKey(x => x.KeyYear)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([StaticEntityNames.TITLE, StaticEntityNames.YEAR]));

            e.HasOne(x => x.EntityDisclaimer)
                .WithMany(x => x.EnumerableTitle)
                .HasForeignKey(x => x.KeyDisclaimer)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([StaticEntityNames.TITLE, StaticEntityNames.DISCLAIMER]));

            e.HasMany(x => x.EnumerableTitleUrl)
                .WithOne(x => x.EntityTitle)
                .HasForeignKey(x => x.KeyTitle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([StaticEntityNames.TITLE, StaticEntityNames.TITLE, StaticEntityNames.URL]));

            e.HasMany(x => x.EnumerableTitleBiblio)
                .WithOne(x => x.EntityTitle)
                .HasForeignKey(x => x.KeyTitle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([StaticEntityNames.TITLE, StaticEntityNames.TITLE, StaticEntityNames.BIBLIO]));

            #endregion
        }
    }
}
