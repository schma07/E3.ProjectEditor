using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Core.Entities.Devices
{
    public abstract class DeviceBase
    {       
        
        public virtual Guid Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string NameInSchematic { get; set; }

        /* Foreign Key(s) */
        public Guid ProjectId { get; set; }
        public Guid LocationId { get; set; }
        public Guid FunctionId { get; set; }    

    }
    
}
