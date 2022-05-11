using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectEditor.Common.Attributes;
using ProjectEditor.Core.Application.Commands;
using ProjectEditor.Core.Application.Results;
using ProjectEditor.Core.Entities.Devices;
using ProjectEditor.Core.Repositories.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectEditor.Application.Devices
{
    [MapServiceDependency(nameof(DeviceCommandHandler))]
    public class DeviceCommandHandler : IRequestHandler<CreateDeviceDtoCommand, DeviceDto>,
                                        IRequestHandler<UpdateDeviceDtoCommand, DeviceDto>
    {
        private IDeviceRepository deviceRepository;

        public DeviceCommandHandler(IServiceProvider service)
        {
            this.deviceRepository = service.GetService<IDeviceRepository>();
        }

        public Task<DeviceDto> Handle(CreateDeviceDtoCommand request, CancellationToken cancellationToken)
        {
            var device = new Device()
            {
                Id = Guid.NewGuid(),
                Name = "tbd",
                Project = null,
                ProjectId = Guid.Empty
        };
            return Task.FromResult(DeviceDto.MapFrom(device));

    }

    public async Task<DeviceDto> Handle(UpdateDeviceDtoCommand request, CancellationToken cancellationToken)
    {
            /* ID im DTO mit ID aus Route überschreiben*/
            request.DeviceDto.Id = request.Id;

            var device = await this.deviceRepository.QueryFrom<Device>().Where(w => w.Id == request.Id).FirstOrDefaultAsync(cancellationToken);

            /* Insert */
            if (device == null)
            {

            }
            /* update */
            else
            {

            }
            return new DeviceDto();

        }
    }


}

