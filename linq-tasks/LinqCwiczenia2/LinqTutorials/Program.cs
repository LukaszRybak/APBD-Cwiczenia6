using LinqTutorials.Models;
using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = LinqTasks.Task1();
            var t2 = LinqTasks.Task2();
            var t3 = LinqTasks.Task3();
            var t4 = LinqTasks.Task4();
            var t5 = LinqTasks.Task5();
            var t6 = LinqTasks.Task6();
            var t7 = LinqTasks.Task7();
            var t8 = LinqTasks.Task8();
            var t9 = LinqTasks.Task9();
            var t10 = LinqTasks.Task10();
            var t11 = LinqTasks.Task11();
            var t12 = LinqTasks.Task12();
            var t13 = LinqTasks.Task13(new[] { 1,1,1,1,1,1,10,1,1,1,1});
            var t14 = LinqTasks.Task14();


            Console.WriteLine(">>>Task1<<<");
            foreach (Emp res in t1)
            {
                Console.WriteLine(res.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine(">>>Task2<<<");
            foreach (Emp res in t2)
            {
                Console.WriteLine(res.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine(">>>Task3<<<");
            Console.WriteLine(t3);

            Console.WriteLine("");
            Console.WriteLine(">>>Task4<<<");
            foreach (Emp res in t4)
            {
                Console.WriteLine(res.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine(">>>Task5<<<");
            foreach (Object res in t5)
            {
                Console.WriteLine(res.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine(">>>Task6<<<");
            foreach (Object res in t6)
            {
                Console.WriteLine(res.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine(">>>Task7<<<");
            foreach (Object res in t7)
            {
                Console.WriteLine(res.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine(">>>Task8<<<");
            Console.WriteLine(t8);

            Console.WriteLine("");
            Console.WriteLine(">>>Task9<<<");
            Console.WriteLine(t9);

            Console.WriteLine("");
            Console.WriteLine(">>>Task10<<<");
            foreach (Object res in t10)
            {
                Console.WriteLine(res.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine(">>>Task11<<<");
            foreach (Object res in t11)
            {
                Console.WriteLine(res.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine(">>>Task12<<<");
            foreach (Object res in t12)
            {
                Console.WriteLine(res.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine(">>>Task13<<<");
            Console.WriteLine(t13);

            Console.WriteLine("");
            Console.WriteLine(">>>Task14<<<");
            foreach (Object res in t14)
            {
                Console.WriteLine(res.ToString());
            }

        }
    }
}
