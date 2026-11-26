using Br.Bibliography.Core.Constants.Impl.Entitled;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Entitled
{
    public class BuilderLanguage : 
        BuilderText<BuilderLanguage, EntityLanguage, IConstantLanguage>, 
        IBuilderLanguage<BuilderLanguage>
    {
        public override IConstantLanguage Constant { get; init; } = ConstantLanguage.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityLanguage>();

            // Table
            e.ToTable("tbl_language");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_language");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_language").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_language")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_language")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableTitle)
                .WithOne(x => x.EntityLanguage)
                .HasForeignKey(x => x.KeyLanguage)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_language_title");
        }
    }
}
