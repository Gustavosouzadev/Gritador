using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Clear();
           Console.Beep();

           string textoPadrao;

           Console.ForegroundColor = ConsoleColor.DarkYellow;
           Console.Write("Palmeiras tem mundial? ");
           
           Console.ResetColor();
           textoPadrao = Console.ReadLine();

           

           Console.ForegroundColor = ConsoleColor.DarkYellow;
           Console.Write("Sua resposta: ");

           Console.ForegroundColor = ConsoleColor.DarkRed;
           Console.Write($"{textoPadrao.ToUpper()}!");
           Console.ResetColor();

           Console.Beep();
        }  
    }
}
