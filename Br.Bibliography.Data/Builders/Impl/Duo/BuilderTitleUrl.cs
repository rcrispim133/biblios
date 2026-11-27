using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;


namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderTitleUrl : 
        BuilderBase<BuilderTitleUrl, EntityTitleUrl>, 
        IBuilderTitleUrl<BuilderTitleUrl>
    {
        public override string[] EntityNameParts => [Constant.Base.TITLE, Constant.Base.URL];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityTitleUrl>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Fluent.PrimaryKeyConstraintFromParams(EntityNameParts));

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Fluent.PrimaryKeyIndexFromParams(EntityNameParts)).IsUnique();

            e.HasIndex(x => x.KeyTitle)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.TITLE, Constant.Base.URL, Constant.Base.TITLE]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyUrl)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.TITLE, Constant.Base.URL, Constant.Base.URL]))
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

            e.Property(x => x.KeyTitle)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.TITLE]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyUrl)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.URL]))
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityTitle)
                .WithMany(x => x.EnumerableTitleUrl)
                .HasForeignKey(x => x.KeyTitle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.TITLE, Constant.Base.URL, Constant.Base.TITLE]));

            e.HasOne(x => x.EntityUrl)
                .WithMany(x => x.EnumerableTitleUrl)
                .HasForeignKey(x => x.KeyUrl)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.TITLE, Constant.Base.URL, Constant.Base.URL]));

            #endregion
        }
    }
}
