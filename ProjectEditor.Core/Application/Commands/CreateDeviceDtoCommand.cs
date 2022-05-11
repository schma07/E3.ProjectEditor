using MediatR;
using ProjectEditor.Core.Application.Results;

namespace ProjectEditor.Core.Application.Commands
{
    public class CreateDeviceDtoCommand : IRequest<DeviceDto>
    {
        public CreateDeviceDtoCommand()
        {
        }
    }
}