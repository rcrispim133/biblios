using Br.Bibliography.Core.Constants.Impl.Duo;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderLectureCourse : 
        BuilderBase<BuilderLectureCourse, EntityLectureCourse, IConstantLectureCourse>, 
        IBuilderLectureCourse<BuilderLectureCourse>
    {
        public override IConstantLectureCourse Constant { get; init; } = ConstantLectureCourse.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityLectureCourse>();

            // Table
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();
            
            e.HasIndex(x => x.KeyLecture).HasDatabaseName("idx_key_lecture_course_lecture").IsUnique(false);
            
            e.HasIndex(x => x.KeyCourse).HasDatabaseName("idx_key_lecture_course_course").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyLecture)
                .HasColumnName("key_lecture")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyCourse)
                .HasColumnName("key_course")
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityLecture)
                .WithMany(x => x.EnumerableLectureCourse)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_lecture_course_lecture");

            e.HasOne(x => x.EntityCourse)
                .WithMany(x => x.EnumerableLectureCourse)
                .HasForeignKey(x => x.KeyCourse)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_lecture_course_course");
        }
    }
}
