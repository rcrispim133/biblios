using Br.Bibliography.Core.Constants.Impl.Identity;
using Br.Bibliography.Core.Constants.Interfaces.Identity;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Identity
{
    public class BuilderUserClaim : 
        BuilderBase<BuilderUserClaim, EntityUserClaim, IConstantUserClaim>, 
        IBuilderUserClaim<BuilderUserClaim>
    {
        public override IConstantUserClaim Constant { get; init; } = ConstantUserClaim.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityUserClaim>();

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
                    [StaticEntityNames.USER, StaticEntityNames.CLAIM ]))
                .IsUnique();

            e.HasIndex(x => x.UserId)
                .HasDatabaseName(Constant.IdentityDatabaseName(
                    [StaticEntityNames.USER, StaticEntityNames.CLAIM, StaticEntityNames.USER ]))
                .IsUnique(false);

            #endregion

            #region Order

            var order = Constant.BaseOrder;

            #endregion

            #region Properties

            e.Property(x => x.Id)
                .HasColumnName(Constant.IdentityColumnName([StaticEntityNames.USER, StaticEntityNames.CLAIM]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyColumnName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.UserId)
                .HasColumnName(Constant.IdentityColumnName([StaticEntityNames.USER]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.ClaimType)
                .HasColumnName(Constant.TextColumnName([StaticEntityNames.USER, StaticEntityNames.CLAIM, StaticEntityNames.TYPE]))
                .HasMaxLength(Constant.DefaultMaxUserClaim)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.ClaimValue)
                .HasColumnName(Constant.TextColumnName([StaticEntityNames.USER, StaticEntityNames.CLAIM, StaticPropertyNames.VALUE ]))
                .HasMaxLength(Constant.DefaultMaxUserClaim)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityUser)
                .WithMany(x => x.EnumerableUserClaim)
                .HasForeignKey(x => x.UserId)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.USER, StaticEntityNames.CLAIM, StaticEntityNames.USER]));

            #endregion
        }
    }
}
