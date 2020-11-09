using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.RequestModels.QueryRequestModels;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.QueryResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;

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
            try
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
            catch (Exception ex)
            {
                var responseModel = new ResponseModel<IEnumerable<GetAllWalletResponseModel>>
                {
                    IsValid = false,
                    ErrorMessage = ex.Message,
                    Data = null
                };

                return BadRequest(responseModel);
            }
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetWalletByIdRequestModel requestModel)
        {
            try
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
            catch (Exception ex)
            {
                var responseModel = new ResponseModel<GetWalletByIdResponseModel>
                {
                    IsValid = false,
                    ErrorMessage = ex.Message,
                    Data = null
                };

                return BadRequest(responseModel);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddWalletRequestModel requestModel)
        {
            try
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
            catch (Exception ex)
            {
                var responseModel = new ResponseModel<AddWalletResponseModel>
                {
                    IsValid = false,
                    ErrorMessage = ex.Message,
                    Data = null
                };

                return BadRequest(responseModel);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateWalletRequestModel requestModel)
        {
            try
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
            catch (Exception ex)
            {
                var responseModel = new ResponseModel<UpdateWalletResponseModel>
                {
                    IsValid = false,
                    ErrorMessage = ex.Message,
                    Data = null
                };

                return BadRequest(responseModel);
            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteWalletRequestModel requestModel)
        {
            try
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
            catch (Exception ex)
            {
                var responseModel = new ResponseModel<DeleteWalletResponseModel>
                {
                    IsValid = false,
                    ErrorMessage = ex.Message,
                    Data = null
                };

                return BadRequest(responseModel);
            }
        }
    }
}
