﻿
namespace BasicCoreProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Program number which is to be executed \n 1. flipCoin \n 2. LeapYear \n 3. Power \n 4. Harmonic \n 5. Prime");
            Console.WriteLine(" 6. Division  \n 7. SwappingNumber \n 8.EvenOdd \n  9. Alphabet \n 10. Largest Number \n 11. Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch (option)
                {
                    case 1:
                        BasicPrograms programs = new BasicPrograms();
                        programs.FlipCoin();
                        break;
                        case 2:
                        BasicPrograms check = new BasicPrograms();
                        check.LeapYear();
                        break;
                    case 3:
                        BasicPrograms res = new BasicPrograms();
                        res.PowerOfTwo();
                        break;
                    case 4:
                        BasicPrograms sum = new BasicPrograms();
                        sum.Harmonic();
                        break;
                    case 5:
                        BasicPrograms basicPrograms = new BasicPrograms();
                         basicPrograms.Prime();
                        break;
                    case 7:
                        BasicPrograms swap = new BasicPrograms();
                        swap.SwappingNumber();
                        break;
                    case 6:
                        BasicPrograms quotient = new BasicPrograms();
                        quotient.Division();
                        break;
                    case 8:
                        BasicPrograms Even = new BasicPrograms();
                        Even.EvenOdd();
                        break;
                    case 9:
                        BasicPrograms constantvowel = new BasicPrograms();
                        constantvowel.Alphabet();
                        break;
                    case 10:
                        BasicPrograms Among = new BasicPrograms();
                         Among.LargestNumber();
                        break;

                    case 11:
                        flag = false;
                        break;

                }
            }
        }
    }
}











