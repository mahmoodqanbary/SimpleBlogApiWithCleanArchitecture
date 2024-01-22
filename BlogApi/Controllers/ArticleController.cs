using Core.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Implementations;
using Services.Interfaces.Article;
using Services.Interfacese;

namespace BlogApi.Controllers
{
   
    public class ArticleController : BaseController
    {
        #region Constractor
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        #endregion

        [HttpGet("[Action]")]
        public async Task<ActionResult> GetArticles()
        {
            var data =  _articleService.GetArticlesAsync();

            return Ok(data);
        }

        [HttpGet("[Action]/{id}")]
        public async Task<ActionResult> GetArticle(int id)
        {
            var data = await _articleService.GetArticleById(id);

            return Ok(data);
        }

        [HttpPost("[Action]")]
        public async Task<ActionResult> AddArticle(ArticleDto article)
        {
            if (!ModelState.IsValid)
                return BadRequest(article);
            await _articleService.AddArticle(article);
            return Ok(article);
        }
    }
}
