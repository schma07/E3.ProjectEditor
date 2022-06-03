using ProjectEditor.Core.Entities.Customers;
using ProjectEditor.Core.Entities.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectEditor.Core.Entities.Projects
{
    public partial class Project : ProjectBase, IEntity
    {
        public string ProjectManagerName { get; set; }

        /* Standard properties*/
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }


        public Project()
        {
            this.Devices = new HashSet<Device>();
            this.Locations = new HashSet<Location>();
            this.Functions = new HashSet<Function>();
        }


        /* Navigation properties */
        public ICollection<Device> Devices { get; }
        public ICollection<Location> Locations { get; }
        public ICollection<Function> Functions { get; }

        /* ForeignKey objects */
        [ForeignKey(nameof(ProjectBase.CustomerId))]
        public Customer Customer { get; set; }
    }
}
