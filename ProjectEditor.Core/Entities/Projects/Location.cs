using ProjectEditor.Core.Entities.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectEditor.Core.Entities.Projects
{
    public partial class Location : LocationBase, IEntity
    {
        public string Description { get; set; }


        /* Standard properties*/
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public Location()
        {
            this.Devices = new HashSet<Device>();
        }

        /* ForeignKey objects */
        [ForeignKey(nameof(LocationBase.ProjectId))]
        public Project Project { get; set; }

        /* Navigation properties */
        public ICollection<Device> Devices { get; }
    }
}