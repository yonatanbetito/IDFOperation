using System;
using System.Collections.Generic;
using IDFOperationFirstStrike.HAMAS;
using IDFOperationFirstStrike.IDF;

namespace IDFOperationFirstStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Terrorist> enemies = new List<Terrorist>
            {
                new Terrorist("Abu Jihad", 5, true),
                new Terrorist("Abu Amar", 4, true),
                new Terrorist("Abu Nidal", 3, true),
                new Terrorist("Abu Qassam", 2, true),
                new Terrorist("Abu Ibrahim", 1, true)
            };
            
            List<Strike> aircrafts = new List<Strike>
            {
                new F16(),
                new Drones(),
                new Airtillery()
                
            };
        }
    }
}