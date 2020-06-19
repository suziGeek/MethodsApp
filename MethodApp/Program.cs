using System;

namespace MethodApp
{
    class Program
    {
        static void Main(string[] args)
        {

                // Name: Michael
                //Favorite Color: Blue
                //Favorite Animal: Walrus
                //Favorite Band: The Beatles

                Console.WriteLine("Hello Tell me your name?");
                string namePerson = Console.ReadLine();

                Console.WriteLine($"Hi {namePerson} - Tell me your Favorite color?");
                string colorPerson = Console.ReadLine();

                Console.WriteLine($"{colorPerson} is a great color! Tell me your favorite animal?");
                string animalPerson = Console.ReadLine();

                Console.WriteLine($"I love {animalPerson}s!Tell me your favorite band?");
                string bandPerson = Console.ReadLine();

            Console.WriteLine($"{bandPerson} is an awesome band." +
                $"So Your name is {namePerson} and your favorite color is {colorPerson}. You also have {animalPerson} as your favorite animal and {bandPerson} as your favorite band! COOL!!");

            }

           
        }
    }

