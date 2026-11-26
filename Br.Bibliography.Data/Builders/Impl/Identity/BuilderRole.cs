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
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.Id).HasDatabaseName("idx_id_role").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Id)
                .HasColumnName(Constant.PropertyKeyColumnName)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Key)
                .HasColumnName("key_role")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Name)
                .HasColumnName("name_role")
                .HasMaxLength(Constant.MaxRoleName)
                .HasColumnOrder(order++)
                .IsRequired();
        }
    }
}