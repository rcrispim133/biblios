using Br.Bibliography.Core.Constants.Impl.Series;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Core.Static;
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
            #region Entity

            var e = builder.Entity<EntityCourse>();

            #endregion

            #region Table

            e.ToTable(Constant.TableName);

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.KeyUnit)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.COURSE, StaticEntityNames.UNIT]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyPeriod)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.COURSE, StaticEntityNames.PERIOD]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyCycle)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.COURSE, StaticEntityNames.CYCLE]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyDuration)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.COURSE, StaticEntityNames.DURATION]))
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

            e.Property(x => x.KeyUnit)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.UNIT]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyPeriod)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.PERIOD]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyCycle)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.CYCLE]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyDuration)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.DURATION]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextColumnName)
                .HasMaxLength(Constant.DefaultTextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityUnit)
                .WithMany(x => x.EnumerableCourse)
                .HasForeignKey(x => x.KeyUnit)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.COURSE, StaticEntityNames.UNIT]));

            e.HasOne(x => x.EntityPeriod)
                .WithMany(x => x.EnumerableCourse)
                .HasForeignKey(x => x.KeyPeriod)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.COURSE, StaticEntityNames.PERIOD]));

            e.HasOne(x => x.EntityCycle)
                .WithMany(x => x.EnumerableCourse)
                .HasForeignKey(x => x.KeyCycle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.COURSE, StaticEntityNames.CYCLE]));

            e.HasOne(x => x.EntityDuration)
                .WithMany(x => x.EnumerableCourse)
                .HasForeignKey(x => x.KeyDuration)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.COURSE, StaticEntityNames.DURATION]));

            e.HasMany(x => x.EnumerableLectureCourse)
                .WithOne(x => x.EntityCourse)
                .HasForeignKey(x => x.KeyCourse)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.COURSE, StaticEntityNames.LECTURE, StaticEntityNames.COURSE]));

            #endregion
        }
    }
}