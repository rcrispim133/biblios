
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Series;
using Microsoft.EntityFrameworkCore;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Model.Entities.Impl.Series;
using Br.Bibliography.Util.Fluent.Base;

namespace Br.Bibliography.Data.Builders.Impl.Series
{
    public class BuilderCourse : 
        BuilderAcronymDesc<BuilderCourse, EntityCourse>, 
        IBuilderCourse<BuilderCourse>
    {
        public override string[] EntityNameParts => [Constant.Base.COURSE];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityCourse>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Fluent.PrimaryKeyConstraintFromParams(EntityNameParts));

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Fluent.PrimaryKeyIndexFromParams(EntityNameParts)).IsUnique();

            e.HasIndex(x => x.KeyUnit)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.COURSE, Constant.Base.UNIT]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyPeriod)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.COURSE, Constant.Base.PERIOD]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyCycle)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.COURSE, Constant.Base.CYCLE]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyDuration)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.COURSE, Constant.Base.DURATION]))
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

            e.Property(x => x.KeyUnit)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.UNIT]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyPeriod)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.PERIOD]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyCycle)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.CYCLE]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyDuration)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.DURATION]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Fluent.TextColumnNameFromParams(EntityNameParts))
                .HasMaxLength(Constant.Max.MaxText)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityUnit)
                .WithMany(x => x.EnumerableCourse)
                .HasForeignKey(x => x.KeyUnit)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.COURSE, Constant.Base.UNIT]));

            e.HasOne(x => x.EntityPeriod)
                .WithMany(x => x.EnumerableCourse)
                .HasForeignKey(x => x.KeyPeriod)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.COURSE, Constant.Base.PERIOD]));

            e.HasOne(x => x.EntityCycle)
                .WithMany(x => x.EnumerableCourse)
                .HasForeignKey(x => x.KeyCycle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.COURSE, Constant.Base.CYCLE]));

            e.HasOne(x => x.EntityDuration)
                .WithMany(x => x.EnumerableCourse)
                .HasForeignKey(x => x.KeyDuration)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.COURSE, Constant.Base.DURATION]));

            e.HasMany(x => x.EnumerableLectureCourse)
                .WithOne(x => x.EntityCourse)
                .HasForeignKey(x => x.KeyCourse)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.COURSE, Constant.Base.LECTURE, Constant.Base.COURSE]));

            #endregion
        }
    }
}