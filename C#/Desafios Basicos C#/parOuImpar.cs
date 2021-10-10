/*
Leia um valor inteiro N. Este valor será a quantidade de valores que serão lidos 
em seguida. Para cada valor lido, mostre uma mensagem em inglês dizendo se este 
valor lido é par (EVEN), ímpar (ODD), positivo (POSITIVE) ou negativo (NEGATIVE). No caso do valor ser igual a zero (0), embora a descrição correta seja (EVEN NULL), pois por definição zero é par, seu programa deverá imprimir apenas NULL.

Entrada
A primeira linha da entrada contém um valor inteiro N(N < 10000) que indica o 
número de casos de teste. Cada caso de teste a seguir é um valor inteiro X 
(-107 < X <107).

Saída
Para cada caso, imprima uma mensagem correspondente, de acordo com o exemplo 
abaixo. Todas as letras deverão ser maiúsculas e sempre deverá haver um espaço 
entre duas palavras impressas na mesma linha.

Exemplo de Entrada

4
-5
0
3
-4

Exemplo de Saída

ODD NEGATIVE
NULL
ODD POSITIVE
EVEN NEGATIVE

*/
using System; 
using System.Globalization;

class Program {

    static void Main(string[] args) { 
        

          string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0 && y != 0.0) {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0 && x != 0.0) {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }

    }

}