using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CommandApi.Controllers
{
    [Route("/api/Commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"Hello", "world", "new"};
        }
    }
}