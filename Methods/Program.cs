using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = Sum(2, 4);
            Minus(2, 5);
            Console.WriteLine(total);
            //const double piNumber = 3.14;
            Console.ReadKey();
        }

        private static int Sum(int number1, int number2)
        {
            var total = number1 + number2;
            return total;
        }

        private static int Sum(int number1, int number2, int number3)
        {
            var total = number1 + number2 + number3;
            return total;
        }
        public static void Minus(int number1, int number2)
        {
            var total = number1 - number2;
            Console.WriteLine(total);
        }
        /*
         *access modifiers - erişim belirleyiciler
         * public her yerden erişebilirsin
         * private aynı class içinden erişebilirsin
         * internal aynı dll yani aynı proje içindeysen kullanabilrsin
         */
    }
}
