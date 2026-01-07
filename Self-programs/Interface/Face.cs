public interface IFace{
    void Display();
}
class Face: IFace{
    public void Display(){
        Console.WriteLine("Implementer Display method");
    }
}
public class Program{
    public static void Main(string[] args){
        Face f = new Face();
        f.Display();
    }
}