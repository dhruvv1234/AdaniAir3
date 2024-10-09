using AdaniAir.Feature.Hero.Factories;
using AdaniAir.Feature.Hero.Mediators;
using AdaniAir.Feature.Hero.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace AdaniAir.Feature.Hero.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IHeroMediator, HeroMediator>();
            serviceCollection.AddTransient<IHeroService, HeroService>();
            serviceCollection.AddTransient<IHeroViewModelFactory, HeroViewModelFactory>();
        }
    }
}