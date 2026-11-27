using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;


namespace Br.Bibliography.Data.Builders.Impl.Biblio
{
    public class BuilderImage : BuilderRaw<BuilderImage, EntityImage>, IBuilderImage<BuilderImage>
    {
        public override string[] EntityNameParts => [Constant.Base.IMAGE];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityImage>();

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

            e.Property(x => x.Text)
                .HasColumnName(Fluent.TextColumnNameFromParams(EntityNameParts))
                .HasColumnOrder(order++)
                .HasMaxLength(Constant.Max.MaxText)
                .IsRequired();

            e.Property(x => x.Raw)
                .HasColumnName(Fluent.RawColumnNameFromParams([ Constant.Base.IMAGE ]))
                .HasColumnOrder(order++)
                .HasMaxLength(Constant.Max.MaxRaw)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasMany(x => x.EnumerableBiblioImage)
                .WithOne(x => x.EntityImage)
                .HasForeignKey(x => x.KeyImage)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.IMAGE, Constant.Base.BIBLIO, Constant.Base.IMAGE ]));

            #endregion
        }
    }
}
