using System;
using System.Collections;
using System.Collections.Generic;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentList = new List<string>() { "Simon", "Jeff", "Lauren", "Matt", "Peter", "Anna", "Jennifer" };
            List<string> studentFoods = new List<string>() { "sushi", "pizza", "pasta", "cigarettes", "hot dogs", "cheese", "salad" };
            List<string> studentHome = new List<string>() { "Muskegon", "Saline", "Canton", "Chelsea", "Bronx", "Marquette", "Ann Arbor" };
            List<string> studentPoke = new List<string>() { "Squirtle", "Pikachu", "Charmander", "Snorlax", "Jigglypuff", "Articuno", "Moltres", };



                Console.WriteLine("Hey there, let's learn about students!");

            bool a = true;
            while (a == true)
            {

                try
                {
                    RESTART:
                    Console.WriteLine("Pop in a number 0-6");
                    string firstInput = Console.ReadLine();
                    int answer1 = int.Parse(firstInput);
                
                if (answer1 >= 0 && answer1 <= 6)
                    {
                        Console.WriteLine("You selected " + studentList[answer1]);
                        
                        bool b = true;
                        while (b == true)
                        {
                            Console.WriteLine("Want to know more about " + studentList[answer1] + "? Favorite food, hometown, favorite pokemon, or 'no'?");
                            string answer2 = Console.ReadLine();
                            answer2.ToLower();

                            if (answer2 == "favorite food" || answer2 == "favoritefood" || answer2 == "food")
                            {
                                Console.WriteLine("Cool, " + studentList[answer1] + "'s favorite food is " + studentFoods[answer1]);
                            }
                            else if (answer2 == "hometown" || answer2 == "home town" || answer2 == "home")
                            {
                                Console.WriteLine("Cool, " + studentList[answer1] + "'s hometown is " + studentHome[answer1]);
                            }
                            else if (answer2 == "pokemon" || answer2 == "favorite pokemon")
                            {
                                Console.WriteLine("Cool, " + studentList[answer1] + "'s favorite pokemon is " + studentPoke[answer1]);
                            }
                            else if (answer2 == "no" || answer2 == "n")
                            {
                                bool c = true;
                                while (c == true)
                                {
                                    Console.WriteLine("Ok, cool, want to know about anyone else? yes/no");
                                    string answer3 = Console.ReadLine();
                                    answer3.ToLower();

                                    if (answer3 == "y" || answer3 == "yes")
                                    {
                                        Console.WriteLine("Cool!");
                                        goto RESTART;
                                        
                                    }
                                    else if (answer3 == "n" || answer3 == "no")
                                    {
                                        Console.WriteLine("Ok, smell you later!");
                                        a = false;
                                        b = false;
                                        c = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Dude, c'mon. Yes or no.");
                                    }
                                }//anyone else while loop
                            }
                            else
                            {
                                Console.WriteLine("Help me out here, man, do you want know the favorite food, pokemon, or the hometown? Type 'no' to quit");
                            }


                        } //while loop for further questions
                    }//if bracket for first round of input
                    else
                    {
                        Console.WriteLine("Whuh-oh, only numbers 0-6");
                    }// else for initial input gunk up
                }
                catch (Exception)
                {
                    Console.WriteLine("Dude that wasn't even a number. Try again.");
                }
            }
          
        }
        
    }
}
