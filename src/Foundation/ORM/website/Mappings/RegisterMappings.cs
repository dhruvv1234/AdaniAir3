using Glass.Mapper.Sc.Pipelines.AddMaps;
using AdaniAir.Foundation.ORM.Extensions;

namespace AdaniAir.Foundation.ORM.Mappings
{
    public class RegisterMappings : AddMapsPipeline  {
        public void Process(AddMapsPipelineArgs args)
        {
            args.MapsConfigFactory.AddFluentMaps("Helixbase.Foundation.ORM");
        }
    }
}