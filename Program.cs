using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate();

            //Case5
            Test();
            Console.Read();
        }

        //Using Tasks
        //static void Calculate()
        //{
        //    Task.Run(() =>
        //    {
        //        Calculate1();
        //    });

        //    Task.Run(() =>
        //    {
        //        Calculate2();
        //    });

        //    Task.Run(() =>
        //    {
        //        Calculate3();
        //    });

        //    //Calculate1();
        //    //Calculate2();
        //    //Calculate3();
        //}

        //static void Calculate()
        //{
        //   var task1 =  Task.Run(() =>
        //    {
        //        return Calculate1();
        //    });

        //    var task2 = Task.Run(() =>
        //    {
        //        return Calculate2();
        //    });

        //    Task.WaitAll(task1, task2);

        //    var awaiter1 = task1.GetAwaiter();
        //    var awaiter2 = task2.GetAwaiter();

        //    var result1 = awaiter1.GetResult();
        //    var result2 = awaiter2.GetResult();


        //    Calculate3(result1, result2);


        //    //Calculate1();
        //    //Calculate2();
        //    //Calculate3();
        //}


        //static void Calculate()
        //{
        //    var task1 = Task.Run(() =>
        //    {
        //        return Calculate1();
        //    });

        //    var awaiter1 = task1.GetAwaiter();
        //    awaiter1.OnCompleted(() =>
        //    {
        //        var result1 = awaiter1.GetResult();
        //        Calculate2(result1);
        //    });

        //    Calculate3();
        //}


        //Case4
        //static void Calculate()
        //{
        //    Calculate1_2();
        //    Calculate3();
        //}

        async static void Test()
        {
            await Calculate();
        }

        async static Task Calculate()
        {
            await Calculate1_2();
            Calculate3();
        }


        async static  Task Calculate1_2()
        {
            var result = await Task.Run(() =>
            {
                return Calculate1();
            });
            Calculate2(result);

        }

        static int Calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Calculating Result1");
            return 100;
        }

        static int Calculate2( int result1)
        {
            Console.WriteLine("Calculating Result2");
            return result1 *2;
        }
        static int Calculate3()
        {
            Console.WriteLine("Calculating Result3");
            return 300;
        }
    }
}
