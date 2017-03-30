using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TerryBerryCore.Domain.Abstract;
using TerryBerryCore.Infrastructure;

namespace TerryBerryCore.Controllers
{
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
        private IHelloWorldRepository repo = new HelloWorldRepository();

        public IActionResult GetMessage()
        {
            var result = repo.GetMessages();

            return Json(result);
        }
    }
}
