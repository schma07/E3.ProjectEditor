using ProjectEditor.Common.Attributes;
using ProjectEditor.Core.Repositories.Projects;
using ProjectEditor.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Persistence.Repositories.Projects
{
    [MapServiceDependency(nameof(FunctionRepository))]
    public class FunctionRepository : BaseRepository, IFunctionRepository
    {
    }
}
