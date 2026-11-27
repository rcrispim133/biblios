using Br.Bibliography.Core.Constants.Impl.Alumni;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Core.Static;
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
            #region Entity

            var e = builder.Entity<EntityLecture>();

            #endregion

            #region Table

            e.ToTable(Constant.TableName);

            #endregion

            #region Key

            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            #endregion

            #region Index

            e.HasIndex(x => x.Key)
                .HasDatabaseName(Constant.PrimaryKeyIndexName)
                .IsUnique();

            e.HasIndex(x => x.KeyCredit)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.LECTURE, StaticEntityNames.CREDIT ]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyWork)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.LECTURE, StaticEntityNames.WORK]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyEffort)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.LECTURE, StaticEntityNames.EFFORT]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyEffort)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.LECTURE, StaticEntityNames.TYPE]))
                .IsUnique(false);

            #endregion

            #region Order

            var order = Constant.BaseOrder;

            #endregion

            #region Properties

            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyColumnName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyCredit)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.CREDIT]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyWork)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.WORK]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyEffort)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.EFFORT]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyType)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.TYPE]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Acronym)
                .HasColumnName(Constant.PropertyAcronymColumnName)
                .HasMaxLength(Constant.DefaultMaxAcronym)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextColumnName)
                .HasMaxLength(Constant.DefaultTextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Translate)
                .HasColumnName(Constant.TextColumnName([StaticPropertyNames.TRANSLATE, StaticEntityNames.LECTURE ]))
                .HasMaxLength(Constant.DefaultTextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired(false);

            e.Property(x => x.Activation)
                .HasColumnName(Constant.DateColumnName([ StaticPropertyNames.ACTIVATION, StaticEntityNames.LECTURE ]))
                .HasColumnOrder(order++)
                .IsRequired(false);

            e.Property(x => x.Deactivation)
                .HasColumnName(Constant.DateColumnName([StaticPropertyNames.DEACTIVATION, StaticEntityNames.LECTURE]))
                .HasColumnOrder(order++)
                .IsRequired(false);

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityCredit)
                .WithMany(x => x.EnumerableLecture)
                .HasForeignKey(x => x.KeyCredit)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.LECTURE, StaticEntityNames.CREDIT ]));

            e.HasOne(x => x.EntityWork)
                .WithMany(x => x.EnumerableLecture)
                .HasForeignKey(x => x.KeyWork)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.LECTURE, StaticEntityNames.WORK ]));

            e.HasOne(x => x.EntityEffort)
                .WithMany(x => x.EnumerableLecture)
                .HasForeignKey(x => x.KeyEffort)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.LECTURE, StaticEntityNames.EFFORT ]));

            e.HasOne(x => x.EntityType)
                .WithMany(x => x.EnumerableLecture)
                .HasForeignKey(x => x.KeyType)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.LECTURE, StaticEntityNames.TYPE ]));

            e.HasMany(x => x.EnumerableBiblioLecture)
                .WithOne(x => x.EntityLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.LECTURE, StaticEntityNames.BIBLIO, StaticEntityNames.LECTURE ]));

            e.HasMany(x => x.EnumerableSection)
                .WithOne(x => x.EntityLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.LECTURE, StaticEntityNames.SECTION ]));

            e.HasMany(x => x.EnumerableLectureTeacher)
                .WithOne(x => x.EntityLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.LECTURE, StaticEntityNames.TEACHER, StaticEntityNames.LECTURE ]));

            e.HasMany(x => x.EnumerableLectureCourse)
                .WithOne(x => x.EntityLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.LECTURE, StaticEntityNames.LECTURE, StaticEntityNames.COURSE ]));

            e.HasMany(x => x.EnumerableLecturePre)
                .WithOne(x => x.EntityLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.LECTURE, StaticEntityNames.LECTURE , StaticEntityNames.PRE ]));

            #endregion
        }
    }
}
