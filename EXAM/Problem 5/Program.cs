using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(number, 2);//.PadLeft(32,'0');
            //Console.WriteLine(binaryNumber);

            List<char> num = binaryNumber.ToList();
            List<char> wave = new List<char>();
            int maxWaveCount = 0;

            for (int i = 0; i < num.Count-1; i++)
            {
                    if (num[i] == '1')
                    {
                        while (num[i] != num[i + 1])
                        {

                            
                                wave.Add(num[i]);
                                maxWaveCount++;
                            
                        }

                    }
                    else
                    {
                        continue;
                    }
                
                

            }
            Console.WriteLine("No waves found!");
            //foreach (var item in wave)
            //{
            //    Console.Write(item);
            //}

        }
    }
}
