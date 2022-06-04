using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectEditor.Core.Entities.Projects
{
    public abstract class LocationBase
    {
        public virtual Guid Id { get; set; }
        [Required]
        public string NameInSchematic { get; set; }
        
       
       
        /* Foreign Key(s) */
        public Guid ProjectId { get; set; }
                
    }
}