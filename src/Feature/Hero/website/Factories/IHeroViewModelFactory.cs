using AdaniAir.Feature.Hero.Models;
using AdaniAir.Feature.Hero.ViewModels;

namespace AdaniAir.Feature.Hero.Factories
{
    public interface IHeroViewModelFactory
    {
        HeroViewModel CreateHeroViewModel(IHeroContentType heroItemDataSource, bool isExperienceEditor);
    }
}
