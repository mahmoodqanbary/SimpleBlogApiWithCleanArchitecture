using Data.Contracts;
using Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Services.Implementations;
using Services.Interfaces.Article;
using Services.Interfacese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFramework.Dependencies
{
    public static class DependencyContainer
    {
        public static void RegisterService(this IServiceCollection services)
        {
            #region Repositories
                services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            #endregion

            #region Services
            services.AddScoped<IArticleCategoryService, ArticleCategoryService>();
            services.AddScoped<IArticleService, ArticleService>();
            #endregion

            #region Tools

            #endregion
        }
    }
}
