using System;

//DevBuild Lab : GET TO KNOW YOUR CLASSMATES
//Author: Yosha Kunnummal
//Date: 10/12/2021

namespace Classmates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declared 3 arrays and initialized the values of 10 students
            string[] students = { "Tommy", "Cassly", "Anurag", "Zac", "Ese", "Marjorie", "Erin", "Richard", "Cullin", "Cordero" };
            string[] homeTowns = { "Raleigh", "Detroit", "Rochester", "Wyandotte", "Detroit", "Detroit", "Troy", "Canton", "Fowlerville", "Berkley" };
            string[] favFoods = { "Curry", "Steak", "Tacos", "Sushi", "Shrimp", "Lasagna", "Tacos", "Sushi", "Pad Thai", "BBQ" };
            int num = students.Length;

            //Printing the details of students in the order of StudentId,Student name,Home town and Favorite food
            //Student ID starts from 0 to 9
            Console.WriteLine("C# DevBuild 7");
            Console.WriteLine("\nStudentID\t\tStudentName\t\tHometown\t\tFavorite Food");
            Console.WriteLine("");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{i}\t\t\t{students[i]}\t\t\t{homeTowns[i]}\t\t\t{favFoods[i]}");
            }

            bool goOn = true;
            while (goOn == true)
            {
                try
                {

                    Console.WriteLine("\nWelcome to our C# class. Which student would you like to learn more about?");
                    int studentNum = int.Parse(Console.ReadLine());

                    //Checking whether the student ID exists based on the input value
                    if (studentNum < num)
                    {
                        Console.WriteLine($"Student {studentNum}  is {students[studentNum]}. What would you like to know about {students[studentNum]}? (enter hometown or favoritefood):");
                        string choice = Console.ReadLine();
                        if (choice.ToLower() == "hometown" || choice.ToLower() == "favoritefood")
                        {
                            if (choice.ToLower() == "hometown")
                            {
                                Console.WriteLine($"{students[studentNum]} is from {homeTowns[studentNum]}.");
                                goOn = Continue();
                            }
                            else
                            {
                                Console.WriteLine($"{students[studentNum]}'s favorite food  is {favFoods[studentNum]}.");
                                goOn = Continue();
                            }
                        }
                        else
                        {
                            Console.WriteLine("That data does not exist. Please try again. (enter “hometown” or “favorite food”):");
                        }
                    }
                    else
                    {
                        Console.WriteLine("That student does not exist. Please try again.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        //A method to continue the application for more inputs
        public static bool Continue()
        {
            Console.WriteLine("\nWould you like to know more ? (enter “yes” or “no”):");
            string answer = Console.ReadLine().ToLower();

            if (answer.ToLower() == "yes")
            {
                return true;
            }
            else if (answer.ToLower() == "no")
            {
                Console.WriteLine("Thanks!");
                return false;
            }
            else
            {
                Console.WriteLine("\nThis is not a valid selection. ");
                Console.WriteLine("Please try again!");

                //This is recursion, calling a method inside itself
                return Continue();
            }
        }
    }
}