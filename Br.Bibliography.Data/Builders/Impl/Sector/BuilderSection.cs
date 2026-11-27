using Br.Bibliography.Core.Constants.Impl.Sector;
using Br.Bibliography.Core.Constants.Interfaces.Sector;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Sector
{
    public class BuilderSection : 
        BuilderBase<BuilderSection, EntitySection, IConstantSection>, 
        IBuilderSection<BuilderSection>
    {
        public override IConstantSection Constant { get; init; } = ConstantSection.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntitySection>();

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
                    [StaticEntityNames.SECTION, StaticEntityNames.LECTURE]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyDetail)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.SECTION, StaticEntityNames.DETAIL]))
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

            e.Property(x => x.KeyDetail)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.DETAIL]))
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityLecture)
                .WithMany(x => x.EnumerableSection)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.SECTION, StaticEntityNames.LECTURE]));

            e.HasOne(x => x.EntityDetail)
                .WithMany(x => x.EnumerableSection)
                .HasForeignKey(x => x.KeyDetail)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.SECTION, StaticEntityNames.DETAIL]));

            e.HasMany(x => x.EnumerableLine)
                .WithOne(x => x.EntitySection)
                .HasForeignKey(x => x.KeySection)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.SECTION, StaticEntityNames.LINE]));

            #endregion
        }
    }
}
