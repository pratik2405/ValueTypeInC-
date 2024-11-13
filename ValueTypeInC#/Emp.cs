using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeInC_
{
    /*Enum=: An enumeration type is a value type defined by the a set of named 
     *       constants of underlying integral numeric type
*/

//    To create a set of constants in C# we can use enum
//    It is a value type
//    Compiler will generate the set of integers constants for enum type

    public enum Department {HR=1 , Sales , Dev ,Testing, Admin };
    public enum Role {Emp=101,Manager,HRManager,CEO}
    public class Emp
    {
      private int id;
        private string name;
        private Department dept;
        private Role role;

       public Emp(int id, string name, Department dept,Role role)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
            this.role = role;
        }

        public override string ToString()
        {
            return $"{id} , {name} , {dept} , {role} ";
        }
    }
}
