
namespace ZombieDice {    
    public enum ZombieDieValue {
        Brain,
        Shotgun,
        Feet
    };
    
    public interface IZombieDie
    {
        ZombieDieValue Roll();
    }
}