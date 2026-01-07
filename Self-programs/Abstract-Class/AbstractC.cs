public abstract class Animal{
    public abstract void Sound();
    public void Legs(){
        Console.WriteLine("Animals have legs");
    }
}
class Dog: Animal{
    public override void Sound(){
        Console.WriteLine("Barks");
    }
}
public class AbstractC{
    public static void Main(string[] args){
        Animal d = new Dog();
        d.Sound();
        d.Legs();
    }
}