using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Amy" , 36);
            myDictionary.Add("Jack", 45);
            myDictionary.Add("Cole", 27);
            myDictionary.Read();


        }
    }
}
