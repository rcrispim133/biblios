using Br.Bibliography.Core.Constants.Impl.Series;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Series
{
    public class BuilderDuration : 
        BuilderText<BuilderDuration, EntityDuration, IConstantDuration>, 
        IBuilderDuration<BuilderDuration>
    {
        public override IConstantDuration Constant { get; init; } = ConstantDuration.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityDuration>();

            // Table
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextName)
                .HasMaxLength(Constant.ConstantMaxText)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableCourse)
                .WithOne(x => x.EntityDuration)
                .HasForeignKey(x => x.KeyDuration)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.DURATION, StaticEntityNames.COURSE]));
        }
    }
}
