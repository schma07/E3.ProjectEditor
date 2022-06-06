using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ProjectEditor.Common.Attributes;
using ProjectEditor.Core.Application.Queries;
using ProjectEditor.Core.Application.Results;
using ProjectEditor.Core.Entities.Devices;
using ProjectEditor.Core.Repositories.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectEditor.Application.Devices
{
    [MapServiceDependency(nameof(DeviceQueryHandler))]
    public class DeviceQueryHandler : IRequestHandler<GetDeviceDtosQuery, IEnumerable<DeviceDto>>,
                                      IRequestHandler<GetDeviceDtoQuery, DeviceDto>  
    {
        public readonly IDeviceRepository deviceRepository;

        public DeviceQueryHandler(IServiceProvider serviceProvider)
        {
            this.deviceRepository = serviceProvider.GetRequiredService<IDeviceRepository>();
        }

        public async Task<DeviceDto> Handle(GetDeviceDtoQuery query, CancellationToken cancellationToken)
        {
            var result = await this.deviceRepository.QueryFrom<Device>(d => d.Id == query.Id)
                                                    .Select(s => DeviceDto.MapFrom(s)).FirstOrDefaultAsync(cancellationToken);
            return result;
        }

        public async Task<IEnumerable<DeviceDto>> Handle(GetDeviceDtosQuery query, CancellationToken cancellationToken)
        {
            var deviceQuery = this.deviceRepository.QueryFrom<Device>()
                                                   .Select(s => DeviceDto.MapFrom(s));


            if (query.De != Guid.Empty || query.ProjectId != null)
            {
                deviceQuery.Where(d => d.ProjectId == query.ProjectId);
            }


            if (query.Take > 0)
            {
                deviceQuery = deviceQuery.Skip(query.Skip).Take(query.Take);
            }

            return await deviceQuery.ToListAsync(cancellationToken);
        }
    }
}