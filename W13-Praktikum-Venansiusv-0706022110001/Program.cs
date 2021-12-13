using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W14_Praktikum_Venansiusv_0706022110001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Output :");
            int faktorial = 0;
            int status = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    faktorial++;
                }
                if (i == input)
                {
                    if (faktorial == 2)
                    {
                        status = 1;
                    }
                    else
                    {
                        status = 0;
                    }
                }
            }
            if (status == 1)
            {
                Prima(input);
            }
            else if (status == 0)
            {
                Bilangan(input);
            }
        }
        public static void Prima(int input)
        {
            int faktorial = 0;
            int count = 0;
            int kount = 0;
            int program = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (program == 1)
                {

                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            faktorial++;
                        }
                    }
                    if (faktorial == 2)
                    {
                        Console.Write(string.Format("{0,5}", i));
                        count++;
                        if (count % input == 0)
                        {
                            Console.WriteLine();
                            count = 0;
                            kount++;
                            if (kount % input == 0)
                            {
                                program = 1;
                            }
                        }
                    }
                    faktorial = 0;
                }
            }
        }
        public static void Bilangan(int input)
        {
            int faktorial = 0;
            int count = 0;
            int kount = 0;
            int program = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (program == 1)
                {

                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            faktorial++;
                        }
                    }
                    if (faktorial != 2)
                    {
                        Console.Write(string.Format("{0,5}", i));
                        count++;
                        if (count % input == 0)
                        {
                            Console.WriteLine();
                            count = 0;
                            kount++;
                            if (kount % input == 0)
                            {
                                program = 1;
                            }
                        }
                    }
                    faktorial = 0;
                }
            }
        }
    }
}
