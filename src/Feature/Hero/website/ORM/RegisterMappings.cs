using Glass.Mapper.Sc.Pipelines.AddMaps;
using AdaniAir.Foundation.ORM.Extensions;

namespace AdaniAir.Feature.Hero.ORM
{
    public class RegisterMappings : AddMapsPipeline  {
        public void Process(AddMapsPipelineArgs args)
        {
            args.MapsConfigFactory.AddFluentMaps("Helixbase.Feature.Hero");
        }
    }
}