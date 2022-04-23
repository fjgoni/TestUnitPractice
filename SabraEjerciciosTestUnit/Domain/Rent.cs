using System;
using System.Collections.Generic;
using System.Text;

namespace SabraEjerciciosTestUnit.Domain
{
    public class Rent
    {
        public DateTime rentStart { get; set; }
        public DateTime rentEnd { get; set; }
        public Vehicle vehicleRented { get; set; }
        public int RentQuantity { get; set; }
        
        public double calculateRentPrice(Rent rent)
        {
            double amountToPay = 0;
            TimeSpan timespan = rentEnd - rentStart;
            double timeHours = Math.Round(timespan.TotalHours);
            double timeDays = Math.Round(timespan.TotalDays);
            double timeWeeks = timeDays / 7;
            if(timeHours < 24) 
            {
                for(int i = 0; i < timeHours; i++) 
                {
                    amountToPay += 5;
                }
            }
            else if(timeHours == 24) 
            {
                amountToPay = 20;
            }

            if(timeDays < 7) 
            {
                for (int i = 0; i < timeDays; i++)
                {
                    amountToPay += 20;
                }
            }
            else
            {
                if(timeWeeks > 1) 
                {
                    for (int i = 0; i < timeWeeks; i++)
                    {
                        amountToPay += 60;
                    }
                }
                else
                {
                    amountToPay = 60;
                }
            }

            //Calculo si hay oferta por cantidad de rentas entre 3 o 5
            if(RentQuantity > 3 && RentQuantity <= 5)
            {
                //30% descuento
                amountToPay = amountToPay - amountToPay * 0.30; 
            }

            return amountToPay * RentQuantity;
        }
    }
}
