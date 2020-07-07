using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract11
{
    class TwoDimArray
    {
        int[,] IntArray;
        int n;

        public TwoDimArray(int n)
        {
            IntArray = new int[n, n];
            this.n = n;
        }
        private void Input()
        {
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write("Input the " + "[" + i + ";" + k + "] element: ");
                    IntArray[i, k] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        private void Output()
        {
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write("[" + IntArray[i, k] + "]");
                }
                Console.WriteLine();
            }
        }
        private void ColumnSum()
        {

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int k = 0; k < n; k++)
                {
                    sum += IntArray[k, i];
                }
                Console.Write(sum + " ");
            }
            Console.WriteLine();

        }
        public int CountZero
        {
            get
            {
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (IntArray[i, k] == 0) count++;


                    }
                }
                return count;
            }
        }
        public int ScalMainDiag
        {
            set
            {
                for (int i = 0; i < n; i++)
                {
                    IntArray[i, i] = value;
                }
            }
        }
        public int this[int x, int y]
        {
            get { return IntArray[x, y]; }
        }
        public static TwoDimArray operator ++(TwoDimArray array)
        {
            TwoDimArray obj = new TwoDimArray(array.IntArray.GetLength(0));
            for (int i = 0; i < array.IntArray.GetLength(0); i++)
            {
                for (int k = 0; k < array.IntArray.GetLength(1); k++)
                {
                    obj.IntArray[i, k] = array.IntArray[i, k] + 1;
                }

            }
            return obj;
        }

        public static TwoDimArray operator --(TwoDimArray array)
        {
            TwoDimArray obj = new TwoDimArray(array.IntArray.GetLength(0));
            for (int i = 0; i < array.IntArray.GetLength(0); i++)
            {
                for (int k = 0; k < array.IntArray.GetLength(1); k++)
                {
                    obj.IntArray[i, k] = array.IntArray[i, k] - 1;
                }

            }
            return obj;
        }
        public static TwoDimArray operator +(TwoDimArray array, TwoDimArray array1)
        {
            TwoDimArray obj = new TwoDimArray(array.IntArray.GetLength(0));
            for (int i = 0; i < array.IntArray.GetLength(0); i++)
            {
                for (int k = 0; k < array.IntArray.GetLength(1); k++)
                {
                    obj.IntArray[i, k] = array.IntArray[i, k] + array1.IntArray[i, k];
                }

            }
            return obj;
        }


        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input TwoDimArray size ");
                int size = Convert.ToInt32(Console.ReadLine());

                TwoDimArray array = new TwoDimArray(size);
                TwoDimArray array1 = array;
                array.Input();
                Console.WriteLine();
                array.Output();
                Console.Write("Columns sum: ");
                array.ColumnSum();
                Console.WriteLine();
                Console.WriteLine("The amount of zero is " + array.CountZero);

                Console.Write("Input scalar ");
                int scal = Convert.ToInt32(Console.ReadLine());
                array.ScalMainDiag = scal;
                array.Output();
                Console.WriteLine();
                Console.WriteLine("Getting element at [0;0] " + array[0, 0]);
                Console.WriteLine();
                Console.WriteLine("Increasing all by 1");
                array++;
                array.Output();
                Console.WriteLine();
                Console.WriteLine("Decreasing all by 1");
                array--;
                array.Output();
                Console.WriteLine();
                Console.WriteLine("Addition of two same arrays:");
                Console.WriteLine("First array:");
                array.Output();
                Console.WriteLine();
                Console.WriteLine("Second array:");
                array.Output();
                Console.WriteLine();
                Console.WriteLine("Result:");
                array = array + array;
                array.Output();
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format");
            }
            catch
            {
                Console.WriteLine("Unknow mistake");
            }
            Console.ReadKey();

        }
    }
}
