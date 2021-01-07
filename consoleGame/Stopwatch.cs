using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace consoleGame
{
    class Stopwatch
    {
        public void Measure()
        {
            //int i;
            TimeSpan interval = new TimeSpan(0, 0, 1);
            Console.WriteLine("\n");

            for (int i = 30; i >= 0; i--)
            {
                

                Thread.Sleep(interval);
                if (i <= 0)
                {
                    Console.Write("\r{0} second", i);
                }
                else
                {
                    Console.Write("\r{0} seconds", i);
                }
            }


         }

            
        }
    }