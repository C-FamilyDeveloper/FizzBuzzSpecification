using FizzBuzzSpecification.Models.Abstractions;
using FizzBuzzSpecification.Models.Extensions;
using FizzBuzzSpecification.Models.Services;
using FizzBuzzSpecification.Models.Specifications;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzzSpecification
{
    internal class Program
    {
        private static IServiceProvider serviceProvider;
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IPrintable, PrintService>();
        }
        static void Main(string[] args)
        {
            ServiceCollection services = new();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
            var list = new ListMockService().Mock(1, 30);
            var fizzSpecification = ActivatorUtilities.CreateInstance<FizzSpecification>(serviceProvider);
            var buzzSpecification = ActivatorUtilities.CreateInstance<BuzzSpecification>(serviceProvider);
            fizzSpecification.Specification = buzzSpecification;
            list.PrintWithSpecifications(fizzSpecification);
        }
    }
}