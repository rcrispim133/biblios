using Br.Bibliography.Core.Constants.Impl.Duo;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Core.Static;
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
            #region Entity

            var e = builder.Entity<EntityLectureTeacher>();

            #endregion

            #region Table

            e.ToTable(Constant.TableName);

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.KeyLecture)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.LECTURE, StaticEntityNames.TEACHER, StaticEntityNames.LECTURE]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyTeacher)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.LECTURE, StaticEntityNames.TEACHER, StaticEntityNames.TEACHER]))
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

            e.Property(x => x.KeyLecture)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.LECTURE]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyTeacher)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.TEACHER]))
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityLecture)
                .WithMany(x => x.EnumerableLectureTeacher)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.LECTURE, StaticEntityNames.TEACHER, StaticEntityNames.LECTURE]));

            e.HasOne(x => x.EntityTeacher)
                .WithMany(x => x.EnumerableLectureTeacher)
                .HasForeignKey(x => x.KeyTeacher)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.LECTURE, StaticEntityNames.TEACHER, StaticEntityNames.TEACHER]));

            #endregion
        }
    }
}
