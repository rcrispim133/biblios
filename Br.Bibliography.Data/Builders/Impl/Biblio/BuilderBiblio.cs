using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Biblio
{
    public class BuilderBiblio : BuilderBase<BuilderBiblio, EntityBiblio>, IBuilderBiblio<BuilderBiblio>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityBiblio>();

            // Table
            e.ToTable("tbl_biblio");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_biblio");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_biblio").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_biblio")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableBiblioAuthor)
                .WithOne(x => x.EntityBiblio)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_biblio_author");

            e.HasMany(x => x.EnumerableTitleBiblio)
                .WithOne(x => x.EntityBiblio)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_biblio_title");

            e.HasMany(x => x.EnumerableBiblioImage)
                .WithOne(x => x.EntityBiblio)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_biblio_image");

            e.HasMany(x => x.EnumerableBiblioLecture)
                .WithOne(x => x.EntityBiblio)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_biblio_lecture");
        }
    }
}
