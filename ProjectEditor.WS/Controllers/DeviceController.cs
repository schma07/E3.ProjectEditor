using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using ProjectEditor.Core.Application.Queries;
using ProjectEditor.Core.Application.Results;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectEditor.WS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
     public class DeviceController : Controller
    {
        private IMediator mediator;

        protected IMediator Mediator => this.mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        [HttpGet(nameof(DeviceDto) + "/{Id}")]
        public async Task<DeviceDto> GetDeviceDto([FromQuery] GetDeviceDtoQuery query, CancellationToken cancellationToken)
        {
            return await this.Mediator.Send(query, cancellationToken);
        }
    }
}
