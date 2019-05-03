using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using In = NBCC_WMAD_Console.Input;
using Out = NBCC_WMAD_Console.Output;

namespace NBCC_WMAD_Console
{
    class Program
    {
        /// <summary>
        /// Menu Items are added here
        /// </summary>
        private static void LoadMenu()
        {
            Menu.menuDictionary.Add(0, "Exit");
            Menu.menuDictionary.Add(1, "About the Console");
            Menu.menuDictionary.Add(2, "Car Builder");
        }

        static void Main(string[] args)
        {
            string choice = Init();

            while (choice.ToLower() == "y")
            {
                switch (In.Get<int>(Menu.CreateMenu(), ConsoleColor.Yellow))
                {
                    case 0:
                        choice = "n";
                        break;
                    case 1:
                        AboutThisApp();
                        break;
                    //Add more options in the menu here
                    case 2:
                        CarBuilder();
                        break;
                }
            }

            Out.P("Press any key to exit.");
            Console.ReadLine();
        }

        static List<Car> carList = new List<Car>();

        private static void CarBuilder()
        {
            string userCarType = In.GetString("Provide a car type (car, turck van)");
            int userNumberOfDoors = In.GetInt("Provide the number of doors: ");
            int userCarSpeed = In.GetInt("Provide car speed: ");


            Car car = new Car();

            car.CarType = userCarType;
            car.NumberOfDooers = userNumberOfDoors;
            car.Speed = userCarSpeed;


            Out.P("************************");

            Out.P($"The car created is: \n {car.CarType} \n Number of doors {car.NumberOfDooers} \n Car speed: {car.Speed} \n Car price: {car.Price.GetValueOrDefault()}");

            Out.P("************************ \n");


            carList.Add(car);

            Out.P($"{carList.Count} cars in my garage");

            string userShowCars = In.GetString("Do you want to see list of the cars (y/n)");
            if (userShowCars == "y")
            {
                foreach(Car cr in carList)
                {
                    Out.P($"\n Car Type: {cr.CarType} \n Number of doors: {cr.NumberOfDooers} \n Car Speed {cr.Speed}");
                }
            }

        }

        #region [My Functionality]

        /*
         * My methods will be added here for executing functionality within the console
         */

        #endregion

        /// <summary>
        /// The About this App
        /// </summary>
        private static void AboutThisApp()
        {
            Out.P("\n");
            Out.P("This app is the Console Root Application. Build on it by providing new menu items and adding to the switch statement");
            Out.P("\n");
        }

        /// <summary>
        /// Initialize the Console
        /// </summary>
        /// <returns></returns>
        private static string Init()
        {
            LoadMenu();
            string choice = "y";
            Logo.CreateLogo("The Root App");
            return choice;
        }
    }
}
