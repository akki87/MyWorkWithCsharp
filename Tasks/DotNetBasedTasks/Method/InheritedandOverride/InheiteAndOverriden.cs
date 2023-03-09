using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Method.Signatures;

namespace Method.InheritedandOverride
{
    internal class InheiteAndOverriden:Method_Signatures
    {

        /// <summary>
        /// This method will take integer as parameter and returns integer.
        /// </summary>
        /// <param name="age"></param>
        /// <returns>integer</returns>
        public override int Details(int age)
        {
            Console.WriteLine("This method is inherited from parent class and overriden in this child class");
            return age * 2;
        }

        /// <summary>
        /// This method will take string as parameter and returns string.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>string</returns>
        public override string Details(string name)
        {
            Console.WriteLine("This method is inherited from parent class and overriden in this child class");
            return "Hi" + name;
        }

    }
}
