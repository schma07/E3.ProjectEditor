using MediatR;
using ProjectEditor.Core.Application.Results;
using ProjectEditor.Core.Entities.Projects;
using System;
using System.Collections.Generic;

namespace ProjectEditor.Core.Application.Queries
{
    public class GetDeviceDtosQuery : IRequest<IEnumerable<DeviceDto>>
    {
        public Guid ProjectId { get; set; }

        public int Take { get; set; }
        public int Skip { get; set; }
    }
}