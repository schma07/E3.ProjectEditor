using ProjectEditor.Core.Entities.Devices;
using ProjectEditor.Core.Entities.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Core.Application.Results
{
    public class LocationDto : LocationBase
    {
        public static LocationDto MapFrom(Location location)
        {
            return new LocationDto
            {
                Id = location.Id,
                LocationSetupId = location.LocationSetupId,
                NameInSchematic = location.NameInSchematic

            };
        }
    }
}
