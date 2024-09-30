using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using POS.BLL.Guide;
using POS.DAL;
using POS.DAL.Contexts;

namespace POS.IOC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            #region DAL

            services.AddScoped(typeof(IUnitOfWork<POSDbContext>), typeof(UnitOfWork<POSDbContext>));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            #endregion
            var BllClasses = typeof(StockBll).Assembly.GetTypes().Where(p => p.IsClass && p.Name.ToLower().Contains("bll"));

            #region BLL
            BllClasses.ToList().ForEach(p =>
            {
                services.AddScoped(p);

            });

            #endregion

        }
    }
}
