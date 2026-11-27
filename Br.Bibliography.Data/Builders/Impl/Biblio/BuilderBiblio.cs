using Br.Bibliography.Core.Constants.Impl.Biblio;
using Br.Bibliography.Core.Constants.Interfaces.Biblio;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Biblio
{
    public class BuilderBiblio : BuilderBase<BuilderBiblio, EntityBiblio, IConstantBiblio>, IBuilderBiblio<BuilderBiblio>
    {
        public override IConstantBiblio Constant { get; init; } = ConstantBiblio.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityBiblio>();

            #endregion

            #region Table

            e.ToTable(Constant.TableName);

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

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

            #endregion

            #region Relationships

            e.HasMany(x => x.EnumerableBiblioAuthor)
                .WithOne(x => x.EntityBiblio)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.BIBLIO, StaticEntityNames.BIBLIO, StaticEntityNames.AUTHOR ]));

            e.HasMany(x => x.EnumerableTitleBiblio)
                .WithOne(x => x.EntityBiblio)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.BIBLIO, StaticEntityNames.TITLE, StaticEntityNames.BIBLIO ]));

            e.HasMany(x => x.EnumerableBiblioImage)
                .WithOne(x => x.EntityBiblio)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.BIBLIO, StaticEntityNames.BIBLIO, StaticEntityNames.IMAGE ]));

            e.HasMany(x => x.EnumerableBiblioLecture)
                .WithOne(x => x.EntityBiblio)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.BIBLIO, StaticEntityNames.BIBLIO, StaticEntityNames.LECTURE ]));

            #endregion
        }
    }
}
