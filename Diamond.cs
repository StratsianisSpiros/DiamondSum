using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiamondSum
{
    class Diamond
    {
        //Returns and ODD integer from user
        public int UserInput()
        {
            string temp;
            do
            {
                temp = Microsoft.VisualBasic.Interaction.InputBox("Enter an ODD integer number, or type exit :", "Integer Input");
                if (temp.ToLower().Equals("exit"))
                    Environment.Exit(0);
            }
            while (!int.TryParse(temp, NumberStyles.Integer, CultureInfo.InvariantCulture, out int u) || (int.Parse(temp)%2) == 0);

            return int.Parse(temp);
        }


        //Adds diamond pattern of array
        public int SumDiamond(int[,] arr)
        {
            int sum = 0;
            int count = 0;
            int mid = (arr.GetLength(0) - 1) / 2;

            for (int i = 1; i < arr.GetLength(1) - 1; i++)
            {
                if (i <= mid)
                {
                    sum += arr[i, mid + count] + arr[i, mid - count];
                    count++;
                }
                else
                {
                    sum += arr[i, mid + count] + arr[i, mid - count];
                    count--;
                }
            }

            return sum + arr[0, mid] + arr[arr.GetLength(1) - 1, mid];
        }

        //Initializes the array
        public void Initialize(int[,] arr)
        {
            int count = 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = count;
                    count++;
                }
            }
        }

        //Displays array in console
        public void ShowArr(int[,] arr)
        {
            int mid = (arr.GetLength(0) - 1) / 2;
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i == 0 || i == arr.GetLength(0) - 1) && arr[i, j] == arr[i, mid])
                    {
                        Display(arr, i, j, 1);
                    }
                    else if (j <= mid)
                    {

                        if ((i > 0 && i < arr.GetLength(0) -1) && (arr[i,j] == arr[i, mid + count] || arr[i,j] == arr[i, mid - count]))
                        {
                            Display(arr, i, j, 1);
                        }
                        else
                        {
                            Display(arr, i, j, 0);
                        }
                    }
                    else
                    {
                        if ((i > 0 && i < arr.GetLength(0) - 1) && (arr[i, j] == arr[i, mid + count] || arr[i, j] == arr[i, mid - count]))
                        {
                            Display(arr, i, j, 1);;
                        }
                        else
                        {
                            Display(arr, i, j, 0);
                        }
                    }
                }
                if (i < mid)
                    count++;
                else
                    count--;
                Console.Write(Environment.NewLine);
            }
        }

        private static void Display(int[,] arr, int i, int j, int col)
        {
            if (col == 1)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Green;

            if (arr[i, j] < 10)
                Console.Write(arr[i, j] + "   ");
            else if (arr[i, j] < 100)
                Console.Write(arr[i, j] + "  ");
            else
                Console.Write(arr[i, j] + " ");
        }
    }
}
