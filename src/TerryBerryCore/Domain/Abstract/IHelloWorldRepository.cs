using System.Collections.Generic;
using TerryBerryCore.Domain.Entities;

namespace TerryBerryCore.Domain.Abstract
{
    public interface IHelloWorldRepository
    {
        List<HelloWorld> GetMessages();
    }
}
