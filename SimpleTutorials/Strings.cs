using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTutorials
{
    class Strings
    {
        static public void HelloWorld()
        {
            Console.WriteLine($"\r\nRunning method: {System.Reflection.MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine("Hello World!");
            Console.WriteLine($"The current time is {DateTime.Now}");
        }

        static public void StringProperties()
        {
            Console.WriteLine($"\r\nRunning method: {System.Reflection.MethodBase.GetCurrentMethod().Name}");
            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
        }

        static public void StringMethods()
        {
            Console.WriteLine($"\r\nRunning method: {System.Reflection.MethodBase.GetCurrentMethod().Name}");
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
        }
    }
}
