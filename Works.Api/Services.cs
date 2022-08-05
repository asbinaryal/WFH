using Works.Repository.Infrastructure;
using Works.Repository.Repositories;
using Works.Service;

namespace Works.Api
{
    public class Services
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region 
            #endregion

            #region UnitOfWork
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            #endregion


            #region Services
            services.AddTransient<IDepartmentServices, DepartmentServices>();
            #endregion
        }


    }
}
