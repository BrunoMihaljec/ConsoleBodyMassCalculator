using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBodyMassCalculator
{
    class Program
    {
        static void Main()
        {
            double weight; double height; string gender; int age; double bmi; double result;



            Console.WriteLine("Please enter your gender(Male/Female): ");
            gender = Console.ReadLine().ToUpper();
            while ((gender != "MALE") && (gender != "FEMALE"))
            {
                Console.WriteLine("{0} choice is invalid please enter 'Male' or 'Female'.", gender);
                gender = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Please enter your age(0 - 100): ");
            string inputAge = Console.ReadLine();
            while (!int.TryParse(inputAge, out age) || age < 0 || age > 100)
            {
                Console.WriteLine("{0} choice is invalid please enter a number betwen (0 - 100): ", inputAge);
                inputAge = Console.ReadLine();
            }
            Console.WriteLine("Please enter your weight in Kilograms(0 - 300): ");
            string inputWeight = Console.ReadLine();
            while (!double.TryParse(inputWeight, out weight) || weight < 0 || weight > 300)
            {
                Console.WriteLine("{0} choice is invalid please enter a number betwen (0 - 300): ", inputWeight);
                inputWeight = Console.ReadLine();
            }
            Console.WriteLine("Please enter your height in Meters(0 - 2,5): ");
            string inputHeight = Console.ReadLine();
            while (!double.TryParse(inputHeight, out height) || height < 0 || height > 2.5)
            {
                Console.WriteLine("{0} choice is invalid please enter a number betwen (0 - 2,5): ", inputHeight);
                inputHeight = Console.ReadLine();
            }
            bmi = weight / (height * height);

            // Your choice is Adult male
            if (gender == "MALE" && age > 18)
            {
                result = (1.20 * bmi) + (0.23 * age) - 16.2;
                Console.WriteLine("Your body fat percentage is {0}%", Math.Round(result, 2));
            }
            // Your choice is Adult female
            else if (gender == "FEMALE" && age > 18)
            {
                result = (1.20 * bmi) + (0.23 * age) - 5.4;
                Console.WriteLine("Your body fat percentage is {0}%", Math.Round(result, 2));
            }
            // Your choice is boy
            else if (gender == "MALE" && age <= 18)
            {
                result = (1.51 * bmi) + (0.70 * age) - 2.2;
                Console.WriteLine("Your body fat percentage is {0}%", Math.Round(result, 2));
            }
            // Your choice is girl
            else if (gender == "FEMALE" && age <= 18)
            {
                result = (1.51 * bmi) + (70 * age) + 1.4;
                Console.WriteLine("Your body fat percentage is {0}%", Math.Round(result, 2));
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
