using System;

namespace ZombieDice {
    
    public enum ZombieDieColor
    {
        Red, Yellow, Green
    }
    
    class YellowZombieDie : IZombieDie {
        public ZombieDieValue Roll() {
            int roll = ZombieDie.GetRandom();
            if (roll == 0 || roll == 1) {
                return ZombieDieValue.Brain;
            } else if (roll == 2 || roll == 3) {
                return ZombieDieValue.Feet;
            } else {
                return ZombieDieValue.Shotgun;
            }
        }
    }
    
    class RedZombieDie : IZombieDie {
        public ZombieDieValue Roll() {
            int roll = ZombieDie.GetRandom();
            if (roll == 0) {
                return ZombieDieValue.Brain;
            } else if (roll == 1 || roll == 2) {
                return ZombieDieValue.Feet;
            } else {
                return ZombieDieValue.Shotgun;                
            }
        }
    }
    
    class GreenZombieDie : IZombieDie {
        public ZombieDieValue Roll() {
            int roll = ZombieDie.GetRandom();
            if (roll == 0) {
                return ZombieDieValue.Shotgun;
            } else if (roll == 1 || roll == 2) {
                return ZombieDieValue.Feet;
            } else {
                return ZombieDieValue.Brain;
            }
        }    
    }
    
    class ZombieDie {
        private static Random rand = new Random();
        
        public static int GetRandom() {
            return rand.Next(6);
        }
        public static IZombieDie CreateDie(ZombieDieColor color) {
            switch (color) {
                case ZombieDieColor.Red:
                    return new RedZombieDie();
                case ZombieDieColor.Yellow:
                    return new YellowZombieDie();
                case ZombieDieColor.Green:
                default:
                    return new GreenZombieDie();
            }
        }
    }
}