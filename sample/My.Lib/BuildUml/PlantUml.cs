using My.Lib;
using NPlant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildUml
{
    public class PlantUml
        : ClassDiagram
    {
        public PlantUml()
        {
            this.GenerationOptions.ShowMethods();
            this.AddClass<A>();
            this.AddClass<C>();
            this.AddPackage("My.Lib1")
                .IncludeClassesWhere(c => c.Name == "A" || c.Name == "C");
            this.AddClass<D>();
            this.AddClass<B>();
            this.AddPackage("My.Lib2")
                .IncludeClassesWhere(c => c.Name == "D" || c.Name == "B");
        }
    }
}
