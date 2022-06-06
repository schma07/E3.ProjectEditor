
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Core.Entities.Projects
{
    public abstract class ProjectBase
    {
        public virtual Guid Id { get; set; }
        public string Description { get; set; }


        /* Foreign Key(s) */
        public Guid? CustomerId { get; set; }
        public Guid? LocationSetupId { get; set; }
        public Guid? FunctionSetupId { get; set; }

    }
}
