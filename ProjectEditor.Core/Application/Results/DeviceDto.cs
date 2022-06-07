using ProjectEditor.Core.Entities.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Core.Application.Results
{
    public class DeviceDto  : DeviceBase
    {
        public static DeviceDto MapFrom(Device device)
        {
            return new DeviceDto
            {
                Id = device.Id,
                Description = device.Description,                            
                NameInSchematic = device.NameInSchematic,
                LocationId = device.LocationId,
                FunctionId = device.FunctionId,
                ProjectId = device.ProjectId

            };
        }
    }
}
