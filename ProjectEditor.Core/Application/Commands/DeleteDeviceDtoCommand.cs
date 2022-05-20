using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Core.Application.Commands
{
    public class DeleteDeviceDtoCommand : IRequest<bool>
    {
        [FromRoute]
        public Guid Id { get; set; }
    }
}
