using Core.DTOs;
using Data.Contracts;
using Entities.Post;
using Services.Interfaces.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class ArticleCategoryService : IArticleCategoryService
    {
        #region Constractur
        private IGenericRepository<ArticleCategory> _articleCategoryService;

        public ArticleCategoryService(IGenericRepository<ArticleCategory> articleCategoryService)
        {
            _articleCategoryService = articleCategoryService;
        }
        #endregion

        #region Methods

        public async Task AddArticleCategoryAsync(ArtcileCategoryDto category)
        {
            ArticleCategory articleCategory = new ArticleCategory()
            {
                CategoryTitle = category.CategoryTitle,
                ParentId = category.ParentId
            };

            await _articleCategoryService.AddEntity(articleCategory);
            await _articleCategoryService.SaveChanges();
        }

        public List<ArticleCategory> GetCategories()
        {
            return _articleCategoryService.GetEntitiesQuery().ToList();
        }


        public async Task<ArticleCategory> GetCategoryByIdAsync(int id)
        {
            return await _articleCategoryService.GetEntityById(id);
        }

       

        #endregion
    }
}
