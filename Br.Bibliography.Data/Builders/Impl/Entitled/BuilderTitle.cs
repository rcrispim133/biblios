using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;


namespace Br.Bibliography.Data.Builders.Impl.Entitled
{
    public class BuilderTitle : 
        BuilderText<BuilderTitle, EntityTitle>, 
        IBuilderTitle<BuilderTitle>
    {
        public override string[] EntityNameParts => [Constant.Base.TITLE];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityTitle>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Fluent.PrimaryKeyConstraintFromParams(EntityNameParts));

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Fluent.PrimaryKeyIndexFromParams(EntityNameParts)).IsUnique();

            e.HasIndex(x => x.KeyEdition)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.TITLE, Constant.Base.EDITION]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyPublisher)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.TITLE, Constant.Base.PUBLISHER]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyLanguage)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.TITLE, Constant.Base.LANGUAGE]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyYear)
               .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                   [Constant.Base.TITLE, Constant.Base.YEAR]))
               .IsUnique(false);

            e.HasIndex(x => x.KeyDisclaimer)
               .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                   [Constant.Base.TITLE, Constant.Base.DISCLAIMER]))
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

            e.Property(x => x.Text)
                .HasColumnName(Fluent.TextColumnNameFromParams(EntityNameParts))
                .HasMaxLength(Constant.Max.MaxText)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityEdition)
                .WithMany(x => x.EnumerableTitle)
                .HasForeignKey(x => x.KeyEdition)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.TITLE, Constant.Base.EDITION]));

            e.HasOne(x => x.EntityPublisher)
                .WithMany(x => x.EnumerableTitle)
                .HasForeignKey(x => x.KeyPublisher)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.TITLE, Constant.Base.PUBLISHER]));

            e.HasOne(x => x.EntityLanguage)
                .WithMany(x => x.EnumerableTitle)
                .HasForeignKey(x => x.KeyLanguage)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.TITLE, Constant.Base.LANGUAGE]));

            e.HasOne(x => x.EntityYear)
                .WithMany(x => x.EnumerableTitle)
                .HasForeignKey(x => x.KeyYear)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.TITLE, Constant.Base.YEAR]));

            e.HasOne(x => x.EntityDisclaimer)
                .WithMany(x => x.EnumerableTitle)
                .HasForeignKey(x => x.KeyDisclaimer)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.TITLE, Constant.Base.DISCLAIMER]));

            e.HasMany(x => x.EnumerableTitleUrl)
                .WithOne(x => x.EntityTitle)
                .HasForeignKey(x => x.KeyTitle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.TITLE, Constant.Base.TITLE, Constant.Base.URL]));

            e.HasMany(x => x.EnumerableTitleBiblio)
                .WithOne(x => x.EntityTitle)
                .HasForeignKey(x => x.KeyTitle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.TITLE, Constant.Base.TITLE, Constant.Base.BIBLIO]));

            #endregion
        }
    }
}
