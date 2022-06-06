using ProjectEditor.Core.Entities.Customers;
using ProjectEditor.Core.Entities.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectEditor.Core.Entities.Projects
{
    public partial class FunctionSetup : FunctionSetupBase, IEntity
    {

        /* Standard properties*/
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }


        public FunctionSetup()
        {
            this.Functions = new HashSet<Function>();

        }

        /* Navigation properties */
       
        public virtual ICollection<Function> Functions { get; }

               

    }
}
