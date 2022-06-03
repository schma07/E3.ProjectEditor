
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Core.Entities.Projects
{
    public abstract class ProjectBase
    {
        public virtual Guid Id { get; set; }
        public string Name { get; set; }

        /* Standard properties*/
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        /* Foreign Key(s) */
        public Guid CustomerId { get; set; }

 
    }
}
