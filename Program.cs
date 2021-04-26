using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Diamond diam = new Diamond();

            int num = diam.UserInput();
            int[,] diamond = new int[num,num];

            diam.Initialize(diamond);
            diam.ShowArr(diamond);

            int n = diam.SumDiamond(diamond);

            Console.Write(Environment.NewLine);
            Console.WriteLine("The diamond sum of the previous array is : " + n.ToString());

            Console.ReadLine();
        }
    }
}
