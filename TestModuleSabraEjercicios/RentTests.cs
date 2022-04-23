using Microsoft.VisualStudio.TestTools.UnitTesting;
using SabraEjerciciosTestUnit.Domain;
using System;

namespace TestModuleSabraEjercicios
{
    [TestClass]
    public class RentTests
    {
        public double hourPrice = 5;
        public double dayPrice = 20;
        public double weekPrice = 60;

        [TestMethod]
        public void calculateRentPrice_HourRentOnePerson()
        {
            Rent rent = new Rent();
            rent.rentStart = DateTime.Now;
            rent.rentEnd = DateTime.Now.AddMinutes(60);
            rent.RentQuantity = 1;
            rent.vehicleRented = new Bicycle();
            Assert.AreEqual(hourPrice * rent.RentQuantity, rent.calculateRentPrice(rent));
        }

        [TestMethod]
        public void calculateRentPrice_HourRentFamilyPlan()
        {
            Rent rent = new Rent();
            rent.rentStart = DateTime.Now;
            rent.rentEnd = DateTime.Now.AddMinutes(60);
            rent.RentQuantity = 4;
            rent.vehicleRented = new Bicycle();
            Assert.AreEqual((hourPrice - hourPrice * 0.30) * rent.RentQuantity, rent.calculateRentPrice(rent));
        }

        [TestMethod]
        public void calculateRentPrice_HourRentFamilyPlanMoreThanOneHour()
        {
            int minutes = 120;
            Rent rent = new Rent();
            rent.rentStart = DateTime.Now;
            rent.rentEnd = DateTime.Now.AddMinutes(minutes);
            rent.RentQuantity = 4;
            rent.vehicleRented = new Bicycle();
            double finalPrice = hourPrice * Math.Round((double)minutes / 60);
            Assert.AreEqual(( finalPrice - finalPrice * 0.30) * rent.RentQuantity, rent.calculateRentPrice(rent));
        }

        [TestMethod]
        public void calculateRentPrice_HourRentMoreThan5Persons()
        {
            Rent rent = new Rent();
            rent.rentStart = DateTime.Now;
            rent.rentEnd = DateTime.Now.AddMinutes(60);
            rent.RentQuantity = 6;
            rent.vehicleRented = new Bicycle();
            Assert.AreEqual(hourPrice * rent.RentQuantity, rent.calculateRentPrice(rent));
        }

        [TestMethod]
        public void calculateRentPrice_LessThanAnHour()
        {
            Rent rent = new Rent();
            rent.rentStart = DateTime.Now;
            rent.rentEnd = DateTime.Now.AddMinutes(30);
            rent.RentQuantity = 1;
            rent.vehicleRented = new Bicycle();
            Assert.AreEqual(hourPrice * rent.RentQuantity, rent.calculateRentPrice(rent));
        }

        [TestMethod]
        public void calculateRentPrice_LessThanAWeek()
        {
            int days = 6;
            Rent rent = new Rent();
            rent.rentStart = DateTime.Now;
            rent.rentEnd = DateTime.Now.AddDays(days);
            rent.RentQuantity = 1;
            rent.vehicleRented = new Bicycle();
            Assert.AreEqual((dayPrice * days) * rent.RentQuantity, rent.calculateRentPrice(rent));
        }

        [TestMethod]
        public void calculateRentPrice_LessThanAWeekFamilyPlan()
        {
            int days = 6;
            Rent rent = new Rent();
            rent.rentStart = DateTime.Now;
            rent.rentEnd = DateTime.Now.AddDays(days);
            rent.RentQuantity = 4;
            rent.vehicleRented = new Bicycle();
            double finalPrice = dayPrice * days;
            Assert.AreEqual((finalPrice  - finalPrice * 0.30) * rent.RentQuantity, rent.calculateRentPrice(rent));
        }


        [TestMethod]
        public void calculateRentPrice_WeekRent()
        {
            int days = 7;
            Rent rent = new Rent();
            rent.rentStart = DateTime.Now;
            rent.rentEnd = DateTime.Now.AddDays(days);
            rent.RentQuantity = 1;
            rent.vehicleRented = new Bicycle();
            Assert.AreEqual(weekPrice * rent.RentQuantity, rent.calculateRentPrice(rent));
        }

        [TestMethod]
        public void calculateRentPrice_MoreThanAWeekRent()
        {
            int days = 9;
            Rent rent = new Rent();
            rent.rentStart = DateTime.Now;
            rent.rentEnd = DateTime.Now.AddDays(9);
            rent.RentQuantity = 1;
            rent.vehicleRented = new Bicycle();
            Assert.AreEqual((weekPrice * Math.Ceiling((double)days / 7)) * rent.RentQuantity, rent.calculateRentPrice(rent));
        }

        [TestMethod]
        public void calculateRentPrice_MoreThanAWeekFamilyPlan()
        {
            int days = 9;
            Rent rent = new Rent();
            rent.rentStart = DateTime.Now;
            rent.rentEnd = DateTime.Now.AddDays(days);
            rent.RentQuantity = 4;
            rent.vehicleRented = new Bicycle();
            double finalPrice = weekPrice * Math.Ceiling((double)days / 7);

            Assert.AreEqual((finalPrice - finalPrice * 0.30) * rent.RentQuantity, rent.calculateRentPrice(rent));
        }

        [TestMethod]
        public void calculateRentPrice_ABunchOfWeeksPlan()
        {
            int days = 30;
            Rent rent = new Rent();
            rent.rentStart = DateTime.Now;
            rent.rentEnd = DateTime.Now.AddDays(days);
            rent.RentQuantity = 1;
            rent.vehicleRented = new Bicycle();
            Assert.AreEqual((weekPrice * Math.Ceiling((double)days / 7)) * rent.RentQuantity, rent.calculateRentPrice(rent));
        }

        [TestMethod]
        public void calculateRentPrice_ABunchOfWeeksFamilyPlan()
        {
            int days = 1456;
            Rent rent = new Rent();
            rent.rentStart = DateTime.Now;
            rent.rentEnd = DateTime.Now.AddDays(days);
            rent.RentQuantity = 4;
            rent.vehicleRented = new Bicycle();
            double finalPrice = weekPrice * Math.Ceiling((double)days / 7);
            Assert.AreEqual((finalPrice - finalPrice * 0.30) * rent.RentQuantity, rent.calculateRentPrice(rent));
        }


    }
}
