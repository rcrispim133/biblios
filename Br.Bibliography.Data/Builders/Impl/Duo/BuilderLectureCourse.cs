using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderLectureCourse : 
        BuilderBase<BuilderLectureCourse, EntityLectureCourse>, 
        IBuilderLectureCourse<BuilderLectureCourse>
    {
        public override string[] EntityNameParts => [Constant.Base.LECTURE, Constant.Base.COURSE];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityLectureCourse>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Fluent.PrimaryKeyConstraintFromParams(EntityNameParts));

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Fluent.PrimaryKeyIndexFromParams(EntityNameParts)).IsUnique();

            e.HasIndex(x => x.KeyLecture)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.LECTURE, Constant.Base.COURSE, Constant.Base.LECTURE]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyCourse)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.LECTURE, Constant.Base.COURSE, Constant.Base.COURSE]))
                .IsUnique(false);

            #endregion

            #region Order

            var order = Constant.Math.Zero;

            #endregion

            #region Properties

            e.Property(x => x.Key)
                .HasColumnName(Fluent.KeyColumnNameFromParams(EntityNameParts))
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyLecture)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.LECTURE]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyCourse)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.COURSE]))
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityLecture)
                .WithMany(x => x.EnumerableLectureCourse)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.LECTURE, Constant.Base.COURSE, Constant.Base.LECTURE]));

            e.HasOne(x => x.EntityCourse)
                .WithMany(x => x.EnumerableLectureCourse)
                .HasForeignKey(x => x.KeyCourse)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.LECTURE, Constant.Base.COURSE, Constant.Base.COURSE]));

            #endregion
        }
    }
}
