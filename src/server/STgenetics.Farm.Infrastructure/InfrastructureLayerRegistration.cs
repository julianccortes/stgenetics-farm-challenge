using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using STgenetics.Farm.Application.Interfaces.Repositories;
using STgenetics.Farm.Infrastructure.Context;
using STgenetics.Farm.Infrastructure.Repositories;

namespace STgenetics.Farm.Infrastructure
{
    public static class InfrastructureLayerRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationFarmContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ApplicationFarmDbConnection"),
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure();
                });
            });


            #region Repositories
            services.AddTransient(typeof(IGenericRepositoryAsync<,>), typeof(GenericRepositoryAsync<,>));           
            services.AddTransient<IAnimalsRepositoryAsync, AnimalsRepositoryAsync>();
            #endregion
        }
    }
}
