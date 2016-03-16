using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Lib
{
    /*!
    * @startuml
    * class "B" {
    * +String F1
    * }
    * "B" -up-|> "C" : Extends
    * @enduml
    */
    public class B : C
    {
        public string F1 { get; set; }
    }
}
