using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Sector
{
    public class BuilderSection : BuilderBase<BuilderSection, EntitySection>, IBuilderSection<BuilderSection>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntitySection>();

            // Table
            e.ToTable("tbl_section");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_section");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_section").IsUnique();

            e.HasIndex(x => x.KeyLecture).HasDatabaseName("idx_key_section_lecture").IsUnique();

            e.HasIndex(x => x.KeyDetail).HasDatabaseName("idx_key_section_detail").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_section")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyLecture)
                .HasColumnName("key_lecture")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyDetail)
                .HasColumnName("key_detail")
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityLecture)
                .WithMany(x => x.EnumerableSection)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_section_lecture");

            e.HasOne(x => x.EntityDetail)
                .WithMany(x => x.EnumerableSection)
                .HasForeignKey(x => x.KeyDetail)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_section_detail");

            e.HasMany(x => x.EnumerableLine)
                .WithOne(x => x.EntitySection)
                .HasForeignKey(x => x.KeySection)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_section_line");
        }
    }
}
