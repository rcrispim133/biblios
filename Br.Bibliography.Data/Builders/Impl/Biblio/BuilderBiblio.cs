using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Constants.Impl;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;


namespace Br.Bibliography.Data.Builders.Impl.Biblio
{
    public class BuilderBiblio : BuilderBase<BuilderBiblio, EntityBiblio>, IBuilderBiblio<BuilderBiblio>
    {
        public override string[] EntityNameParts => [Constant.Base.BIBLIO];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityBiblio>();

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

            #endregion

            #region Relationships

            e.HasMany(x => x.EnumerableBiblioAuthor)
                .WithOne(x => x.EntityBiblio)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.BIBLIO, Constant.Base.BIBLIO, Constant.Base.AUTHOR ]));

            e.HasMany(x => x.EnumerableTitleBiblio)
                .WithOne(x => x.EntityBiblio)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.BIBLIO, Constant.Base.TITLE, Constant.Base.BIBLIO ]));

            e.HasMany(x => x.EnumerableBiblioImage)
                .WithOne(x => x.EntityBiblio)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.BIBLIO, Constant.Base.BIBLIO, Constant.Base.IMAGE ]));

            e.HasMany(x => x.EnumerableBiblioLecture)
                .WithOne(x => x.EntityBiblio)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.BIBLIO, Constant.Base.BIBLIO, Constant.Base.LECTURE ]));

            #endregion
        }
    }
}
