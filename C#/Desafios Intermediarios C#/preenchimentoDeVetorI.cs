/*
Você recebeu o desafio de ler um valor e criar um programa que coloque o valor 
lido na primeira posição de um vetor N[10]. Em cada posição subsequente, coloque
 o dobro do valor da posição anterior. Por exemplo, se o valor lido for 1, os 
 valores do vetor devem ser 1,2,4,8 e assim sucessivamente. Mostre o vetor em 
 seguida.

Entrada
A entrada contém um valor inteiro (V<=50).

Saída
Para cada posição do vetor, escreva "N[i] = X", onde i é a posição do vetor 
e X é o valor armazenado na posição i. O primeiro número do vetor N (N[0]) 
irá receber o valor de V.

Exemplo de entrada
1

Exemplo de Saída

N[0] = 1
N[1] = 2
N[2] = 4

*/
using System; 

class minhaClasse {
  static void Main(string[] args) { 
    int valorLido = int.Parse(Console.ReadLine());
    int[] n = new int[10];
    
    
    
    for (int j = 1; j < 10; j++) {
      n[0] = valorLido;
      n[j] = n[j-1] * 2; 
    }

    for (int j = 0; j < 10; j++) {
      Console.WriteLine("N[{0}] = {1}", j , n [j]);
    }
  }
}
