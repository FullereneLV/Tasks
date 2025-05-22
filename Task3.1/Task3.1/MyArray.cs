using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    public class MyArray : IOutput
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
    }
}
