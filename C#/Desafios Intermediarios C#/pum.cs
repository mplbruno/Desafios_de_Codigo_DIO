/* 
Desenvolva um programa que leia um valor inteiro N. Este N refere-se à quantidade de linhas de saída que serão apresentadas na execução do programa.

Entrada
O arquivo de entrada contém um número inteiro positivo N.

Saída
Imprima a saída conforme o exemplo fornecido.

Exemplo de Entrada

7

Exemplo de Saída 

1 2 3 PUM
5 6 7 PUM
9 10 11 PUM
13 14 15 PUM
17 18 19 PUM
21 22 23 PUM
25 26 27 PUM
*/

using System;

namespace TESTE {
    class Program {
        static void Main(string[] args) {
        
            int N = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= (4*N - 1); i+=4) 
            {
            
            for (int j = i; j <= i+2; j++) 
            
            {
			      
			      Console.Write(j+" ");
              

            }
            
          Console.WriteLine(" PUM\n");  
        }
    }
  }
}