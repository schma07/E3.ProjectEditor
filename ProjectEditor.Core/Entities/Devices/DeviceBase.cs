using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Core.Entities.Devices
{
    public abstract class DeviceBase
    {
        public virtual Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public Guid ProjectId { get; set; }

    }
    
}
