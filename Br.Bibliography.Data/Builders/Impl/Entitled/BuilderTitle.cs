using Br.Bibliography.Core.Constants.Impl.Entitled;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Entitled
{
    public class BuilderTitle : 
        BuilderText<BuilderTitle, EntityTitle, IConstantTitle>, 
        IBuilderTitle<BuilderTitle>
    {
        public override IConstantTitle Constant { get; init; } = ConstantTitle.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityTitle>();

            // Table
            e.ToTable("tbl_title");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_title");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_title").IsUnique();

            e.HasIndex(x => x.KeyEdition).HasDatabaseName("idx_key_title_edition").IsUnique(false);

            e.HasIndex(x => x.KeyPublisher).HasDatabaseName("idx_key_title_publisher").IsUnique(false);

            e.HasIndex(x => x.KeyLanguage).HasDatabaseName("idx_key_title_language").IsUnique(false);

            e.HasIndex(x => x.KeyYear).HasDatabaseName("idx_key_title_year").IsUnique(false);

            e.HasIndex(x => x.KeyDisclaimer).HasDatabaseName("idx_key_title_disclaimer").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_title")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_title")
                .HasMaxLength(DescMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityEdition)
                .WithMany(x => x.EnumerableTitle)
                .HasForeignKey(x => x.KeyEdition)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_title_edition");

            e.HasOne(x => x.EntityPublisher)
                .WithMany(x => x.EnumerableTitle)
                .HasForeignKey(x => x.KeyPublisher)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_title_publisher");

            e.HasOne(x => x.EntityLanguage)
                .WithMany(x => x.EnumerableTitle)
                .HasForeignKey(x => x.KeyLanguage)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_title_language");

            e.HasOne(x => x.EntityYear)
                .WithMany(x => x.EnumerableTitle)
                .HasForeignKey(x => x.KeyYear)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_title_year");

            e.HasOne(x => x.EntityDisclaimer)
                .WithMany(x => x.EnumerableTitle)
                .HasForeignKey(x => x.KeyDisclaimer)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_title_disclaimer");

            e.HasMany(x => x.EnumerableTitleUrl)
                .WithOne(x => x.EntityTitle)
                .HasForeignKey(x => x.KeyTitle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_title_title");

            e.HasMany(x => x.EnumerableTitleBiblio)
                .WithOne(x => x.EntityTitle)
                .HasForeignKey(x => x.KeyTitle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_title_biblio");
        }
    }
}
