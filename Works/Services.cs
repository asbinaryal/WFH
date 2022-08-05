using Works.Repository.Repositories;
using Works.Service;

namespace Works
{
    public class Services
    {
        public static  void RegisterServices(IServiceCollection services)
        {
             
           services.AddTransient<HttpClient, HttpClient>();
            #region Repository
     
                 
            #endregion Services 
        }


    }
}