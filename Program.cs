using System;

namespace Week2Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            exercise1();
            exercise2();
            exercise3();
            exercise4();
            exercise5();
        }

        public static void exercise1()
        {
            Console.WriteLine("Employee data");

            string firstName, lastName;
            int age;
            char gender;
            string personalIDNumber, employeeID;
        }

        public static void exercise2()
        {
            char a = 'a';
            char b = 'b';
            char c = 'c';

            Console.WriteLine($"{c}, {b}, {a})");
        }

        public static void exercise3()
        {
            Console.WriteLine("Program to calculate diagonal of square/rectangle using its side");
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            double diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2));
            Console.WriteLine($"Diagonal = {diagonal}");
        }

        public static void exercise4()
        {
            int a;
            string b;
            double c;

            a = 10;
            b = "Szkoła Dotneta";
            c = 12.5;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        public static void exercise5()
        {
            Console.WriteLine("User Data \r\nPlease enter user data below:");

            Console.Write("First name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Height (in cm): ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Weight (in kg): ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Adress: ");
            string adress = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("State\\Voivodeship: ");
            string state = Console.ReadLine();

            Console.Write("Postal Code: ");
            string postal = Console.ReadLine();

            Console.Write("Country: ");
            string country = Console.ReadLine();

            Console.Write("E-mail: ");
            string mail = Console.ReadLine();

            Console.Write("Phone Number: ");
            string num = Console.ReadLine();

        }
    }
}
