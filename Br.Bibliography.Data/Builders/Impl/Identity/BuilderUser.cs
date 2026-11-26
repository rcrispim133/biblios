using Br.Bibliography.Core.Constants.Impl.Identity;
using Br.Bibliography.Core.Constants.Interfaces.Identity;
using Br.Bibliography.Core.Util.Static;
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
            var e = builder.Entity<EntityUser>();

            // Table
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.Id).HasDatabaseName("idx_id_user").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Id)
                .HasColumnName("id_user")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.UserName)
                .HasColumnName("username_user")
                .HasMaxLength(UserNameMax)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Email)
                .HasColumnName("email_user")
                .HasMaxLength(UserEmailMax)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.EmailConfirmed)
                .HasColumnName("email_confirmed_user")
                .HasColumnOrder(order++)
                .IsRequired()
                .HasDefaultValue(false);

            e.Property(x => x.PasswordHash)
                .HasColumnName("pwd_user")
                .HasMaxLength(PasswordMax)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableUserClaim)
                .WithOne(x => x.EntityUser)
                .HasForeignKey(x => x.UserId)
                .HasPrincipalKey(x => x.Id)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.USER, StaticEntityNames.USER, StaticEntityNames.CLAIM ]));
        }
    }
}
