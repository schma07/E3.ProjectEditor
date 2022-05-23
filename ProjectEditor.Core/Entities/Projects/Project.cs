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
        public Project()
        {
           this.Devices = new HashSet<Device>();
        }

        DateTime CreateDate { get; set; } = DateTime.Now;
        DateTime? ModifyDate { get; set; }

        
        
        
        public ICollection<Device> Devices { get; }




        [ForeignKey(nameof(ProjectBase.CustomerId))]
        public Customer Customer { get; set; }
    }
}
