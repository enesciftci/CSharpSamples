using System;
using System.Linq;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * char 'a','2','s'
             * string "isim soyisim"
             * byte 0-255
             * int
             * long
             * double
             * decimal
             * bool true false
             */
            //Console.WriteLine("Hello World!");
            char d = 'a';
            // byte number = 255;
            int number2 = 2323;
            long number3 = 123123123;
            double number4 = 2.5;
            string name = "İbrahim";
            string surname = "Çiftçi";
            if (number2 < 3)
            {
                Console.WriteLine($"{name} {surname} ");
            }
            else
            {

            }

            // dizi  -  array
            string[] stringArray = { "adana", "mersin" };
            Console.WriteLine(stringArray[1]);
            int[] intArray = { 1, 3, 3, 5, 6 };
            //Console.WriteLine(intArray);
            ////Console.WriteLine(intArray[1]);
            ////Console.WriteLine(intArray.GetValue(1));
            //Console.WriteLine(intArray.Contains(11)); // verdiğim değer dizinin içinde varsa true yoksa false
            //Console.WriteLine(intArray.Min());// en küçüğünü getirir
            //Console.WriteLine(intArray.Sum()); // hepsini toplar
            //Console.WriteLine(intArray.Distinct()); // aynı olanları teke düşürür
            //intArray[0] = 5;
            //Console.WriteLine(intArray[0]);
            //long [] longArray=new long[10];



            /*
             *for foreach
             *
             */
            //var values = intArray.Distinct();
            //for (int i = 0; i < intArray.Count(); i++) // daha hızlı
            //{
            //    Console.WriteLine(intArray.GetValue(i));
            //}

            //Console.WriteLine("-----------------------------");
            //foreach (var number in intArray) // kullanımı kolay
            //{
            //    Console.WriteLine(number);
            //}

            //var index = 0;
            //while (index > intArray.Length)
            //{
            //    Console.WriteLine(intArray.GetValue(index));
            //    index++;
            //}

            //Console.WriteLine("do while a geldi");
            //do
            //{
            //    Console.WriteLine(intArray.GetValue(index));
            //    index++;
            //} while (index > intArray.Length);
            Console.ReadKey();
        }
    }
}
