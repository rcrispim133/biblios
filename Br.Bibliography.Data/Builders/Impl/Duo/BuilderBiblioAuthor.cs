using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Constants.Impl;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;


namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderBiblioAuthor : 
        BuilderBase<BuilderBiblioAuthor, EntityBiblioAuthor>, 
        IBuilderBiblioAuthor<BuilderBiblioAuthor>
    {
        public override string[] EntityNameParts => [Constant.Base.BIBLIO, Constant.Base.AUTHOR];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityBiblioAuthor>();

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
                    [ Constant.Base.BIBLIO, Constant.Base.AUTHOR, Constant.Base.BIBLIO]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyAuthor)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.BIBLIO, Constant.Base.AUTHOR, Constant.Base.AUTHOR]))
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
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([ Constant.Base.BIBLIO ]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyAuthor)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.AUTHOR]))
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityBiblio)
                .WithMany(x => x.EnumerableBiblioAuthor)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.BIBLIO, Constant.Base.AUTHOR, Constant.Base.BIBLIO]));

            e.HasOne(x => x.EntityAuthor)
                .WithMany(x => x.EnumerableBiblioAuthor)
                .HasForeignKey(x => x.KeyAuthor)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.BIBLIO, Constant.Base.AUTHOR, Constant.Base.AUTHOR]));
            
            #endregion
        }
    }
}
