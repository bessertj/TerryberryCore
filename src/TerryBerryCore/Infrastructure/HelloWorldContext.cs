using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TerryBerryCore.Domain.Entities;

namespace TerryBerryCore.Infrastructure
{
    public class HelloWorldContext
    {
        public HelloWorldContext()
        {
            HelloWorldEntities = new List<HelloWorld>();
            for (var i = 0; i <= 9; i++)
            {
                HelloWorldEntities.Add(new HelloWorld { Message = "hello world" });
            }
        }

        public List<HelloWorld> HelloWorldEntities { get; set; }
    }
}
