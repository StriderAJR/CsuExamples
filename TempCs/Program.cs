using System;
using System.Collections.Generic;
using System.Linq;

namespace TempCs
{
    class Program
    {
        public List<int> intList { get; set; }


        public int Age;


        static void Main(string[] args)
        {
            int value1 = 65;
            string hex = Convert.ToString(value1, 16);
            int value1Decode = Convert.ToInt32(hex, 16);

            int value2 = 66;
            string binary = Convert.ToString(value2, 2);
            int value2Decode = Convert.ToInt32(binary, 2);

            Console.WriteLine($"{value1} - {hex} - {value1Decode}");
            Console.WriteLine($"{value2} - {binary} - {value2Decode}");
        }
    }
}
