using ProjectEditor.Core.Entities.Customers;
using ProjectEditor.Core.Entities.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectEditor.Core.Entities.Projects
{
    public partial class LocationSetup : LocationSetupBase, IEntity
    {

        /* Standard properties*/
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }


        public LocationSetup()
        {
            this.Locations = new HashSet<Location>();           
        }

        
        public virtual ICollection<Location> Locations { get; }                     

    }
}
