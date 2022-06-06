using ProjectEditor.Core.Entities.Projects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectEditor.Core.Entities.Devices
{
    public partial class Device : DeviceBase, IEntity
    {
        
        /* Standard properties*/
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }      



        
        /* ForeignKey objects */        
        [ForeignKey(nameof(DeviceBase.LocationId))]        
        public Location Location { get; set; }
        [ForeignKey(nameof(DeviceBase.FunctionId))]
        public Function Function { get; set; }

        [ForeignKey(nameof(DeviceBase.ProjectId))]
        public Project Project { get; set; }
    }
}
