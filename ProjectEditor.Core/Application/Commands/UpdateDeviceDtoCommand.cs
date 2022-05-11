using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProjectEditor.Core.Application.Results;
using System;

namespace ProjectEditor.Core.Application.Commands
{
    public class UpdateDeviceDtoCommand : IRequest<DeviceDto>
    {
        [FromRoute]
        public Guid Id { get; set; }

        [FromBody]
        public DeviceDto DeviceDto { get; set; }   
    }
}