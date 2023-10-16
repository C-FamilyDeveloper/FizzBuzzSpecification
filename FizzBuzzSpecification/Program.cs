using FizzBuzzSpecification.Models.Abstractions;
using FizzBuzzSpecification.Models.Extensions;
using FizzBuzzSpecification.Models.Handlers;
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
            services.AddSingleton<IPrintable, PrintService>(i =>
            {
                return new PrintService("-");
            });
        }
        static void Main(string[] args)
        {
            ServiceCollection services = new();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
            var list = new ListMockService().Mock(1, 30);
            var gbSpecification = new FizzSpecification().And(new BuzzSpecification());
            var fizzSpecification = new FizzSpecification().And(gbSpecification.Not());
            var buzzSpecification = new BuzzSpecification().And(gbSpecification.Not());
            var muzzSpecification = new MuzzSpecification();
            var guzzSpecification = new GuzzSpecification();
            var gbHandler = ActivatorUtilities.CreateInstance<GoodBoyHandler>(serviceProvider);
            gbHandler.Specification = gbSpecification;
            var fizzHandler = ActivatorUtilities.CreateInstance<FizzHandler>(serviceProvider);
            fizzHandler.Specification = fizzSpecification;
            var buzzHandler = ActivatorUtilities.CreateInstance<BuzzHandler>(serviceProvider);
            buzzHandler.Specification = buzzSpecification;
            var muzzHandler = ActivatorUtilities.CreateInstance<MuzzHandler>(serviceProvider);
            muzzHandler.Specification = muzzSpecification;
            var guzzHandler = ActivatorUtilities.CreateInstance<GuzzHandler>(serviceProvider);
            guzzHandler.Specification = guzzSpecification;
            gbHandler.Handler = fizzHandler;
            fizzHandler.Handler = buzzHandler;
            buzzHandler.Handler = muzzHandler;
            muzzHandler.Handler = guzzHandler;
            list.PrintWithSpecifications(gbHandler);
        }
    }
}