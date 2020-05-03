using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capabality1
{
    class Program
    {
        int age;
        string name;
        public Program(int age,string name)
        {
            this.age = age;
            this.name = name;
        }
        public Program()
        {

        }
        
        static void Main(string[] args)
        {
            int Sum = PrintSum(1, 2, 3);
            Console.WriteLine(Sum);
            Console.ReadLine();
        }
        public static int PrintSum(int n1, int n2, int n3)
        {
            int sum = n1 + n2 + n3;
            return sum;
        }
    }
}






