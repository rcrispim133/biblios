using Br.Bibliography.Core.Constants.Impl.Identity;
using Br.Bibliography.Core.Constants.Interfaces.Identity;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Identity
{
    public class BuilderUser : 
        BuilderBase<BuilderUser, EntityUser, IConstantUser>, 
        IBuilderUser<BuilderUser>
    {
        public override IConstantUser Constant { get; init; } = ConstantUser.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityUser>();

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
                    [StaticEntityNames.USER]))
                .IsUnique();

            #endregion

            #region Order

            var order = Constant.BaseOrder;

            #endregion

            #region Properties

            e.Property(x => x.Id)
                .HasColumnName(Constant.IdentityColumnName([StaticEntityNames.USER]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyColumnName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.UserName)
                .HasColumnName(Constant.TextColumnName([StaticPropertyNames.USERNAME]))
                .HasMaxLength(Constant.DefaultUserNameMax)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Email)
                .HasColumnName(Constant.TextColumnName([StaticPropertyNames.EMAIL]))
                .HasMaxLength(Constant.DefaultEmailMax)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.EmailConfirmed)
                .HasColumnName(Constant.LogicColumnName([StaticPropertyNames.EMAIL, StaticPropertyNames.CONFIRMED ]))
                .HasColumnOrder(order++)
                .IsRequired()
                .HasDefaultValue(false);

            e.Property(x => x.PasswordHash)
                .HasColumnName(Constant.TextColumnName([StaticPropertyNames.PASSWORD]))
                .HasMaxLength(Constant.DefaultPasswordMax)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasMany(x => x.EnumerableUserClaim)
                .WithOne(x => x.EntityUser)
                .HasForeignKey(x => x.UserId)
                .HasPrincipalKey(x => x.Id)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.USER, StaticEntityNames.USER, StaticEntityNames.CLAIM ]));

            #endregion
        }
    }
}
