using BL;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [ApiController]
    [Route("api/project")]
    public class ExempleController:Controller
    {
        [HttpGet]
        public string Q()
        {
           return ExempleBL.GetT();
        }
    }
}
