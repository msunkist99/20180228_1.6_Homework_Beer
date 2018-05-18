using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180228_1._6_Homework_Beer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "20180228_1.6_Homework_Beer";

            // DateStuff is a class which contains methods
            // you must declare an instance of the class (I call my instance dateStuff) in order to
            // use the methods within the DateStuff class.
            DateStuff dateStuff = new DateStuff();

            dateStuff.SetLegalAgeDate(21);

            Console.WriteLine("Today's date is {0}", dateStuff.TodaysDate.ToShortDateString());
            Console.WriteLine("To buy alcohol you must have been born on or before {0}", dateStuff.LegalAgeDate.ToShortDateString());

            Console.Write("Enter your birthdate as mm/dd/yyyy: ");
            dateStuff.Birthdate = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Your birthdate {0}", DateStuff.Birthdate.ToShortDateString());

            if (dateStuff.BirthdayCheck())
            {
                Console.WriteLine("HAPPY BIRTHDAY!!!!!");
            }

            if (dateStuff.LegalAge())
            {
                Console.WriteLine("Please proceed with your legal alcohol purchase.");
            }
            else
            {
                Console.WriteLine("You are underage and cannot legally purchase alcohol.");
            }

            Console.ReadLine();
        }

        private class DateStuff
        {
            public DateTime TodaysDate { get; set; }
            public DateTime Birthdate { get; set; }
            public DateTime LegalAgeDate { get; set; }
            private int intYears { get; set; }

            public DateStuff()
            {
                TodaysDate = DateTime.Now;
            }

            public void SetLegalAgeDate(int intYears)
            {
                LegalAgeDate = TodaysDate.AddYears(-1 * intYears);
            }

            public bool LegalAge()
            {
                bool legalAge = true;

                if (Birthdate.CompareTo(LegalAgeDate) > 0)
                    legalAge = false;
                else
                    legalAge = true;

                return legalAge;
            }

            public bool BirthdayCheck()
            {
                bool blnBirthdayCheck = false;

                if ((TodaysDate.Month == Birthdate.Month) & (TodaysDate.Day == Birthdate.Day))
                    blnBirthdayCheck = true;
                else
                    blnBirthdayCheck = false;

                return blnBirthdayCheck;
            }
        }
    }
}

