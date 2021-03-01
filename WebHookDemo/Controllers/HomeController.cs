using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebHooks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebHookDemo.Controllers
{
	public class HomeController : ControllerBase
	{
		[GitHubWebHook]
		public IActionResult GitHubHandler(JObject data)
		{
			var result = JsonConvert.SerializeObject(data);
			return Ok(result);
		}
	}
}
