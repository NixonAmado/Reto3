using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<int> rango = new(Enumerable.Range(1000, 501));
        int Num1 = 0;
        int Num2 = 0;
        foreach (var item in rango)
        {
            Num1 = Divisores(1210);
            Num2 = Divisores(Num1);
            if(item == Num2)
            {
                Console.WriteLine("los numeros amigos son : "  + Num1 + "y" + item );
                
            } 
        }
       
        
    
    }

    private static int Divisores (int a)
    {
        HashSet<int> rangoDivisores = new(Enumerable.Range(1, a % 2 == 0 ? a/2 : a/3)); //me ahorro la iteracion inecesaria
        var DivisoresN1 = rangoDivisores.Where(d => a % d == 0 );
        return DivisoresN1.Sum();
    }

}