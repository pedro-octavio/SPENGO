using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.RequestModels.QueryRequestModels;

namespace SPENGO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletsController : ControllerBase
    {
        private readonly IMediator mediator;

        public WalletsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllWalletRequestModel requestModel)
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

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetWalletByIdRequestModel requestModel)
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
        public async Task<IActionResult> Post([FromBody] AddWalletRequestModel requestModel)
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
        public async Task<IActionResult> Put([FromBody] UpdateWalletRequestModel requestModel)
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
        public async Task<IActionResult> Delete([FromRoute] DeleteWalletRequestModel requestModel)
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
