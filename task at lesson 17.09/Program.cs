using System;
using System.Collections.Generic;

namespace task_at_lesson_17._09
{
    class Program
    {
        private static int amount;



        public static void Main(string[] args)
        {
            #region Task 1
            List<Student> Students = new List<Student>();

            Students.Add(new Student("onur", "ibadov", "turizm", 23));
            Students.Add(new Student("perviz", "pervizov", "iqtisadci", 25));
            Students.Add(new Student("turxay", "memmedov", "IT", 26));
            Students.Add(new Student("valeh", "aliyev", "muhasibat", 34));
            Students.Add(new Student("ali", "veliyev", "idman", 27));



            foreach (Student items in Students)
            {
                Console.WriteLine(items);
                //Console.WriteLine(items.ToString());
            }
            #endregion


            #region Task 2 - INTEREST RATE + EXCEPTION HANDLING

            //decimal money;

            //try
            //{
            //    Console.WriteLine("Meblegi daxil edin");
            //    money = decimal.Parse(Console.ReadLine());
            //}

            //catch (FormatException)
            //{
            //    Console.WriteLine("QAQA REQEM DAXIL ELE");
            //    return;
            //}

            //Console.WriteLine("Ili daxil edin-");
            //int year = int.Parse(Console.ReadLine());
            //int percent = 6;

            //var last_amount = money + (year * ((money * percent) / 100));
            //Console.WriteLine(last_amount);

            //FINALLY - Exception cixsa da, cixmasa da yene davaMJJS edir.
            #endregion


            #region COMPOUND INTEREST RATE

            //double Total = 0, interestRate, years, annualCompound, Amount;

            //Console.Write("Enter the Initial Amount : ");
            //Amount = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the Rate of Interest : ");
            //interestRate = Convert.ToDouble(Console.ReadLine()) / 100;

            //Console.Write("Enter the Number of Years : ");
            //years = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Number of Times the Interest will be Compounded : ");
            //annualCompound = Convert.ToDouble(Console.ReadLine());

            //for (int t = 1; t < years + 1; t++)
            //{
            //    Total = Amount * Math.Pow((1 + interestRate / annualCompound),
            //                             (annualCompound * t));

            //    Console.Write("Your Total for Year {0} " + "is {1:F0}. \n", t, Total);

            //}

            //Console.ReadLine();
            #endregion







        }

    }
}
