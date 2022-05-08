using MediatR;
using ProjectEditor.Core.Application.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Core.Application.Queries
{
    public class GetDeviceDtoQuery : IRequest<DeviceDto>
    {
        public Guid Id { get; set; }
    }

}
