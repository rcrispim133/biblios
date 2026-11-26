using Br.Bibliography.Core.Constants.Impl.Duo;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
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
            var e = builder.Entity<EntityBiblioAuthor>();

            // Table
            e.ToTable("tbl_biblio_author");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_biblio_author");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_biblio_author").IsUnique();
            
            e.HasIndex(x => x.KeyBiblio).HasDatabaseName("idx_key_biblio_author_biblio").IsUnique(false);
            
            e.HasIndex(x => x.KeyAuthor).HasDatabaseName("idx_key_biblio_author_author").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_biblio_author")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyBiblio)
                .HasColumnName("key_biblio")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyAuthor)
                .HasColumnName("key_author")
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityBiblio)
                .WithMany(x => x.EnumerableBiblioAuthor)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_biblio_author_biblio");

            e.HasOne(x => x.EntityAuthor)
                .WithMany(x => x.EnumerableBiblioAuthor)
                .HasForeignKey(x => x.KeyAuthor)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_biblio_author_author");
        }
    }
}
