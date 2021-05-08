using Microsoft.AspNetCore.Mvc;
using testdata.Business.Concrete;

namespace testdata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ICommonResource<UserController> _commonResource;
        public UserController(ICommonResource<UserController> commonResource)
        {
            _commonResource = commonResource;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            var res = _commonResource.GetString("user");

            return Ok(new { opt = res});
        }
    }
}