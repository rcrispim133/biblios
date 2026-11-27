using Br.Bibliography.Core.Constants.Impl.Biblio;
using Br.Bibliography.Core.Constants.Interfaces.Biblio;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Biblio
{
    public class BuilderAuthor : BuilderAcronym<BuilderAuthor, EntityAuthor, IConstantAuthor>, IBuilderAuthor<BuilderAuthor>
    {
        public override IConstantAuthor Constant { get; init; } = ConstantAuthor.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityAuthor>();

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

            e.Property(x => x.Acronym)
                .HasColumnName(Constant.PropertyAcronymColumnName)
                .HasMaxLength(Constant.DefaultMaxAcronym)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextColumnName)
                .HasColumnOrder(order++)
                .HasMaxLength(Constant.DefaultTextMaxLength)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasMany(x => x.EnumerableBiblioAuthor)
                .WithOne(x => x.EntityAuthor)
                .HasForeignKey(x => x.KeyAuthor)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.AUTHOR, StaticEntityNames.BIBLIO, StaticEntityNames.AUTHOR ]));

            #endregion
        }
    }
}
