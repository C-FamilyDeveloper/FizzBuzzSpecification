using FizzBuzzSpecification.Models.Handlers;
using FizzBuzzSpecification.Models.Services;
using FizzBuzzSpecification.Models.Specifications;
using FizzBuzzSpecification.Models.Extensions;
using Microsoft.Extensions.DependencyInjection;
using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzTests
{
    public class Tests
    {
        private IServiceProvider serviceProvider;
        private GoodBoyHandler gbHandler;
        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ISwitchable, SwitchService>(i =>
            {
                return new SwitchService("-");
            });
        }
        public Tests()
        {
            ServiceCollection services = new();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }
        [SetUp]
        public void Setup()
        {
            var gbSpecification = new FizzSpecification().And(new BuzzSpecification());
            var fizzSpecification = new FizzSpecification().And(gbSpecification.Not());
            var buzzSpecification = new BuzzSpecification().And(gbSpecification.Not());
            var muzzSpecification = new MuzzSpecification();
            var guzzSpecification = new GuzzSpecification();
            var gbHandler = ActivatorUtilities.CreateInstance<GoodBoyHandler>(serviceProvider);
            this.gbHandler = gbHandler;
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
        }
        [TestCase(3)]
        [Test]
        public void TestIsFizzAsserted(int number)
        {
            Assert.That(number.ReplaceWithSpecifications(gbHandler), Is.EqualTo("Fizz"));
        }
        [TestCase(5)]
        [Test]
        public void TestIsBuzzAsserted(int number)
        {
            Assert.That(number.ReplaceWithSpecifications(gbHandler), Is.EqualTo("Buzz"));
        }
        [TestCase(15)]
        [TestCase(30)]
        [Test]
        public void TestIsGoodBoyAsserted(int number)
        {
            Assert.That(number.ReplaceWithSpecifications(gbHandler), Is.EqualTo("Good-Boy"));
        }
    }
}