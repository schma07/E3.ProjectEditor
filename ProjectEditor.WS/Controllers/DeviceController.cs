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

        private const string ID_PARAMETER = "/{Id}";


        [HttpGet(nameof(DeviceDto) + ID_PARAMETER)]
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

        [HttpPut(nameof(DeviceDto) + ID_PARAMETER)]
        public async Task<DeviceDto> UpdateMovieDto([FromQuery] UpdateDeviceDtoCommand command, CancellationToken cancellationToken)
        {
            return await base.Mediator.Send(command, cancellationToken);
        }

        [HttpDelete(nameof(DeviceDto) + ID_PARAMETER)]
        public async Task<bool> DeleteMovieDto([FromQuery] DeleteDeviceDtoCommand command, CancellationToken cancellationToken)
        {
            return await base.Mediator.Send(command, cancellationToken);
        }
    }
}
