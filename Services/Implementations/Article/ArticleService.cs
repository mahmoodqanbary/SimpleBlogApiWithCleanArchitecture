using Core.DTOs;
using Data.Contracts;
using Entities.Post;
using Services.Interfaces.Article;
using Services.Interfacese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class ArticleService : IArticleService
    {
        #region Constractur
        private IGenericRepository<Article> _articleService;

        public ArticleService(IGenericRepository<Article> articleService)
        {
            _articleService = articleService;
        }
        #endregion

        #region Methods
            
        public List<Article> GetArticlesAsync()
        {
            return _articleService.GetEntitiesQuery().ToList(); 
        }

        public async Task<Article> GetArticleById(int Id)
        {
            return await _articleService.GetEntityById(Id);
        }

        public async Task AddArticle(ArticleDto articleDto)
        {
            Article article = new Article()
            {
                ArticleTitle = articleDto.ArticleTitle,
                ArticleDescription = articleDto.ArticleDescription,
            };

            await _articleService.AddEntity(article);
            await _articleService.SaveChanges();
        }

        #endregion
    }
}
