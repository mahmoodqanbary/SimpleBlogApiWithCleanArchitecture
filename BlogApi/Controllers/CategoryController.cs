using Core.DTOs;
using Entities.Post;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Services.Interfaces.Article;

namespace BlogApi.Controllers
{

    public class CategoryController : BaseController
    {
        #region Constractor
        private readonly IArticleCategoryService _articleCategoryService;

        public CategoryController(IArticleCategoryService articleCategoryService)
        {
            _articleCategoryService = articleCategoryService;
        }
        #endregion

        [HttpGet("[Action]")]
        public async Task<ActionResult> GetCategories()
        {
            var data =  _articleCategoryService.GetCategories();
            return Ok(data);
        }

        [HttpGet("[Action]/{id}")]
        public async Task<ActionResult> GetCategory(int id)
        {
            var data = await _articleCategoryService.GetCategoryByIdAsync(id);

            return Ok(data);
        }

        [HttpPost("[Action]")]
        public async Task<ActionResult> AddCategory(ArtcileCategoryDto category)
        {
            if (!ModelState.IsValid)
                return BadRequest(category);

            await _articleCategoryService.AddArticleCategoryAsync(category);
            return Ok(category);
        }


    }
}
