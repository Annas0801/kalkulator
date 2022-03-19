using system;

namespace BasicCalculator
{


class Calculator
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 6;
    Console.WriteLine("HASIL PENAMBAHAN : {0} + {1} ={2}", a b Penambahan (a, b));
    Console.WriteLine("HASIL PENGURANGAN: {0} - {1} = {2}",a ,b , Pengurangan (a, b));

    Console.WriteLine("\nTekan sembarang key untuk keluar");
    Console.Readkey();

    }
    static int Penambahan (int a, int b){
        return a + b;
    }
    static int Pengurangan(int a, int b){
        return a - b;
    }
    
    
}
}
