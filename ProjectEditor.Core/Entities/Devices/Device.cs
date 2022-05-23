using ProjectEditor.Core.Entities.Projects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectEditor.Core.Entities.Devices
{
    public partial class Device : DeviceBase, IEntity
    {
        DateTime CreateDate { get; set; } = DateTime.Now;
        DateTime? ModifyDate { get; set; }

        [ForeignKey(nameof(DeviceBase.ProjectId))]
        public Project Project { get; set; }

    }
}
