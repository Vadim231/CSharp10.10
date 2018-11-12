using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10._10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tank[] winner = new Tank[5];
                Tank[] t34 = new Tank[5];
                Tank[] pantera = new Tank[5];
                for (int i = 0; i < t34.Length; i++)
                {
                    winner[i] = new Tank();
                }

                //заполнение
                Random random = new Random();
                for (int i = 0; i < t34.Length; i++)
                {
                    t34[i] = new Tank("T34", random.Next(0, 100), random.Next(0, 100), random.Next(0, 100));
                }
                for (int i = 0; i < t34.Length; i++)
                {
                    pantera[i] = new Tank("Pantera", random.Next(0, 100), random.Next(0, 100), random.Next(0, 100));
                }

                for (int i = 0; i < 5; i++)
                {
                    t34[i].Print();
                    pantera[i].Print();
                    winner[i] = t34[i] * pantera[i];
                    Console.WriteLine("В " + (i + 1) + " схватке победил: ");
                    winner[i].Print();
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();


        
        }
    }
}
