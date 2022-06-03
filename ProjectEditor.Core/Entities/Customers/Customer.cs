using ProjectEditor.Core.Entities.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Core.Entities.Customers
{
    public partial class Customer : CustomerBase, IEntity
    {
        /* Standard properties*/
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        /* Navigation properties */
        public virtual ICollection<Project> Projects { get; }

        public Customer()
        {
            this.Projects = new HashSet<Project>();
        }

    }
}
