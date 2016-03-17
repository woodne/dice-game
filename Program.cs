using System;

namespace ZombieDice
{
    public class Program
    {        
        public static void Main()
        {
            DiceContainer dc = new DiceContainer();
            
            var dice = dc.SelectDice();
            
            Console.WriteLine(dice);
            
        }
    }
}
