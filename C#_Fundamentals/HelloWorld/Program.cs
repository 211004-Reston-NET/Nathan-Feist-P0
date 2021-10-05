using System;
using HouseFunction;

// this is a comment

/*
All of this will be a comment

We use PascelCase for the most part it means naming artifacts as EverythingWillBeCapitalized
camelCase means naming artifacts as onlyOnceYouHaveALowerCaseWordAtTheBeginning
*/

namespace HelloWorld
{
    class Program
    {
        /*
        - the main method is the first method that will run
        - static means that you don't heve to istantiate the program class to use that method
        - void, the method will not give anything back
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //this is if you don't make the method static you have to instantiate it
              //  Program test = new Program(); //This will instantiate the obj
               // text.Example();
               Program.Example();

               House Nathan = new House(); 
               Nathan.MiceName = "Jerry";
                Console.WriteLine(Nathan.MiceName);
                Console.WriteLine(Nathan.Owner);

                Console.WriteLine("Enter your name:");
                string yourName = Console.ReadLine();
                Console.WriteLine("Your name is: " + yourName);


                
        }

        public static int Example()
    {   
return 10;
    }   
 }
}
