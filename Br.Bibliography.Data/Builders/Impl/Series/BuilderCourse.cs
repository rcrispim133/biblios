using Br.Bibliography.Core.Constants.Impl.Series;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Series
{
    public class BuilderCourse : 
        BuilderAcronymDesc<BuilderCourse, EntityCourse, IConstantCourse>, 
        IBuilderCourse<BuilderCourse>
    {
        public override IConstantCourse Constant { get; init; } = ConstantCourse.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityCourse>();

            // Table
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.KeyUnit).HasDatabaseName("idx_key_course_unit").IsUnique(false);

            e.HasIndex(x => x.KeyPeriod).HasDatabaseName("idx_key_course_period").IsUnique(false);

            e.HasIndex(x => x.KeyCycle).HasDatabaseName("idx_key_course_cycle").IsUnique(false);

            e.HasIndex(x => x.KeyDuration).HasDatabaseName("idx_key_course_duration").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyUnit)
                .HasColumnName("key_unit")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyPeriod)
                .HasColumnName("key_period")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyCycle)
                .HasColumnName("key_cycle")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyDuration)
                .HasColumnName("key_duration")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextName)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityUnit)
                .WithMany(x => x.EnumerableCourse)
                .HasForeignKey(x => x.KeyUnit)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.COURSE, StaticEntityNames.UNIT]));

            e.HasOne(x => x.EntityPeriod)
                .WithMany(x => x.EnumerableCourse)
                .HasForeignKey(x => x.KeyPeriod)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.COURSE, StaticEntityNames.PERIOD]));

            e.HasOne(x => x.EntityCycle)
                .WithMany(x => x.EnumerableCourse)
                .HasForeignKey(x => x.KeyCycle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.COURSE, StaticEntityNames.CYCLE]));

            e.HasOne(x => x.EntityDuration)
                .WithMany(x => x.EnumerableCourse)
                .HasForeignKey(x => x.KeyDuration)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.COURSE, StaticEntityNames.DURATION]));

            e.HasMany(x => x.EnumerableLectureCourse)
                .WithOne(x => x.EntityCourse)
                .HasForeignKey(x => x.KeyCourse)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.COURSE, StaticEntityNames.LECTURE, StaticEntityNames.COURSE]));
        }
    }
}