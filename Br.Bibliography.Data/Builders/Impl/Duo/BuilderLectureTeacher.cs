using Br.Bibliography.Core.Constants.Impl.Duo;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderLectureTeacher : 
        BuilderBase<BuilderLectureTeacher, EntityLectureTeacher, IConstantLectureTeacher>, 
        IBuilderLectureTeacher<BuilderLectureTeacher>
    {
        public override IConstantLectureTeacher Constant { get; init; } = ConstantLectureTeacher.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityLectureTeacher>();

            // Table
            e.ToTable("tbl_lecture_teacher");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_lecture_teacher");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_lecture_teacher").IsUnique();
            
            e.HasIndex(x => x.KeyLecture).HasDatabaseName("idx_key_lecture_teacher_lecture").IsUnique(false);
            
            e.HasIndex(x => x.KeyTeacher).HasDatabaseName("idx_key_lecture_teacher_teacher").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_lecture_teacher")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyLecture)
                .HasColumnName("key_lecture")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyTeacher)
                .HasColumnName("key_teacher")
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityLecture)
                .WithMany(x => x.EnumerableLectureTeacher)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_lecture_teacher_lecture");

            e.HasOne(x => x.EntityTeacher)
                .WithMany(x => x.EnumerableLectureTeacher)
                .HasForeignKey(x => x.KeyTeacher)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_lecture_teacher_teacher");
        }
    }
}
