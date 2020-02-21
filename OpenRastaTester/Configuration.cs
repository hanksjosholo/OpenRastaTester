using System.Diagnostics;
using OpenRasta.Configuration;
using OpenRasta.Configuration.Fluent;
using OpenRastaTester.Handlers;
using OpenRastaTester.Resources;

namespace OpenRastaTester
{
    public class Configuration : IConfigurationSource
    {
        public void Configure()
        {
            ResourceSpace.Has.ResourcesOfType<Alien>().AtUri("/alien").HandledBy<AlienHandler>().AsJsonDataContract();
            ResourceSpace.Has.ResourcesOfType<Animal>().AtUri("/cat").Named("cat").HandledBy<CatHandler>().AsJsonDataContract();
            ResourceSpace.Has.ResourcesOfType<Animal>().AtUri("/dog").Named("dog").HandledBy<DogHandler>().AsJsonDataContract();
            
        }


    }
}