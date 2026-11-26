using Br.Bibliography.Core.Constants.Impl.Biblio;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Biblio
{
    public class BuilderAuthor : BuilderAcronym<BuilderAuthor, EntityAuthor, ConstantAuthor>, IBuilderAuthor<BuilderAuthor>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityAuthor>();

            // Table
            e.ToTable("tbl_author");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_author");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_author").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_author")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Acronym)
                .HasColumnName("acronym_author")
                .HasMaxLength(AcronymMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_author")
                .HasColumnOrder(order++)
                .HasMaxLength(TextMaxLength)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableBiblioAuthor)
                .WithOne(x => x.EntityAuthor)
                .HasForeignKey(x => x.KeyAuthor)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_author_biblio");
        }
    }
}
