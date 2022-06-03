using System;

namespace ProjectEditor.Core.Entities.Projects
{
    public partial class Location
    {
        public string Description { get; set; }
        public string NameInSchematic { get; set; }

        /* Standard properties*/
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
    }
}