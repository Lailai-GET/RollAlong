using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System;

namespace RollAlong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Oppgaver løkker
            //Oppgaver om og med Løkker

            //--------------------------------

            //Oppgave 1: 

            Console.WriteLine("Lag en for-løkke som printer " + "'Terje er kul'" + " til konsollen 5 ganger");
            //            ------------------------------------------------------------ -
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Terje er kul");
            }

            //Oppgave 2:

            Console.WriteLine("Lag en foreach-løkke som går igjennom hver bokstav i en string og printer den til konsollen");
            Console.WriteLine("skriv noe og trykk enter:");
            string userInput = Console.ReadLine();
            foreach (var letter in userInput)
            {
                Console.WriteLine(letter);
            }

            //Hint: en string kan brukes på samme måte som et array!
            //            -------------------------------------------------------------- -

            //Oppgave 3:

            Console.WriteLine("Lag en while-løkke som printer ut 'Runde nummer:' + et tall som øker med 1 per runde, så lenge rundetelleren er mindre enn 10");
            int roundCounter = 1;
            bool runner = true;
            while (runner)
            {
                Console.WriteLine("Runde nummer: " + roundCounter);
                roundCounter++;
                if (roundCounter >= 10) {
                    runner = false;
                }
            }
        }
    }
}