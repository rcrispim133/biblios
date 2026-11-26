using Br.Bibliography.Core.Constants.Impl.Biblio;
using Br.Bibliography.Core.Constants.Interfaces.Biblio;
using Br.Bibliography.Core.Util.Static;
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
            var e = builder.Entity<EntityImage>();

            // Table
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextName)
                .HasColumnOrder(order++)
                .HasMaxLength(Constant.ConstantMaxText)
                .IsRequired();

            e.Property(x => x.Raw)
                .HasColumnName("raw_image")
                .HasColumnOrder(order++)
                .HasMaxLength(RawMax)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableBiblioImage)
                .WithOne(x => x.EntityImage)
                .HasForeignKey(x => x.KeyImage)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([ StaticEntityNames.IMAGE, StaticEntityNames.BIBLIO, StaticEntityNames.IMAGE ]));
        }
    }
}
