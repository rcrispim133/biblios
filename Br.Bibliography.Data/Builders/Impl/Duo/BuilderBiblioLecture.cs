using Br.Bibliography.Core.Constants.Impl.Duo;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderBiblioLecture : 
        BuilderBase<BuilderBiblioLecture, EntityBiblioLecture, ConstantBiblioLecture>, 
        IBuilderBiblioLecture<BuilderBiblioLecture>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityBiblioLecture>();

            // Table
            e.ToTable("tbl_biblio_lecture");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_biblio_lecture");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_biblio_lecture").IsUnique();
            
            e.HasIndex(x => x.KeyBiblio).HasDatabaseName("idx_key_biblio_lecture_biblio").IsUnique(false);
            
            e.HasIndex(x => x.KeyLecture).HasDatabaseName("idx_key_biblio_lecture_lecture").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_biblio_lecture")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyBiblio)
                .HasColumnName("key_biblio")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyLecture)
                .HasColumnName("key_lecture")
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityBiblio)
                .WithMany(x => x.EnumerableBiblioLecture)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_biblio_lecture_biblio");

            e.HasOne(x => x.EntityLecture)
                .WithMany(x => x.EnumerableBiblioLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_biblio_lecture_lecture");
        }
    }
}
