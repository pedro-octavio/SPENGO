using MediatR;
using Microsoft.AspNetCore.Mvc;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.RequestModels.QueryRequestModels;
using System.Threading.Tasks;

namespace SPENGO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletGroupsController : ControllerBase
    {
        private readonly IMediator mediator;

        public WalletGroupsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{WalletId}")]
        public async Task<IActionResult> Get([FromRoute] GetAllWalletGroupByWalletIdRequestModel requestModel)
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
        public async Task<IActionResult> Post([FromBody] AddWalletGroupRequestModel requestModel)
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
        public async Task<IActionResult> Put([FromBody] UpdateWalletGroupRequestModel requestModel)
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
        public async Task<IActionResult> Delete([FromRoute] DeleteWalletGroupRequestModel requestModel)
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
