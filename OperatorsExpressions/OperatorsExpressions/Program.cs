using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // +operator .. adds
            // =operators variables assignment
            // == operators .. method invocations.. ex Console.WriteLine()
            // . operator ... member access

            int x, y, a, b;
            // Assignment operator
            x = 10;
            a = 5;
            b = 6;
            y = 8;

            // + operator
            x = x + a;

            // * operator
            x = x * a;

            // "/" operator
            x = x / a;

            // there are many operators used to evaluate
            
            // equality operators
            if (x == y)
            
            // greater than and less than operators
            if(x > y)
            if(x < y)

             //Conditional operators
            if( (x > y) || (a < b))
            if( (x > y) && (a < b))
                        
            
        }
    }
}
