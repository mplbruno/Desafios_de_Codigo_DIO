
using System; 

class Galopeira
{

  static void Main() 
  { 

    int casosTeste = int.Parse(Console.ReadLine());

    
    for (int i= 1; i <= casosTeste; i++) 
    {
        string entrada = Console.ReadLine();
        double T = entrada.Length * 0.01;
        
        Console.WriteLine("{0:F}", T);
    }
  }
}


