using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    internal class isEven
    {

        public static void execute()
        {



            List<int> list = new List<int>();
            int sum = 0;
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;


            while (true)
            {
                Console.WriteLine("enter the number");
                var result = Console.ReadLine();
                int value = 0;
                bool validConversionOrNot = int.TryParse(result, out value);
                
                if (validConversionOrNot)
                {
                   
                    if (value %2==0)
                    {
                        list.Add(value);
                        sum += value;
                        if (value < minValue)
                            minValue = value;
                        if (value > maxValue)
                            maxValue = value;
                    }
                    else
                    {
                        Console.WriteLine("number is not even");
                    }

                }
                else
                {
                    result = result.ToUpper();
                    if (result == "STOP")
                        break;
                    else
                        Console.WriteLine("not valid input");
                }
            }
            double avg = sum / list.Count;
            Console.WriteLine($"sum of num is {sum}");
            Console.WriteLine($"avg is :{avg}");
            Console.WriteLine($"Min value is {minValue}");
            Console.WriteLine($"Maximum number is {maxValue}");
        }
    }
}
