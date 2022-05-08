using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MapServiceDependencyAttribute : Attribute
    {
        protected string name;

        public string Name => this.name;

        public MapServiceDependencyAttribute(string name)
        {
            this.name = name;
        }
    }
}
