using System;


// If Statements (con't) | C# | Tutorial 15

namespace CSharpExercises_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GetMax(2, 10));
            Console.WriteLine(GetMax(25, 10, 41));
            Console.ReadLine();
        }

        static int GetMax(int num1, int num2, int num3)
        {
            // >=, <=, >, <, ==, !=, 'c' == 'c'
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }


        //static int GetMax(int num1, int num2)
        //{
        //    int result;
        //    if (num1 > num2)
        //    {
        //        result = num1;
        //    }
        //    else
        //    {
        //        result = num2;
        //    }
        //    return result;
        //}


    }
}

