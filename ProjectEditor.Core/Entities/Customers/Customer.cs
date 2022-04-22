using ProjectEditor.Core.Entities.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Core.Entities.Customers
{
    public partial class Customer : CustomerBase
    { 
        DateTime CreateDate { get; set; } = DateTime.Now;
        DateTime? ModifyDate { get; set; }


        public ICollection<Project> Projects { get; }

    }
}
