using ProjectEditor.Core.Entities.Devices;
using ProjectEditor.Core.Entities.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Core.Application.Results
{
    public class FunctionDto  : FunctionBase
    {
        public static FunctionDto MapFrom(Function function)
        {
            return new FunctionDto
            {
                Id = function.Id,
                FunctionSetupId = function.FunctionSetupId,
                NameInSchematic = function.NameInSchematic,
                                
            };
        }
    }
}
