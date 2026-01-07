public class Arrays{
    public static void Main(string[] args){
        //Declaration and Initialization of Arrays
        int[] A = new int[5]; 
        A[0] = 10;
        Console.WriteLine(A[0]);
        A[1] = 20;
        A[2] = 30;
        A[3] = 40;
        A[4] = 50;
        Console.WriteLine("A is:\n");
        for(int i = 0; i<5; i++){
            Console.WriteLine(A[i]);
        }
        string[] B = new string[]{"a","b","c"};
        Console.WriteLine("B is:\n");
        for(int i = 0; i<3; i++){
            Console.WriteLine(B[i]);
        }

        //User input Array3        
        Console.WriteLine("Enter size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements of array: ");
        int[] C = new int[size];
        for(int i = 0; i<size; i++){
            C[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(C[1]);
    }
}