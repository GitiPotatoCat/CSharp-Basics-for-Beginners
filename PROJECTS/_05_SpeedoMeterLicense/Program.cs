/*
    4- Your job is to write a program for a speed camera. For simplicity, 
       ignore the details such as camera, sensors, etc and focus purely on the logic. 
       Write a program that asks the user to enter the speed limit. Once set, 
       the program asks for the speed of a car. If the user enters a value less than 
       the speed limit, program should display Ok on the console. If the value is above 
       the speed limit, the program should calculate the number of demerit points. 
       For every 5km/hr above the speed limit, 1 demerit points should be incurred and 
       displayed on the console. If the number of demerit points is above 12, the program 
       should display License Suspended.
*/

using static System.Console;

namespace _05_SpeedoMeterLicense 
{
    class Program 
    {
        private static int CalculateDemeritPoints(int km) => (int)(km / 5);

        protected static void CheckSpeedOfCar(int carSpeed, int speedLimit) {
            if (carSpeed <= speedLimit)
                WriteLine("Ok");
            else {
                int kmOverLimit = carSpeed - speedLimit;
                int points = CalculateDemeritPoints(kmOverLimit);
                WriteLine("Demerit points for overspeed: {0}", points);

                if (points > 12)
                    WriteLine("License Suspended");
            }
        }


        static void Main() 
        {
            int speedLimit = 0;
            int carSpeed = 0;

            // Get speed Limit
            Write("Enter speed limit: ");
            while (!int.TryParse(ReadLine(), out speedLimit) || speedLimit <= 0) {
                WriteLine("Invalid input. Please enter a positive number.");
                Write("Enter speed limit: ");
            }

            // Get car speed
            Write("Enter car speed: ");
            while (!int.TryParse(ReadLine(), out carSpeed) || carSpeed < 0) {
                WriteLine("Invalid input. Please enter a non-negative number.");
                Write("Enter car speed: ");
            }

            // calling the helper method
            CheckSpeedOfCar(carSpeed, speedLimit);
        }
    }
}