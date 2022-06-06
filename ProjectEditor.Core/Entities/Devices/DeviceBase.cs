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
        
        public virtual Guid? LocationId { get; set; }
        public virtual Guid? FunctionId { get; set; }
        public virtual Guid? ProjectId { get; set; }
    }
    
}
