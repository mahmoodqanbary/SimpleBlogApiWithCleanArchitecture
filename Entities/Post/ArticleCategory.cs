using Entities.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Post
{
    public class ArticleCategory : BaseEntity
    {
        public string CategoryTitle { get; set; }

        public int? ParentId { get; set; }
        public ArticleCategory Parent { get; set; }

        public ICollection<ArticleCategory> ArticleCategories { get; set; }
        public ICollection<SelectedCategory> SelectedCategories { get; set; }

    }

    public class ArticleCategoryConfiguration : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.Property(p => p.CategoryTitle).IsRequired().HasMaxLength(150);
            builder.HasOne(c => c.Parent).WithMany(c => c.ArticleCategories).HasForeignKey(c => c.ParentId);
        }
    }
}
