using Br.Bibliography.Core.Constants.Impl.Alumni;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Alumni
{
    public class BuilderTeacher : BuilderText<BuilderTeacher, EntityTeacher, IConstantTeacher>, IBuilderTeacher<BuilderTeacher>
    {
        public override IConstantTeacher Constant { get; init; } = ConstantTeacher.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityTeacher>();

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
            e.HasMany(x => x.EnumerableLectureTeacher)
                .WithOne(x => x.EntityTeacher)
                .HasForeignKey(x => x.KeyTeacher)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([ StaticEntityNames.TEACHER, StaticEntityNames.LECTURE, StaticEntityNames.TEACHER ]));
        }
    }
}
