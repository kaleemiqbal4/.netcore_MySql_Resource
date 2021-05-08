using Microsoft.AspNetCore.Mvc;
using testdata.Business.Concrete;

namespace testdata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ICommonResource<AdminController> _commonResource;
        public AdminController(ICommonResource<AdminController> commonResource)
        {
            _commonResource = commonResource;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            var res = _commonResource.GetString("user");

            return Ok(new { opt = res });
        }
    }
}
