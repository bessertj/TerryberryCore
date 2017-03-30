using System.Collections.Generic;
using TerryBerryCore.Domain.Abstract;
using TerryBerryCore.Domain.Entities;

namespace TerryBerryCore.Infrastructure
{
    public class HelloWorldRepository : IHelloWorldRepository
    {
        private HelloWorldContext db = new HelloWorldContext();

        public List<HelloWorld> GetMessages()
        {
            return db.HelloWorldEntities;
        }
    }
}
