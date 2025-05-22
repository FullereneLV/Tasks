using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    public class MyArray : IOutput, IMath
    {
        public int [] ArInt {  get; set; }
        public string Message { get; set; }

        public MyArray(int[] ar)
        {
            ArInt = ar;
        }
        public MyArray(int[] ar, string message)
        {
            ArInt = ar;
            Message = message;
        }

        public void Show()
        {
            for (int i = 0; i < ArInt.Length; i++)
            {
                Console.WriteLine(ArInt[i]);
            }
                  
        }

        public void Show(string info)
        {
            Message = info;
            for (int i = 0; i < ArInt.Length; i++)
            {
                Console.WriteLine($"{ArInt[i]} {info} [{i}]");
            }
        }

        public int Max()
        {
            int maxEle = ArInt[0];
            for(int i = 1; i < ArInt.Length; i++)
            {
                if (ArInt[i] > maxEle)
                {
                    maxEle = ArInt[i];
                }
            }
            Console.WriteLine($"This is max value: {maxEle}");
            return maxEle;
        }

        public int Min()
        {
            int minEle = ArInt[0];
            for (int i = 1; i < ArInt.Length; i++)
            {
                if (ArInt[i] < minEle)
                {
                    minEle = ArInt[i];
                }
            }
            Console.WriteLine($"This is min value: {minEle}");
            return minEle;
        }

        public float Avg()
        {
            int sumEle = 0;
            float avgEle = 0;
            int arLenght = ArInt.Length;

            for (int i = 0; i < arLenght; i++)
            {
                sumEle += ArInt[i];
            }
            float result = (float)sumEle / arLenght;
            Console.WriteLine("This is average: " + result);
            return result;
        }

        public bool Search(int valueToSearch)
        {
            bool result = false;
            for (int i = 0; i < ArInt.Length; i++)
            {
                if (ArInt[i] == valueToSearch)
                {
                    result = true;
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
