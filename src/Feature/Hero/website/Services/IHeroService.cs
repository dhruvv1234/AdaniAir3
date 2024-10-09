using AdaniAir.Feature.Hero.Models;
using AdaniAir.Foundation.Search.Models;

namespace AdaniAir.Feature.Hero.Services
{
    public interface IHeroService
    {
        IHeroContentType GetHeroItems();
        BaseSearchResultItem GetHeroImagesSearch();
        bool IsExperienceEditor { get; }
    }
}
