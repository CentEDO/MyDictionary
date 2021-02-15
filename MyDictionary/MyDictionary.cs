using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<kT, vT>
    {
        kT[] names;
        vT[] ages;
        public MyDictionary()
        {
            names = new kT[0];
            ages = new vT[0];
        }
        public void Add(kT name , vT age)
        {
            kT[] tempArray1 = names;
            vT[] tempArray2 = ages;

            names = new kT[names.Length + 1];
            ages = new vT[ages.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                names[i] = tempArray1[i];
            }
            for (int i = 0; i < tempArray2.Length; i++)
            {
                ages[i] = tempArray2[i];
            }
            names[names.Length - 1] = name;
            ages[ages.Length - 1] = age;
        }
        public void Read()
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + " " + ages[i]);
            }
        }

    }
}
