using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Alumni
{
    public class BuilderWork : BuilderText<BuilderWork, EntityWork>, IBuilderWork<BuilderWork>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityWork>();

            // Table
            e.ToTable("tbl_work");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_work");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_work").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_work")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_work")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableLecture)
                .WithOne(x => x.EntityWork)
                .HasForeignKey(x => x.KeyWork)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_work_lecture");



        }
    }
}
