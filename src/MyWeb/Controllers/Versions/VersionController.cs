using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers.Versions {
    [ApiController]
    [Route("api/[controller]")]
    public class VersionController : ControllerBase {
        public string GetAssemblyVersion() {
            return GetType().Assembly.GetName().Version.ToString();
        }

        [HttpGet]
        public ActionResult Get() {
            return Ok(GetAssemblyVersion());
        }
    }
}