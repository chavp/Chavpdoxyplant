using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Lib
{
    /*!
    * @startuml
    * class "C" {
    * }
    * class "D" {
    * }
    * class "B" {
    * +String F1
    * }
    * "D" *-- "B" : Has A \nB
    * "D" *-- "C" : Has A \nC
    * @enduml
    */
    public class D
    {
        // http://www.stack.nl/~dimitri/doxygen/manual/commands.html#cmdmsc
        public B B { get; set; }

        public C C { get; set; }

        public void SetD(D d)
        {

        }
    }
}
