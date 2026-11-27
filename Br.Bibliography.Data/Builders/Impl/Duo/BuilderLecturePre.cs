using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;


namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderLecturePre : 
        BuilderBase<BuilderLecturePre, EntityLecturePre>, 
        IBuilderLecturePre<BuilderLecturePre>
    {
        public override string[] EntityNameParts => [Constant.Base.LECTURE, Constant.Base.PRE];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityLecturePre>();

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
                    [Constant.Base.LECTURE, Constant.Base.PRE, Constant.Base.LECTURE]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyPre)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.LECTURE, Constant.Base.PRE, Constant.Base.PRE]))
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

            e.Property(x => x.KeyPre)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.PRE]))
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relatiionships

            e.HasOne(x => x.EntityLecture)
                .WithMany(x => x.EnumerableLecturePre)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.LECTURE, Constant.Base.PRE, Constant.Base.LECTURE ]));

            e.HasOne(x => x.EntityPre)
                .WithMany(x => x.EnumerableLecturePre)
                .HasForeignKey(x => x.KeyPre)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.LECTURE, Constant.Base.PRE, Constant.Base.PRE]));

            #endregion
        }
    }
}
