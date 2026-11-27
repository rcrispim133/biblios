using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;


namespace Br.Bibliography.Data.Builders.Impl.Biblio
{
    public class BuilderAuthor : BuilderAcronym<BuilderAuthor, EntityAuthor>, IBuilderAuthor<BuilderAuthor>
    {
        public override string[] EntityNameParts => [Constant.Base.AUTHOR];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityAuthor>();

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

            e.Property(x => x.Acronym)
                .HasColumnName(Fluent.AcronymColumnNameFromParams(EntityNameParts))
                .HasMaxLength(Constant.Max.MaxAcronym)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Fluent.TextColumnNameFromParams(EntityNameParts))
                .HasColumnOrder(order++)
                .HasMaxLength(Constant.Max.MaxText)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasMany(x => x.EnumerableBiblioAuthor)
                .WithOne(x => x.EntityAuthor)
                .HasForeignKey(x => x.KeyAuthor)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.AUTHOR, Constant.Base.BIBLIO, Constant.Base.AUTHOR ]));

            #endregion
        }
    }
}
