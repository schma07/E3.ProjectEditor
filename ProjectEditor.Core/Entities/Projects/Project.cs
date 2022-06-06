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
            

        }

        /* Navigation properties */
        public virtual ICollection<Device> Devices { get; }
        

        /* ForeignKey objects */
        [ForeignKey(nameof(ProjectBase.LocationSetupId))]
        public LocationSetup LocationSetup { get; set; }

        [ForeignKey(nameof(ProjectBase.FunctionSetupId))]
        public FunctionSetup FunctionSetup { get; set; }

        [ForeignKey(nameof(ProjectBase.CustomerId))]
        public Customer Customer { get; set; }

    }
}
