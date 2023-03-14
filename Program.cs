using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System;

namespace RollAlong
{
    internal class Program
    {
        private const int V = '1';

        static void Main(string[] args)
        {
            //            Oppgaver løkker
            //Oppgaver om og med Løkker

            //--------------------------------

            //Oppgave 1: 

            loopOppgave1();

            //Oppgave 2:

            loopOppgave2();

            //Hint: en string kan brukes på samme måte som et array!
            //            -------------------------------------------------------------- -

            //Oppgave 3:

            loopOppgave3();

            //Krokodillespill
            int points = 0;
            int userControl = V;
            Console.WriteLine("Krokkodillespill: du får to tall, skriv '>', '<', eller '=' for å peke krokodillemunn mot størst nummer/si tallene er like og trykk 'enter'");
            Console.WriteLine("skriv '0' og trykk enter for å avslutte krokodillespill");
            while (userControl != 48) { 
            int num1 = randomizer();
            int num2 = randomizer();
            Console.WriteLine(num1 + "_" + num2);
                userControl = Console.Read();
                // for å bli kvitt read buffer:
                Console.Read();
                Console.Read();
                if (num1 < num2)
                {
                    switch (userControl)
                    {
                        case 60:
                            points++;
                            Console.WriteLine("Riktig! Poeng: " + points);
                            continue;
                        case 61:
                            Console.WriteLine("Nei, tall to var størst");
                            continue;
                        case 62:
                            Console.WriteLine("Nei, tall to var størst");
                            continue;
                        default: 
                            Console.WriteLine("Er du sikker på du skrev '>', '<', eller '='?");
                            continue;
                    }
                }
                if (num1 == num2)
                {
                    switch (userControl)
                    {
                        case 60:
                            Console.WriteLine("Nei, de var like");
                            continue;
                        case 61:
                            points++;
                            Console.WriteLine("Riktig! Poeng: " + points);
                            continue;
                        case 62:
                            Console.WriteLine("Nei, de var like");
                            continue;
                        default:
                            Console.WriteLine("Er du sikker på du skrev '>', '<', eller '='?");
                            continue;
                    }
                }
                if (num1 > num2)
                {
                    switch (userControl)
                    {
                        case 60:
                            Console.WriteLine("Nei, tall en var størst");
                            continue;
                        case 61:
                            Console.WriteLine("Nei, tall en var størst");
                            continue;
                        case 62:
                            points++;
                            Console.WriteLine("Riktig! Poeng: " + points);
                            continue;
                        default:
                            Console.WriteLine("Er du sikker på du skrev '>', '<', eller '='?");
                            continue;
                    }
                }
            }
        }

        private static int randomizer()
        {

            Random rnd = new Random();
            int rndNum = rnd.Next(1, 11);
            return rndNum;
        }

        private static void loopOppgave3()
        {
            Console.WriteLine("Lag en while-løkke som printer ut 'Runde nummer:' + et tall som øker med 1 per runde, så lenge rundetelleren er mindre enn 10");
            int roundCounter = 1;
            bool runner = true;
            while (runner)
            {
                Console.WriteLine("Runde nummer: " + roundCounter);
                roundCounter++;
                if (roundCounter >= 10)
                {
                    runner = false;
                }
            }
        }

        private static void loopOppgave2()
        {
            Console.WriteLine("Lag en foreach-løkke som går igjennom hver bokstav i en string og printer den til konsollen");
            Console.WriteLine("skriv noe og trykk enter:");
            string userInput = Console.ReadLine();
            foreach (var letter in userInput)
            {
                Console.WriteLine(letter);
            }
        }

        private static void loopOppgave1()
        {
            Console.WriteLine("Lag en for-løkke som printer " + "'Terje er kul'" + " til konsollen 5 ganger");
            //            ------------------------------------------------------------ -
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Terje er kul");
            }
        }
    }
}