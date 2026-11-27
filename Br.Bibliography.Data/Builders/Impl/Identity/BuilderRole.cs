using Br.Bibliography.Core.Constants.Impl.Identity;
using Br.Bibliography.Core.Constants.Interfaces.Identity;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Identity
{
    public class BuilderRole : 
        BuilderBase<BuilderRole, EntityRole, IConstantRole>, 
        IBuilderRole<BuilderRole>
    {
        public override IConstantRole Constant { get; init; } = ConstantRole.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityRole>();

            #endregion

            #region Table

            e.ToTable(Constant.TableName);

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.Id)
                .HasDatabaseName(Constant.IdentityDatabaseName(
                    [StaticEntityNames.ROLE]))
                .IsUnique();

            #endregion

            #region Order

            var order = Constant.BaseOrder;

            #endregion

            #region Properties

            e.Property(x => x.Id)
                .HasColumnName(Constant.IdentityColumnName([StaticEntityNames.ROLE]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Key)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.ROLE]))
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Name)
                .HasColumnName(Constant.NameColumnName([StaticEntityNames.ROLE]))
                .HasMaxLength(Constant.DefaultMaxRoleName)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion
        }
    }
}