using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    class Program
    {
        //f(x) = f(x-1)+f(x-2)
        public static IEnumerable<int> FibSequence(int count) //max quantity of numbers
        {
            //1 1 2 3 5
            //always begin with the second one
            if (count < 0)
                throw new ArgumentException();

            if (count != 0)
                yield return 1; //first 1 should always be

            int prev2 = 0;
            int prev1 = 1;

            int i = 0;
            while(i<count) //count=1
            {
                int current = prev1 + prev2;
                prev2 = prev1;
                prev1 = current;
                yield return current;
                i++;
            }

        }


        /*function getFibonachi(n)
{
    if (n == 0){
        return 0;
    }
    if (n == 1){
        return 1;
    }
    else{
        return getFibonachi(n - 1) + getFibonachi(n - 2);
    }
}
var result = getFibonachi(8); //21 
console.log(result); // 21*/

        //1,1,2,3,5,8,13,21 - 8-е число в последовательности Фибоначи равно 21

        static void Main(string[] args)
        {
              foreach(var i in FibSequence(8))
             {
                 Console.WriteLine(i);
             }

           // Console.WriteLine(FibSequence(8).LastOrDefault()); //получить последнеее число в последовательности
             
        }
    }
}
