using Br.Bibliography.Core.Constants.Impl.Alumni;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Alumni
{
    public class BuilderLecture : BuilderAcronym<BuilderLecture, EntityLecture, IConstantLecture>, IBuilderLecture<BuilderLecture>
    {
        public override IConstantLecture Constant { get; init; } = ConstantLecture.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityLecture>();

            // Table
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.KeyCredit).HasDatabaseName("idx_key_lecture_credit").IsUnique(false);

            e.HasIndex(x => x.KeyWork).HasDatabaseName("idx_key_lecture_work").IsUnique(false);

            e.HasIndex(x => x.KeyEffort).HasDatabaseName("idx_key_lecture_effort").IsUnique(false);

            e.HasIndex(x => x.KeyType).HasDatabaseName("idx_key_lecture_type").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyColumnName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyCredit)
                .HasColumnName("key_credit")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyWork)
                .HasColumnName("key_work")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyEffort)
                .HasColumnName("key_effort")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyType)
                .HasColumnName("key_type")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Acronym)
                .HasColumnName("acronym_lecture")
                .HasMaxLength(Constant.PropertyAcronymMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextColumnName)
                .HasMaxLength(Constant.PropertyTextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Translate)
                .HasColumnName("trans_lecture")
                .HasMaxLength(144)
                .HasColumnOrder(order++)
                .IsRequired(false);

            e.Property(x => x.Activation)
                .HasColumnName("dt_act_lecture")
                .HasColumnOrder(order++)
                .IsRequired(false);

            e.Property(x => x.Deactivation)
                .HasColumnName("dt_deact_lecture")
                .HasColumnOrder(order++)
                .IsRequired(false);

            // Relationships
            e.HasOne(x => x.EntityCredit)
                .WithMany(x => x.EnumerableLecture)
                .HasForeignKey(x => x.KeyCredit)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([ StaticEntityNames.LECTURE, StaticEntityNames.CREDIT ]));

            e.HasOne(x => x.EntityWork)
                .WithMany(x => x.EnumerableLecture)
                .HasForeignKey(x => x.KeyWork)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([ StaticEntityNames.LECTURE, StaticEntityNames.WORK ]));

            e.HasOne(x => x.EntityEffort)
                .WithMany(x => x.EnumerableLecture)
                .HasForeignKey(x => x.KeyEffort)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([ StaticEntityNames.LECTURE, StaticEntityNames.EFFORT ]));

            e.HasOne(x => x.EntityType)
                .WithMany(x => x.EnumerableLecture)
                .HasForeignKey(x => x.KeyType)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([ StaticEntityNames.LECTURE, StaticEntityNames.TYPE ]));

            e.HasMany(x => x.EnumerableBiblioLecture)
                .WithOne(x => x.EntityLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([ StaticEntityNames.LECTURE, StaticEntityNames.BIBLIO, StaticEntityNames.LECTURE ]));

            e.HasMany(x => x.EnumerableSection)
                .WithOne(x => x.EntityLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([ StaticEntityNames.LECTURE, StaticEntityNames.SECTION ]));

            e.HasMany(x => x.EnumerableLectureTeacher)
                .WithOne(x => x.EntityLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([ StaticEntityNames.LECTURE, StaticEntityNames.TEACHER, StaticEntityNames.LECTURE ]));

            e.HasMany(x => x.EnumerableLectureCourse)
                .WithOne(x => x.EntityLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([ StaticEntityNames.LECTURE, StaticEntityNames.LECTURE, StaticEntityNames.COURSE ]));

            e.HasMany(x => x.EnumerableLecturePre)
                .WithOne(x => x.EntityLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([ StaticEntityNames.LECTURE, StaticEntityNames.LECTURE , StaticEntityNames.PRE ]));
        }
    }
}
