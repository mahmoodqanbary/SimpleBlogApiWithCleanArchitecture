using Core.DTOs;
using Data.Contracts;
using Entities.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfacese
{
    public interface IArticleService 
    {
        List<Article> GetArticlesAsync();
        Task<Article> GetArticleById(int Id);
        Task AddArticle(ArticleDto articleDto);

    }
}
