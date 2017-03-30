using System.Collections.Generic;
using TerryBerryCore.Domain.Entities;

namespace TerryBerryCore.Domain.Abstract
{
    public interface IMessage
    {
        List<HelloWorld> GetMessages();
    }
}
