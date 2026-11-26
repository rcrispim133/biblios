using Br.Bibliography.Core.Constants.Impl.Identity;
using Br.Bibliography.Core.Constants.Interfaces.Identity;
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
            var e = builder.Entity<EntityUserClaim>();

            // Table
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.Id).HasDatabaseName("idx_id_user_claim").IsUnique();

            e.HasIndex(x => x.UserId).HasDatabaseName("idx_user_id_user_claim").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Id)
                .HasColumnName("id_user_claim")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.UserId)
                .HasColumnName("id_user")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.ClaimType)
                .HasColumnName("txt_claim_type")
                .HasMaxLength(ClaimTypeMax)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.ClaimValue)
                .HasColumnName("txt_claim_value")
                .HasMaxLength(ClaimValueMax)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityUser)
                .WithMany(x => x.EnumerableUserClaim)
                .HasForeignKey(x => x.UserId)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_user_claim_user");
        }
    }
}
