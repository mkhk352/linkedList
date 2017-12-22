using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List();
            for (int i = 0; i < 10; i++)
            {
                myList.insert(i);
            }
            Console.WriteLine(myList.ToString());
            myList.delete(8);
            Console.WriteLine(myList.ToString());
        }
    }
}
