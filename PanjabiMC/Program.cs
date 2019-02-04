using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanjabiMC
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicExercises();
            DataTypes();
            ConditionalStatements();
            ForLoop();
            Arrays();
        }

        public static void BasicExercises()
        {
            Console.WriteLine("Hello\nOstap");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a + b = " + a + b);
            Console.WriteLine("a / b = " + (double)a / (double)b);
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + (-4 * 6 / 11));
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            Console.WriteLine("Input first ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second ");
            int second = int.Parse(Console.ReadLine());
            int temp = first; first = second; second = temp;
            Console.WriteLine("After swapping\nFirst = " + first + "\nSecond = " + second);
            Console.WriteLine("Input first number to multiply ");
            int fm = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second number to multiply ");
            int sm = int.Parse(Console.ReadLine());
            Console.WriteLine("Input third number to multiply ");
            int tm = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} * {2} = {3}", fm, sm, tm, (fm * sm * tm));
            Console.WriteLine("Input first ");
            int one = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second ");
            int two = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", one, two, (one + two));
            Console.WriteLine("{0} - {1} = {2}", one, two, (one - two));
            Console.WriteLine("{0} * {1} = {2}", one, two, (one * two));
            Console.WriteLine("{0} / {1} = {2}", one, two, (one / two));
            Console.WriteLine("{0} mod {1} = {2}", one, two, (one % two));
            Console.WriteLine("Input number ");
            int table = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} * 0 = {1}", table, table * 0);
            Console.WriteLine("{0} * 1 = {1}", table, table * 1);
            Console.WriteLine("{0} * 2 = {1}", table, table * 2);
            Console.WriteLine("{0} * 3 = {1}", table, table * 3);
            Console.WriteLine("{0} * 4 = {1}", table, table * 4);
            Console.WriteLine("{0} * 5 = {1}", table, table * 5);
            Console.WriteLine("{0} * 6 = {1}", table, table * 6);
            Console.WriteLine("{0} * 7 = {1}", table, table * 7);
            Console.WriteLine("{0} * 8 = {1}", table, table * 8);
            Console.WriteLine("{0} * 9 = {1}", table, table * 9);
            Console.WriteLine("{0} * 10 = {1}", table, table * 10);
            Console.ReadLine();
        }
        public static void DataTypes()
        {
            Console.WriteLine("Enter letter:");
            char a = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter letter:");
            char b = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter letter:");
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine(c + " " + b + " " + a);
            Console.WriteLine("Enter number:");
            char n = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter width:");
            int w = int.Parse(Console.ReadLine());
            for (int i = 0; i < w; i++)
            {
                for (int j = i; j < w; j++)
                    Console.Write(n);
                Console.WriteLine();
            }
            Console.WriteLine("enter name and password ");
            string name;
            string password;
            int attempt = 0;
            do
            {
                if (attempt >
3)
                {
                    Console.WriteLine("You use all 3 attempts, try later");
                    break;
                }
                Console.Write("Enter name = ");
                name = Console.ReadLine();
                Console.Write("Enter password = ");
                password = Console.ReadLine();
                attempt++;
            } while (name != "name" && password != "password");
            Console.WriteLine("Enter first number:");
            int fn = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation:");
            char o = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int sn = int.Parse(Console.ReadLine());
            switch (o)
            {
                case '+': Console.WriteLine("{0} {1} {2} = {3}", fn, o, sn, fn + sn); break;
                case '-': Console.WriteLine("{0} {1} {2} = {3}", fn, o, sn, fn - sn); break;
                case '*': Console.WriteLine("{0} {1} {2} = {3}", fn, o, sn, fn * sn); break;
                case '/': Console.WriteLine("{0} {1} {2} = {3}", fn, o, sn, fn / sn); break;
                default: Console.WriteLine("Error"); break;
            }
            Console.ReadLine();
        }
        public static void ConditionalStatements()
        {
            Console.WriteLine("Input 1st number:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
            int second = int.Parse(Console.ReadLine());
            if (first == second) Console.WriteLine("{0} & {1} are equal", first, second);
            else Console.WriteLine("{0} & {1} are not equal", first, second);
            Console.WriteLine("Input number:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) Console.WriteLine("is even");
            else Console.WriteLine("is odd");
            Console.WriteLine("Input number:");
            int number2 = int.Parse(Console.ReadLine());
            if (number2 >= 0) Console.WriteLine("is positive");
            else Console.WriteLine("is negative");
            Console.WriteLine("Input year:");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0) Console.WriteLine("is leap");
            else Console.WriteLine("is not leap");
            Console.WriteLine("Input your age:");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18) Console.WriteLine("Congratulation! You are eligible for casting your vote");
            else Console.WriteLine("Sorry! You are not eligible for casting your vote");
            Console.ReadLine();
        }
        public static void ForLoop()
        {
            for (int i = 1; i <= 10; i++) Console.Write(i + " ");
            int s = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
                s += i;
            }
            Console.WriteLine("\nSum = " + s);
            Console.WriteLine("Input number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++) Console.Write(i + " ");
            s = 0;
            Console.WriteLine("\nInput 10 numbers");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("number {0}:", i);
                s += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum = " + s);
            Console.WriteLine("Average = " + (double)s / 10);
            Console.WriteLine("Input number:");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Number is: {0} and cube of {0} is {1}", i, i * i * i);

            }
            Console.WriteLine("Input number:");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, i * number);
            }
            Console.ReadLine();
        }
        public static void Arrays()
        {
            int[] Store = new int[10];
            Console.WriteLine("Input 10 numbers");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("number {0}:", i);
                Store[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elements in array are:");
            for (int i = 0; i < 10; i++)
                Console.Write(Store[i]+"\t");
            Console.WriteLine("\nInput number of elements: ");
            int number = int.Parse(Console.ReadLine());
            int[] Ar = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("number {0}:", i+1);
                Ar[i] = int.Parse(Console.ReadLine());
            }
            for (int i = number - 1; i >= 0; i--)
                Console.Write(Ar[i] + "\t");
            Console.WriteLine("\nInput number of elements: ");
            number = int.Parse(Console.ReadLine());
            int[] Ms = new int[number];
            int s = 0;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("number {0}:", i + 1);
                Ms[i] = int.Parse(Console.ReadLine());
                s += Ms[i];
            }
            Console.WriteLine("Sum of elements = " + s);
            Console.WriteLine("\nInput number of elements: ");
             number = int.Parse(Console.ReadLine());
            int[] Fa = new int[number];
            int[] Sa = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("number {0}:", i + 1);
                Fa[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < number; i++)
            {
                Sa[i] = Fa[i];
            }
            Console.WriteLine("Elements in first array are:");
            for (int i = 0; i < number; i++)
                Console.Write(Fa[i] + "\t");
            Console.WriteLine("Elements in second array are:");
            for (int i = 0; i < number; i++)
                Console.Write(Sa[i] + "\t");
            Console.WriteLine("\nInput number of elements: ");
            number = int.Parse(Console.ReadLine());
            int[] Dr = new int[number];
            int count = 0;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("number {0}:", i + 1);
                Dr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < number; i++)
            {
                for(int j =i+1;j<number;j++)
                    if(Dr[i]==Dr[j])
                    {
                        count++;
                        break;
                    }
            }
            Console.WriteLine("Duplicated elements are " + count);
            Console.ReadLine();
        }
    }
}
