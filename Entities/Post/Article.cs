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
    public class Article : BaseEntity
    {
        public string ArticleTitle { get; set; }
        public string ArticleDescription { get; set; }

        public ICollection<SelectedCategory> SelectedCategories { get; set; }
    }

    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(p => p.ArticleTitle).IsRequired().HasMaxLength(150);
            builder.Property(p => p.ArticleDescription).IsRequired().HasMaxLength(1500);
        }
    }
}
