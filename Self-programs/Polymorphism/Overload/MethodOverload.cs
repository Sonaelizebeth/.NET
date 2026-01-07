public class MethodOverload{
    public int Area(int a){
        return a*a;
    }
    public int Area(int l, int b){
        return l*b;
    }
    public static void Main(string[] args){
        MethodOverload m = new MethodOverload();
        int square = m.Area(2);
        int rectangle = m.Area(2,9);
        Console.WriteLine("Area of Square: " + square);
        Console.WriteLine("Area of Rectangle: " + rectangle);
    }
}