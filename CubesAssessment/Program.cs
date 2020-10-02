using CubesAssessment.Library.Calculations;
using CubesAssessment.Library.Interfaces;
using CubesAssessment.Library.Validations;
using Microsoft.Extensions.DependencyInjection;

namespace CubesAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetService<CubesApplication>().Run();            
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection(); 

            services.AddTransient<INumericValidations, NumericValidations>();
            services.AddTransient<ICubes, Cubes>();
            
            //App entry point
            services.AddTransient<CubesApplication>(); 
            
            return services;
        }
    }
}
