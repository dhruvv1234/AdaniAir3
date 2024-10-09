using AdaniAir.Feature.Hero.ViewModels;
using AdaniAir.Foundation.Core.Models;

namespace AdaniAir.Feature.Hero.Mediators
{
    public interface IHeroMediator
    {
        MediatorResponse<HeroViewModel> RequestHeroViewModel();
    }
}
