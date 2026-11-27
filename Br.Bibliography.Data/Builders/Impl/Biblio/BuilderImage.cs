using Br.Bibliography.Core.Constants.Impl.Biblio;
using Br.Bibliography.Core.Constants.Interfaces.Biblio;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Biblio
{
    public class BuilderImage : BuilderRaw<BuilderImage, EntityImage, IConstantImage>, IBuilderImage<BuilderImage>
    {
        public override IConstantImage Constant { get; init; } = ConstantImage.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityImage>();

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

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextColumnName)
                .HasColumnOrder(order++)
                .HasMaxLength(Constant.DefaultTextMaxLength)
                .IsRequired();

            e.Property(x => x.Raw)
                .HasColumnName(Constant.RawColumnName([ StaticEntityNames.IMAGE ]))
                .HasColumnOrder(order++)
                .HasMaxLength(Constant.DefaultMaxRaw)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasMany(x => x.EnumerableBiblioImage)
                .WithOne(x => x.EntityImage)
                .HasForeignKey(x => x.KeyImage)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.IMAGE, StaticEntityNames.BIBLIO, StaticEntityNames.IMAGE ]));

            #endregion
        }
    }
}
