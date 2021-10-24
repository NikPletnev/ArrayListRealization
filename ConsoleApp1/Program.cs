using System;
using Lists;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[3];
            int[] array2 = new int[] { 13, 123 ,32, 2, 1, 2};



            ArrayList arrayList = new ArrayList(array);

            ArrayList arrayList2 = new ArrayList(array2);

            for (int i = 0; i < arrayList.GetLenght(); i++)
            {
                arrayList.List[i] = rnd.Next(10);
                Console.Write($"{arrayList.List[i]} ");
            }

            Console.WriteLine("");
            arrayList.AddAt(0,arrayList2);

            for (int i = 0; i < arrayList.GetLenght(); i++)
            {
                
                Console.Write($"{arrayList.List[i]} ");
            }

            

            Console.WriteLine("");

            for (int i = 0; i < arrayList.GetLenght(); i++)
            {

                Console.Write($"{arrayList.List[i]} ");
            }


            Console.WriteLine("");
            arrayList.AddLast(3);

            int[] toArray = arrayList.ToArray();

            for (int i = 0; i < arrayList.GetLenght(); i++)
            {

                Console.Write($"{toArray[i]} ");
            }

            //Console.WriteLine();
            //Console.WriteLine(arrayList.GetLenght());
            //Console.WriteLine(arrayList._arrayList.Length);


        }
    }
}
