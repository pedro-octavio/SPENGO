using MediatR;
using Microsoft.AspNetCore.Mvc;
using SPENGO.Domain.Handlers.CommandHandlers;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.RequestModels.QueryRequestModels;
using System.Threading.Tasks;

namespace SPENGO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletGroupItemsController : ControllerBase
    {
        private readonly IMediator mediator;

        public WalletGroupItemsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{WalletGroupId}")]
        public async Task<IActionResult> Get([FromRoute] GetAllWalletGroupItemByWalletGroupIdRequestModel requestModel)
        {
            var responseModel = await mediator.Send(requestModel);

            if (responseModel.IsValid)
            {
                return Ok(responseModel);
            }
            else
            {
                return BadRequest(responseModel);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddWalletGroupItemRequestModel requestModel)
        {
            var responseModel = await mediator.Send(requestModel);

            if (responseModel.IsValid)
            {
                return Ok(responseModel);
            }
            else
            {
                return BadRequest(responseModel);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateWalletGroupItemRequestModel requestModel)
        {
            var responseModel = await mediator.Send(requestModel);

            if (responseModel.IsValid)
            {
                return Ok(responseModel);
            }
            else
            {
                return BadRequest(responseModel);
            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteWalletGroupItemRequestModel requestModel)
        {
            var responseModel = await mediator.Send(requestModel);

            if (responseModel.IsValid)
            {
                return Ok(responseModel);
            }
            else
            {
                return BadRequest(responseModel);
            }
        }
    }
}
