using Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Post
{
    public class SelectedCategory : BaseEntity
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int ArticleCategoryId { get; set; }
        public ArticleCategory ArticleCategory { get; set; }
    }

    public class SelectedCategoryConfiguration : IEntityTypeConfiguration<SelectedCategory>
    {
        public void Configure(EntityTypeBuilder<SelectedCategory> builder)
        {
            builder.HasOne(c => c.Article).WithMany(c => c.SelectedCategories).HasForeignKey(c => c.ArticleId);
            builder.HasOne(c => c.ArticleCategory).WithMany(c => c.SelectedCategories).HasForeignKey(c => c.ArticleCategoryId);
        }
    }
}
