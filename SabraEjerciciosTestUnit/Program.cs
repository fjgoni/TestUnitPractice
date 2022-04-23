using SabraEjerciciosTestUnit.Domain;
using System;

namespace SabraEjerciciosTestUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bicycle bike = new Bicycle();
            TimeSpan span =  DateTime.Now.AddMinutes(60) - DateTime.Now;
            var a = Math.Round(span.TotalHours);*/


            double amountToPay = 0;
            TimeSpan timespan = DateTime.Now.AddMinutes(120) - DateTime.Now;

            double timeHours = Math.Round(timespan.TotalHours);
            Console.WriteLine("time span {0}", timeHours);

            if (timeHours < 24)
            {
                for (int i = 0; i < timeHours; i++)
                {
                    amountToPay += 5;
                }
            }
            else if (timeHours == 24)
            {
                amountToPay = 20;
            }

            Console.WriteLine(amountToPay);

            int weeks = (int)((DateTime.Now.AddDays(14) - DateTime.Now).TotalDays) / 7;
            Console.WriteLine(weeks);



            int b = 5;
            Console.WriteLine(Math.Ceiling((double)30 / 7));


            
        }
    }
}
