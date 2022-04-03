using System;
using Extentions;
using ClassLibrary;

namespace Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n=============Tasks1==============\n");
            int testNum1 = 33;
            string testStr = "    salam 1 sagol";
            Console.WriteLine(testNum1.IsOdd());
            Console.WriteLine(testNum1.IsEven());
            Console.WriteLine(testStr.IsContainsDigit());
            Console.WriteLine(testStr.Capilatize());
            foreach (var item in testStr.GetValueIndexes('s'))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n=============Tasks2==============\n");
            Console.WriteLine("Aduy yaz! : ");
            string fullname = Console.ReadLine();
            while (!fullname.IsFullname())
            {
                Console.WriteLine("Aduy duz yaz !!!");
                fullname = Console.ReadLine();
            }
            Console.WriteLine("Qrup Nomroy yaz !");
            string groupNo = Console.ReadLine();
            while (!groupNo.IsGroupNo())
            {
                Console.WriteLine("Duz yaz !!");
                groupNo = Console.ReadLine();
            }
            Console.WriteLine("Yasi yaz");
            int age = int.Parse(Console.ReadLine());
            Student student = new Student(fullname, groupNo, age);
            Console.WriteLine(student.Fullname, student.GroupNo, student.Age);
        }
    }
}