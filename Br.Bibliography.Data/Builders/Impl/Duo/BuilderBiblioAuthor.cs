using Br.Bibliography.Core.Constants.Impl.Duo;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderBiblioAuthor : 
        BuilderBase<BuilderBiblioAuthor, EntityBiblioAuthor, IConstantBiblioAuthor>, 
        IBuilderBiblioAuthor<BuilderBiblioAuthor>
    {
        public override IConstantBiblioAuthor Constant { get; init; } = ConstantBiblioAuthor.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityBiblioAuthor>();

            #endregion

            #region Table

            e.ToTable(Constant.TableName);

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.KeyBiblio)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [ StaticEntityNames.BIBLIO, StaticEntityNames.AUTHOR, StaticEntityNames.BIBLIO]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyAuthor)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.BIBLIO, StaticEntityNames.AUTHOR, StaticEntityNames.AUTHOR]))
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

            e.Property(x => x.KeyBiblio)
                .HasColumnName(Constant.ForeignKeyColumnName([ StaticEntityNames.BIBLIO ]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyAuthor)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.AUTHOR]))
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityBiblio)
                .WithMany(x => x.EnumerableBiblioAuthor)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.BIBLIO, StaticEntityNames.AUTHOR, StaticEntityNames.BIBLIO]));

            e.HasOne(x => x.EntityAuthor)
                .WithMany(x => x.EnumerableBiblioAuthor)
                .HasForeignKey(x => x.KeyAuthor)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.BIBLIO, StaticEntityNames.AUTHOR, StaticEntityNames.AUTHOR]));
            
            #endregion
        }
    }
}
