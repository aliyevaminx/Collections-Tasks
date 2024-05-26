using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_exceptions_task_6
{
    internal class Calculator<T> where T : struct, IComparable
    {
        public T Add(T number1, T number2) 
        {
            dynamic num1 = number1;
            dynamic num2 = number2;

            return num1 + num2;
        }  
        
        public T Subtract(T number1, T number2) 
        {
            dynamic num1 = number1;
            dynamic num2 = number2;

            return num1 - num2;
        }
        public T Divide(T number1, T number2)
        {
            dynamic num1 = number1;
            dynamic num2 = number2;

            return num1 / num2;
        }

        public T Multiply(T number1, T number2)
        {
            dynamic num1 = number1;
            dynamic num2 = number2;

            return num1 * num2;
        }
    }
}
