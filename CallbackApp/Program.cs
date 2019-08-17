using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.LongRunning(Print);
        }

        static void Print(int i)
        {
            Console.WriteLine(i);
        }
    }

    public class MyClass
    {
        public delegate void Callback(int i);

        public void LongRunning(Callback obj)
        {
            for(int i = 0;i < 10000;i++)
            {
                obj(i);
            }
        }

        public void Method1()
        {
            Console.WriteLine("Test Method");
        }
    }
}
