using ProjectEditor.Core.Entities.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Core.Entities.Customers
{
    public partial class Customer : CustomerBase, IEntity
    {
        DateTime CreateDate { get; set; } = DateTime.Now;
        DateTime? ModifyDate { get; set; }

        public Customer()
        {
            this.Projects = new HashSet<Project>();
            
        }

        public ICollection<Project> Projects { get; }

    }
}
