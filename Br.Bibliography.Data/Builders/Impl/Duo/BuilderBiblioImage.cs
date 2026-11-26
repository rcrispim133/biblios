using Br.Bibliography.Core.Constants.Impl.Duo;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderBiblioImage : 
        BuilderBase<BuilderBiblioImage, EntityBiblioImage, ConstantBiblioImage>, 
        IBuilderBiblioImage<BuilderBiblioImage>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityBiblioImage>();

            // Table
            e.ToTable("tbl_biblio_image");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_biblio_image");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_biblio_image").IsUnique();
            
            e.HasIndex(x => x.KeyBiblio).HasDatabaseName("idx_key_biblio_image_biblio").IsUnique(false);
            
            e.HasIndex(x => x.KeyImage).HasDatabaseName("idx_key_biblio_image_image").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_biblio_image")
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
                .HasConstraintName("fk_key_biblio_image_biblio");

            e.HasOne(x => x.EntityImage)
                .WithMany(x => x.EnumerableBiblioImage)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_biblio_image_image");
        }
    }
}
