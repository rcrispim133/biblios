using Br.Bibliography.Core.Constants.Impl.Alumni;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Alumni
{
    public class BuilderTeacher : BuilderText<BuilderTeacher, EntityTeacher, ConstantTeacher>, IBuilderTeacher<BuilderTeacher>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityTeacher>();

            // Table
            e.ToTable("tbl_teacher");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_teacher");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_teacher").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_teacher")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_teacher")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableLectureTeacher)
                .WithOne(x => x.EntityTeacher)
                .HasForeignKey(x => x.KeyTeacher)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_teacher_lecture");
        }
    }
}
