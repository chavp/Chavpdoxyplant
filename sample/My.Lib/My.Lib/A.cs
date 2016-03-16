using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Lib
{
    #region PlantUML
    /*!
    * @startuml
    * package "My.Lib1"{
    * class "A" {
    * +String F1
    * }
    * class "B" {
    * +String F1
    * }
    * "A" *-- "B" : Has A \nB
    * }
    * @enduml
    */
    #endregion

    public class A
    {
        public string F1 { get; set; }

        public B B { get; set; }
    }

}