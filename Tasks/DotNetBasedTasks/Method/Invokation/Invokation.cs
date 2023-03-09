using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Method.Signatures;

namespace Method.Invokation
{
    internal class Invokation
    {
        public string carName;
        public string carType;
        public int horsePower;
        /// <summary>
        /// This is parameterized constructor.
        /// </summary>
        /// <param name="carName"></param>
        /// <param name="carType"></param>
        public Invokation(string carName, string carType)
        {
            this.carName = carName;
            this.carType = carType;
        }

        /// <summary>
        /// This is Default constructor.
        /// </summary>
        public Invokation() { }

        public string printCarDetails(int horsePower, string Name = "Ford")
        {
            return $"This is {Name} car with {horsePower}HP";
        }

    }
}
