using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Constants.Impl;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;


namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderBiblioImage : 
        BuilderBase<BuilderBiblioImage, EntityBiblioImage>, 
        IBuilderBiblioImage<BuilderBiblioImage>
    {
        public override string[] EntityNameParts => [Constant.Base.BIBLIO, Constant.Base.IMAGE];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityBiblioImage>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Fluent.PrimaryKeyConstraintFromParams(EntityNameParts));

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Fluent.PrimaryKeyIndexFromParams(EntityNameParts)).IsUnique();

            e.HasIndex(x => x.KeyBiblio)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.BIBLIO, Constant.Base.IMAGE, Constant.Base.BIBLIO]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyImage)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.BIBLIO, Constant.Base.IMAGE, Constant.Base.IMAGE]))
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

            e.Property(x => x.KeyBiblio)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.BIBLIO]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyImage)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.IMAGE]))
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityBiblio)
                .WithMany(x => x.EnumerableBiblioImage)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.BIBLIO, Constant.Base.IMAGE, Constant.Base.BIBLIO]));

            e.HasOne(x => x.EntityImage)
                .WithMany(x => x.EnumerableBiblioImage)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.BIBLIO, Constant.Base.IMAGE, Constant.Base.IMAGE]));

            #endregion
        }
    }
}
