using System;
using System.Collections.Generic;
using System.Linq;

namespace ZombieDice {
    
    public static class ListShuffler {
        private static Random rng = new Random();
        
        public static List<T> Shuffle<T>(this IEnumerable<T> list) {
            int n = list.Count();
            List<T> newList = new List<T>(n);
            
            while (n > 1) {
                n--;
                int k = rng.Next(n+1);
                newList[n] = list.ElementAt(k);
            }
            
            return newList;
        } 
    }
    public class DiceContainer {
        
        private IEnumerable<IZombieDie> _dice { get; }
        
        
        public DiceContainer() {
            _dice = new List<ZombieDieColor>{
               ZombieDieColor.Green,
               ZombieDieColor.Green,
               ZombieDieColor.Green,
               ZombieDieColor.Green,
               ZombieDieColor.Green,
               ZombieDieColor.Green,
               ZombieDieColor.Yellow,
               ZombieDieColor.Yellow,
               ZombieDieColor.Yellow,
               ZombieDieColor.Yellow,
               ZombieDieColor.Red,
               ZombieDieColor.Red,
               ZombieDieColor.Red  
            }.Select(t => ZombieDie.CreateDie(t));
        }
        
        public List<IZombieDie> SelectDice() {
            return ListShuffler.Shuffle(this._dice).Take(3).ToList();
        }
    }
}