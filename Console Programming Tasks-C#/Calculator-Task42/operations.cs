using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calculator
{
    /// <summary>
    /// This class performs basic mathematical operations and also error writing to a text file.
    /// </summary>
    class operations
    {
        /// <summary>
        /// This method is used to perform Additionby taking two integer variables as parameters and return the result.
        /// </summary>
        /// <param name="Number1"></param>
        /// <param name="Number2"></param>
        public double Addition(double Number1,double Number2)
        {
            double result = Number1 + Number2;
            return result;
        }
        /// <summary>
        /// This method is used to perform Subtraction by taking two integer variables as parameters and return the result.
        /// </summary>
        /// <param name="Number1"></param>
        /// <param name="Number2"></param>
        public double Subtraction(double Number1, double Number2)
        {
            double result = Number1 - Number2;
            return result;
            
        }
        /// <summary>
        /// This method is used to perform Multiplication by taking two integer variables as parameters and return the result.
        /// </summary>
        /// <param name="Number1"></param>
        /// <param name="Number2"></param>
        public double Multiplication(double Number1, double Number2)
        {
            double result = Number1 * Number2;
            return result;
           
        }
        /// <summary>
        /// This method is used to perform division by taking two integer variables as parameters and return the result.
        /// </summary>
        /// <param name="Number1"></param>
        /// <param name="Number2"></param>
        public double Division(double Number1, double Number2)
        {
            if(Number2 == 0)
            {
                return -1;
            }
            else
            {
                double result = Number1 / Number2;
                return result;

            } 
        }
        /// <summary>
        /// This method is used to perform Error writing to a  text file by taking error from exception as parameters.
        /// </summary>
        /// <param name="Number1"></param>
        /// <param name="Number2"></param>
        public void Errortext(string error)
        {
            string file= @"D:\Calculator\Calculator\Error.txt";
            if (!File.Exists(file))
            {
                // Creating the same file if it doesn't exist
                using (StreamWriter sw = File.CreateText(file))
                {
                    sw.WriteLine("File Created on {0}",DateTime.Now.ToString());
                    sw.WriteLine("-------------------------------------------");
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(file))
                {
                    sw.WriteLine("{0} {1}",DateTime.Now.ToString(),error);
                }

            }
            

        }
    }
}
