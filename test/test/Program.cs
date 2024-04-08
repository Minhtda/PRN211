using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudent = new List<Student>();
            Boolean con = true;
            var s0 = new Student();
            s0.Name = "Minh";
            foreach (var item in listStudent)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("hello");
            do
            {
                Console.WriteLine("Do you want to add Student?");
                Console.WriteLine("Press 2 exit");
                Console.WriteLine("Press 1 to yes");
                Console.WriteLine("Press 0 to show all Student");
                var answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        {
                            Console.WriteLine("Input Student Name: ");
                            var s = new Student();
                            s.Name = Console.ReadLine();
                            Console.WriteLine("Input Student Age: ");
                            s.Age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Input Student ID: ");
                            s.Id = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 0:
                        {
                            foreach (var item in listStudent)
                            {
                                Console.WriteLine(item.Name);
                            }

                            Console.WriteLine("hello");
                            break;
                        }
                    case 2:
                        {
                            con = false;
                            break;
                        }

                    default:
                        Console.WriteLine("Please try again!");
                        break;
                }
            }
            while (con == true);


        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
