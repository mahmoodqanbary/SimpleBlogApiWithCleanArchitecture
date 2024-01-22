using Core.DTOs;
using Entities.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Article
{
    public interface IArticleCategoryService
    {
        Task AddArticleCategoryAsync(ArtcileCategoryDto category);
        List<ArticleCategory> GetCategories();
        Task<ArticleCategory> GetCategoryByIdAsync(int id);
    }
}
