using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectEditor.Core.Entities.Projects
{
    public abstract class FunctionBase
    {
        public virtual Guid Id { get; set; }
        [Required]
        public string NameInSchematic { get; set; }

        /* Foreign Key(s) */
        public Guid ProjectId { get; set; }

    }
}