using OpenRasta.Web;
using OpenRastaTester.Resources;

namespace OpenRastaTester.Handlers
{
    public class DogHandler : AnimalHandler
    {
    }

    public class CatHandler : AnimalHandler
    {
    }

    public  class AnimalHandler
    {
        public OperationResult Get()
        {
            return new OperationResult.OK { ResponseResource = new Animal() { Name = "Bob" } };
        }
    }


    public class AlienHandler
    {
        public OperationResult Get()
        {
            return new OperationResult.OK{ResponseResource = new Alien(){Name = "Glurg"}};
        }
    }
}