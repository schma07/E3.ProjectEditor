
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Core.Entities.Projects
{
    public abstract class ProjectBase
    {
        public virtual Guid Id { get; set; }

        public Guid CustomerId { get; set; }

 
    }
}
