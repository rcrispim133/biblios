using Br.Bibliography.Core.Constants.Impl.Identity;
using Br.Bibliography.Core.Constants.Interfaces.Identity;
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
            var e = builder.Entity<EntityRole>();

            // Table
            e.ToTable("tbl_role");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_role");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_role").IsUnique();

            e.HasIndex(x => x.Id).HasDatabaseName("idx_id_role").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Id)
                .HasColumnName("id_role")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Key)
                .HasColumnName("key_role")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Name)
                .HasColumnName("name_role")
                .HasMaxLength(UserRoleMax)
                .HasColumnOrder(order++)
                .IsRequired();
        }
    }
}