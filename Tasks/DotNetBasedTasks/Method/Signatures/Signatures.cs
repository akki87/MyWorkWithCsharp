using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.Signatures
{
    internal class Method_Signatures
    {
        public string name;
        public int age;
        public static int count;

        public static void counter()
        {
            count++;

        }
        /// <summary>
        /// This method take no parameter and return nothing.
        /// </summary>
        public void PrintName()
        {
            Console.WriteLine(name);
            Console.WriteLine("This method take no parameter and return nothing");
        }

        /// <summary>
        /// his method takes parameter age and return nothing.
        /// </summary>
        /// <param name="age"></param>
        public void PrintAge(int age)
        {
            Console.WriteLine(age);
        }

        /// <summary>
        /// This method takes string as a parameter and return string name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>return string</returns>
        public virtual string Details(string name)
        {
            Console.WriteLine("This method is called my parameter name");
            return "Hello" + name;
        }

        /// <summary>
        /// This method takes string as a parameter and return integer age
        /// </summary>
        /// <param name="age"></param>
        /// <returns> return integer</returns>
        public virtual int Details(int age)
        {
            Console.WriteLine("This method is called my parameter age");
            return age;
        }
    }
}