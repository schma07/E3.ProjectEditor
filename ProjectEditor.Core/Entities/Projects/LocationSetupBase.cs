using System;

namespace ProjectEditor.Core.Entities.Projects
{
    public abstract class LocationSetupBase
    {
        public virtual Guid Id { get; set; }
        public string Name { get; set; }


        /* Foreign Key(s) */
        public Guid ProjectId { get; set; }

    }
}