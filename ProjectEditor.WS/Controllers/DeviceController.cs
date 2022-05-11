using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using ProjectEditor.Core.Application.Commands;
using ProjectEditor.Core.Application.Queries;
using ProjectEditor.Core.Application.Results;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectEditor.WS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
     public class DeviceController : BaseController
    {
        
        [HttpGet(nameof(DeviceDto) + "/{Id}")]
        public async Task<DeviceDto> GetDeviceDto([FromRoute] GetDeviceDtoQuery query, CancellationToken cancellationToken)
        {
            return await this.Mediator.Send(query, cancellationToken);
        }

        [HttpGet(nameof(DeviceDto))]
        public async Task<IEnumerable<DeviceDto>> GetMovieDtos([FromQuery] GetDeviceDtosQuery query, CancellationToken cancellationToken)
        {
            return await base.Mediator.Send(query, cancellationToken);
        }


        [ProducesResponseType(typeof(DeviceDto), (int)HttpStatusCode.Created)]
        [HttpPost(nameof(DeviceDto))]
        public async Task<DeviceDto> CreateMovieDto(CancellationToken cancellationToken)
        {
            var command = new CreateDeviceDtoCommand();
            var result = await base.Mediator.Send(command, cancellationToken);

            //Todo: Location header implementieren

            return base.SetLocatioURI<DeviceDto>(result, result.Id.ToString());
        }
    }
}
