using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectEditor.Core.Entities.Projects
{
    public partial class Location : IEntity
    {
        public virtual Guid Id { get; set; }
        [Required]
        public string NameInSchematic { get; set; }
        public string Description { get; set; }
        

        /* Standard properties*/
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

       
        /* Foreign Key(s) */
        public Guid ProjectId { get; set; }

        /* ForeignKey objects */
        [ForeignKey(nameof(ProjectId))]
        public Project Project { get; set; }
    }
}