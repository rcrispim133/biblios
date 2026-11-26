using Br.Bibliography.Core.Constants.Impl.Duo;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderBiblioImage : 
        BuilderBase<BuilderBiblioImage, EntityBiblioImage, IConstantBiblioImage>, 
        IBuilderBiblioImage<BuilderBiblioImage>
    {
        public override IConstantBiblioImage Constant { get; init; } = ConstantBiblioImage.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityBiblioImage>();

            // Table
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();
            
            e.HasIndex(x => x.KeyBiblio).HasDatabaseName("idx_key_biblio_image_biblio").IsUnique(false);
            
            e.HasIndex(x => x.KeyImage).HasDatabaseName("idx_key_biblio_image_image").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyBiblio)
                .HasColumnName("key_biblio")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyImage)
                .HasColumnName("key_image")
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityBiblio)
                .WithMany(x => x.EnumerableBiblioImage)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.BIBLIO, StaticEntityNames.IMAGE, StaticEntityNames.BIBLIO]));

            e.HasOne(x => x.EntityImage)
                .WithMany(x => x.EnumerableBiblioImage)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.BIBLIO, StaticEntityNames.IMAGE, StaticEntityNames.IMAGE]));
        }
    }
}
