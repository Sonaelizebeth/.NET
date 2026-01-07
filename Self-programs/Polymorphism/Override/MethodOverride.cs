class Animal{
    public virtual void Sound(){
        Console.WriteLine("Animal makes sound");
    }
}
class Dog: Animal{
    public override void Sound(){
        Console.WriteLine("Dog barks");
    }
}
class Cat: Animal{
    public override void Sound(){
        Console.WriteLine("Cat meows");
    }
}
public class MethodOverride{
    public static void Main(string[] args){
        Animal a = new Animal();
        a.Sound();
        Animal d = new Dog();
        Animal c = new Cat();
        d.Sound();
        c.Sound();
    }
}