using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace DemoBotWeb.Controllers
{
    public class WebhookController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromServices] UpdateHandlersService handleUpdateService,
                                              [FromBody] Update update)
        {
            //await handleUpdateService.EchoAsync(update);
            return Ok();
        }
    }
}
