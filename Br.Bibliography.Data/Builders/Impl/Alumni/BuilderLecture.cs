using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;


namespace Br.Bibliography.Data.Builders.Impl.Alumni
{
    public class BuilderLecture : BuilderAcronym<BuilderLecture, EntityLecture>, IBuilderLecture<BuilderLecture>
    {
        public override string[] EntityNameParts => [Constant.Base.LECTURE];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityLecture>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Key

            e.HasKey(x => x.Key).HasName(Fluent.PrimaryKeyConstraintFromParams(EntityNameParts));

            #endregion

            #region Index

            e.HasIndex(x => x.Key)
                .HasDatabaseName(Fluent.PrimaryKeyIndexFromParams(EntityNameParts))
                .IsUnique();

            e.HasIndex(x => x.KeyCredit)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.LECTURE, Constant.Base.CREDIT ]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyWork)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.LECTURE, Constant.Base.WORK]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyEffort)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.LECTURE, Constant.Base.EFFORT]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyEffort)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.LECTURE, Constant.Base.TYPE]))
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

            e.Property(x => x.KeyCredit)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.CREDIT]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyWork)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.WORK]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyEffort)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.EFFORT]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyType)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.TYPE]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Acronym)
                .HasColumnName(Fluent.AcronymColumnNameFromParams(EntityNameParts))
                .HasMaxLength(Constant.Max.MaxDesc)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Fluent.TextColumnNameFromParams(EntityNameParts))
                .HasMaxLength(Constant.Max.MaxText)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Translate)
                .HasColumnName(Fluent.TextColumnNameFromParams([Constant.Properties.TRANSLATE, Constant.Base.LECTURE ]))
                .HasMaxLength(Constant.Max.MaxText)
                .HasColumnOrder(order++)
                .IsRequired(false);

            e.Property(x => x.Activation)
                .HasColumnName(Fluent.DateTimeColumnNameFromParams([ Constant.Properties.ACTIVATION, Constant.Base.LECTURE ]))
                .HasColumnOrder(order++)
                .IsRequired(false);

            e.Property(x => x.Deactivation)
                .HasColumnName(Fluent.DateTimeColumnNameFromParams([Constant.Properties.DEACTIVATION, Constant.Base.LECTURE]))
                .HasColumnOrder(order++)
                .IsRequired(false);

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityCredit)
                .WithMany(x => x.EnumerableLecture)
                .HasForeignKey(x => x.KeyCredit)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.LECTURE, Constant.Base.CREDIT ]));

            e.HasOne(x => x.EntityWork)
                .WithMany(x => x.EnumerableLecture)
                .HasForeignKey(x => x.KeyWork)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.LECTURE, Constant.Base.WORK ]));

            e.HasOne(x => x.EntityEffort)
                .WithMany(x => x.EnumerableLecture)
                .HasForeignKey(x => x.KeyEffort)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.LECTURE, Constant.Base.EFFORT ]));

            e.HasOne(x => x.EntityType)
                .WithMany(x => x.EnumerableLecture)
                .HasForeignKey(x => x.KeyType)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.LECTURE, Constant.Base.TYPE ]));

            e.HasMany(x => x.EnumerableBiblioLecture)
                .WithOne(x => x.EntityLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.LECTURE, Constant.Base.BIBLIO, Constant.Base.LECTURE ]));

            e.HasMany(x => x.EnumerableSection)
                .WithOne(x => x.EntityLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.LECTURE, Constant.Base.SECTION ]));

            e.HasMany(x => x.EnumerableLectureTeacher)
                .WithOne(x => x.EntityLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.LECTURE, Constant.Base.TEACHER, Constant.Base.LECTURE ]));

            e.HasMany(x => x.EnumerableLectureCourse)
                .WithOne(x => x.EntityLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.LECTURE, Constant.Base.LECTURE, Constant.Base.COURSE ]));

            e.HasMany(x => x.EnumerableLecturePre)
                .WithOne(x => x.EntityLecture)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.LECTURE, Constant.Base.LECTURE , Constant.Base.PRE ]));

            #endregion
        }
    }
}
