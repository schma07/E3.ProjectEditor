using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Core.Entities.Customers
{
    public abstract class CustomerBase 
    {
        public virtual Guid Id { get; set; }   

        public string Name { get; set; } = string.Empty;
        
    }
}
